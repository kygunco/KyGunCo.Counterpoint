// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_DM_LIVE_FEED_LIN
    public class ViDmLiveFeedLinConfiguration : IEntityTypeConfiguration<ViDmLiveFeedLin>
    {
        public void Configure(EntityTypeBuilder<ViDmLiveFeedLin> builder)
        {
            builder.ToView("VI_DM_LIVE_FEED_LIN", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.Stat).HasColumnName(@"STAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.TktDt).HasColumnName(@"TKT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.QtySoldStkUnit).HasColumnName(@"QTY_SOLD_STK_UNIT").HasColumnType("decimal(38,15)").IsRequired(false);
            builder.Property(x => x.ExtCost).HasColumnName(@"EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ExtPrc).HasColumnName(@"EXT_PRC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CalcExtPrc).HasColumnName(@"CALC_EXT_PRC").HasColumnType("decimal(15,2)").IsRequired(false);
        }
    }

}
// </auto-generated>
