// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DOC_HDR_PROF
    public class PsDocHdrProf
    {
        public long DocId { get; set; } // DOC_ID (Primary key)
        public string ProfCod1 { get; set; } // PROF_COD_1 (length: 10)
        public string ProfCod2 { get; set; } // PROF_COD_2 (length: 10)
        public string ProfCod3 { get; set; } // PROF_COD_3 (length: 10)
        public string ProfCod4 { get; set; } // PROF_COD_4 (length: 10)
        public string ProfCod5 { get; set; } // PROF_COD_5 (length: 10)
        public decimal? ProfNo1 { get; set; } // PROF_NO_1
        public decimal? ProfNo2 { get; set; } // PROF_NO_2
        public decimal? ProfNo3 { get; set; } // PROF_NO_3
        public decimal? ProfNo4 { get; set; } // PROF_NO_4
        public decimal? ProfNo5 { get; set; } // PROF_NO_5
        public string ProfAlpha1 { get; set; } // PROF_ALPHA_1 (length: 30)
        public string ProfAlpha2 { get; set; } // PROF_ALPHA_2 (length: 30)
        public string ProfAlpha3 { get; set; } // PROF_ALPHA_3 (length: 30)
        public string ProfAlpha4 { get; set; } // PROF_ALPHA_4 (length: 30)
        public string ProfAlpha5 { get; set; } // PROF_ALPHA_5 (length: 30)
        public DateTime? ProfDat1 { get; set; } // PROF_DAT_1
        public DateTime? ProfDat2 { get; set; } // PROF_DAT_2
        public DateTime? ProfDat3 { get; set; } // PROF_DAT_3
        public DateTime? ProfDat4 { get; set; } // PROF_DAT_4
        public DateTime? ProfDat5 { get; set; } // PROF_DAT_5

        // Foreign keys

        /// <summary>
        /// Parent PsDocHdr pointed by [PS_DOC_HDR_PROF].([DocId]) (FK_PS_DOC_HDR_PROF_PS_DOC_HDR)
        /// </summary>
        public virtual PsDocHdr PsDocHdr { get; set; } // FK_PS_DOC_HDR_PROF_PS_DOC_HDR
    }

}
// </auto-generated>
