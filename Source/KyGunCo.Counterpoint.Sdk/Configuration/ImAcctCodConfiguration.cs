// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_ACCT_COD
    public class ImAcctCodConfiguration : IEntityTypeConfiguration<ImAcctCod>
    {
        public void Configure(EntityTypeBuilder<ImAcctCod> builder)
        {
            builder.ToTable("IM_ACCT_COD", "dbo");
            builder.HasKey(x => x.AcctCod).HasName("PK_IM_ACCT_COD").IsClustered();

            builder.Property(x => x.AcctCod).HasColumnName(@"ACCT_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.BsInvAcctNo).HasColumnName(@"BS_INV_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.MitemExpAcctNo).HasColumnName(@"MITEM_EXP_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.MitemExpMeth).HasColumnName(@"MITEM_EXP_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RecvAccruAcctNo).HasColumnName(@"RECV_ACCRU_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RecvAccruMeth).HasColumnName(@"RECV_ACCRU_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PurVarAcctNo).HasColumnName(@"PUR_VAR_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.PurVarMeth).HasColumnName(@"PUR_VAR_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SlsAcctNo).HasColumnName(@"SLS_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.SlsMeth).HasColumnName(@"SLS_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CogsAcctNo).HasColumnName(@"COGS_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.CogsMeth).HasColumnName(@"COGS_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RetAcctNo).HasColumnName(@"RET_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RetMeth).HasColumnName(@"RET_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CogsRetAcctNo).HasColumnName(@"COGS_RET_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.CogsRetMeth).HasColumnName(@"COGS_RET_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RtvAcctNo).HasColumnName(@"RTV_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RtvMeth).HasColumnName(@"RTV_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AdjAcctNo).HasColumnName(@"ADJ_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.AdjMeth).HasColumnName(@"ADJ_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CostCorrAcctNo).HasColumnName(@"COST_CORR_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.CostCorrMeth).HasColumnName(@"COST_CORR_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DropshipInvAcctNo).HasColumnName(@"DROPSHIP_INV_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.PhysCntAcctNo).HasColumnName(@"PHYS_CNT_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.PhysCntMeth).HasColumnName(@"PHYS_CNT_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RecvAdjAcctNo).HasColumnName(@"RECV_ADJ_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RecvAdjMeth).HasColumnName(@"RECV_ADJ_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.XferClrAcctNo).HasColumnName(@"XFER_CLR_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RtvAdjMeth).HasColumnName(@"RTV_ADJ_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RtvAdjAcctNo).HasColumnName(@"RTV_ADJ_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("IM_ACCT_COD_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("IM_ACCT_COD_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.AcctCod }).HasDatabaseName("IM_ACCT_COD_X1");
        }
    }

}
// </auto-generated>