
namespace AndExteriors.Region1.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("Region1.Category")]
    [BasedOnRow(typeof(Entities.CategoryRow))]
    public class CategoryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CategoryID { get; set; }
        [EditLink, Width(250)]
        public String CategoryName { get; set; }
        [Width(450)]
        public String Description { get; set; }
    }
}