// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_LIN_EXT
    public class PsOrdHistLinExtConfiguration : IEntityTypeConfiguration<PsOrdHistLinExt>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistLinExt> builder)
        {
            builder.ToTable("PS_ORD_HIST_LIN_EXT", "dbo");
            builder.HasKey(x => new { x.BusDatExt, x.DocIdExt, x.LinSeqNoExt }).HasName("PK_PS_ORD_HIST_LIN_EXT").IsClustered();

            builder.Property(x => x.BusDatExt).HasColumnName(@"BUS_DAT_EXT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocIdExt).HasColumnName(@"DOC_ID_EXT").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNoExt).HasColumnName(@"LIN_SEQ_NO_EXT").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.UserBuybackPrc).HasColumnName(@"USER_BUYBACK_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.UserBuybackTradeinItemNo).HasColumnName(@"USER_BUYBACK_TRADEIN_ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UserBuybackTradeinDescr).HasColumnName(@"USER_BUYBACK_TRADEIN_DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserBuybackTradeinSerNo).HasColumnName(@"USER_BUYBACK_TRADEIN_SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserBuybackTradeinItemNote).HasColumnName(@"USER_BUYBACK_TRADEIN_ITEM_NOTE").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.UserTradeinBuybackExtCost).HasColumnName(@"USER_TRADEIN_BUYBACK_EXT_COST").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.UserBuybackTradeinTrxType).HasColumnName(@"USER_BUYBACK_TRADEIN_TRX_TYPE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserBuybackTradeinConsideration).HasColumnName(@"USER_BUYBACK_TRADEIN_CONSIDERATION").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.UserBuybackTradeinRecvrNo).HasColumnName(@"USER_BUYBACK_TRADEIN_RECVR_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserBuybackTradeinRecvrLinSeqNo).HasColumnName(@"USER_BUYBACK_TRADEIN_RECVR_LIN_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UserTradeinBuybackProcessed).HasColumnName(@"USER_TRADEIN_BUYBACK_PROCESSED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserTradeInProcessed).HasColumnName(@"USER_TRADE_IN_PROCESSED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserConsignmentItemNo).HasColumnName(@"USER_CONSIGNMENT_ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UserConsignmentDescr).HasColumnName(@"USER_CONSIGNMENT_DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserConsignmentSerNo).HasColumnName(@"USER_CONSIGNMENT_SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserConsignmentItemNote).HasColumnName(@"USER_CONSIGNMENT_ITEM_NOTE").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.UserConsignmentExtCost).HasColumnName(@"USER_CONSIGNMENT_EXT_COST").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.UserConsignmentTrxType).HasColumnName(@"USER_CONSIGNMENT_TRX_TYPE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserConsignmentConsideration).HasColumnName(@"USER_CONSIGNMENT_CONSIDERATION").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.UserConsignmentRecvrNo).HasColumnName(@"USER_CONSIGNMENT_RECVR_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserConsignmentRecvrLinSeqNo).HasColumnName(@"USER_CONSIGNMENT_RECVR_LIN_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UserConsignmentProcessed).HasColumnName(@"USER_CONSIGNMENT_PROCESSED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserConsignmentPayoutItemNo).HasColumnName(@"USER_CONSIGNMENT_PAYOUT_ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UserConsignmentPayoutLocId).HasColumnName(@"USER_CONSIGNMENT_PAYOUT_LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserConsignmentPayoutSerNo).HasColumnName(@"USER_CONSIGNMENT_PAYOUT_SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserConsignmentPayoutRecvdDt).HasColumnName(@"USER_CONSIGNMENT_PAYOUT_RECVD_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UserRentalAmmoCount).HasColumnName(@"USER_RENTAL_AMMO_COUNT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UserIntakeType).HasColumnName(@"USER_INTAKE_TYPE").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserIntakeDocNo).HasColumnName(@"USER_INTAKE_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserKgcVendNo).HasColumnName(@"USER_KGC_VEND_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserKgcIsDropship).HasColumnName(@"USER_KGC_IS_DROPSHIP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);

            // Foreign keys
            builder.HasOne(a => a.PsOrdHistLin).WithOne(b => b.PsOrdHistLinExt).HasForeignKey<PsOrdHistLinExt>(c => new { c.BusDatExt, c.DocIdExt, c.LinSeqNoExt }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_LIN_EXT_PS_ORD_HIST_LIN");
        }
    }

}
// </auto-generated>
