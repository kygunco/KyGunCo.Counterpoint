// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AI_DIST
    public class AiDistConfiguration : IEntityTypeConfiguration<AiDist>
    {
        public void Configure(EntityTypeBuilder<AiDist> builder)
        {
            builder.ToTable("AI_DIST", "dbo");
            builder.HasKey(x => new { x.BatId, x.SeqNo }).HasName("PK_AI_DIST").IsClustered();

            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DistGrp).HasColumnName(@"DIST_GRP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DistTyp).HasColumnName(@"DIST_TYP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AcctNo).HasColumnName(@"ACCT_NO").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.DistDat).HasColumnName(@"DIST_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PkgId).HasColumnName(@"PKG_ID").HasColumnType("varchar(2)").IsRequired(false).IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.ActTyp).HasColumnName(@"ACT_TYP").HasColumnType("varchar(3)").IsRequired(false).IsUnicode(false).HasMaxLength(3);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.FstDocNo).HasColumnName(@"FST_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.FstRef).HasColumnName(@"FST_REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.CpAcctNo).HasColumnName(@"CP_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
        }
    }

}
// </auto-generated>
