// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_PRC
    public class ImPrcConfiguration : IEntityTypeConfiguration<ImPrc>
    {
        public void Configure(EntityTypeBuilder<ImPrc> builder)
        {
            builder.ToTable("IM_PRC", "dbo");
            builder.HasKey(x => new { x.ItemNo, x.LocId, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_IM_PRC").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.RegPrc).HasColumnName(@"REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc1).HasColumnName(@"PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc2).HasColumnName(@"PRC_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc3).HasColumnName(@"PRC_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc4).HasColumnName(@"PRC_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc5).HasColumnName(@"PRC_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prc6).HasColumnName(@"PRC_6").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt1RegPrc).HasColumnName(@"ALT_1_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt1Prc1).HasColumnName(@"ALT_1_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt1Prc2).HasColumnName(@"ALT_1_PRC_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt1Prc3).HasColumnName(@"ALT_1_PRC_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt1Prc4).HasColumnName(@"ALT_1_PRC_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt1Prc5).HasColumnName(@"ALT_1_PRC_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt1Prc6).HasColumnName(@"ALT_1_PRC_6").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2RegPrc).HasColumnName(@"ALT_2_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2Prc1).HasColumnName(@"ALT_2_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2Prc2).HasColumnName(@"ALT_2_PRC_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2Prc3).HasColumnName(@"ALT_2_PRC_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2Prc4).HasColumnName(@"ALT_2_PRC_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2Prc5).HasColumnName(@"ALT_2_PRC_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2Prc6).HasColumnName(@"ALT_2_PRC_6").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3RegPrc).HasColumnName(@"ALT_3_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3Prc1).HasColumnName(@"ALT_3_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3Prc2).HasColumnName(@"ALT_3_PRC_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3Prc3).HasColumnName(@"ALT_3_PRC_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3Prc4).HasColumnName(@"ALT_3_PRC_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3Prc5).HasColumnName(@"ALT_3_PRC_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3Prc6).HasColumnName(@"ALT_3_PRC_6").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4RegPrc).HasColumnName(@"ALT_4_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4Prc1).HasColumnName(@"ALT_4_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4Prc2).HasColumnName(@"ALT_4_PRC_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4Prc3).HasColumnName(@"ALT_4_PRC_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4Prc4).HasColumnName(@"ALT_4_PRC_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4Prc5).HasColumnName(@"ALT_4_PRC_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4Prc6).HasColumnName(@"ALT_4_PRC_6").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5RegPrc).HasColumnName(@"ALT_5_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5Prc1).HasColumnName(@"ALT_5_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5Prc2).HasColumnName(@"ALT_5_PRC_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5Prc3).HasColumnName(@"ALT_5_PRC_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5Prc4).HasColumnName(@"ALT_5_PRC_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5Prc5).HasColumnName(@"ALT_5_PRC_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5Prc6).HasColumnName(@"ALT_5_PRC_6").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.ImItem).WithMany(b => b.ImPrcs).HasForeignKey(c => c.ItemNo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_PRC_IM_ITEM");

            builder.HasIndex(x => new { x.LocId, x.ItemNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasDatabaseName("IM_PRC_X1");
            builder.HasIndex(x => x.LocId).HasDatabaseName("USER_IDX_ITEMS_VIEW");
            builder.HasIndex(x => new { x.LocId, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasDatabaseName("USER_IX_IM_PRC_LOC_ID_DIM_1_UPR_DIM_2_UPR_DIM_3_UPR");
        }
    }

}
// </auto-generated>
