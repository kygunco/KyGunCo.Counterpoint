// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AR_FCH_TRX
    public class ArFchTrxConfiguration : IEntityTypeConfiguration<ArFchTrx>
    {
        public void Configure(EntityTypeBuilder<ArFchTrx> builder)
        {
            builder.ToTable("AR_FCH_TRX", "dbo");
            builder.HasKey(x => new { x.BatId, x.CustNo, x.DocNo }).HasName("PK_AR_FCH_TRX").IsClustered();

            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.DocDat).HasColumnName(@"DOC_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.EntrySeqNo).HasColumnName(@"ENTRY_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.CalcFchCod).HasColumnName(@"CALC_FCH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CalcCutoffDat).HasColumnName(@"CALC_CUTOFF_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.CalcAmtPastDue).HasColumnName(@"CALC_AMT_PAST_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CalcFchAmt).HasColumnName(@"CALC_FCH_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CalcBy).HasColumnName(@"CALC_BY").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CalcDt).HasColumnName(@"CALC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.LstEditDt).HasColumnName(@"LST_EDIT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstEditUsrId).HasColumnName(@"LST_EDIT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.EditCommnt).HasColumnName(@"EDIT_COMMNT").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ErrRef).HasColumnName(@"ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.ArCust).WithMany(b => b.ArFchTrxes).HasForeignKey(c => c.CustNo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AR_FCH_TRX_AR_CUST");

            builder.HasIndex(x => new { x.BatId, x.EntrySeqNo, x.CustNo, x.DocNo }).HasDatabaseName("AR_FCH_TRX_X1");
        }
    }

}
// </auto-generated>