// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_CTL
    public class PoCtlConfiguration : IEntityTypeConfiguration<PoCtl>
    {
        public void Configure(EntityTypeBuilder<PoCtl> builder)
        {
            builder.ToTable("PO_CTL", "dbo");
            builder.HasKey(x => x.KeyId).HasName("PK_PO_CTL").IsClustered();

            builder.Property(x => x.KeyId).HasColumnName(@"KEY_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.VitemCostUpdMeth).HasColumnName(@"VITEM_COST_UPD_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VitemCreateMeth).HasColumnName(@"VITEM_CREATE_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendAutoNoteId).HasColumnName(@"VEND_AUTO_NOTE_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ItemAutoNoteId).HasColumnName(@"ITEM_AUTO_NOTE_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.PoOrdAutoNoteId).HasColumnName(@"PO_ORD_AUTO_NOTE_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.VendProfAlpha1).HasColumnName(@"VEND_PROF_ALPHA_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfAlpha2).HasColumnName(@"VEND_PROF_ALPHA_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfAlpha3).HasColumnName(@"VEND_PROF_ALPHA_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfAlpha4).HasColumnName(@"VEND_PROF_ALPHA_4").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfAlpha5).HasColumnName(@"VEND_PROF_ALPHA_5").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfCod1).HasColumnName(@"VEND_PROF_COD_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfCod2).HasColumnName(@"VEND_PROF_COD_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfCod3).HasColumnName(@"VEND_PROF_COD_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfCod4).HasColumnName(@"VEND_PROF_COD_4").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfCod5).HasColumnName(@"VEND_PROF_COD_5").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfDat1).HasColumnName(@"VEND_PROF_DAT_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfDat2).HasColumnName(@"VEND_PROF_DAT_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfDat3).HasColumnName(@"VEND_PROF_DAT_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfDat4).HasColumnName(@"VEND_PROF_DAT_4").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfDat5).HasColumnName(@"VEND_PROF_DAT_5").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfNo1).HasColumnName(@"VEND_PROF_NO_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfNo2).HasColumnName(@"VEND_PROF_NO_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfNo3).HasColumnName(@"VEND_PROF_NO_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfNo4).HasColumnName(@"VEND_PROF_NO_4").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.VendProfNo5).HasColumnName(@"VEND_PROF_NO_5").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DfltLinDescr).HasColumnName(@"DFLT_LIN_DESCR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseMisc1).HasColumnName(@"USE_MISC_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CostInMisc1).HasColumnName(@"COST_IN_MISC_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocMisc1By).HasColumnName(@"ALLOC_MISC_1_BY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseMisc2).HasColumnName(@"USE_MISC_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CostInMisc2).HasColumnName(@"COST_IN_MISC_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocMisc2By).HasColumnName(@"ALLOC_MISC_2_BY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseMisc3).HasColumnName(@"USE_MISC_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CostInMisc3).HasColumnName(@"COST_IN_MISC_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocMisc3By).HasColumnName(@"ALLOC_MISC_3_BY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseMisc4).HasColumnName(@"USE_MISC_4").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CostInMisc4).HasColumnName(@"COST_IN_MISC_4").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocMisc4By).HasColumnName(@"ALLOC_MISC_4_BY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseMisc5).HasColumnName(@"USE_MISC_5").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CostInMisc5).HasColumnName(@"COST_IN_MISC_5").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocMisc5By).HasColumnName(@"ALLOC_MISC_5_BY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DfltRecvMeth).HasColumnName(@"DFLT_RECV_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoJrnlPrtMeth).HasColumnName(@"PO_JRNL_PRT_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoFrmPrtMeth).HasColumnName(@"PO_FRM_PRT_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RecvrJrnlPrtMeth).HasColumnName(@"RECVR_JRNL_PRT_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RecvrFrmPrtMeth).HasColumnName(@"RECVR_FRM_PRT_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoQrecvJrnlMeth).HasColumnName(@"PO_QRECV_JRNL_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SuggQtyRoundMeth).HasColumnName(@"SUGG_QTY_ROUND_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Misc1Meth).HasColumnName(@"MISC_1_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Misc1AcctNo).HasColumnName(@"MISC_1_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Misc2Meth).HasColumnName(@"MISC_2_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Misc2AcctNo).HasColumnName(@"MISC_2_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Misc3Meth).HasColumnName(@"MISC_3_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Misc3AcctNo).HasColumnName(@"MISC_3_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Misc4Meth).HasColumnName(@"MISC_4_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Misc4AcctNo).HasColumnName(@"MISC_4_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Misc5Meth).HasColumnName(@"MISC_5_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Misc5AcctNo).HasColumnName(@"MISC_5_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RecvrJrnlDist).HasColumnName(@"RECVR_JRNL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoQrecvJrnlDist).HasColumnName(@"PO_QRECV_JRNL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PrmptForLinInfo).HasColumnName(@"PRMPT_FOR_LIN_INFO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.XferCreateMeth).HasColumnName(@"XFER_CREATE_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DfltRecvLblJob).HasColumnName(@"DFLT_RECV_LBL_JOB").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PreqTagsMeth).HasColumnName(@"PREQ_TAGS_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RecvTagsMeth).HasColumnName(@"RECV_TAGS_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.QrecvTagsMeth).HasColumnName(@"QRECV_TAGS_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DfltPreqLblJob).HasColumnName(@"DFLT_PREQ_LBL_JOB").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DfltQrecvLblJob).HasColumnName(@"DFLT_QRECV_LBL_JOB").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RtvJrnlPrtMeth).HasColumnName(@"RTV_JRNL_PRT_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RtvFrmPrtMeth).HasColumnName(@"RTV_FRM_PRT_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RtvJrnlDist).HasColumnName(@"RTV_JRNL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RtvPrmptForLinInfo).HasColumnName(@"RTV_PRMPT_FOR_LIN_INFO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RtvDfltLinDescr).HasColumnName(@"RTV_DFLT_LIN_DESCR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoAdjJrnlPrtMeth).HasColumnName(@"PO_ADJ_JRNL_PRT_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoAdjJrnlDist).HasColumnName(@"PO_ADJ_JRNL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IncrementOnReissue).HasColumnName(@"INCREMENT_ON_REISSUE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.WarnDiscontOnPreq).HasColumnName(@"WARN_DISCONT_ON_PREQ").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.WarnDiscontOnRecv).HasColumnName(@"WARN_DISCONT_ON_RECV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ConsolLinsMeth).HasColumnName(@"CONSOL_LINS_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.WarnOfOddCost).HasColumnName(@"WARN_OF_ODD_COST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.WarnOfOddCostThresholdPct).HasColumnName(@"WARN_OF_ODD_COST_THRESHOLD_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.BatIdForDropships).HasColumnName(@"BAT_ID_FOR_DROPSHIPS").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UseMultiCurr).HasColumnName(@"USE_MULTI_CURR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseTaxInPurchasing).HasColumnName(@"USE_TAX_IN_PURCHASING").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DfltCurncyCodMisc1).HasColumnName(@"DFLT_CURNCY_COD_MISC_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DfltCurncyCodMisc2).HasColumnName(@"DFLT_CURNCY_COD_MISC_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DfltCurncyCodMisc3).HasColumnName(@"DFLT_CURNCY_COD_MISC_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DfltCurncyCodMisc4).HasColumnName(@"DFLT_CURNCY_COD_MISC_4").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DfltCurncyCodMisc5).HasColumnName(@"DFLT_CURNCY_COD_MISC_5").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxAccruAcctNo).HasColumnName(@"TAX_ACCRU_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.TaxAccruMeth).HasColumnName(@"TAX_ACCRU_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);

            builder.HasIndex(x => x.RsStat).HasDatabaseName("PO_CTL_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("PO_CTL_X_RS_UTC_DT");
        }
    }

}
// </auto-generated>
