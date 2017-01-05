﻿
namespace AndExteriors.Region1.Entities
{
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Region1"), DisplayName("Sales by Category"), InstanceName("Sales by Category"), TwoLevelCached]
    [ReadPermission("Region1:General")]
    [ModifyPermission("Region1:General")]
    public sealed class SalesByCategoryRow : Row, INameRow
    {
        [DisplayName("Category Id"), Column("CategoryID"), NotNull]
        public Int32? CategoryId
        {
            get { return Fields.CategoryId[this]; }
            set { Fields.CategoryId[this] = value; }
        }

        [DisplayName("Category Name"), Size(15), NotNull, QuickSearch]
        public String CategoryName
        {
            get { return Fields.CategoryName[this]; }
            set { Fields.CategoryName[this] = value; }
        }

        [DisplayName("Product Name"), Size(40), NotNull, QuickSearch]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }

        [DisplayName("Product Sales"), Size(19), Scale(4)]
        public Decimal? ProductSales
        {
            get { return Fields.ProductSales[this]; }
            set { Fields.ProductSales[this] = value; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CategoryName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SalesByCategoryRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CategoryId;
            public StringField CategoryName;
            public StringField ProductName;
            public DecimalField ProductSales;

            public RowFields()
                : base("[dbo].[Sales by Category]")
            {
                LocalTextPrefix = "Region1.SalesByCategory";
            }
        }
    }
}