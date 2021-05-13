// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_DOC_STAT
    public class PsOrdHistDocStatConfiguration : IEntityTypeConfiguration<PsOrdHistDocStat>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistDocStat> builder)
        {
            builder.ToTable("PS_ORD_HIST_DOC_STAT", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId }).HasName("PK_PS_ORD_HIST_DOC_STAT").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LstDocActiv).HasColumnName(@"LST_DOC_ACTIV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DocAsTktSeqNo).HasColumnName(@"DOC_AS_TKT_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.DocStat).HasColumnName(@"DOC_STAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstCancelDepRefunded).HasColumnName(@"LST_CANCEL_DEP_REFUNDED").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.LstCancelDepForfeit).HasColumnName(@"LST_CANCEL_DEP_FORFEIT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotDepReceived).HasColumnName(@"TOT_DEP_RECEIVED").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotDepApplied).HasColumnName(@"TOT_DEP_APPLIED").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotDepRefunded).HasColumnName(@"TOT_DEP_REFUNDED").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotDepForfeit).HasColumnName(@"TOT_DEP_FORFEIT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.LstDocEditDt).HasColumnName(@"LST_DOC_EDIT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocEditUsrId).HasColumnName(@"LST_DOC_EDIT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstDocPrtDt).HasColumnName(@"LST_DOC_PRT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocPrtUsrId).HasColumnName(@"LST_DOC_PRT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstDocPickDt).HasColumnName(@"LST_DOC_PICK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocPickUsrId).HasColumnName(@"LST_DOC_PICK_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstDocRelDt).HasColumnName(@"LST_DOC_REL_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocRelUsrId).HasColumnName(@"LST_DOC_REL_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstDocInvcdDt).HasColumnName(@"LST_DOC_INVCD_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocInvcdUsrId).HasColumnName(@"LST_DOC_INVCD_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstDocPckvrfdDt).HasColumnName(@"LST_DOC_PCKVRFD_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocPckvrfdUsrId).HasColumnName(@"LST_DOC_PCKVRFD_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.IsSuspended).HasColumnName(@"IS_SUSPENDED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstDocSuspendedDt).HasColumnName(@"LST_DOC_SUSPENDED_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocSuspendedUsrId).HasColumnName(@"LST_DOC_SUSPENDED_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PreqWrkgrpId).HasColumnName(@"PREQ_WRKGRP_ID").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);

            // Foreign keys
            builder.HasOne(a => a.PsOrdHist).WithOne(b => b.PsOrdHistDocStat).HasForeignKey<PsOrdHistDocStat>(c => new { c.BusDat, c.DocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_DOC_STAT_PS_ORD_HIST");
        }
    }

}
// </auto-generated>