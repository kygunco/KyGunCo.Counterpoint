// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_PLAN_PROMO_RUL
    public class ImPlanPromoRulConfiguration : IEntityTypeConfiguration<ImPlanPromoRul>
    {
        public void Configure(EntityTypeBuilder<ImPlanPromoRul> builder)
        {
            builder.ToTable("IM_PLAN_PROMO_RUL", "dbo");
            builder.HasKey(x => new { x.GrpCod, x.SeqNo }).HasName("PK_IM_PLAN_PROMO_RUL").IsClustered();

            builder.Property(x => x.GrpCod).HasColumnName(@"GRP_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.PromoPrc).HasColumnName(@"PROMO_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImPlanPromoGrp).WithMany(b => b.ImPlanPromoRuls).HasForeignKey(c => c.GrpCod).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_PLAN_PROMO_RUL_IM_PLAN_PROMO_GRP");

            builder.HasIndex(x => new { x.GrpCod, x.ItemNo, x.SeqNo }).HasDatabaseName("IM_PLAN_PROMO_RUL_X1");
        }
    }

}
// </auto-generated>
