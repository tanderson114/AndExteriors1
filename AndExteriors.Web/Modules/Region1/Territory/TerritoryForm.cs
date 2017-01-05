
namespace AndExteriors.Region1.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Region1.Territory")]
    [BasedOnRow(typeof(Entities.TerritoryRow))]
    public class TerritoryForm
    {
        public String TerritoryID { get; set; }
        public String TerritoryDescription { get; set; }
        [LookupEditor(typeof(Entities.RegionRow))]
        public Int32 RegionID { get; set; }
    }
}