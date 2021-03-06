// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_ITEM_LOC_MONTHLY_HIST
    public class ViPsItemLocMonthlyHistConfiguration : IEntityTypeConfiguration<ViPsItemLocMonthlyHist>
    {
        public void Configure(EntityTypeBuilder<ViPsItemLocMonthlyHist> builder)
        {
            builder.ToView("VI_PS_ITEM_LOC_MONTHLY_HIST", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.StkLocId).HasColumnName(@"STK_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PriorMonths).HasColumnName(@"PriorMonths").HasColumnType("int").IsRequired();
            builder.Property(x => x.Mo).HasColumnName(@"mo").HasColumnType("nvarchar(40)").IsRequired(false).HasMaxLength(40);
            builder.Property(x => x.Yr).HasColumnName(@"yr").HasColumnType("nvarchar(40)").IsRequired(false).HasMaxLength(40);
            builder.Property(x => x.Returns).HasColumnName(@"Returns").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.SalesExclReturns).HasColumnName(@"Sales_excl_returns").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.Sales).HasColumnName(@"Sales").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.QtySold).HasColumnName(@"Qty_Sold").HasColumnType("decimal(38,15)").IsRequired(false);
            builder.Property(x => x.Tickets).HasColumnName(@"Tickets").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.AvgTicket).HasColumnName(@"Avg_Ticket").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PctReturns).HasColumnName(@"Pct_Returns").HasColumnType("decimal(15,2)").IsRequired(false);
        }
    }

}
// </auto-generated>
