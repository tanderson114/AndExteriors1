﻿
namespace AndExteriors.Region1.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("Region1.Region")]
    [BasedOnRow(typeof(Entities.RegionRow))]
    public class RegionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 RegionID { get; set; }
        [EditLink, Width(300)]
        public String RegionDescription { get; set; }
    }
}