// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_FILL_BO_RSLT_CELL_WRK
    public class PsFillBoRsltCellWrkConfiguration : IEntityTypeConfiguration<PsFillBoRsltCellWrk>
    {
        public void Configure(EntityTypeBuilder<PsFillBoRsltCellWrk> builder)
        {
            builder.ToTable("PS_FILL_BO_RSLT_CELL_WRK", "dbo");
            builder.HasKey(x => new { x.SessId, x.DocId, x.LinSeqNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_PS_FILL_BO_RSLT_CELL_WRK").IsClustered();

            builder.Property(x => x.SessId).HasColumnName(@"SESS_ID").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.QtyFilled).HasColumnName(@"QTY_FILLED").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
