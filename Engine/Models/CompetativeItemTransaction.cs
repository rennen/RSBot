using System;
using NPoco;

namespace Engine.Models
{
    [TableName("competative_item_transaction")]
    [PrimaryKey("ebay_item_id", AutoIncrement = false)]
    public class CompetativeItemTransaction
    {
        [Column("ebay_item_id")]
        public string EbayItemId { get; set; }

        [Column("transaction_id")]
        public string TransactionId { get; set; }

        [Column("transaction_time_utc")]
        public DateTime TransactionTime { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("price")]
        public double Price { get; set; }
    }
}