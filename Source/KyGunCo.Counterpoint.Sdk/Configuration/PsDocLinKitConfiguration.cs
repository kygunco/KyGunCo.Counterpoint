// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_DOC_LIN_KIT
    public class PsDocLinKitConfiguration : IEntityTypeConfiguration<PsDocLinKit>
    {
        public void Configure(EntityTypeBuilder<PsDocLinKit> builder)
        {
            builder.ToTable("PS_DOC_LIN_KIT", "dbo");
            builder.HasKey(x => new { x.DocId, x.LinSeqNo }).HasName("PK_PS_DOC_LIN_KIT").IsClustered();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.KitCompQty).HasColumnName(@"KIT_COMP_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.KitCompQtyUnitFlg).HasColumnName(@"KIT_COMP_QTY_UNIT_FLG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.KitCompUpcharge).HasColumnName(@"KIT_COMP_UPCHARGE").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.KitCompItemNo).HasColumnName(@"KIT_COMP_ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.KitCompDim1Upr).HasColumnName(@"KIT_COMP_DIM_1_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.KitCompDim2Upr).HasColumnName(@"KIT_COMP_DIM_2_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.KitCompDim3Upr).HasColumnName(@"KIT_COMP_DIM_3_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.KitSubsTyp).HasColumnName(@"KIT_SUBS_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.KitPrcAdjTyp).HasColumnName(@"KIT_PRC_ADJ_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.KitAdjPrcLvl).HasColumnName(@"KIT_ADJ_PRC_LVL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RequiredComp).HasColumnName(@"REQUIRED_COMP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.PsDocLin).WithOne(b => b.PsDocLinKit).HasForeignKey<PsDocLinKit>(c => new { c.DocId, c.LinSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_DOC_LIN_KIT_PS_DOC_LIN");
        }
    }

}
// </auto-generated>
