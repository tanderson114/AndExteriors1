using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AndExteriors.Region1
{
    public partial class FreightFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "AndExteriors.Region1.FreightFormatter";

        public FreightFormatterAttribute()
            : base(Key)
        {
        }
    }
}

