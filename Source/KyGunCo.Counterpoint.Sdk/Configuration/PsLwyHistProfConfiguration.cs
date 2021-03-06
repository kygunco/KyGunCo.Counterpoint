// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_LWY_HIST_PROF
    public class PsLwyHistProfConfiguration : IEntityTypeConfiguration<PsLwyHistProf>
    {
        public void Configure(EntityTypeBuilder<PsLwyHistProf> builder)
        {
            builder.ToTable("PS_LWY_HIST_PROF", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId }).HasName("PK_PS_LWY_HIST_PROF").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ProfCod1).HasColumnName(@"PROF_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod2).HasColumnName(@"PROF_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod3).HasColumnName(@"PROF_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod4).HasColumnName(@"PROF_COD_4").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod5).HasColumnName(@"PROF_COD_5").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfNo1).HasColumnName(@"PROF_NO_1").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.ProfNo2).HasColumnName(@"PROF_NO_2").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.ProfNo3).HasColumnName(@"PROF_NO_3").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.ProfNo4).HasColumnName(@"PROF_NO_4").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.ProfNo5).HasColumnName(@"PROF_NO_5").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.ProfAlpha1).HasColumnName(@"PROF_ALPHA_1").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha2).HasColumnName(@"PROF_ALPHA_2").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha3).HasColumnName(@"PROF_ALPHA_3").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha4).HasColumnName(@"PROF_ALPHA_4").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha5).HasColumnName(@"PROF_ALPHA_5").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfDat1).HasColumnName(@"PROF_DAT_1").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat2).HasColumnName(@"PROF_DAT_2").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat3).HasColumnName(@"PROF_DAT_3").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat4).HasColumnName(@"PROF_DAT_4").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat5).HasColumnName(@"PROF_DAT_5").HasColumnType("datetime").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsLwyHist).WithOne(b => b.PsLwyHistProf).HasForeignKey<PsLwyHistProf>(c => new { c.BusDat, c.DocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_LWY_HIST_PROF_PS_LWY_HIST");
        }
    }

}
// </auto-generated>
