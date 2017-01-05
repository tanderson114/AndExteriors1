using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AndExteriors.Region1
{
    public partial class ShipperFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "AndExteriors.Region1.ShipperFormatter";

        public ShipperFormatterAttribute()
            : base(Key)
        {
        }
    }
}

