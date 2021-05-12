// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_DOC_LIN_DISC
    public class ViPsDocLinDiscConfiguration : IEntityTypeConfiguration<ViPsDocLinDisc>
    {
        public void Configure(EntityTypeBuilder<ViPsDocLinDisc> builder)
        {
            builder.ToView("VI_PS_DOC_LIN_DISC", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DiscSeqNo).HasColumnName(@"DISC_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.DiscId).HasColumnName(@"DISC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.DiscCod).HasColumnName(@"DISC_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DiscDescr).HasColumnName(@"DISC_DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ApplyTo).HasColumnName(@"APPLY_TO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DiscTyp).HasColumnName(@"DISC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DiscAmt).HasColumnName(@"DISC_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.DiscPct).HasColumnName(@"DISC_PCT").HasColumnType("decimal(9,3)").IsRequired();
            builder.Property(x => x.DiscAmtShipped).HasColumnName(@"DISC_AMT_SHIPPED").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.MinDiscntblAmt).HasColumnName(@"MIN_DISCNTBL_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
        }
    }

}
// </auto-generated>
