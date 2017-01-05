using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AndExteriors.Region1
{
    public partial class NotesEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "AndExteriors.Region1.NotesEditor";

        public NotesEditorAttribute()
            : base(Key)
        {
        }
    }
}

