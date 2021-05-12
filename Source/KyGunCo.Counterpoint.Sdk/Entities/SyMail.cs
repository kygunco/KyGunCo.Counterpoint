// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // SY_MAIL
    public class SyMail
    {
        public long MailId { get; set; } // MAIL_ID (Primary key)
        public string SenderId { get; set; } // SENDER_ID (length: 10)
        public DateTime? SentDt { get; set; } = DateTime.Now; // SENT_DT
        public string Subj { get; set; } // SUBJ (length: 50)
        public string Msg { get; set; } // MSG (length: 2147483647)
        public string MsgTxt { get; set; } // MSG_TXT (length: 2147483647)
        public string Importance { get; set; } = "N"; // IMPORTANCE (length: 1)
        public string SentTo { get; set; } // SENT_TO (length: 2147483647)
        public string IsPopup { get; set; } = "N"; // IS_POPUP (length: 1)
        public string DeltdBySender { get; set; } = "N"; // DELTD_BY_SENDER (length: 1)
        public string AutoDelPopup { get; set; } = "N"; // AUTO_DEL_POPUP (length: 1)
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT

        // Reverse navigation

        /// <summary>
        /// Child SyMailRecpnts where [SY_MAIL_RECPNT].[MAIL_ID] point to this entity (FK_SY_MAIL_RECPNT_SY_MAIL)
        /// </summary>
        public virtual IList<SyMailRecpnt> SyMailRecpnts { get; set; } = new List<SyMailRecpnt>(); // SY_MAIL_RECPNT.FK_SY_MAIL_RECPNT_SY_MAIL

        // Foreign keys

        /// <summary>
        /// Parent SyUsr pointed by [SY_MAIL].([SenderId]) (FK_SY_MAIL_SY_USR)
        /// </summary>
        public virtual SyUsr SyUsr { get; set; } // FK_SY_MAIL_SY_USR
    }

}
// </auto-generated>
