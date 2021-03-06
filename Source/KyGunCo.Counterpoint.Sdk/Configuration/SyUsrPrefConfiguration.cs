// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_USR_PREF
    public class SyUsrPrefConfiguration : IEntityTypeConfiguration<SyUsrPref>
    {
        public void Configure(EntityTypeBuilder<SyUsrPref> builder)
        {
            builder.ToTable("SY_USR_PREF", "dbo");
            builder.HasKey(x => x.UsrId).HasName("PK_SY_USR_PREF").IsClustered();

            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.HomeActn).HasColumnName(@"HOME_ACTN").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.OpnHomeActn).HasColumnName(@"OPN_HOME_ACTN").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MenuStyle).HasColumnName(@"MENU_STYLE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.BtnSize).HasColumnName(@"BTN_SIZE").HasColumnType("int").IsRequired();
            builder.Property(x => x.RoundCrnrs).HasColumnName(@"ROUND_CRNRS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.BtnFont).HasColumnName(@"BTN_FONT").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.DfltFont).HasColumnName(@"DFLT_FONT").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.FrmsOnTaskbar).HasColumnName(@"FRMS_ON_TASKBAR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowMultiFrm).HasColumnName(@"ALLOW_MULTI_FRM").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ShowSuppMsgs).HasColumnName(@"SHOW_SUPP_MSGS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CustomDd).HasColumnName(@"CUSTOM_DD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PrtBtnActn).HasColumnName(@"PRT_BTN_ACTN").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImplDecs).HasColumnName(@"IMPL_DECS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ReqColr).HasColumnName(@"REQ_COLR").HasColumnType("int").IsRequired();
            builder.Property(x => x.NegColr).HasColumnName(@"NEG_COLR").HasColumnType("int").IsRequired();
            builder.Property(x => x.UseSimpleFilt).HasColumnName(@"USE_SIMPLE_FILT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TlbrScheme).HasColumnName(@"TLBR_SCHEME").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.DfltMaintFrmView).HasColumnName(@"DFLT_MAINT_FRM_VIEW").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DfltDocMaintFrmView).HasColumnName(@"DFLT_DOC_MAINT_FRM_VIEW").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseLstFrmView).HasColumnName(@"USE_LST_FRM_VIEW").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DfltTouchScrnFont).HasColumnName(@"DFLT_TOUCH_SCRN_FONT").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.BtnTxtPos).HasColumnName(@"BTN_TXT_POS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MailNewMailFont).HasColumnName(@"MAIL_NEW_MAIL_FONT").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.MailRplyFrwMailFont).HasColumnName(@"MAIL_RPLY_FRW_MAIL_FONT").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.MailViewReadPane).HasColumnName(@"MAIL_VIEW_READ_PANE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MailNewMailSnd).HasColumnName(@"MAIL_NEW_MAIL_SND").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.MailPopupMailSnd).HasColumnName(@"MAIL_POPUP_MAIL_SND").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.SyUsr).WithOne(b => b.SyUsrPref).HasForeignKey<SyUsrPref>(c => c.UsrId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SY_USR_PREF_SY_USR");

            builder.HasIndex(x => x.RsStat).HasDatabaseName("SY_USR_PREF_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("SY_USR_PREF_X_RS_UTC_DT");
        }
    }

}
// </auto-generated>
