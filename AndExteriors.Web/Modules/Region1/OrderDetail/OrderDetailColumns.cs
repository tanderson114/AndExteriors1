﻿
namespace AndExteriors.Region1.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Region1.OrderDetail")]
    [BasedOnRow(typeof(Entities.OrderDetailRow))]
    public class OrderDetailColumns
    {
        [EditLink, Width(200)]
        public String ProductName { get; set; }
        [Width(100)]
        public Decimal UnitPrice { get; set; }
        [Width(100)]
        public Int16 Quantity { get; set; }
        [Width(100)]
        public Double Discount { get; set; }
        [Width(100)]
        public Decimal LineTotal { get; set; }
    }
}