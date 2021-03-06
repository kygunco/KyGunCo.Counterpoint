// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_KIT_COMP
    public class ImKitCompConfiguration : IEntityTypeConfiguration<ImKitComp>
    {
        public void Configure(EntityTypeBuilder<ImKitComp> builder)
        {
            builder.ToTable("IM_KIT_COMP", "dbo");
            builder.HasKey(x => new { x.ItemNo, x.CompSeqNo }).HasName("PK_IM_KIT_COMP").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.CompSeqNo).HasColumnName(@"COMP_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.CompItemNo).HasColumnName(@"COMP_ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.CompDim1Upr).HasColumnName(@"COMP_DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CompDim2Upr).HasColumnName(@"COMP_DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CompDim3Upr).HasColumnName(@"COMP_DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CompCellDescr).HasColumnName(@"COMP_CELL_DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.CompQty).HasColumnName(@"COMP_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CompQtyUnitFlg).HasColumnName(@"COMP_QTY_UNIT_FLG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CompQtyMeth).HasColumnName(@"COMP_QTY_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.CompPrompt).HasColumnName(@"COMP_PROMPT").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.SubsTyp).HasColumnName(@"SUBS_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PrcAdjTyp).HasColumnName(@"PRC_ADJ_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AdjPrcLvl).HasColumnName(@"ADJ_PRC_LVL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PromptForCell).HasColumnName(@"PROMPT_FOR_CELL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RequiredComp).HasColumnName(@"REQUIRED_COMP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImKitPar).WithMany(b => b.ImKitComps).HasForeignKey(c => c.ItemNo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_KIT_COMP_IM_KIT_PAR");
        }
    }

}
// </auto-generated>
