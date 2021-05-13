// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_FILL_BO_SUPPLY_WRK
    public class PsFillBoSupplyWrkConfiguration : IEntityTypeConfiguration<PsFillBoSupplyWrk>
    {
        public void Configure(EntityTypeBuilder<PsFillBoSupplyWrk> builder)
        {
            builder.ToTable("PS_FILL_BO_SUPPLY_WRK", "dbo");
            builder.HasKey(x => new { x.SessId, x.ItemNo, x.LocId, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_PS_FILL_BO_SUPPLY_WRK").IsClustered();

            builder.Property(x => x.SessId).HasColumnName(@"SESS_ID").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.QtyOnHnd).HasColumnName(@"QTY_ON_HND").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyCommit).HasColumnName(@"QTY_COMMIT").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyAvail).HasColumnName(@"QTY_AVAIL").HasColumnType("decimal(16,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
        }
    }

}
// </auto-generated>