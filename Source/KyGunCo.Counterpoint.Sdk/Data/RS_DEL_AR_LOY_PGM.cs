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

    public partial class RS_DEL_AR_LOY_PGM 
    {
        [AutoIncrement]
        [PrimaryKey]
        public int DEL_ID { get; set; }
        public byte? RS_STAT { get; set; }
        public DateTime? DELETE_DT { get; set; }
        public string LOY_PGM_COD { get; set; }
    }

}
#pragma warning restore 1591
