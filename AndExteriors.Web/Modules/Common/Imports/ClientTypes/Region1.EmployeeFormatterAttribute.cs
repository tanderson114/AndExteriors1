using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AndExteriors.Region1
{
    public partial class EmployeeFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "AndExteriors.Region1.EmployeeFormatter";

        public EmployeeFormatterAttribute()
            : base(Key)
        {
        }

        public String GenderProperty
        {
            get { return GetOption<String>("genderProperty"); }
            set { SetOption("genderProperty", value); }
        }
    }
}

