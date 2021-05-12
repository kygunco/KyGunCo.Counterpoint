// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_AUDIT_LOG_TOT
    public class PsOrdHistAuditLogTotConfiguration : IEntityTypeConfiguration<PsOrdHistAuditLogTot>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistAuditLogTot> builder)
        {
            builder.ToTable("PS_ORD_HIST_AUDIT_LOG_TOT", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.LogSeqNo, x.TotTyp }).HasName("PK_PS_ORD_HIST_AUDIT_LOG_TOT").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LogSeqNo).HasColumnName(@"LOG_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.TotTyp).HasColumnName(@"TOT_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedNever();
            builder.Property(x => x.Lins).HasColumnName(@"LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SubTot).HasColumnName(@"SUB_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotMisc).HasColumnName(@"TOT_MISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotGfcAmt).HasColumnName(@"TOT_GFC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotSvcAmt).HasColumnName(@"TOT_SVC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.NormTaxAmt).HasColumnName(@"NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TaxAmt).HasColumnName(@"TAX_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotExtCost).HasColumnName(@"TOT_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotTnd).HasColumnName(@"TOT_TND").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotChng).HasColumnName(@"TOT_CHNG").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AmtDue).HasColumnName(@"AMT_DUE").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.Tot).HasColumnName(@"TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.DepNetChange).HasColumnName(@"DEP_NET_CHANGE").HasColumnType("decimal(15,2)").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsOrdHistAuditLog).WithMany(b => b.PsOrdHistAuditLogTots).HasForeignKey(c => new { c.BusDat, c.DocId, c.LogSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_AUDIT_LOG_TOT_PS_ORD_HIST_AUDIT_LOG");
        }
    }

}
// </auto-generated>
