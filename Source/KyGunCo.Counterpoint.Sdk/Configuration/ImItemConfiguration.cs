// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_ITEM
    public class ImItemConfiguration : IEntityTypeConfiguration<ImItem>
    {
        public void Configure(EntityTypeBuilder<ImItem> builder)
        {
            builder.ToTable("IM_ITEM", "dbo");
            builder.HasKey(x => x.ItemNo).HasName("PK_IM_ITEM").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.LongDescr).HasColumnName(@"LONG_DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.LongDescrUpr).HasColumnName(@"LONG_DESCR_UPR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ShortDescr).HasColumnName(@"SHORT_DESCR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.AddlDescr1).HasColumnName(@"ADDL_DESCR_1").HasColumnType("varchar(80)").IsRequired(false).IsUnicode(false).HasMaxLength(80);
            builder.Property(x => x.AddlDescr2).HasColumnName(@"ADDL_DESCR_2").HasColumnType("varchar(80)").IsRequired(false).IsUnicode(false).HasMaxLength(80);
            builder.Property(x => x.AddlDescr3).HasColumnName(@"ADDL_DESCR_3").HasColumnType("varchar(80)").IsRequired(false).IsUnicode(false).HasMaxLength(80);
            builder.Property(x => x.ItemTyp).HasColumnName(@"ITEM_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CategCod).HasColumnName(@"CATEG_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SubcatCod).HasColumnName(@"SUBCAT_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AcctCod).HasColumnName(@"ACCT_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LblCod).HasColumnName(@"LBL_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AttrCod1).HasColumnName(@"ATTR_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AttrCod2).HasColumnName(@"ATTR_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AttrCod3).HasColumnName(@"ATTR_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AttrCod4).HasColumnName(@"ATTR_COD_4").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AttrCod5).HasColumnName(@"ATTR_COD_5").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AttrCod6).HasColumnName(@"ATTR_COD_6").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TrkMeth).HasColumnName(@"TRK_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Stat).HasColumnName(@"STAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.StatDat).HasColumnName(@"STAT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.IsTxbl).HasColumnName(@"IS_TXBL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.QtyDecs).HasColumnName(@"QTY_DECS").HasColumnType("int").IsRequired();
            builder.Property(x => x.PrcDecs).HasColumnName(@"PRC_DECS").HasColumnType("int").IsRequired();
            builder.Property(x => x.StkUnit).HasColumnName(@"STK_UNIT").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ItemVendNo).HasColumnName(@"ITEM_VEND_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Weight).HasColumnName(@"WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TareCod).HasColumnName(@"TARE_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Cube).HasColumnName(@"CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.IsWeighed).HasColumnName(@"IS_WEIGHED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Alt1Unit).HasColumnName(@"ALT_1_UNIT").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Alt1Numer).HasColumnName(@"ALT_1_NUMER").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.Alt1Denom).HasColumnName(@"ALT_1_DENOM").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.Alt1Weight).HasColumnName(@"ALT_1_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt1Cube).HasColumnName(@"ALT_1_CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt1Prc1).HasColumnName(@"ALT_1_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2Unit).HasColumnName(@"ALT_2_UNIT").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Alt2Numer).HasColumnName(@"ALT_2_NUMER").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.Alt2Denom).HasColumnName(@"ALT_2_DENOM").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.Alt2Weight).HasColumnName(@"ALT_2_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2Cube).HasColumnName(@"ALT_2_CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2Prc1).HasColumnName(@"ALT_2_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3Unit).HasColumnName(@"ALT_3_UNIT").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Alt3Numer).HasColumnName(@"ALT_3_NUMER").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.Alt3Denom).HasColumnName(@"ALT_3_DENOM").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.Alt3Weight).HasColumnName(@"ALT_3_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3Cube).HasColumnName(@"ALT_3_CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3Prc1).HasColumnName(@"ALT_3_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4Unit).HasColumnName(@"ALT_4_UNIT").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Alt4Numer).HasColumnName(@"ALT_4_NUMER").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.Alt4Denom).HasColumnName(@"ALT_4_DENOM").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.Alt4Weight).HasColumnName(@"ALT_4_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4Cube).HasColumnName(@"ALT_4_CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4Prc1).HasColumnName(@"ALT_4_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5Unit).HasColumnName(@"ALT_5_UNIT").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Alt5Numer).HasColumnName(@"ALT_5_NUMER").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.Alt5Denom).HasColumnName(@"ALT_5_DENOM").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.Alt5Weight).HasColumnName(@"ALT_5_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5Cube).HasColumnName(@"ALT_5_CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5Prc1).HasColumnName(@"ALT_5_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.PrefUnit).HasColumnName(@"PREF_UNIT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PromptForPrc).HasColumnName(@"PROMPT_FOR_PRC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PromptForCost).HasColumnName(@"PROMPT_FOR_COST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PromptForDescr).HasColumnName(@"PROMPT_FOR_DESCR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.WarrPrd1).HasColumnName(@"WARR_PRD_1").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.WarrUnit1).HasColumnName(@"WARR_UNIT_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.WarrPrd2).HasColumnName(@"WARR_PRD_2").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.WarrUnit2).HasColumnName(@"WARR_UNIT_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SerNoReqForSal).HasColumnName(@"SER_NO_REQ_FOR_SAL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SerPromptCod1).HasColumnName(@"SER_PROMPT_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SerPromptCod2).HasColumnName(@"SER_PROMPT_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SerPromptCod3).HasColumnName(@"SER_PROMPT_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfAlpha1).HasColumnName(@"PROF_ALPHA_1").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha2).HasColumnName(@"PROF_ALPHA_2").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha3).HasColumnName(@"PROF_ALPHA_3").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha4).HasColumnName(@"PROF_ALPHA_4").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha5).HasColumnName(@"PROF_ALPHA_5").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfCod1).HasColumnName(@"PROF_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod2).HasColumnName(@"PROF_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod3).HasColumnName(@"PROF_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod4).HasColumnName(@"PROF_COD_4").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod5).HasColumnName(@"PROF_COD_5").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfDat1).HasColumnName(@"PROF_DAT_1").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat2).HasColumnName(@"PROF_DAT_2").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat3).HasColumnName(@"PROF_DAT_3").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat4).HasColumnName(@"PROF_DAT_4").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat5).HasColumnName(@"PROF_DAT_5").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfNo1).HasColumnName(@"PROF_NO_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ProfNo2).HasColumnName(@"PROF_NO_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ProfNo3).HasColumnName(@"PROF_NO_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ProfNo4).HasColumnName(@"PROF_NO_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ProfNo5).HasColumnName(@"PROF_NO_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.GridDim1Tag).HasColumnName(@"GRID_DIM_1_TAG").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.GridDim2Tag).HasColumnName(@"GRID_DIM_2_TAG").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.GridDim3Tag).HasColumnName(@"GRID_DIM_3_TAG").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.GridDim1TagUpr).HasColumnName(@"GRID_DIM_1_TAG_UPR").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.GridDim2TagUpr).HasColumnName(@"GRID_DIM_2_TAG_UPR").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.GridDim3TagUpr).HasColumnName(@"GRID_DIM_3_TAG_UPR").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.GridEnt1).HasColumnName(@"GRID_ENT_1").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.GridEnt2).HasColumnName(@"GRID_ENT_2").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.GridEnt3).HasColumnName(@"GRID_ENT_3").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.CellBarcodPre).HasColumnName(@"CELL_BARCOD_PRE").HasColumnType("varchar(16)").IsRequired(false).IsUnicode(false).HasMaxLength(16);
            builder.Property(x => x.NxtCellBarcodNo).HasColumnName(@"NXT_CELL_BARCOD_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Prc1).HasColumnName(@"PRC_1").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.Barcod).HasColumnName(@"BARCOD").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.PsPromptCod1).HasColumnName(@"PS_PROMPT_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PsPromptCod2).HasColumnName(@"PS_PROMPT_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PsPromptCod3).HasColumnName(@"PS_PROMPT_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.IsEcommItem).HasColumnName(@"IS_ECOMM_ITEM").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommLstPubDt).HasColumnName(@"ECOMM_LST_PUB_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EcommLstPubStat).HasColumnName(@"ECOMM_LST_PUB_STAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommOnSpeclUntil).HasColumnName(@"ECOMM_ON_SPECL_UNTIL").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EcommImgFile).HasColumnName(@"ECOMM_IMG_FILE").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.EcommTxbl1).HasColumnName(@"ECOMM_TXBL_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommTxbl2).HasColumnName(@"ECOMM_TXBL_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommTxbl3).HasColumnName(@"ECOMM_TXBL_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Url).HasColumnName(@"URL").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.EcommNew).HasColumnName(@"ECOMM_NEW").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommNewUntil).HasColumnName(@"ECOMM_NEW_UNTIL").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EcommOnSpecl).HasColumnName(@"ECOMM_ON_SPECL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommChrgFrt).HasColumnName(@"ECOMM_CHRG_FRT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommFrtAmt).HasColumnName(@"ECOMM_FRT_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.VendItemNo).HasColumnName(@"VEND_ITEM_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.TaxCategCod).HasColumnName(@"TAX_CATEG_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DfltCostOfSlsPct).HasColumnName(@"DFLT_COST_OF_SLS_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.RegPrc).HasColumnName(@"REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt1RegPrc).HasColumnName(@"ALT_1_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt2RegPrc).HasColumnName(@"ALT_2_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt3RegPrc).HasColumnName(@"ALT_3_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt4RegPrc).HasColumnName(@"ALT_4_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Alt5RegPrc).HasColumnName(@"ALT_5_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.LstCost).HasColumnName(@"LST_COST").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.LstRecvDat).HasColumnName(@"LST_RECV_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.IsFoodStmpItem).HasColumnName(@"IS_FOOD_STMP_ITEM").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PromptForUnit).HasColumnName(@"PROMPT_FOR_UNIT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PromptForCustomFlds).HasColumnName(@"PROMPT_FOR_CUSTOM_FLDS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MixMatchCod).HasColumnName(@"MIX_MATCH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.IsAdmTkt).HasColumnName(@"IS_ADM_TKT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.IsBomPar).HasColumnName(@"IS_BOM_PAR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IsKitPar).HasColumnName(@"IS_KIT_PAR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CategSubcat).HasColumnName(@"CATEG_SUBCAT").HasColumnType("varchar(21)").IsRequired(false).IsUnicode(false).HasMaxLength(21).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.DimCod).HasColumnName(@"DIM_COD").HasColumnType("varchar(36)").IsRequired(false).IsUnicode(false).HasMaxLength(36).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.DimCodLabel).HasColumnName(@"DIM_COD_LABEL").HasColumnType("varchar(36)").IsRequired(false).IsUnicode(false).HasMaxLength(36).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.DimCount).HasColumnName(@"DIM_COUNT").HasColumnType("int").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.PrefUnitCube).HasColumnName(@"PREF_UNIT_CUBE").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.PrefUnitDenom).HasColumnName(@"PREF_UNIT_DENOM").HasColumnType("numeric(12,1)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.PrefUnitNam).HasColumnName(@"PREF_UNIT_NAM").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.PrefUnitNumer).HasColumnName(@"PREF_UNIT_NUMER").HasColumnType("numeric(12,1)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.PrefUnitPrc1).HasColumnName(@"PREF_UNIT_PRC_1").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.PrefUnitRegPrc).HasColumnName(@"PREF_UNIT_REG_PRC").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.PrefUnitWeight).HasColumnName(@"PREF_UNIT_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.ItemIsMisc).HasColumnName(@"ITEM_IS_MISC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.CopyFromItemNo).HasColumnName(@"COPY_FROM_ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Barcod3Of9).HasColumnName(@"BARCOD_3_OF_9").HasColumnType("varchar(22)").IsRequired(false).IsUnicode(false).HasMaxLength(22).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.IsDiscntbl).HasColumnName(@"IS_DISCNTBL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommDiscOnSal).HasColumnName(@"ECOMM_DISC_ON_SAL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommItemIsDiscntbl).HasColumnName(@"ECOMM_ITEM_IS_DISCNTBL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.PsLinCustFldFrmId).HasColumnName(@"PS_LIN_CUST_FLD_FRM_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.EcommLstChngUtcDt).HasColumnName(@"ECOMM_LST_CHNG_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EcommNxtPubTyp).HasColumnName(@"ECOMM_NXT_PUB_TYP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.EcommPubStat).HasColumnName(@"ECOMM_PUB_STAT").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.UserIsFirearm).HasColumnName(@"USER_IS_FIREARM").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserAtfType).HasColumnName(@"USER_ATF_TYPE").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserStateType).HasColumnName(@"USER_STATE_TYPE").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserManufacturer).HasColumnName(@"USER_MANUFACTURER").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserImporter).HasColumnName(@"USER_IMPORTER").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserModel).HasColumnName(@"USER_MODEL").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserCaliberGauge).HasColumnName(@"USER_CALIBER_GAUGE").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserHand).HasColumnName(@"USER_HAND").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserFinish).HasColumnName(@"USER_FINISH").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserAction).HasColumnName(@"USER_ACTION").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserFirearmNotes).HasColumnName(@"USER_FIREARM_NOTES").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.UserMagCapacity).HasColumnName(@"USER_MAG_CAPACITY").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserBarrelLength).HasColumnName(@"USER_BARREL_LENGTH").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserOverallLength).HasColumnName(@"USER_OVERALL_LENGTH").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserIsNew).HasColumnName(@"USER_IS_NEW").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserIsConsigned).HasColumnName(@"USER_IS_CONSIGNED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserIsUsed).HasColumnName(@"USER_IS_USED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserCountryOfOrigin).HasColumnName(@"USER_COUNTRY_OF_ORIGIN").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.UserBoundBookType).HasColumnName(@"USER_BOUND_BOOK_TYPE").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.UserConsignmentPayoutAmt).HasColumnName(@"USER_CONSIGNMENT_PAYOUT_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.UserRequiresLock).HasColumnName(@"USER_REQUIRES_LOCK").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserIsLock).HasColumnName(@"USER_IS_LOCK").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserConsignmentPayoutPct).HasColumnName(@"USER_CONSIGNMENT_PAYOUT_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.UserAmmoLogHollowPoint).HasColumnName(@"USER_AMMO_LOG_HOLLOW_POINT").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserAmmoLogManufacturer).HasColumnName(@"USER_AMMO_LOG_MANUFACTURER").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserAmmoLogCaliberGauge).HasColumnName(@"USER_AMMO_LOG_CALIBER_GAUGE").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserAmmoLogRoundsPerBox).HasColumnName(@"USER_AMMO_LOG_ROUNDS_PER_BOX").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserAmmoLogItemRoundsPerBox).HasColumnName(@"USER_AMMO_LOG_ITEM_ROUNDS_PER_BOX").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);

            // Foreign keys
            builder.HasOne(a => a.ImCategCod).WithMany(b => b.ImItems).HasForeignKey(c => c.CategCod).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_ITEM_IM_CATEG_COD");

            builder.HasIndex(x => x.ItemNo).HasDatabaseName("_dta_index_IM_ITEM_5_661577395__K1_95_96_97_101_102_103");
            builder.HasIndex(x => x.EcommItemIsDiscntbl).HasDatabaseName("_dta_stat_661577395_180");
            builder.HasIndex(x => x.UserIsNew).HasDatabaseName("_dta_stat_661577395_200");
            builder.HasIndex(x => x.RsStat).HasDatabaseName("IM_ITEM_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("IM_ITEM_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.ItemNo }).HasDatabaseName("IM_ITEM_X1");
            builder.HasIndex(x => new { x.CategCod, x.ItemNo }).HasDatabaseName("IM_ITEM_X2");
            builder.HasIndex(x => new { x.ItemTyp, x.ItemNo }).HasDatabaseName("IM_ITEM_X3");
            builder.HasIndex(x => new { x.TrkMeth, x.ItemNo }).HasDatabaseName("IM_ITEM_X4");
            builder.HasIndex(x => new { x.Barcod, x.ItemNo }).HasDatabaseName("IM_ITEM_X5");
            builder.HasIndex(x => new { x.LongDescrUpr, x.ItemNo }).HasDatabaseName("IM_ITEM_X6");
            builder.HasIndex(x => new { x.ItemVendNo, x.ItemNo }).HasDatabaseName("IM_ITEM_X7");
            builder.HasIndex(x => new { x.VendItemNo, x.ItemNo }).HasDatabaseName("IM_ITEM_X8");
            builder.HasIndex(x => x.EcommLstChngUtcDt).HasDatabaseName("IM_ITEM_X9");
            builder.HasIndex(x => x.IsEcommItem).HasDatabaseName("IX_IM_ITEM_IS_ECOMM_ITEM");
            builder.HasIndex(x => new { x.TrkMeth, x.IsEcommItem }).HasDatabaseName("USER_IDX_IM_ITEM_TRK_METH");
            builder.HasIndex(x => x.IsEcommItem).HasDatabaseName("USER_IX_IM_ITEM_IS_ECOMM_ITEM");
            builder.HasIndex(x => x.IsEcommItem).HasDatabaseName("USER_IX_IM_ITEM_IS_ECOMM_ITEM2");
            builder.HasIndex(x => x.TrkMeth).HasDatabaseName("USER_IX_IM_ITEM_TRK_METH");
            builder.HasIndex(x => new { x.TrkMeth, x.Alt1Unit }).HasDatabaseName("USER_IX_IM_ITEM_TRK_METH_ALT_1_UNIT");
            builder.HasIndex(x => new { x.TrkMeth, x.Alt2Unit }).HasDatabaseName("USER_IX_IM_ITEM_TRK_METH_ALT_2_UNIT");
            builder.HasIndex(x => new { x.TrkMeth, x.Alt3Unit }).HasDatabaseName("USER_IX_IM_ITEM_TRK_METH_ALT_3_UNIT");
            builder.HasIndex(x => new { x.TrkMeth, x.Alt4Unit }).HasDatabaseName("USER_IX_IM_ITEM_TRK_METH_ALT_4_UNIT");
            builder.HasIndex(x => new { x.TrkMeth, x.Alt5Unit }).HasDatabaseName("USER_IX_IM_ITEM_TRK_METH_ALT_5_UNIT");
        }
    }

}
// </auto-generated>
