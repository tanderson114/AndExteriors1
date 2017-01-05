using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AndExteriors.Region1
{
    public partial class CustomerEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "AndExteriors.Region1.CustomerEditor";

        public CustomerEditorAttribute()
            : base(Key)
        {
        }
    }
}

