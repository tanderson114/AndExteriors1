
namespace AndExteriors.Region1.Forms
{
    using System;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Region1.Category")]
    [BasedOnRow(typeof(Entities.CategoryRow))]
    public class CategoryForm
    {
        public String CategoryName { get; set; }
        public String Description { get; set; }
    }
}