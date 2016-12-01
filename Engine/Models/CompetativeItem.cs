using System.Collections.Generic;
using NPoco;

namespace Engine.Models
{
    [TableName("competative_item")]
    [PrimaryKey("ebay_id", AutoIncrement = false)]
    public class CompetativeItem
    {
        [Column("upc")]
        public string Upc { get; set; }

        [Column("ebay_id")]
        public string EbayId { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("category")]
        public string Category { get; set; }

        [Column("url")]
        public string Url { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("watch_count")]
        public long WatchCount { get; set; }

        [Ignore]
        public List<CompetativeItemTransaction> Transactions = new List<CompetativeItemTransaction>();
    }
}