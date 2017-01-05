
namespace AndExteriors.Region1.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.IO;
    using System.ComponentModel;
    using Serenity.ComponentModel;

    [ConnectionKey("Region1"), DisplayName("Region"), InstanceName("Region"), TwoLevelCached]
    [ReadPermission(Region1.PermissionKeys.General)]
    [ModifyPermission(Region1.PermissionKeys.General)]
    [LookupScript("Region1.Region")]
    public sealed class RegionRow : Row, IIdRow, INameRow
    {
        [DisplayName("Region Id"), PrimaryKey, NotNull, Updatable(false), QuickSearch]
        public Int32? RegionID
        {
            get { return Fields.RegionID[this]; }
            set { Fields.RegionID[this] = value; }
        }

        [DisplayName("Region Description"), Size(50), NotNull, QuickSearch]
        public String RegionDescription
        {
            get { return Fields.RegionDescription[this]; }
            set { Fields.RegionDescription[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.RegionID; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RegionDescription; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RegionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RegionID;
            public StringField RegionDescription;
            public RowFields()
                : base("Region")
            {
                LocalTextPrefix = "Region1.Region";
            }
        }
    }
}