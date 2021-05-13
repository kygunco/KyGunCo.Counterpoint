// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // DM_INV_LOC_ITEM_MNTH
    public class DmInvLocItemMnthConfiguration : IEntityTypeConfiguration<DmInvLocItemMnth>
    {
        public void Configure(EntityTypeBuilder<DmInvLocItemMnth> builder)
        {
            builder.ToTable("DM_INV_LOC_ITEM_MNTH", "dbo");
            builder.HasKey(x => new { x.MnthId, x.LocId, x.ItemNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_DM_INV_LOC_ITEM_MNTH").IsClustered();

            builder.Property(x => x.MnthId).HasColumnName(@"MNTH_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.BegQty).HasColumnName(@"BEG_QTY").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.BegGlVal).HasColumnName(@"BEG_GL_VAL").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.BegExtRet).HasColumnName(@"BEG_EXT_RET").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.QtyDelta).HasColumnName(@"QTY_DELTA").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.GlValDelta).HasColumnName(@"GL_VAL_DELTA").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ExtRetDelta).HasColumnName(@"EXT_RET_DELTA").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.DmLocHist).WithMany(b => b.DmInvLocItemMnths).HasForeignKey(c => c.LocId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_DM_INV_LOC_ITEM_MNTH_DM_LOC_HIST");

            builder.HasIndex(x => new { x.LocId, x.MnthId, x.ItemNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasDatabaseName("DM_INV_LOC_ITEM_MNTH_X1");
            builder.HasIndex(x => new { x.LocId, x.ItemNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr, x.MnthId }).HasDatabaseName("DM_INV_LOC_ITEM_MNTH_X2");
            builder.HasIndex(x => new { x.MnthId, x.ItemNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasDatabaseName("DM_INV_LOC_ITEM_MNTH_X3");
        }
    }

}
// </auto-generated>