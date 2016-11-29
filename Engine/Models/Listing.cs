using System;
using NPoco;

namespace Engine.Models
{
    [TableName("listing")]
    [PrimaryKey("ebay_id", AutoIncrement = false)]
    public class Listing
    {
        [Column("ebay_id")]
        public string EbayId { get; set; }

        [Column("asin")]
        public string Asin { get; set; }

        [Column("upc")]
        public string Upc { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("purchases")]
        public int Purchases { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("start_date")]
        public DateTime? StartDate { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("category")]
        public string Category { get; set; }

        [Column("pic_url")]
        public string PicUrl { get; set; }
    }
}