// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_BOUND_BOOK
    public class UserBoundBook
    {
        public string AcqDocNo { get; set; } // ACQ_DOC_NO (Primary key) (length: 15)
        public string AcqTransType { get; set; } // ACQ_TRANS_TYPE (Primary key) (length: 3)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string SerNo { get; set; } // SER_NO (Primary key) (length: 30)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public string Descr { get; set; } // DESCR (length: 30)
        public string UserManufacturer { get; set; } // USER_MANUFACTURER (length: 30)
        public string UserImporter { get; set; } // USER_IMPORTER (length: 30)
        public string UserModel { get; set; } // USER_MODEL (length: 30)
        public string UserAction { get; set; } // USER_ACTION (length: 30)
        public string UserCaliberGauge { get; set; } // USER_CALIBER_GAUGE (length: 30)
        public string UserAtfType { get; set; } // USER_ATF_TYPE (length: 30)
        public string UserStateType { get; set; } // USER_STATE_TYPE (length: 30)
        public DateTime? AcqDate { get; set; } // ACQ_DATE
        public string AcqVendNo { get; set; } // ACQ_VEND_NO (length: 15)
        public string AcqCustNo { get; set; } // ACQ_CUST_NO (length: 15)
        public string AcqName { get; set; } // ACQ_NAME (length: 40)
        public string AcqAdrs1 { get; set; } // ACQ_ADRS_1 (length: 40)
        public string AcqAdrs2 { get; set; } // ACQ_ADRS_2 (length: 40)
        public string AcqCity { get; set; } // ACQ_CITY (length: 20)
        public string AcqState { get; set; } // ACQ_STATE (length: 10)
        public string AcqZipCode { get; set; } // ACQ_ZIP_CODE (length: 15)
        public string AcqFfl { get; set; } // ACQ_FFL (length: 30)
        public string AcqDojVerificationNo { get; set; } // ACQ_DOJ_VERIFICATION_NO (length: 30)
        public string AcqUsrId { get; set; } // ACQ_USR_ID (length: 10)
        public string DispDocNo { get; set; } // DISP_DOC_NO (length: 15)
        public string DispTransType { get; set; } // DISP_TRANS_TYPE (length: 3)
        public DateTime? DispDate { get; set; } // DISP_DATE
        public string DispVendNo { get; set; } // DISP_VEND_NO (length: 15)
        public string DispCustNo { get; set; } // DISP_CUST_NO (length: 15)
        public string DispName { get; set; } // DISP_NAME (length: 40)
        public string DispAdrs1 { get; set; } // DISP_ADRS_1 (length: 40)
        public string DispAdrs2 { get; set; } // DISP_ADRS_2 (length: 40)
        public string DispCity { get; set; } // DISP_CITY (length: 20)
        public string DispState { get; set; } // DISP_STATE (length: 10)
        public string DispZipCode { get; set; } // DISP_ZIP_CODE (length: 15)
        public string DispFfl { get; set; } // DISP_FFL (length: 30)
        public string Disp4473 { get; set; } // DISP_4473 (length: 30)
        public string DispApprovalNo { get; set; } // DISP_APPROVAL_NO (length: 50)
        public DateTime? DispDob { get; set; } // DISP_DOB
        public string DispUsrId { get; set; } // DISP_USR_ID (length: 10)
        public string ChangeNotes { get; set; } // CHANGE_NOTES (length: 50)
        public DateTime LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public int BoundBookSeqNo { get; set; } // BOUND_BOOK_SEQ_NO
        public int? BoundBookLocSeqNo { get; set; } // BOUND_BOOK_LOC_SEQ_NO
        public int? BoundBookPageNo { get; private set; } // BOUND_BOOK_PAGE_NO
        public int? BoundBookPageSeqNo { get; private set; } // BOUND_BOOK_PAGE_SEQ_NO
        public string UserCountryOfOrigin { get; set; } // USER_COUNTRY_OF_ORIGIN (length: 50)
        public string CorSerNo { get; set; } // COR_SER_NO (length: 30)
        public string BoundBookType { get; set; } // BOUND_BOOK_TYPE (length: 50)
        public int? BoundBookTypeLocSeqNo { get; set; } // BOUND_BOOK_TYPE_LOC_SEQ_NO
        public string ConversionRef { get; set; } // CONVERSION_REF (length: 10)
        public string E4473SeqNo { get; set; } // E4473_SEQ_NO
    }

}
// </auto-generated>
