// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace KyGunCo.Counterpoint.Sdk.Data
{
    using System;
    using ServiceStack.DataAnnotations;

    public partial class USER_KGC_ITEM_CHANGES_QUEUE
    {
        [Required]
        [PrimaryKey]
        public string ITEM_NO { get; set; }
        public DateTimeOffset CREATED_DT { get; set; }
        public DateTimeOffset UPDATED_DT { get; set; }
    }
}
