// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_PRC_CHANGE_EVENT_HDR
    public class ImPrcChangeEventHdrConfiguration : IEntityTypeConfiguration<ImPrcChangeEventHdr>
    {
        public void Configure(EntityTypeBuilder<ImPrcChangeEventHdr> builder)
        {
            builder.ToTable("IM_PRC_CHANGE_EVENT_HDR", "dbo");
            builder.HasKey(x => x.PrcEventId).HasName("PK_IM_PRC_CHANGE_EVENT_HDR").IsClustered();

            builder.Property(x => x.PrcEventId).HasColumnName(@"PRC_EVENT_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PrcEventCod).HasColumnName(@"PRC_EVENT_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PrcEventDescr).HasColumnName(@"PRC_EVENT_DESCR").HasColumnType("varchar(80)").IsRequired().IsUnicode(false).HasMaxLength(80);
            builder.Property(x => x.EventCreatedByUsr).HasColumnName(@"EVENT_CREATED_BY_USR").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LocGrp).HasColumnName(@"LOC_GRP").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PostingErrRef).HasColumnName(@"POSTING_ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);

            builder.HasIndex(x => new { x.PrcEventCod, x.PrcEventId }).HasDatabaseName("IM_PRC_CHANGE_EVENT_HDR_X1");
            builder.HasIndex(x => new { x.PrcEventDescr, x.PrcEventId }).HasDatabaseName("IM_PRC_CHANGE_EVENT_HDR_X2");
        }
    }

}
// </auto-generated>
