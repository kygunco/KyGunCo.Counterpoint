// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_GFT_RGSTRY_HIST_ANL
    public class ViPsGftRgstryHistAnlConfiguration : IEntityTypeConfiguration<ViPsGftRgstryHistAnl>
    {
        public void Configure(EntityTypeBuilder<ViPsGftRgstryHistAnl> builder)
        {
            builder.ToView("VI_PS_GFT_RGSTRY_HIST_ANL", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.CategCod).HasColumnName(@"CATEG_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SubcatCod).HasColumnName(@"SUBCAT_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.MiscExtPrc).HasColumnName(@"MISC_EXT_PRC").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.MiscExtPrcPct).HasColumnName(@"MISC_EXT_PRC_PCT").HasColumnType("decimal(38,6)").IsRequired(false);
            builder.Property(x => x.GftExtPrc).HasColumnName(@"GFT_EXT_PRC").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.GftExtPrcPct).HasColumnName(@"GFT_EXT_PRC_PCT").HasColumnType("decimal(38,6)").IsRequired(false);
        }
    }

}
// </auto-generated>
