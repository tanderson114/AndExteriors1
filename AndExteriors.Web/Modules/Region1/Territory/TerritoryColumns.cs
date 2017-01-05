
namespace AndExteriors.Region1.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("Region1.Territory")]
    [BasedOnRow(typeof(Entities.TerritoryRow))]
    public class TerritoryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), Width(100)]
        public Int32 TerritoryID { get; set; }
        [EditLink, Width(200)]
        public String TerritoryDescription { get; set; }
        [EditLink(ItemType = "Region1.Region", IdField = "RegionID"), Width(150)]
        [LookupEditor(typeof(Entities.RegionRow)), QuickFilter]
        public String RegionDescription { get; set; }
    }
}