// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_BATCH_REL_WRK
    public class PsBatchRelWrkConfiguration : IEntityTypeConfiguration<PsBatchRelWrk>
    {
        public void Configure(EntityTypeBuilder<PsBatchRelWrk> builder)
        {
            builder.ToTable("PS_BATCH_REL_WRK", "dbo");
            builder.HasKey(x => new { x.SessId, x.OrdDocId }).HasName("PK_PS_BATCH_REL_WRK").IsClustered();

            builder.Property(x => x.SessId).HasColumnName(@"SESS_ID").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.OrdDocId).HasColumnName(@"ORD_DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.AmtToAuth).HasColumnName(@"AMT_TO_AUTH").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RelTktDocId).HasColumnName(@"REL_TKT_DOC_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.Successful).HasColumnName(@"SUCCESSFUL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();
        }
    }

}
// </auto-generated>