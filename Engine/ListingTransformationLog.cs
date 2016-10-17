using System;
using NPoco;

namespace Engine
{
    [TableName("listing_trans_log")]
    [PrimaryKey("ebay_id", AutoIncrement = false)]
    public class ListingTransformationLog
    {
        [Column("ebay_id")]
        public string EbayId { get; set; }

        [Column("timestamp")]
        public DateTime? Timestamp { get; set; }

        [Column("collage_added")]
        public bool CollageAdded { get; set; }
    }
}