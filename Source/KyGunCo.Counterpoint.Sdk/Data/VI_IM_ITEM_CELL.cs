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
    using ServiceStack.Model;
    using ServiceStack;

    public partial class VI_IM_ITEM_CELL 
    {
        [Required]
        public string ITEM_NO { get; set; }
        public string DisplayLabel1 { get; set; }
        public string DisplayLabel2 { get; set; }
        public string DisplayLabel3 { get; set; }
    }

}
#pragma warning restore 1591
