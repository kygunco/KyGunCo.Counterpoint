// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // SY_ACCTG_INTFC
    public class SyAcctgIntfc
    {
        public int KeyId { get; set; } = 1; // KEY_ID (Primary key)
        public string AcctgSys { get; set; } = "NONE"; // ACCTG_SYS (length: 10)
        public string CompId { get; set; } // COMP_ID (length: 10)
        public string DataPath { get; set; } // DATA_PATH (length: 100)
        public string IntfcWithGl { get; set; } = "N"; // INTFC_WITH_GL (length: 1)
        public string GlPath { get; set; } // GL_PATH (length: 100)
        public string GlCorrAcct { get; set; } // GL_CORR_ACCT (length: 20)
        public string GlBatNo { get; set; } = "GL-0001"; // GL_BAT_NO (length: 15)
        public string GlBatMeth { get; set; } = "R"; // GL_BAT_METH (length: 1)
        public string IntfcWithAp { get; set; } = "N"; // INTFC_WITH_AP (length: 1)
        public string ApPath { get; set; } // AP_PATH (length: 100)
        public string ApBatNo { get; set; } = "AP-0001"; // AP_BAT_NO (length: 15)
        public string TmpltVend { get; set; } // TMPLT_VEND (length: 15)
        public string InvcVarAcct { get; set; } // INVC_VAR_ACCT (length: 20)
        public string Seg1Part1Typ { get; set; } = "A"; // SEG_1_PART_1_TYP (length: 1)
        public string Seg1Part1Lit { get; set; } // SEG_1_PART_1_LIT (length: 15)
        public int? Seg1Part1Strt { get; set; } = 1; // SEG_1_PART_1_STRT
        public int? Seg1Part1Len { get; set; } = 20; // SEG_1_PART_1_LEN
        public string Seg1Part2Typ { get; set; } = "!"; // SEG_1_PART_2_TYP (length: 1)
        public string Seg1Part2Lit { get; set; } // SEG_1_PART_2_LIT (length: 15)
        public int? Seg1Part2Strt { get; set; } // SEG_1_PART_2_STRT
        public int? Seg1Part2Len { get; set; } // SEG_1_PART_2_LEN
        public string Seg1Part3Typ { get; set; } = "!"; // SEG_1_PART_3_TYP (length: 1)
        public string Seg1Part3Lit { get; set; } // SEG_1_PART_3_LIT (length: 15)
        public int? Seg1Part3Strt { get; set; } // SEG_1_PART_3_STRT
        public int? Seg1Part3Len { get; set; } // SEG_1_PART_3_LEN
        public string Seg2Part1Typ { get; set; } = "!"; // SEG_2_PART_1_TYP (length: 1)
        public string Seg2Part1Lit { get; set; } // SEG_2_PART_1_LIT (length: 15)
        public int? Seg2Part1Strt { get; set; } // SEG_2_PART_1_STRT
        public int? Seg2Part1Len { get; set; } // SEG_2_PART_1_LEN
        public string Seg2Part2Typ { get; set; } = "!"; // SEG_2_PART_2_TYP (length: 1)
        public string Seg2Part2Lit { get; set; } // SEG_2_PART_2_LIT (length: 15)
        public int? Seg2Part2Strt { get; set; } // SEG_2_PART_2_STRT
        public int? Seg2Part2Len { get; set; } // SEG_2_PART_2_LEN
        public string Seg2Part3Typ { get; set; } = "!"; // SEG_2_PART_3_TYP (length: 1)
        public string Seg2Part3Lit { get; set; } // SEG_2_PART_3_LIT (length: 15)
        public int? Seg2Part3Strt { get; set; } // SEG_2_PART_3_STRT
        public int? Seg2Part3Len { get; set; } // SEG_2_PART_3_LEN
        public string Seg3Part1Typ { get; set; } = "!"; // SEG_3_PART_1_TYP (length: 1)
        public string Seg3Part1Lit { get; set; } // SEG_3_PART_1_LIT (length: 15)
        public int? Seg3Part1Strt { get; set; } // SEG_3_PART_1_STRT
        public int? Seg3Part1Len { get; set; } // SEG_3_PART_1_LEN
        public string Seg3Part2Typ { get; set; } = "!"; // SEG_3_PART_2_TYP (length: 1)
        public string Seg3Part2Lit { get; set; } // SEG_3_PART_2_LIT (length: 15)
        public int? Seg3Part2Strt { get; set; } // SEG_3_PART_2_STRT
        public int? Seg3Part2Len { get; set; } // SEG_3_PART_2_LEN
        public string Seg3Part3Typ { get; set; } = "!"; // SEG_3_PART_3_TYP (length: 1)
        public string Seg3Part3Lit { get; set; } // SEG_3_PART_3_LIT (length: 15)
        public int? Seg3Part3Strt { get; set; } // SEG_3_PART_3_STRT
        public int? Seg3Part3Len { get; set; } // SEG_3_PART_3_LEN
        public string Seg4Part1Typ { get; set; } = "!"; // SEG_4_PART_1_TYP (length: 1)
        public string Seg4Part1Lit { get; set; } // SEG_4_PART_1_LIT (length: 15)
        public int? Seg4Part1Strt { get; set; } // SEG_4_PART_1_STRT
        public int? Seg4Part1Len { get; set; } // SEG_4_PART_1_LEN
        public string Seg4Part2Typ { get; set; } = "!"; // SEG_4_PART_2_TYP (length: 1)
        public string Seg4Part2Lit { get; set; } // SEG_4_PART_2_LIT (length: 15)
        public int? Seg4Part2Strt { get; set; } // SEG_4_PART_2_STRT
        public int? Seg4Part2Len { get; set; } // SEG_4_PART_2_LEN
        public string Seg4Part3Typ { get; set; } = "!"; // SEG_4_PART_3_TYP (length: 1)
        public string Seg4Part3Lit { get; set; } // SEG_4_PART_3_LIT (length: 15)
        public int? Seg4Part3Strt { get; set; } // SEG_4_PART_3_STRT
        public int? Seg4Part3Len { get; set; } // SEG_4_PART_3_LEN
        public string Seg5Part1Typ { get; set; } = "!"; // SEG_5_PART_1_TYP (length: 1)
        public string Seg5Part1Lit { get; set; } // SEG_5_PART_1_LIT (length: 15)
        public int? Seg5Part1Strt { get; set; } // SEG_5_PART_1_STRT
        public int? Seg5Part1Len { get; set; } // SEG_5_PART_1_LEN
        public string Seg5Part2Typ { get; set; } = "!"; // SEG_5_PART_2_TYP (length: 1)
        public string Seg5Part2Lit { get; set; } // SEG_5_PART_2_LIT (length: 15)
        public int? Seg5Part2Strt { get; set; } // SEG_5_PART_2_STRT
        public int? Seg5Part2Len { get; set; } // SEG_5_PART_2_LEN
        public string Seg5Part3Typ { get; set; } = "!"; // SEG_5_PART_3_TYP (length: 1)
        public string Seg5Part3Lit { get; set; } // SEG_5_PART_3_LIT (length: 15)
        public int? Seg5Part3Strt { get; set; } // SEG_5_PART_3_STRT
        public int? Seg5Part3Len { get; set; } // SEG_5_PART_3_LEN
        public string AcctPart1Typ { get; set; } = "1"; // ACCT_PART_1_TYP (length: 1)
        public string AcctPart1Lit { get; set; } // ACCT_PART_1_LIT (length: 15)
        public int? AcctPart1Strt { get; set; } = 1; // ACCT_PART_1_STRT
        public int? AcctPart1Len { get; set; } = 20; // ACCT_PART_1_LEN
        public string AcctPart2Typ { get; set; } = "!"; // ACCT_PART_2_TYP (length: 1)
        public string AcctPart2Lit { get; set; } // ACCT_PART_2_LIT (length: 15)
        public int? AcctPart2Strt { get; set; } // ACCT_PART_2_STRT
        public int? AcctPart2Len { get; set; } // ACCT_PART_2_LEN
        public string AcctPart3Typ { get; set; } = "!"; // ACCT_PART_3_TYP (length: 1)
        public string AcctPart3Lit { get; set; } // ACCT_PART_3_LIT (length: 15)
        public int? AcctPart3Strt { get; set; } // ACCT_PART_3_STRT
        public int? AcctPart3Len { get; set; } // ACCT_PART_3_LEN
        public string AcctPart4Typ { get; set; } = "!"; // ACCT_PART_4_TYP (length: 1)
        public string AcctPart4Lit { get; set; } // ACCT_PART_4_LIT (length: 15)
        public int? AcctPart4Strt { get; set; } // ACCT_PART_4_STRT
        public int? AcctPart4Len { get; set; } // ACCT_PART_4_LEN
        public string AcctPart5Typ { get; set; } = "!"; // ACCT_PART_5_TYP (length: 1)
        public string AcctPart5Lit { get; set; } // ACCT_PART_5_LIT (length: 15)
        public int? AcctPart5Strt { get; set; } // ACCT_PART_5_STRT
        public int? AcctPart5Len { get; set; } // ACCT_PART_5_LEN
        public string AcctPart6Typ { get; set; } = "!"; // ACCT_PART_6_TYP (length: 1)
        public string AcctPart6Lit { get; set; } // ACCT_PART_6_LIT (length: 15)
        public int? AcctPart6Strt { get; set; } // ACCT_PART_6_STRT
        public int? AcctPart6Len { get; set; } // ACCT_PART_6_LEN
        public string AcctPart7Typ { get; set; } = "!"; // ACCT_PART_7_TYP (length: 1)
        public string AcctPart7Lit { get; set; } // ACCT_PART_7_LIT (length: 15)
        public int? AcctPart7Strt { get; set; } // ACCT_PART_7_STRT
        public int? AcctPart7Len { get; set; } // ACCT_PART_7_LEN
        public string AcctPart8Typ { get; set; } = "!"; // ACCT_PART_8_TYP (length: 1)
        public string AcctPart8Lit { get; set; } // ACCT_PART_8_LIT (length: 15)
        public int? AcctPart8Strt { get; set; } // ACCT_PART_8_STRT
        public int? AcctPart8Len { get; set; } // ACCT_PART_8_LEN
        public string AcctPart9Typ { get; set; } = "!"; // ACCT_PART_9_TYP (length: 1)
        public string AcctPart9Lit { get; set; } // ACCT_PART_9_LIT (length: 15)
        public int? AcctPart9Strt { get; set; } // ACCT_PART_9_STRT
        public int? AcctPart9Len { get; set; } // ACCT_PART_9_LEN
        public string AcctPart10Typ { get; set; } = "!"; // ACCT_PART_10_TYP (length: 1)
        public string AcctPart10Lit { get; set; } // ACCT_PART_10_LIT (length: 15)
        public int? AcctPart10Strt { get; set; } // ACCT_PART_10_STRT
        public int? AcctPart10Len { get; set; } // ACCT_PART_10_LEN
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string DbNam { get; set; } // DB_NAM (length: 128)
        public string DbUsrId { get; set; } // DB_USR_ID (length: 128)
        public string DbPassword { get; set; } // DB_PASSWORD (length: 128)
        public string GlCmdTyp { get; set; } = "!"; // GL_CMD_TYP (length: 1)
        public string GlDtsRunPath { get; set; } = @"C:\Program Files\Microsoft SQL Server\80\Tools\Binn"; // GL_DTS_RUN_PATH (length: 100)
        public string GlDtsPkg { get; set; } // GL_DTS_PKG (length: 100)
        public string GlCmdToRun { get; set; } // GL_CMD_TO_RUN (length: 100)
        public string GlFilename { get; set; } // GL_FILENAME (length: 100)
        public string ApCmdTyp { get; set; } = "!"; // AP_CMD_TYP (length: 1)
        public string ApDtsRunPath { get; set; } = @"C:\Program Files\Microsoft SQL Server\80\Tools\Binn"; // AP_DTS_RUN_PATH (length: 100)
        public string ApDtsPkg { get; set; } // AP_DTS_PKG (length: 100)
        public string ApCmdToRun { get; set; } // AP_CMD_TO_RUN (length: 100)
        public string ApFilename { get; set; } // AP_FILENAME (length: 100)
        public string GlCmdArgs { get; set; } // GL_CMD_ARGS (length: 100)
        public string ApCmdArgs { get; set; } // AP_CMD_ARGS (length: 100)
        public string GlFilePromptFlg { get; set; } = "PC"; // GL_FILE_PROMPT_FLG (length: 2)
        public string ApFilePromptFlg { get; set; } = "PC"; // AP_FILE_PROMPT_FLG (length: 2)
        public string AllowConcurrentVchr { get; set; } = "N"; // ALLOW_CONCURRENT_VCHR (length: 1)
        public string ApAcctNo { get; set; } // AP_ACCT_NO (length: 50)
        public string UseNxtVchrNo { get; set; } = "N"; // USE_NXT_VCHR_NO (length: 1)
        public string NxtVchrNo { get; set; } // NXT_VCHR_NO (length: 20)
        public string InvcGainLossAcct { get; set; } // INVC_GAIN_LOSS_ACCT (length: 20)
        public string RecvAccruAcct { get; set; } // RECV_ACCRU_ACCT (length: 20)
    }

}
// </auto-generated>
