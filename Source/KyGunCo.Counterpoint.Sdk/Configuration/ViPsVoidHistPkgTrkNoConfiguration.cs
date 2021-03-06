// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_VOID_HIST_PKG_TRK_NO
    public class ViPsVoidHistPkgTrkNoConfiguration : IEntityTypeConfiguration<ViPsVoidHistPkgTrkNo>
    {
        public void Configure(EntityTypeBuilder<ViPsVoidHistPkgTrkNo> builder)
        {
            builder.ToView("VI_PS_VOID_HIST_PKG_TRK_NO", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.PkgTrkSeqNo).HasColumnName(@"PKG_TRK_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PkgTrkNo).HasColumnName(@"PKG_TRK_NO").HasColumnType("varchar(25)").IsRequired().IsUnicode(false).HasMaxLength(25);
        }
    }

}
// </auto-generated>
