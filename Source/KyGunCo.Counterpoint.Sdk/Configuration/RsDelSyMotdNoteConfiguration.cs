// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // RS_DEL_SY_MOTD_NOTE
    public class RsDelSyMotdNoteConfiguration : IEntityTypeConfiguration<RsDelSyMotdNote>
    {
        public void Configure(EntityTypeBuilder<RsDelSyMotdNote> builder)
        {
            builder.ToTable("RS_DEL_SY_MOTD_NOTE", "dbo");
            builder.HasKey(x => x.DelId).HasName("PK_RS_DEL_SY_MOTD_NOTE").IsClustered();

            builder.Property(x => x.DelId).HasColumnName(@"DEL_ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.DeleteDt).HasColumnName(@"DELETE_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.BegDat).HasColumnName(@"BEG_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.BegTim).HasColumnName(@"BEG_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EndDat).HasColumnName(@"END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EndTim).HasColumnName(@"END_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ToUsrId).HasColumnName(@"TO_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>