// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_GFT_RGSTRY_HDR
    public class PsGftRgstryHdrConfiguration : IEntityTypeConfiguration<PsGftRgstryHdr>
    {
        public void Configure(EntityTypeBuilder<PsGftRgstryHdr> builder)
        {
            builder.ToTable("PS_GFT_RGSTRY_HDR", "dbo");
            builder.HasKey(x => x.GftRgstryId).HasName("PK_PS_GFT_RGSTRY_HDR").IsClustered();

            builder.Property(x => x.GftRgstryId).HasColumnName(@"GFT_RGSTRY_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.GftRgstryCpolId).HasColumnName(@"GFT_RGSTRY_CPOL_ID").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.GftRgstryEvntTyp).HasColumnName(@"GFT_RGSTRY_EVNT_TYP").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.EventNam).HasColumnName(@"EVENT_NAM").HasColumnType("varchar(80)").IsRequired(false).IsUnicode(false).HasMaxLength(80);
            builder.Property(x => x.EventDat).HasColumnName(@"EVENT_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.ExpDat).HasColumnName(@"EXP_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.EventCity).HasColumnName(@"EVENT_CITY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.EventState).HasColumnName(@"EVENT_STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.IsEcommReg).HasColumnName(@"IS_ECOMM_REG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OrigStrId).HasColumnName(@"ORIG_STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Reg1FstNam).HasColumnName(@"REG1_FST_NAM").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Reg1LstNam).HasColumnName(@"REG1_LST_NAM").HasColumnType("varchar(25)").IsRequired().IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.Reg2FstNam).HasColumnName(@"REG2_FST_NAM").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Reg2LstNam).HasColumnName(@"REG2_LST_NAM").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.Commnt).HasColumnName(@"COMMNT").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.ShipAdrs1).HasColumnName(@"SHIP_ADRS_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipAdrs2).HasColumnName(@"SHIP_ADRS_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipCity).HasColumnName(@"SHIP_CITY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ShipState).HasColumnName(@"SHIP_STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipZipCod).HasColumnName(@"SHIP_ZIP_COD").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ShipCntry).HasColumnName(@"SHIP_CNTRY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ContctPhone).HasColumnName(@"CONTCT_PHONE").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.EcommNxtHdrPubMode).HasColumnName(@"ECOMM_NXT_HDR_PUB_MODE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommLstPubDt).HasColumnName(@"ECOMM_LST_PUB_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsGftRgstryEvntTyp).WithMany(b => b.PsGftRgstryHdrs).HasForeignKey(c => c.GftRgstryEvntTyp).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_GFT_RGSTRY_HDR_PS_GFT_RGSTRY_EVNT_TYP");
        }
    }

}
// </auto-generated>
