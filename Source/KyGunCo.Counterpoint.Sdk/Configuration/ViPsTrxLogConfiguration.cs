// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_TRX_LOG
    public class ViPsTrxLogConfiguration : IEntityTypeConfiguration<ViPsTrxLog>
    {
        public void Configure(EntityTypeBuilder<ViPsTrxLog> builder)
        {
            builder.ToView("VI_PS_TRX_LOG", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.LogId).HasColumnName(@"LOG_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DrwId).HasColumnName(@"DRW_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.ActivDt).HasColumnName(@"ACTIV_DT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OvrdUsrId).HasColumnName(@"OVRD_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ActivTyp).HasColumnName(@"ACTIV_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SysFuncTyp).HasColumnName(@"SYS_FUNC_TYP").HasColumnType("varchar(2)").IsRequired(false).IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.PsSecTyp).HasColumnName(@"PS_SEC_TYP").HasColumnType("varchar(2)").IsRequired(false).IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.LinId).HasColumnName(@"LIN_ID").HasColumnType("uniqueidentifier").IsRequired(false);
            builder.Property(x => x.Value1).HasColumnName(@"VALUE_1").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Value2).HasColumnName(@"VALUE_2").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Processed).HasColumnName(@"PROCESSED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
        }
    }

}
// </auto-generated>
