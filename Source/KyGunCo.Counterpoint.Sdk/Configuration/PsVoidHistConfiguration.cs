// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_VOID_HIST
    public class PsVoidHistConfiguration : IEntityTypeConfiguration<PsVoidHist>
    {
        public void Configure(EntityTypeBuilder<PsVoidHist> builder)
        {
            builder.ToTable("PS_VOID_HIST", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId }).HasName("PK_PS_VOID_HIST").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DocGuid).HasColumnName(@"DOC_GUID").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.TktDt).HasColumnName(@"TKT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.TktTyp).HasColumnName(@"TKT_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DrwId).HasColumnName(@"DRW_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DrwSessionId).HasColumnName(@"DRW_SESSION_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SlsRep).HasColumnName(@"SLS_REP").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StkLocId).HasColumnName(@"STK_LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PrcLocId).HasColumnName(@"PRC_LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PftCtr).HasColumnName(@"PFT_CTR").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BillToContactId).HasColumnName(@"BILL_TO_CONTACT_ID").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.ShipToContactId).HasColumnName(@"SHIP_TO_CONTACT_ID").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.LoyPgmCod).HasColumnName(@"LOY_PGM_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TermsCod).HasColumnName(@"TERMS_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipViaCod).HasColumnName(@"SHIP_VIA_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipZoneCod).HasColumnName(@"SHIP_ZONE_COD").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ShipDat).HasColumnName(@"SHIP_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.NormTaxCod).HasColumnName(@"NORM_TAX_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCod).HasColumnName(@"TAX_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxExemptNo).HasColumnName(@"TAX_EXEMPT_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.TaxOvrdReas).HasColumnName(@"TAX_OVRD_REAS").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CustPoNo).HasColumnName(@"CUST_PO_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.LstFrmGrpPrtd).HasColumnName(@"LST_FRM_GRP_PRTD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstFrmPrtd).HasColumnName(@"LST_FRM_PRTD").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.TimesPrtd).HasColumnName(@"TIMES_PRTD").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.FoodStmpAmt).HasColumnName(@"FOOD_STMP_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.FoodStmpLins).HasColumnName(@"FOOD_STMP_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.FoodStmpTaxAmt).HasColumnName(@"FOOD_STMP_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.FoodStmpNormTaxAmt).HasColumnName(@"FOOD_STMP_NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalLins).HasColumnName(@"SAL_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SalLinTot).HasColumnName(@"SAL_LIN_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.GfcLins).HasColumnName(@"GFC_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.SvcLins).HasColumnName(@"SVC_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.RetLins).HasColumnName(@"RET_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.RetLinTot).HasColumnName(@"RET_LIN_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.VoidUsrId).HasColumnName(@"VOID_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VoidReas).HasColumnName(@"VOID_REAS").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.HasTaxOvrd).HasColumnName(@"HAS_TAX_OVRD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxOvrdLins).HasColumnName(@"TAX_OVRD_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.Lins).HasColumnName(@"LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SubTot).HasColumnName(@"SUB_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotExtCost).HasColumnName(@"TOT_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotWeight).HasColumnName(@"TOT_WEIGHT").HasColumnType("money").IsRequired();
            builder.Property(x => x.TotCube).HasColumnName(@"TOT_CUBE").HasColumnType("money").IsRequired();
            builder.Property(x => x.TotGfcAmt).HasColumnName(@"TOT_GFC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotSvcAmt).HasColumnName(@"TOT_SVC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotMisc).HasColumnName(@"TOT_MISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.NormTaxAmt).HasColumnName(@"NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TaxAmt).HasColumnName(@"TAX_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotTnd).HasColumnName(@"TOT_TND").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotChng).HasColumnName(@"TOT_CHNG").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.Tot).HasColumnName(@"TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.TotHdrDisc).HasColumnName(@"TOT_HDR_DISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotLinDisc).HasColumnName(@"TOT_LIN_DISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.IsOffline).HasColumnName(@"IS_OFFLINE").HasColumnType("bit").IsRequired();
            builder.Property(x => x.TotTipAmt).HasColumnName(@"TOT_TIP_AMT").HasColumnType("decimal(15,2)").IsRequired();

            builder.HasIndex(x => new { x.EventNo, x.StrId, x.StaId, x.TktNo }).HasDatabaseName("PS_VOID_HIST_X1");
            builder.HasIndex(x => new { x.StrId, x.BusDat }).HasDatabaseName("PS_VOID_HIST_X2");
        }
    }

}
// </auto-generated>
