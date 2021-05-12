// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_CALNDR
    public class SyCalndrConfiguration : IEntityTypeConfiguration<SyCalndr>
    {
        public void Configure(EntityTypeBuilder<SyCalndr> builder)
        {
            builder.ToTable("SY_CALNDR", "dbo");
            builder.HasKey(x => x.CalndrId).HasName("PK_SY_CALNDR").IsClustered();

            builder.Property(x => x.CalndrId).HasColumnName(@"CALNDR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.BegDat).HasColumnName(@"BEG_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.EndDat).HasColumnName(@"END_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.NxtCalndrId).HasColumnName(@"NXT_CALNDR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstCalndrId).HasColumnName(@"LST_CALNDR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Seas1).HasColumnName(@"SEAS_1").HasColumnType("varchar(5)").IsRequired().IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas1EndDat).HasColumnName(@"SEAS_1_END_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Seas2).HasColumnName(@"SEAS_2").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas2EndDat).HasColumnName(@"SEAS_2_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Seas3).HasColumnName(@"SEAS_3").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas3EndDat).HasColumnName(@"SEAS_3_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Seas4).HasColumnName(@"SEAS_4").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas4EndDat).HasColumnName(@"SEAS_4_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Seas5).HasColumnName(@"SEAS_5").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas5EndDat).HasColumnName(@"SEAS_5_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Seas6).HasColumnName(@"SEAS_6").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas6EndDat).HasColumnName(@"SEAS_6_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon1).HasColumnName(@"MON_1").HasColumnType("varchar(5)").IsRequired().IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon1EndDat).HasColumnName(@"MON_1_END_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Mon2).HasColumnName(@"MON_2").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon2EndDat).HasColumnName(@"MON_2_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon3).HasColumnName(@"MON_3").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon3EndDat).HasColumnName(@"MON_3_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon4).HasColumnName(@"MON_4").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon4EndDat).HasColumnName(@"MON_4_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon5).HasColumnName(@"MON_5").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon5EndDat).HasColumnName(@"MON_5_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon6).HasColumnName(@"MON_6").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon6EndDat).HasColumnName(@"MON_6_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon7).HasColumnName(@"MON_7").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon7EndDat).HasColumnName(@"MON_7_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon8).HasColumnName(@"MON_8").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon8EndDat).HasColumnName(@"MON_8_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon9).HasColumnName(@"MON_9").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon9EndDat).HasColumnName(@"MON_9_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon10).HasColumnName(@"MON_10").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon10EndDat).HasColumnName(@"MON_10_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon11).HasColumnName(@"MON_11").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon11EndDat).HasColumnName(@"MON_11_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon12).HasColumnName(@"MON_12").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon12EndDat).HasColumnName(@"MON_12_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon13).HasColumnName(@"MON_13").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon13EndDat).HasColumnName(@"MON_13_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Mon14).HasColumnName(@"MON_14").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Mon14EndDat).HasColumnName(@"MON_14_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week1).HasColumnName(@"WEEK_1").HasColumnType("varchar(5)").IsRequired().IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week1EndDat).HasColumnName(@"WEEK_1_END_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Week2).HasColumnName(@"WEEK_2").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week2EndDat).HasColumnName(@"WEEK_2_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week3).HasColumnName(@"WEEK_3").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week3EndDat).HasColumnName(@"WEEK_3_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week4).HasColumnName(@"WEEK_4").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week4EndDat).HasColumnName(@"WEEK_4_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week5).HasColumnName(@"WEEK_5").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week5EndDat).HasColumnName(@"WEEK_5_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week6).HasColumnName(@"WEEK_6").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week6EndDat).HasColumnName(@"WEEK_6_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week7).HasColumnName(@"WEEK_7").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week7EndDat).HasColumnName(@"WEEK_7_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week8).HasColumnName(@"WEEK_8").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week8EndDat).HasColumnName(@"WEEK_8_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week9).HasColumnName(@"WEEK_9").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week9EndDat).HasColumnName(@"WEEK_9_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week10).HasColumnName(@"WEEK_10").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week10EndDat).HasColumnName(@"WEEK_10_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week11).HasColumnName(@"WEEK_11").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week11EndDat).HasColumnName(@"WEEK_11_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week12).HasColumnName(@"WEEK_12").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week12EndDat).HasColumnName(@"WEEK_12_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week13).HasColumnName(@"WEEK_13").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week13EndDat).HasColumnName(@"WEEK_13_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week14).HasColumnName(@"WEEK_14").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week14EndDat).HasColumnName(@"WEEK_14_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week15).HasColumnName(@"WEEK_15").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week15EndDat).HasColumnName(@"WEEK_15_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week16).HasColumnName(@"WEEK_16").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week16EndDat).HasColumnName(@"WEEK_16_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week17).HasColumnName(@"WEEK_17").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week17EndDat).HasColumnName(@"WEEK_17_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week18).HasColumnName(@"WEEK_18").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week18EndDat).HasColumnName(@"WEEK_18_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week19).HasColumnName(@"WEEK_19").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week19EndDat).HasColumnName(@"WEEK_19_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week20).HasColumnName(@"WEEK_20").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week20EndDat).HasColumnName(@"WEEK_20_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week21).HasColumnName(@"WEEK_21").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week21EndDat).HasColumnName(@"WEEK_21_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week22).HasColumnName(@"WEEK_22").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week22EndDat).HasColumnName(@"WEEK_22_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week23).HasColumnName(@"WEEK_23").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week23EndDat).HasColumnName(@"WEEK_23_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week24).HasColumnName(@"WEEK_24").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week24EndDat).HasColumnName(@"WEEK_24_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week25).HasColumnName(@"WEEK_25").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week25EndDat).HasColumnName(@"WEEK_25_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week26).HasColumnName(@"WEEK_26").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week26EndDat).HasColumnName(@"WEEK_26_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week27).HasColumnName(@"WEEK_27").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week27EndDat).HasColumnName(@"WEEK_27_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week28).HasColumnName(@"WEEK_28").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week28EndDat).HasColumnName(@"WEEK_28_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week29).HasColumnName(@"WEEK_29").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week29EndDat).HasColumnName(@"WEEK_29_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week30).HasColumnName(@"WEEK_30").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week30EndDat).HasColumnName(@"WEEK_30_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week31).HasColumnName(@"WEEK_31").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week31EndDat).HasColumnName(@"WEEK_31_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week32).HasColumnName(@"WEEK_32").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week32EndDat).HasColumnName(@"WEEK_32_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week33).HasColumnName(@"WEEK_33").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week33EndDat).HasColumnName(@"WEEK_33_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week34).HasColumnName(@"WEEK_34").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week34EndDat).HasColumnName(@"WEEK_34_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week35).HasColumnName(@"WEEK_35").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week35EndDat).HasColumnName(@"WEEK_35_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week36).HasColumnName(@"WEEK_36").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week36EndDat).HasColumnName(@"WEEK_36_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week37).HasColumnName(@"WEEK_37").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week37EndDat).HasColumnName(@"WEEK_37_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week38).HasColumnName(@"WEEK_38").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week38EndDat).HasColumnName(@"WEEK_38_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week39).HasColumnName(@"WEEK_39").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week39EndDat).HasColumnName(@"WEEK_39_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week40).HasColumnName(@"WEEK_40").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week40EndDat).HasColumnName(@"WEEK_40_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week41).HasColumnName(@"WEEK_41").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week41EndDat).HasColumnName(@"WEEK_41_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week42).HasColumnName(@"WEEK_42").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week42EndDat).HasColumnName(@"WEEK_42_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week43).HasColumnName(@"WEEK_43").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week43EndDat).HasColumnName(@"WEEK_43_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week44).HasColumnName(@"WEEK_44").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week44EndDat).HasColumnName(@"WEEK_44_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week45).HasColumnName(@"WEEK_45").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week45EndDat).HasColumnName(@"WEEK_45_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week46).HasColumnName(@"WEEK_46").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week46EndDat).HasColumnName(@"WEEK_46_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week47).HasColumnName(@"WEEK_47").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week47EndDat).HasColumnName(@"WEEK_47_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week48).HasColumnName(@"WEEK_48").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week48EndDat).HasColumnName(@"WEEK_48_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week49).HasColumnName(@"WEEK_49").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week49EndDat).HasColumnName(@"WEEK_49_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week50).HasColumnName(@"WEEK_50").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week50EndDat).HasColumnName(@"WEEK_50_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week51).HasColumnName(@"WEEK_51").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week51EndDat).HasColumnName(@"WEEK_51_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week52).HasColumnName(@"WEEK_52").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week52EndDat).HasColumnName(@"WEEK_52_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week53).HasColumnName(@"WEEK_53").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week53EndDat).HasColumnName(@"WEEK_53_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Week54).HasColumnName(@"WEEK_54").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Week54EndDat).HasColumnName(@"WEEK_54_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Seas7).HasColumnName(@"SEAS_7").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas7EndDat).HasColumnName(@"SEAS_7_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Seas8).HasColumnName(@"SEAS_8").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas8EndDat).HasColumnName(@"SEAS_8_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Seas9).HasColumnName(@"SEAS_9").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas9EndDat).HasColumnName(@"SEAS_9_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Seas10).HasColumnName(@"SEAS_10").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas10EndDat).HasColumnName(@"SEAS_10_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Seas11).HasColumnName(@"SEAS_11").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas11EndDat).HasColumnName(@"SEAS_11_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Seas12).HasColumnName(@"SEAS_12").HasColumnType("varchar(5)").IsRequired(false).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Seas12EndDat).HasColumnName(@"SEAS_12_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("SY_CALNDR_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("SY_CALNDR_X_RS_UTC_DT");
        }
    }

}
// </auto-generated>
