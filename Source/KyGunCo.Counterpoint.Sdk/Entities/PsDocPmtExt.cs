// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DOC_PMT_EXT
    public class PsDocPmtExt
    {
        public long DocIdExt { get; set; } // DOC_ID_EXT (Primary key)
        public int PmtSeqNoExt { get; set; } // PMT_SEQ_NO_EXT (Primary key)
        public string UserRef { get; set; } // USER_REF (length: 50)

        // Foreign keys

        /// <summary>
        /// Parent PsDocPmt pointed by [PS_DOC_PMT_EXT].([DocIdExt], [PmtSeqNoExt]) (FK_PS_DOC_PMT_EXT_PS_DOC_PMT)
        /// </summary>
        public virtual PsDocPmt PsDocPmt { get; set; } // FK_PS_DOC_PMT_EXT_PS_DOC_PMT
    }

}
// </auto-generated>
