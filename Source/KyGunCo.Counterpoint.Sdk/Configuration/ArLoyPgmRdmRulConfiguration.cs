// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AR_LOY_PGM_RDM_RUL
    public class ArLoyPgmRdmRulConfiguration : IEntityTypeConfiguration<ArLoyPgmRdmRul>
    {
        public void Configure(EntityTypeBuilder<ArLoyPgmRdmRul> builder)
        {
            builder.ToTable("AR_LOY_PGM_RDM_RUL", "dbo");
            builder.HasKey(x => new { x.LoyPgmCod, x.RulSeqNo }).HasName("PK_AR_LOY_PGM_RDM_RUL").IsClustered();

            builder.Property(x => x.LoyPgmCod).HasColumnName(@"LOY_PGM_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.RulSeqNo).HasColumnName(@"RUL_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ItemFilt).HasColumnName(@"ITEM_FILT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.ItemFiltTmplt).HasColumnName(@"ITEM_FILT_TMPLT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.ItemFiltText).HasColumnName(@"ITEM_FILT_TEXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.SalFilt).HasColumnName(@"SAL_FILT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.SalFiltTmplt).HasColumnName(@"SAL_FILT_TMPLT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.SalFiltText).HasColumnName(@"SAL_FILT_TEXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ArLoyPgm).WithMany(b => b.ArLoyPgmRdmRuls).HasForeignKey(c => c.LoyPgmCod).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AR_LOY_PGM_RDM_RUL_AR_LOY_PGM");

            builder.HasIndex(x => new { x.DescrUpr, x.LoyPgmCod, x.RulSeqNo }).HasDatabaseName("AR_LOY_PGM_RDM_RUL_X1");
        }
    }

}
// </auto-generated>
