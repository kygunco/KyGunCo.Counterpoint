// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_PRC_WRK_CELL
    public class ImPrcWrkCellConfiguration : IEntityTypeConfiguration<ImPrcWrkCell>
    {
        public void Configure(EntityTypeBuilder<ImPrcWrkCell> builder)
        {
            builder.ToTable("IM_PRC_WRK_CELL", "dbo");
            builder.HasKey(x => new { x.SessId, x.LinSessId, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_IM_PRC_WRK_CELL").IsClustered();

            builder.Property(x => x.SessId).HasColumnName(@"SESS_ID").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSessId).HasColumnName(@"LIN_SESS_ID").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.OrigQty).HasColumnName(@"ORIG_QTY").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.RegPrc).HasColumnName(@"REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc1).HasColumnName(@"PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc2).HasColumnName(@"PRC_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc3).HasColumnName(@"PRC_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc4).HasColumnName(@"PRC_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc5).HasColumnName(@"PRC_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc6).HasColumnName(@"PRC_6").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.UnitRetlVal).HasColumnName(@"UNIT_RETL_VAL").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc1Typ).HasColumnName(@"PRC_1_TYP").HasColumnType("varchar(3)").IsRequired().IsUnicode(false).HasMaxLength(3);
        }
    }

}
// </auto-generated>