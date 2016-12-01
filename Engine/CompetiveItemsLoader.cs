using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using eBay.Service.Call;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using Engine.Models;

namespace Engine
{
    public class CompetiveItemsLoader
    {
        private readonly IActionController controller;
        private readonly SettingsData settings;
        private readonly CompetativeItemComparer competativeItemComparer;
        private readonly CompetativeItemTransactionComparer transactionComparer;
        private readonly ApiContext apiContext;
        private readonly DateTime officialNow;

        public CompetiveItemsLoader(SettingsData settings, IActionController controller)
        {
            this.settings = settings;
            this.controller = controller;

            this.competativeItemComparer = new CompetativeItemComparer();
            this.transactionComparer = new CompetativeItemTransactionComparer();

            this.apiContext = new ApiContext();
            apiContext.SoapApiServerUrl = "https://api.ebay.com/wsapi";

            var apiCredential = new ApiCredential();
            apiCredential.eBayToken = settings.EbayApiAppToken;
            //                "AgAAAA**AQAAAA**aAAAAA**eZE8WA**nY+sHZ2PrBmdj6wVnY+sEZ2PrA2dj6AAlYWgAJmCqAqdj6x9nY+seQ**9XYDAA**AAMAAA**rNE8oscp0rCyARJTNiX9mxGsKyRxKxR3Pw4KGu3TBtcwQ8bCDQU1VDj2JzGcxozYqvsHqjqkUOT37jAXRQ4XHLM2Ny+7XKXaI2Nh7YrosN9ndWhvk5l9ldiZzgRDxBGbRp4Znn1BuS7yOpZFrkdSWlzZWfREnGTb8jyBAFaXwNC5NEAvk8rd4YzddP11CEh7TqMxYzVd91ST2hW/DrFt018o2riN0ZPs22o8kzi1xi4g7SwNAlYeQ5/lD85MUdz0uVixoGGT/vhsU18x4zO71oNklYCpESkVneDshL5uvSc0tBg8jkpox2r8PQnePVR+lbhEkJSDWNRxWBvSBbKnO42EnHs5T0cVooSxrL7adOCz0FcRyeY27nW/ss/TLeunKG3I9/T3JF5sXrqhLiwtY/YwU9S2vELlbv1/9w94EKE45oAOKEPH9pSK39eaB5RbwuVzZoFFjPkU0HpMI134aqXPPck0az8Dl4/vlhw86Z86KxHDmX59LGM+Ijg1ou2ThIkLj+/KRsyE9w+TCLLUTJKTQykobdLqL9ZDpwYYSOxRIflQ9GaJsKWW4n2ueETrHMJlLm5+hMjnXgOE6HTP/FIqP0Y+aCrOGzf/71z5Ky6G884zi10oO7uZtSkyzZzBfaoXilr7Z+GPC/PfSNbR0caHTtuy8hw341ysY1hyLBG7jaOn59foRtdRDv8pBFVqjd25BCRe91Mrg/kIF8FkdaUJJMOWjAqf06l+NfOOuytQuKhcoOfnO2wn4kTZODw4";

            apiContext.ApiCredential = apiCredential;
            apiContext.Site = SiteCodeType.US;

            var officialTimeCall = new GeteBayOfficialTimeCall(apiContext);
            this.officialNow = officialTimeCall.GeteBayOfficialTime();
        }

        public IList<CompetativeItem> GetCompetativeItems(string origEbayId, string upc)
        {
            var SecurityAppName = settings.EbayApiAppName;

            string BaseUrl = $"http://svcs.ebay.com/services/search/FindingService/v1?OPERATION-NAME=findItemsAdvanced&SERVICE-VERSION=1.13.0&SECURITY-APPNAME={SecurityAppName}&RESPONSE-DATA-FORMAT=JSON&REST-PAYLOAD&globalId=EBAY-US&keywords={upc}&paginationInput.entriesPerPage=100&paginationInput.pageNumber="; ;

            var client = new HttpClient();

            var currentPage = 1;
            var hasLoadedAllItems = false;

            List<dynamic> dynList = new List<dynamic>();

            while (!hasLoadedAllItems)
            {
                var requestTask = client.GetAsync(BaseUrl + currentPage);
                requestTask.Wait();

                var contentTask = requestTask.Result.Content.ReadAsStringAsync();
                contentTask.Wait();

                var result = contentTask.Result;

                dynamic dynResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

                var success = (dynResponse.findItemsAdvancedResponse[0].ack[0].ToString() == "Success");

                if (!success)
                {
                    hasLoadedAllItems = false;
                }
                else
                {
                    var pageNumber = dynResponse.findItemsAdvancedResponse[0].paginationOutput[0].pageNumber[0].ToString();
                    var totalPages = dynResponse.findItemsAdvancedResponse[0].paginationOutput[0].totalPages[0].ToString();

                    dynList.AddRange(dynResponse.findItemsAdvancedResponse[0].searchResult[0].item);

                    hasLoadedAllItems = (pageNumber == totalPages);
                    currentPage++;
                }
            }

            var itemsByEbayId = dynList
                .Where(
                    item =>
                        item != null &&
                        item.globalId[0]?.ToString() == "EBAY-US" &&
                        (item.condition[0]?.conditionId[0]?.ToString() == "1000" || item.condition[0]?.conditionId[0]?.ToString() == "1500") &&
                        item.itemId[0].ToString() != origEbayId &&
                        !item.listingInfo[0]?.listingType[0].ToString().StartsWith("Auction"))
                .Select(
                    item =>
                        new CompetativeItem
                        {
                            Category = item.primaryCategory[0].categoryName[0].ToString(),
                            EbayId = item.itemId[0].ToString(),
                            Upc = upc,
                            Title = item.title[0].ToString(),
                            Url = item.viewItemURL[0].ToString(),
                            Price = double.Parse(item.sellingStatus[0].convertedCurrentPrice[0].__value__.ToString())  // Always use converted to ensure USD
                        })
                .Distinct(competativeItemComparer)
                .ToList();

            // var filteredOut = dynList.Select(x => x.itemId[0].ToString()).Where(id => itemsByEbayId.All(ci => ci.EbayId != id)).ToList();

            EnrichedItem(itemsByEbayId, upc);

            return itemsByEbayId;
        }

        private void EnrichedItem(List<CompetativeItem> items, string targetUpc)
        {
            var itemCall = new GetItemCall(apiContext);
            var transactionsCall = new GetItemTransactionsCall(apiContext);

            var itemsToRemove = new List<CompetativeItem>();

            foreach (var item in items)
            {
                var itemResult = itemCall.GetItem(item.EbayId, true, false, true, false, null, null, null, null, false);

                item.HitCount = itemResult.HitCount;

                var itemUpc = string.Empty;
                Retry(() => itemUpc = itemResult.ItemSpecifics.ToArray().ToList().Find(specific => specific.Name == "UPC")?.Value[0]);

                if (itemUpc != targetUpc)
                {
                    itemsToRemove.Add(item);
                }
                else
                {
                    TransactionTypeCollection results = null;
                    Retry(() => results = transactionsCall.GetItemTransactions(item.EbayId, officialNow.AddDays(-30), officialNow));

                    item.Transactions =
                        results?
                        .ToArray()
                        .Select(
                            transaction =>
                                new CompetativeItemTransaction
                                {
                                    EbayItemId = item.EbayId,
                                    TransactionId = transaction.TransactionID,
                                    Price = transaction.ConvertedTransactionPrice.Value,
                                    Quantity = transaction.QuantityPurchased,
                                    TransactionTime = transaction.CreatedDate
                                })
                        .Distinct(transactionComparer)
                        .ToList();
                }
            }

            foreach (var itemToRemove in itemsToRemove)
            {
                items.Remove(itemToRemove);
            }
        }

        public void Retry(Action action, int maxRetries = 3)
        {
            var count = 0;
            var success = false;

            while (count < maxRetries && !success)
            {
                try
                {
                    action();
                    success = true;
                }
                catch (Exception)
                {
                    count++;

                    if (count == maxRetries)
                    {
                        throw;
                    }
                }
            }
        }
    }
}
