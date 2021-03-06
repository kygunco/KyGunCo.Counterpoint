// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_RECVR_HIST_LIN_MSD
    public class PoRecvrHistLinMsdConfiguration : IEntityTypeConfiguration<PoRecvrHistLinMsd>
    {
        public void Configure(EntityTypeBuilder<PoRecvrHistLinMsd> builder)
        {
            builder.ToTable("PO_RECVR_HIST_LIN_MSD", "dbo");
            builder.HasKey(x => new { x.SiteId, x.RecvrNo, x.SeqNo }).HasName("PK_PO_RECVR_HIST_LIN_MSD").IsClustered();

            builder.Property(x => x.SiteId).HasColumnName(@"SITE_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.RecvrNo).HasColumnName(@"RECVR_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.AdjLinMiscChrg1).HasColumnName(@"ADJ_LIN_MISC_CHRG_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjLinMiscChrg2).HasColumnName(@"ADJ_LIN_MISC_CHRG_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjLinMiscChrg3).HasColumnName(@"ADJ_LIN_MISC_CHRG_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjLinMiscChrg4).HasColumnName(@"ADJ_LIN_MISC_CHRG_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjLinMiscChrg5).HasColumnName(@"ADJ_LIN_MISC_CHRG_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjTotLinMiscChrg).HasColumnName(@"ADJ_TOT_LIN_MISC_CHRG").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjCost).HasColumnName(@"ADJ_COST").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.AdjExtCost).HasColumnName(@"ADJ_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjRecvdCost).HasColumnName(@"ADJ_RECVD_COST").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.AdjRecvdExtCost).HasColumnName(@"ADJ_RECVD_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjTotCostCorr).HasColumnName(@"ADJ_TOT_COST_CORR").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjNormTaxAmtAllocHome).HasColumnName(@"ADJ_NORM_TAX_AMT_ALLOC_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjTaxAmtAllocHome).HasColumnName(@"ADJ_TAX_AMT_ALLOC_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
        }
    }

}
// </auto-generated>
