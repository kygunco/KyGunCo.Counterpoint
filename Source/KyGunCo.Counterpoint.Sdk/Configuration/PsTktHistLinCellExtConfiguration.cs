// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_TKT_HIST_LIN_CELL_EXT
    public class PsTktHistLinCellExtConfiguration : IEntityTypeConfiguration<PsTktHistLinCellExt>
    {
        public void Configure(EntityTypeBuilder<PsTktHistLinCellExt> builder)
        {
            builder.ToTable("PS_TKT_HIST_LIN_CELL_EXT", "dbo");
            builder.HasKey(x => new { x.BusDatExt, x.DocIdExt, x.LinSeqNoExt, x.Dim1UprExt, x.Dim2UprExt, x.Dim3UprExt }).HasName("PK_PS_TKT_HIST_LIN_CELL_EXT").IsClustered();

            builder.Property(x => x.BusDatExt).HasColumnName(@"BUS_DAT_EXT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocIdExt).HasColumnName(@"DOC_ID_EXT").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNoExt).HasColumnName(@"LIN_SEQ_NO_EXT").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Dim1UprExt).HasColumnName(@"DIM_1_UPR_EXT").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2UprExt).HasColumnName(@"DIM_2_UPR_EXT").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3UprExt).HasColumnName(@"DIM_3_UPR_EXT").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();

            // Foreign keys
            builder.HasOne(a => a.PsTktHistLinCell).WithOne(b => b.PsTktHistLinCellExt).HasForeignKey<PsTktHistLinCellExt>(c => new { c.BusDatExt, c.DocIdExt, c.LinSeqNoExt, c.Dim1UprExt, c.Dim2UprExt, c.Dim3UprExt }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("PS_TKT_HIST_LIN_CELL_EXT_PS_TKT_HIST_LIN_CELL");
        }
    }

}
// </auto-generated>
