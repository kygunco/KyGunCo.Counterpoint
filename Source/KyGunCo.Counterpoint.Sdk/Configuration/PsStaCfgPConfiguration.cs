// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_STA_CFG_PS
    public class PsStaCfgPConfiguration : IEntityTypeConfiguration<PsStaCfgP>
    {
        public void Configure(EntityTypeBuilder<PsStaCfgP> builder)
        {
            builder.ToTable("PS_STA_CFG_PS", "dbo");
            builder.HasKey(x => new { x.StrId, x.StaId }).HasName("PK_PS_STA_CFG_PS").IsClustered();

            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.UseDfltCust).HasColumnName(@"USE_DFLT_CUST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DfltLinMod).HasColumnName(@"DFLT_LIN_MOD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.BegTktAt).HasColumnName(@"BEG_TKT_AT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.BegLinAt).HasColumnName(@"BEG_LIN_AT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DfltEntMod).HasColumnName(@"DFLT_ENT_MOD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DfltTndPayCod).HasColumnName(@"DFLT_TND_PAY_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DfltChngPayCod).HasColumnName(@"DFLT_CHNG_PAY_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DfltRfndPayCod).HasColumnName(@"DFLT_RFND_PAY_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TouchScrnCod).HasColumnName(@"TOUCH_SCRN_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.NxtTktNo).HasColumnName(@"NXT_TKT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.NxtTktNoAuto).HasColumnName(@"NXT_TKT_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.NxtHoldNo).HasColumnName(@"NXT_HOLD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.NxtHoldNoAuto).HasColumnName(@"NXT_HOLD_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.NxtQuotNo).HasColumnName(@"NXT_QUOT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.NxtQuotNoAuto).HasColumnName(@"NXT_QUOT_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.NxtOrdNo).HasColumnName(@"NXT_ORD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.NxtOrdNoAuto).HasColumnName(@"NXT_ORD_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ServNam1).HasColumnName(@"SERV_NAM_1").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.ServNam2).HasColumnName(@"SERV_NAM_2").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.FrmTyp).HasColumnName(@"FRM_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseAllFrmGrps).HasColumnName(@"USE_ALL_FRM_GRPS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ShowItemImg).HasColumnName(@"SHOW_ITEM_IMG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ShowCustImg).HasColumnName(@"SHOW_CUST_IMG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseConsolLins).HasColumnName(@"USE_CONSOL_LINS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SigCapAfterPrt).HasColumnName(@"SIG_CAP_AFTER_PRT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OfflineNxtTktNo).HasColumnName(@"OFFLINE_NXT_TKT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OfflineNxtHoldNo).HasColumnName(@"OFFLINE_NXT_HOLD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OfflineNxtQuotNo).HasColumnName(@"OFFLINE_NXT_QUOT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OfflineNxtOrdNo).HasColumnName(@"OFFLINE_NXT_ORD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OfflineNxtTktNoAuto).HasColumnName(@"OFFLINE_NXT_TKT_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OfflineNxtHoldNoAuto).HasColumnName(@"OFFLINE_NXT_HOLD_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OfflineNxtQuotNoAuto).HasColumnName(@"OFFLINE_NXT_QUOT_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OfflineNxtOrdNoAuto).HasColumnName(@"OFFLINE_NXT_ORD_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OfflineNxtGfcNo).HasColumnName(@"OFFLINE_NXT_GFC_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.OfflineNxtStcNo).HasColumnName(@"OFFLINE_NXT_STC_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.OfflineNxtGfcNoAuto).HasColumnName(@"OFFLINE_NXT_GFC_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OfflineNxtStcNoAuto).HasColumnName(@"OFFLINE_NXT_STC_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OfflineNxtCustNo).HasColumnName(@"OFFLINE_NXT_CUST_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OfflineNxtCustNoAuto).HasColumnName(@"OFFLINE_NXT_CUST_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.NxtLwyNo).HasColumnName(@"NXT_LWY_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.NxtLwyNoAuto).HasColumnName(@"NXT_LWY_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OfflineNxtLwyNo).HasColumnName(@"OFFLINE_NXT_LWY_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OfflineNxtLwyNoAuto).HasColumnName(@"OFFLINE_NXT_LWY_NO_AUTO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ShowRdmLoyPtsMsg).HasColumnName(@"SHOW_RDM_LOY_PTS_MSG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseTndPayCodForChng).HasColumnName(@"USE_TND_PAY_COD_FOR_CHNG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.PsHdrCustFldFrmId).HasColumnName(@"PS_HDR_CUST_FLD_FRM_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.PsPmtCustFldFrmId).HasColumnName(@"PS_PMT_CUST_FLD_FRM_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.AllowTip).HasColumnName(@"ALLOW_TIP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowViewTip).HasColumnName(@"ALLOW_VIEW_TIP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);

            // Foreign keys
            builder.HasOne(a => a.PsSta).WithOne(b => b.PsStaCfgP).HasForeignKey<PsStaCfgP>(c => new { c.StrId, c.StaId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_STA_CFG_PS_PS_STA");

            builder.HasIndex(x => x.RsStat).HasDatabaseName("PS_STA_CFG_PS_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("PS_STA_CFG_PS_X_RS_UTC_DT");
        }
    }

}
// </auto-generated>
