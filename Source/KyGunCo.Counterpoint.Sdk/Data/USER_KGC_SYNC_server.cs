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

    public partial class USER_KGC_SYNC_server 
    {
        [Required]
        [PrimaryKey]
        public string sync_scope_name { get; set; }
        public string sync_scope_schema { get; set; }
        public string sync_scope_setup { get; set; }
        public string sync_scope_version { get; set; }
        public long? sync_scope_last_clean_timestamp { get; set; }
    }

}
#pragma warning restore 1591
