using Abp.IdentityServer4;
using Abp.Organizations;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Plexform.Authorization.Delegation;
using Plexform.Authorization.Roles;
using Plexform.Authorization.Users;
using Plexform.Chat;
using Plexform.Editions;
using Plexform.Friendships;
using Plexform.MultiTenancy;
using Plexform.MultiTenancy.Accounting;
using Plexform.MultiTenancy.Payments;
using Plexform.Storage;

namespace Plexform.EntityFrameworkCore
{
    public class PlexformDbContext : AbpZeroDbContext<Tenant, Role, User, PlexformDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public virtual DbSet<SubscriptionPaymentExtensionData> SubscriptionPaymentExtensionDatas { get; set; }

        public virtual DbSet<UserDelegation> UserDelegations { get; set; }

        public virtual DbSet<Plexform.MultiTenancy.Editions.TenantEditions> TenantEditions { get; set; }

        ////#region ACCOUNTING
        ////public virtual DbSet<DTO.Accounting.INVOICEHDR> INVOICEHDR { get; set; }
        ////public virtual DbSet<DTO.Accounting.INVOICEDTL> INVOICEDTL { get; set; }
        ////public virtual DbSet<DTO.Accounting.INVOICETAX> INVOICETAX { get; set; }
        ////public virtual DbSet<DTO.Accounting.TRANSHDR> TRANSHDR { get; set; }
        ////public virtual DbSet<DTO.Accounting.TRANSDTL> TRANSDTL { get; set; }
        ////public virtual DbSet<DTO.Accounting.TRANSFPX> TRANSFPX { get; set; }
        ////public virtual DbSet<DTO.Accounting.TRANSTENDER> TRANSTENDER { get; set; }
        ////public virtual DbSet<DTO.Accounting.TENDER> TENDER { get; set; }
        //////public virtual DbSet<DTO.Accounting.TENDERTYPE> TENDERTYPE { get; set; }
        ////public virtual DbSet<DTO.Accounting.PROCTASK> PROCTASK { get; set; }
        ////public virtual DbSet<DTO.Accounting.SYSCODEB> SYSCODEB { get; set; }
        ////public virtual DbSet<DTO.Accounting.INVOICEHDR_OLD> INVOICEHDR_OLD { get; set; }
        ////public virtual DbSet<DTO.Accounting.INVOICEITEM> INVOICEITEM { get; set; }
        ////public virtual DbSet<DTO.Accounting.TRANSCDHDR> TRANSCDHDR { get; set; }
        ////public virtual DbSet<DTO.Accounting.TRANSCDITEM> TRANSCDITEM { get; set; }

        ////#region PURCHASE ORDER
        ////public virtual DbSet<Plexform.DTO.Accounting.PURCHASEORDERHDR> PURCHASEORDERHDR { get; set; }
        ////public virtual DbSet<Plexform.DTO.Accounting.PURCHASEORDERDTL> PURCHASEORDERDTL { get; set; }

        ////public virtual DbSet<Plexform.DTO.Accounting.SAP_PO> SAP_PO { get; set; }
        ////#endregion  
        ////#endregion

        //#region PAYMENT
        //public virtual DbSet<DTO.Payment.PAYMENTHDR> PAYMENTHDR { get; set; }
        //public virtual DbSet<DTO.Payment.PAYMENTDTL> PAYMENTDTL { get; set; }
        //public virtual DbSet<DTO.Payment.PAYMENTTENDER> PAYMENTTENDER { get; set; }
        //public virtual DbSet<DTO.Payment.PAYMENTLOG> PAYMENTLOG { get; set; }
        //public virtual DbSet<DTO.Payment.TENDERTYPE> TENDERTYPE { get; set; }
        //#endregion

        //#region CREDIT
        //public virtual DbSet<DTO.Credit.MASTERBALANCE> MasterBalance { get; set; }
        //#endregion

        #region KA APPROVAL
        //public virtual DbSet<DTO.Approval.KA.EMPAPPROVER> EMPAPPROVER { get; set; }
        //public virtual DbSet<DTO.Approval.KA.LOARULES> LOARULES { get; set; }
        //public virtual DbSet<DTO.Approval.KA.APPTRAIL> APPTRAIL { get; set; }
        //public virtual DbSet<DTO.Approval.KA.LOA> LOA { get; set; }
        //public virtual DbSet<DTO.Approval.KA.TASKASSIGN> TASKASSIGN { get; set; }
        //public virtual DbSet<DTO.Approval.KA.TASKLOG> TASKLOG { get; set; }
        //public virtual DbSet<DTO.Approval.KA.ApprovalHDR> ApprovalHDR { get; set; }
        //public virtual DbSet<DTO.Approval.KA.ApprovalDTL> ApprovalDTL { get; set; }
        #endregion

        //#region APPROVAL
        //public virtual DbSet<DTO.Approval.LOA> LOA { get; set; }

        //public virtual DbSet<DTO.Approval.LOARULES> LOARULES { get; set; }
        //public virtual DbSet<DTO.Approval.TASKLOG> TASKLOG { get; set; }

        //public virtual DbSet<DTO.Approval.APPTRAIL> APPTRAIL { get; set; }

        //public virtual DbSet<DTO.Approval.TASKASSIGN> TASKASSIGN { get; set; }

        //#endregion


        #region CORE
        #region ENTITY
        public virtual DbSet<DTO.Core.Entity.BIZCATEGORY> BIZCATEGORY { get; set; }
        public virtual DbSet<DTO.Core.Entity.BIZDOCUMENT> BIZDOCUMENT { get; set; }
        public virtual DbSet<DTO.Core.Entity.BIZENTITY> BIZENTITY { get; set; }
        public virtual DbSet<DTO.Core.Entity.BIZGROUP> BIZGROUP { get; set; }
        public virtual DbSet<DTO.Core.Entity.BIZLOCATE> BIZLOCATE { get; set; }
        public virtual DbSet<DTO.Core.Entity.BIZMEMBER> BIZMEMBER { get; set; }
        public virtual DbSet<DTO.Core.Entity.BIZITEM> BIZITEM { get; set; }
        public virtual DbSet<DTO.Core.Entity.EMPLOYEE> EMPLOYEE { get; set; }
        public virtual DbSet<DTO.Core.Entity.LICENSE> LICENSE { get; set; }
        public virtual DbSet<DTO.Core.Entity.USRPROFILE> USRPROFILE { get; set; }
        public virtual DbSet<DTO.Core.Entity.USRGROUP> USRGROUP { get; set; }
        public virtual DbSet<DTO.Core.Entity.USRAPP> USRAPP { get; set; }
        public virtual DbSet<DTO.Core.Entity.USRVERIFY> USRVERIFY { get; set; }

        public virtual DbSet<DTO.Core.Entity.ACCVERIFY> ACCVERIFY { get; set; }
        public virtual DbSet<DTO.Core.Entity.CUSTOMER> CUSTOMER { get; set; }
        public virtual DbSet<DTO.Core.Entity.EMAIL> EMAIL { get; set; }
        public virtual DbSet<DTO.Core.Entity.BIZREFERENCE> BIZREFERENCE { get; set; }
        public virtual DbSet<DTO.Core.Entity.BIZRELATION> BIZRELATION { get; set; }
        //public virtual DbSet<DTO.Core.Entity.EMPBRANCH> EMPBRANCH { get; set; }
        public virtual DbSet<DTO.Core.Entity.AbpUserProfile> AbpUserProfile { get; set; }
        #endregion

        #region Location
        public virtual DbSet<DTO.Core.Location.COUNTRY> COUNTRY { get; set; }
        public virtual DbSet<DTO.Core.Location.STATE> STATE { get; set; }
        public virtual DbSet<DTO.Core.Location.AREA> AREA { get; set; }
        //public virtual DbSet<DTO.Core.Location.ZONE> ZONE { get; set; }
        public virtual DbSet<DTO.Core.Location.CITY> CITY { get; set; }
        public virtual DbSet<DTO.Core.Location.DISTRICT> DISTRICT { get; set; }
        public virtual DbSet<DTO.Core.Location.PBT> PBT { get; set; }
        #endregion

        #region MASTER
        public virtual DbSet<Plexform.DTO.Core.General.APPMASTER> APPMASTER { get; set; }
        public virtual DbSet<DTO.Core.General.CODENUM> CODENUM { get; set; }
        public virtual DbSet<DTO.Core.General.CODEMASTER> CODEMASTER { get; set; }
        public virtual DbSet<DTO.Core.General.CURRENCY> CURRENCY { get; set; }
        public virtual DbSet<DTO.Core.General.SYSPREFT> SYSPREFT { get; set; }
        public virtual DbSet<DTO.Core.General.SYSPREFB> SYSPREFB { get; set; }
        public virtual DbSet<DTO.Core.General.PROJECT> PROJECT { get; set; }
        public virtual DbSet<DTO.Core.General.PFI> PFI { get; set; }
        #endregion

        #region MAMEE
        public virtual DbSet<DTO.Core.General.PRODUCTISMUPLOAD> PRODUCTISMUPLOAD { get; set; }
        #endregion

        #region QUESTIONNAIRE
        public virtual DbSet<DTO.Core.Questionnaire.QUESTIONDTL> QUESTIONDTL { get; set; }
        public virtual DbSet<DTO.Core.Questionnaire.QUESTIONHDR> QUESTIONHDR { get; set; }
        public virtual DbSet<DTO.Core.Questionnaire.QUESTIONITEM> QUESTIONITEM { get; set; }

        public virtual DbSet<DTO.Core.Questionnaire.QUESTIONPAXSCORE> QUESTIONPAXSCORE { get; set; }
        public virtual DbSet<DTO.Core.Questionnaire.QUESTIONPAX> QUESTIONPAX { get; set; }
        public virtual DbSet<DTO.Core.Questionnaire.QUESTIONPAXITEM> QUESTIONPAXITEM { get; set; }
        public virtual DbSet<DTO.Core.Questionnaire.QUESTIONPAXSUM> QUESTIONPAXSUM { get; set; }

        public virtual DbSet<Plexform.DTO.Core.Questionnaire.QUESTIONGROUP> QUESTIONGROUP { get; set; }

        public virtual DbSet<Plexform.DTO.Core.Questionnaire.ANSWEROPT> ANSWEROPT { get; set; }

        public virtual DbSet<Plexform.DTO.Core.Questionnaire.ANSWERGROUP> ANSWERGROUP { get; set; }

        public virtual DbSet<Plexform.DTO.Core.Questionnaire.ANSWEROPTGROUP> ANSWEROPTGROUP { get; set; }

        #endregion
        #endregion

        //#region CROSSMARQ
        //#region CAMPAIGN
        //public virtual DbSet<DTO.CrossmarQ.Campaign.CAMPAIGNDOCUMENT> CAMPAIGNDOCUMENT { get; set; }
        //public virtual DbSet<DTO.CrossmarQ.Campaign.CAMPAIGNDTL> CAMPAIGNDTL { get; set; }
        //public virtual DbSet<DTO.CrossmarQ.Campaign.CAMPAIGNHDR> CAMPAIGNHDR { get; set; }
        //public virtual DbSet<DTO.CrossmarQ.Campaign.CAMPAIGNITEM> CAMPAIGNITEM { get; set; }
        //public virtual DbSet<DTO.CrossmarQ.Campaign.CAMPAIGNITEMSUPP> CAMPAIGNITEMSUPP { get; set; }
        //public virtual DbSet<DTO.CrossmarQ.Campaign.CAMPAIGNAFFILIATE> CAMPAIGNAFFILIATE { get; set; }
        //#endregion

        //#region AFFILIATE
        //public virtual DbSet<DTO.CrossmarQ.Affiliate.IMPRESSION> IMPRESSION { get; set; }
        //public virtual DbSet<DTO.CrossmarQ.Affiliate.IMPRESSIONPROGRESS> IMPRESSIONPROGRESS { get; set; }
        //public virtual DbSet<DTO.CrossmarQ.Affiliate.LOGEVENT> LOGEVENT { get; set; }
        //#endregion
        //#endregion

        #region INVENTORY
        public virtual DbSet<DTO.Inventory.ITEM> ITEM { get; set; }
        public virtual DbSet<DTO.Inventory.VOC_VOUCHER> VOC_VOUCHER { get; set; }
        public virtual DbSet<DTO.Inventory.ITMTRANSDTL> ITMTRANSDTL { get; set; }
        public virtual DbSet<DTO.Inventory.ITMTRANSHDR> ITMTRANSHDR { get; set; }
        public virtual DbSet<DTO.Inventory.ITEMLOC> ITEMLOC { get; set; }
        public virtual DbSet<DTO.Inventory.ITEMCOMBO> ITEMCOMBO { get; set; }
        public virtual DbSet<DTO.Inventory.ITEMPRICE> ITEMPRICE { get; set; }
        public virtual DbSet<DTO.Inventory.ITEMPRICEHDR> ITEMPRICEHDR { get; set; }
        public virtual DbSet<DTO.Inventory.ITEMSELLGRP> ITEMSELLGRP { get; set; }
        public virtual DbSet<DTO.Inventory.ITEMCOSTGRP> ITEMCOSTGRP { get; set; }
        public virtual DbSet<DTO.Inventory.ITEMCATEGORY> ITEMCATEGORY { get; set; }
        public virtual DbSet<DTO.Inventory.SAP_ITEMPRICE> SAP_ITEMPRICE { get; set; }
        public virtual DbSet<DTO.Inventory.ITEMDEPT> ITEMDEPT { get; set; }
        public virtual DbSet<DTO.Inventory.ITEMGROUP> ITEMGROUP { get; set; }
        #endregion

        //#region QUESTIL
        //#region CONTRACT
        //public virtual DbSet<DTO.Questil.Contract.CONTRACTDOCUMENT> CONTRACTDOCUMENT { get; set; }
        //public virtual DbSet<DTO.Questil.Contract.CONTRACTHDR> CONTRACTHDR { get; set; }
        //public virtual DbSet<DTO.Questil.Contract.CONTRACTITEM> CONTRACTITEM { get; set; }
        //public virtual DbSet<DTO.Questil.Contract.CONTRACTRESOURCE> CONTRACTRESOURCE { get; set; }
        //public virtual DbSet<DTO.Questil.Contract.CONTRACTSCOPESUM> CONTRACTSCOPESUM { get; set; }
        //public virtual DbSet<DTO.Questil.Contract.STGAPPROVAL> STGAPPROVAL { get; set; }
        //#endregion

        //#region RESOURCE
        //public virtual DbSet<DTO.Questil.Resources.VEHICLE> VEHICLE { get; set; }
        //public virtual DbSet<DTO.Questil.Resources.WORKER> WORKER { get; set; }
        //public virtual DbSet<DTO.Questil.Resources.VEHICLEDOCUMENT> VEHICLEDOCUMENT { get; set; }
        //#endregion

        //#region SCHEDULE
        //public virtual DbSet<DTO.Questil.Contract.SCHEDULEDTL> SCHEDULEDTL { get; set; }
        //public virtual DbSet<DTO.Questil.Contract.SCHEDULEHDR> SCHEDULEHDR { get; set; }
        //public virtual DbSet<DTO.Questil.Contract.SCHEDULEITEM> SCHEDULEITEM { get; set; }
        //#endregion

        //#region WORKORDER
        //public virtual DbSet<DTO.Questil.WorkOrder.WORKORDERPERSON> WORKORDERPERSON { get; set; }
        //public virtual DbSet<DTO.Questil.WorkOrder.WORKORDERHDR> WORKORDERHDR { get; set; }
        //public virtual DbSet<DTO.Questil.WorkOrder.WORKORDERDTL> WORKORDERDTL { get; set; }
        //public virtual DbSet<DTO.Questil.WorkOrder.WORKORDERLOG> WORKORDERLOG { get; set; }
        //public virtual DbSet<DTO.Questil.WorkOrder.WORKORDERDTLLOG> WORKORDERDTLLOG { get; set; }
        //public virtual DbSet<DTO.Questil.WorkOrder.WORKORDERBIN> WORKORDERBIN { get; set; }
        //public virtual DbSet<DTO.Questil.WorkOrder.INSPECTCHECK> INSPECTCHECK { get; set; }
        //public virtual DbSet<DTO.Questil.WorkOrder.MOB_QUEST> MOB_QUEST { get; set; }
        //public virtual DbSet<DTO.Questil.WorkOrder.IMAGEUPLOAD> IMAGEUPLOAD { get; set; }
        //#endregion

        //#region PAYMENTQ
        //public virtual DbSet<Plexform.DTO.Questil.Payment.INVOICEHDR_CWMS> INVOICEHDR_CWMS { get; set; }
        //#endregion

        //#region REPORT
        //public virtual DbSet<DTO.Questil.Report.SYSREPORT> SYSREPORT { get; set; }
        //#endregion

        //#region QUESTIL PAYMENT
        //public virtual DbSet<DTO.Questil.Payment.INSERVICEHDR> INSERVICEHDR { get; set; }

        //public virtual DbSet<DTO.Questil.Payment.INSERVICEDTL> INSERVICEDTL { get; set; }
        //#endregion

        //#endregion

        //#region BIDDING
        //public virtual DbSet<DTO.Clobid.CBXBIDDING> CBXBIDDING { get; set; }

        //public virtual DbSet<DTO.Campaign.CAMPHDR> CAMPHDR { get; set; }
        //public virtual DbSet<DTO.Campaign.CAMPPAX> CAMPPAX { get; set; }
        //public virtual DbSet<DTO.Campaign.CAMPCOMMITTEE> CAMPCOMMITTEE { get; set; }

        //public virtual DbSet<DTO.Campaign.CAMPAFFILIATE> CAMPAFFILIATE { get; set; }
        //#endregion


        public PlexformDbContext(DbContextOptions<PlexformDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BinaryObject>(b =>
            {
                b.HasIndex(e => new { e.TenantId });
            });

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { PaymentId = e.ExternalPaymentId, e.Gateway });
            });

            modelBuilder.Entity<SubscriptionPaymentExtensionData>(b =>
            {
                b.HasQueryFilter(m => !m.IsDeleted)
                    .HasIndex(e => new { e.SubscriptionPaymentId, e.Key, e.IsDeleted })
                    .IsUnique();
            });

            modelBuilder.Entity<UserDelegation>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.SourceUserId });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId });
            });

            modelBuilder.Entity<Plexform.MultiTenancy.Editions.TenantEditions>(b =>
            {
                b.HasKey(e => new { e.TenantId, e.AppId });
                b.Property(e => e.IsInTrialPeriod).HasDefaultValueSql("CONVERT([bit],(0))");
                b.Property(e => e.SubscriptionPaymentType).HasDefaultValueSql("(0)");
            });

            //#region ACCOUNTING
            //#region INVOICEHDR
            ////modelBuilder.Entity<DTO.Accounting.Account.INVOICEHDR>(b =>
            ////{
            ////    b.HasKey(e => new { e.MonthCode, e.PBTCode, e.BatchCode, });
            ////    b.Property(e => e.MonthCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.PBTCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.BatchCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TotalRec1).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TotalRec2).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TotalRec3).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TotalRec4).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TotalRec5).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TotalAmt1).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.TotalAmt2).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.TotalAmt3).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.TotalAmt4).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.TotalAmt5).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            ////});
            //modelBuilder.Entity<Plexform.DTO.Accounting.INVOICEHDR>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.TransNo, e.BillNo, e.OrderNo, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TransType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            //    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            //    b.Property(e => e.CashierID).HasDefaultValueSql("''");
            //    b.Property(e => e.ShiftCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TotalServer).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ServerID).HasDefaultValueSql("''");
            //    b.Property(e => e.EmpType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TillID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransStartTime).HasDefaultValueSql("''");
            //    b.Property(e => e.TransEndTime).HasDefaultValueSql("''");
            //    b.Property(e => e.TransPayTime).HasDefaultValueSql("''");
            //    b.Property(e => e.TransAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransSubTotal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransAmtRnd).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransAmtSave).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransAmtOrg).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransChgAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDiscType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscValue).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscAuth).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDiscReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDiscRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.TransAmtSpDisc).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransValueSpDisc).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AuthSpDisc).HasDefaultValueSql("''");
            //    b.Property(e => e.SpDiscReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SpDiscRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.CustomerID).HasDefaultValueSql("''");
            //    b.Property(e => e.CustType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CustPrivilege).HasDefaultValueSql("''");
            //    b.Property(e => e.AcctNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TotalPoints).HasDefaultValueSql("(0)");
            //    b.Property(e => e.InSvcID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.TransStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Training).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Profiled).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.TblNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TblPax).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransPointsStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransPoints).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderNo).HasDefaultValueSql("''");
            //    b.Property(e => e.IsApproved).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ApprovedBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region invoicehdr old
            //modelBuilder.Entity<DTO.Accounting.INVOICEHDR_OLD>(b =>
            //{
            //    b.HasKey(e => new { e.MonthCode, e.PBTCode, e.BatchCode, });
            //    b.Property(e => e.MonthCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PBTCode).HasDefaultValueSql("''");
            //    b.Property(e => e.BatchCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TotalRec1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec4).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec5).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt4).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt5).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region INVOICEITEM
            //modelBuilder.Entity<DTO.Accounting.INVOICEITEM>(b =>
            //{
            //    b.HasKey(e => new { e.MonthCode, e.PBTCode, e.BizRegID, e.BatchCode, e.SeqNo, });
            //    b.Property(e => e.MonthCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PBTCode).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.CompanyName).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractID).HasDefaultValueSql("''");
            //    b.Property(e => e.BatchCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.InvDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.ExpiryDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.Amount1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Amount2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark1).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark2).HasDefaultValueSql("''");
            //    b.Property(e => e.SvcType).HasDefaultValueSql("''");
            //    b.Property(e => e.ProcType).HasDefaultValueSql("''");
            //    b.Property(e => e.ErrCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Currency).HasDefaultValueSql("''");
            //    b.Property(e => e.FilePath).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //});
            //#endregion

            //#region INVOICEDTL
            //modelBuilder.Entity<Plexform.DTO.Accounting.INVOICEDTL>(b =>
            //{
            //    b.HasKey(e => new { e.BizLocID, e.BizRegID, e.TransNo, e.TransSeq, e.ItemCode, e.OrderNo, });
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TransSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            //    b.Property(e => e.EntryTime).HasDefaultValueSql("''");
            //    b.Property(e => e.StkCode).HasDefaultValueSql("''");
            //    b.Property(e => e.StkDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.StkType).HasDefaultValueSql("''");
            //    b.Property(e => e.BehvType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitCost).HasDefaultValueSql("(1)");
            //    b.Property(e => e.OrgPrice).HasDefaultValueSql("(1)");
            //    b.Property(e => e.NettPrice).HasDefaultValueSql("(1)");
            //    b.Property(e => e.TolAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.DiscAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.NettAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.SubPoints).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Points).HasDefaultValueSql("(1)");
            //    b.Property(e => e.PriceOverrided).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Discounted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Taxable).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ReturnCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.SerialNo).HasDefaultValueSql("''");
            //    b.Property(e => e.PriceAuthID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("''");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            //    b.Property(e => e.PrcDisplayType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PromoCode).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.ExCode1).HasDefaultValueSql("''");
            //    b.Property(e => e.ExCode2).HasDefaultValueSql("''");
            //    b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CoRate1H).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CoRate1G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate2H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate2G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate3H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate3G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate4H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate4G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate5H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate5G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.WarSerialNo).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderNo).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PathRef).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region INVOICETAX
            //modelBuilder.Entity<DTO.Accounting.INVOICETAX>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.TransNo, e.TaxCode, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TaxCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TaxAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.TaxRate).HasDefaultValueSql("(1)");
            //    b.Property(e => e.TaxInEx).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TaxCharge).HasDefaultValueSql("(1)");
            //    b.Property(e => e.TaxRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Points).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region TRANSHDR
            //modelBuilder.Entity<DTO.Accounting.TRANSHDR>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.TermID, e.TransNo, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TransType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            //    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            //    b.Property(e => e.CashierID).HasDefaultValueSql("''");
            //    b.Property(e => e.ShiftCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TotalServer).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ServerID).HasDefaultValueSql("''");
            //    b.Property(e => e.EmpType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TillID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransStartTime).HasDefaultValueSql("''");
            //    b.Property(e => e.TransEndTime).HasDefaultValueSql("''");
            //    b.Property(e => e.TransPayTime).HasDefaultValueSql("''");
            //    b.Property(e => e.TransAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransSubTotal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransAmtRnd).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransAmtSave).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransAmtOrg).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransChgAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDiscType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscValue).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscAuth).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDiscReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDiscRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.TransAmtSpDisc).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransValueSpDisc).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AuthSpDisc).HasDefaultValueSql("''");
            //    b.Property(e => e.SpDiscReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SpDiscRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.CustomerID).HasDefaultValueSql("''");
            //    b.Property(e => e.CustType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CustPrivilege).HasDefaultValueSql("''");
            //    b.Property(e => e.AcctNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TotalPoints).HasDefaultValueSql("(0)");
            //    b.Property(e => e.InSvcID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.TransStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Training).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Profiled).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.TblNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TblPax).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransPointsStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransPoints).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region TRANSDTL
            //modelBuilder.Entity<DTO.Accounting.TRANSDTL>(b =>
            //{
            //    b.HasKey(e => new { e.BizLocID, e.TermID, e.TransNo, e.TransSeq, });
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TransSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            //    b.Property(e => e.EntryTime).HasDefaultValueSql("''");
            //    b.Property(e => e.StkCode).HasDefaultValueSql("''");
            //    b.Property(e => e.StkDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.StkType).HasDefaultValueSql("''");
            //    b.Property(e => e.BehvType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitCost).HasDefaultValueSql("(1)");
            //    b.Property(e => e.OrgPrice).HasDefaultValueSql("(1)");
            //    b.Property(e => e.NettPrice).HasDefaultValueSql("(1)");
            //    b.Property(e => e.TolAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.DiscAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.NettAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.SubPoints).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Points).HasDefaultValueSql("(1)");
            //    b.Property(e => e.PriceOverrided).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Discounted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Taxable).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ReturnCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.SerialNo).HasDefaultValueSql("''");
            //    b.Property(e => e.PriceAuthID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("''");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            //    b.Property(e => e.PrcDisplayType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PromoCode).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.ExCode1).HasDefaultValueSql("''");
            //    b.Property(e => e.ExCode2).HasDefaultValueSql("''");
            //    b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CoRate1H).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CoRate1G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate2H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate2G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate3H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate3G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate4H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate4G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate5H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate5G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.WarSerialNo).HasDefaultValueSql("(1)");
            //});
            //#endregion

            //#region TRANSFPX
            //modelBuilder.Entity<DTO.Accounting.TRANSFPX>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.TermID, e.TransNo, e.TransSeq, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TransSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransTime).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderID).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ExchgRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TenderDue).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChangeAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefInfo).HasDefaultValueSql("''");
            //    b.Property(e => e.CCrefInfo).HasDefaultValueSql("''");
            //    b.Property(e => e.CustName).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //});
            //#endregion

            //#region TRANSTENDER
            //modelBuilder.Entity<DTO.Accounting.TRANSTENDER>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.TermID, e.TransNo, e.TransSeq, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TransSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TransTime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TenderType).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderID).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ExchgRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TenderDue).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChangeAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Currency).HasDefaultValueSql("''");
            //    b.Property(e => e.ExternalID).HasDefaultValueSql("''");
            //    b.Property(e => e.MerchantID).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo).HasDefaultValueSql("''");
            //    b.Property(e => e.RefKey).HasDefaultValueSql("''");
            //    b.Property(e => e.RefType).HasDefaultValueSql("''");
            //    b.Property(e => e.RefToken).HasDefaultValueSql("''");
            //    b.Property(e => e.RefRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.RefRemark2).HasDefaultValueSql("''");
            //    b.Property(e => e.RefRemark3).HasDefaultValueSql("''");
            //    b.Property(e => e.RefOth1).HasDefaultValueSql("''");
            //    b.Property(e => e.RefOth2).HasDefaultValueSql("''");
            //    b.Property(e => e.RefOth3).HasDefaultValueSql("''");
            //    b.Property(e => e.CustName).HasDefaultValueSql("''");
            //    b.Property(e => e.CardNo).HasDefaultValueSql("''");
            //    b.Property(e => e.BankCode).HasDefaultValueSql("''");
            //    b.Property(e => e.BankAccNo).HasDefaultValueSql("''");
            //    b.Property(e => e.RespCode).HasDefaultValueSql("''");
            //    b.Property(e => e.AuthCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TraceNo).HasDefaultValueSql("''");
            //    b.Property(e => e.IsApproved).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ApprovedBy).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovalFlow).HasDefaultValueSql("''");
            //    b.Property(e => e.TransStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region TENDER
            //modelBuilder.Entity<DTO.Accounting.TENDER>(b =>
            //{
            //    b.HasKey(e => new { e.TenderID, });
            //    b.Property(e => e.TenderType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TenderDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.CurrencyCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderPrompt).HasDefaultValueSql("''");
            //    b.Property(e => e.RefPrompt).HasDefaultValueSql("''");
            //    b.Property(e => e.DefValue).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Pickup1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Pickup2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MinTenderAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MaxTenderAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AllowPickup).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AllowFloat).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AllowOverTender).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OpenDrawer).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TrackRefNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TrackClrDate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.TrackAppCode).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region TENDERTYPE
            ////modelBuilder.Entity<DTO.Core.TENDERTYPE>(b =>
            ////{
            ////    b.HasKey(e => new { e.TenderType, });
            ////    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            ////});
            //#endregion

            //#region TRANSINVOICEHDR
            ////modelBuilder.Entity<DTO.Accounting.TRANSINVOICEHDR>(b =>
            ////{
            ////    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.TransNo, e.BillNo, });
            ////    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            ////    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            ////    b.Property(e => e.CashierID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ShiftCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TotalServer).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ServerID).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmpType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TillID).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransStartTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransEndTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransPayTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransSubTotal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransAmtRnd).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransAmtSave).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransAmtOrg).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransChgAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransDiscType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscValue).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscAuth).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransDiscReasonCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransDiscRemark).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransAmtSpDisc).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransValueSpDisc).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.AuthSpDisc).HasDefaultValueSql("''");
            ////    b.Property(e => e.SpDiscReasonCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.SpDiscRemark).HasDefaultValueSql("''");
            ////    b.Property(e => e.CustomerID).HasDefaultValueSql("''");
            ////    b.Property(e => e.CustType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CustPrivilege).HasDefaultValueSql("''");
            ////    b.Property(e => e.AcctNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TotalPoints).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.InSvcID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransReasonCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransRemark).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransStatus).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Training).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Profiled).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.TblNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TblPax).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransPointsStatus).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransPoints).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            ////});
            //#endregion

            //#region TRANSINVOICEDTL
            ////modelBuilder.Entity<DTO.Accounting.TRANSINVOICEDTL>(b =>
            ////{
            ////    b.HasKey(e => new { e.BizLocID, e.TransNo, e.TransSeq, e.ItemCode, });
            ////    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            ////    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransSeq).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.RefSeq).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.IsCal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.EntryTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.StkCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.StkDesc).HasDefaultValueSql("''");
            ////    b.Property(e => e.StkType).HasDefaultValueSql("''");
            ////    b.Property(e => e.BehvType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ItemType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.UnitCost).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.OrgPrice).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.NettPrice).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.TolAmt).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.DiscAmt).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.NettAmt).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.SubPoints).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.Points).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.PriceOverrided).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Discounted).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Taxable).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ReturnCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.Remark).HasDefaultValueSql("''");
            ////    b.Property(e => e.SerialNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.PriceAuthID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Posted).HasDefaultValueSql("''");
            ////    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            ////    b.Property(e => e.PrcDisplayType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.PromoCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.ExCode1).HasDefaultValueSql("''");
            ////    b.Property(e => e.ExCode2).HasDefaultValueSql("''");
            ////    b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CoRate1H).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CoRate1G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate2H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate2G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate3H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate3G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate4H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate4G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate5H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate5G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.WarSerialNo).HasDefaultValueSql("(1)");
            ////});
            //#endregion

            //#region TRANSCASHBILLHDR
            ////modelBuilder.Entity<DTO.Accounting.TRANSCASHBILLHDR>(b =>
            ////{
            ////    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.BillNo, e.TransNo, });
            ////    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            ////    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            ////    b.Property(e => e.CashierID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ShiftCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TotalServer).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ServerID).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmpType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TillID).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransStartTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransEndTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransPayTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransSubTotal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransAmtRnd).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransAmtSave).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransAmtOrg).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransChgAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransDiscType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscValue).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscAuth).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransDiscReasonCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransDiscRemark).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransAmtSpDisc).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransValueSpDisc).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.AuthSpDisc).HasDefaultValueSql("''");
            ////    b.Property(e => e.SpDiscReasonCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.SpDiscRemark).HasDefaultValueSql("''");
            ////    b.Property(e => e.CustomerID).HasDefaultValueSql("''");
            ////    b.Property(e => e.CustType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CustPrivilege).HasDefaultValueSql("''");
            ////    b.Property(e => e.AcctNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TotalPoints).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.InSvcID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransReasonCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransRemark).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransStatus).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Training).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Profiled).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.TblNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TblPax).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransPointsStatus).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransPoints).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            ////});
            //#endregion

            //#region TRANSCASHBILLDTL
            ////modelBuilder.Entity<DTO.Accounting.TRANSCASHBILLDTL>(b =>
            ////{
            ////    b.HasKey(e => new { e.BizLocID, e.TransNo, e.TransSeq, e.ItemCode, });
            ////    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            ////    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransSeq).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.RefSeq).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.IsCal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.EntryTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.StkCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.StkDesc).HasDefaultValueSql("''");
            ////    b.Property(e => e.StkType).HasDefaultValueSql("''");
            ////    b.Property(e => e.BehvType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ItemType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.UnitCost).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.OrgPrice).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.NettPrice).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.TolAmt).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.DiscAmt).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.NettAmt).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.SubPoints).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.Points).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.PriceOverrided).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Discounted).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Taxable).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ReturnCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.Remark).HasDefaultValueSql("''");
            ////    b.Property(e => e.SerialNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.PriceAuthID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Posted).HasDefaultValueSql("''");
            ////    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            ////    b.Property(e => e.PrcDisplayType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.PromoCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.ExCode1).HasDefaultValueSql("''");
            ////    b.Property(e => e.ExCode2).HasDefaultValueSql("''");
            ////    b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CoRate1H).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CoRate1G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate2H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate2G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate3H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate3G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate4H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate4G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate5H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate5G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.WarSerialNo).HasDefaultValueSql("(1)");
            ////});
            //#endregion

            //#region TRANSCDNHDR
            ////modelBuilder.Entity<DTO.Accounting.TRANSCDNHDR>(b =>
            ////{
            ////    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.BillNo, e.TransNo, });
            ////    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            ////    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            ////    b.Property(e => e.CashierID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ShiftCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TotalServer).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ServerID).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmpType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TillID).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransStartTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransEndTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransPayTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransSubTotal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransAmtRnd).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransAmtSave).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransAmtOrg).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransChgAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransDiscType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscValue).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransDiscAuth).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransDiscReasonCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransDiscRemark).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransAmtSpDisc).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransValueSpDisc).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.AuthSpDisc).HasDefaultValueSql("''");
            ////    b.Property(e => e.SpDiscReasonCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.SpDiscRemark).HasDefaultValueSql("''");
            ////    b.Property(e => e.CustomerID).HasDefaultValueSql("''");
            ////    b.Property(e => e.CustType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CustPrivilege).HasDefaultValueSql("''");
            ////    b.Property(e => e.AcctNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TotalPoints).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.InSvcID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransReasonCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransRemark).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransStatus).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Training).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Profiled).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.TblNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TblPax).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransPointsStatus).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransPoints).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            ////});
            //#endregion

            //#region TRANSCDNDTL
            ////modelBuilder.Entity<DTO.Accounting.TRANSCDNDTL>(b =>
            ////{
            ////    b.HasKey(e => new { e.BizLocID, e.TransNo, e.TransSeq, e.ItemCode, });
            ////    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            ////    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransSeq).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.RefSeq).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.IsCal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.BillNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.EntryTime).HasDefaultValueSql("''");
            ////    b.Property(e => e.StkCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.StkDesc).HasDefaultValueSql("''");
            ////    b.Property(e => e.StkType).HasDefaultValueSql("''");
            ////    b.Property(e => e.BehvType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ItemType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.UnitCost).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.OrgPrice).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.NettPrice).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.TolAmt).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.DiscAmt).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.NettAmt).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.SubPoints).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.Points).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.PriceOverrided).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Discounted).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Taxable).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ReturnCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.Remark).HasDefaultValueSql("''");
            ////    b.Property(e => e.SerialNo).HasDefaultValueSql("''");
            ////    b.Property(e => e.PriceAuthID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Posted).HasDefaultValueSql("''");
            ////    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            ////    b.Property(e => e.PrcDisplayType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.PromoCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.ExCode1).HasDefaultValueSql("''");
            ////    b.Property(e => e.ExCode2).HasDefaultValueSql("''");
            ////    b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CoRate1H).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CoRate1G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate2H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate2G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate3H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate3G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate4H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate4G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate5H).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CoRate5G).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.WarSerialNo).HasDefaultValueSql("(1)");
            ////});
            //#endregion

            //#region PROCTASK
            //modelBuilder.Entity<DTO.Accounting.PROCTASK>(b =>
            //{
            //    b.HasKey(e => new { e.ProSegID, e.TaskID, e.AgentID, e.TaskType, e.SubType, e.TaskStartDate, });
            //    b.Property(e => e.AgentID).HasDefaultValueSql("''");
            //    b.Property(e => e.TaskEndDate).HasDefaultValueSql("NULL");
            //    b.Property(e => e.TaskValue1).HasDefaultValueSql("''");
            //    b.Property(e => e.TaskValue2).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Result).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BatchNo).HasDefaultValueSql("''");
            //    b.Property(e => e.MsgID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransID).HasDefaultValueSql("''");
            //    b.Property(e => e.RecordLocator).HasDefaultValueSql("''");
            //    b.Property(e => e.QueueCode).HasDefaultValueSql("''");
            //    b.Property(e => e.CreatedDate).HasDefaultValueSql("NULL");
            //    b.Property(e => e.EmailType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.EmailAddress).HasDefaultValueSql("''");
            //    b.Property(e => e.ExpiryDate).HasDefaultValueSql("NULL");
            //    b.Property(e => e.Currency).HasDefaultValueSql("''");
            //    b.Property(e => e.BalanceDue).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PaymentAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransTotalAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AttemptCountSender).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AttemptCountSenderDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsSuccess).HasDefaultValueSql("(0)");
            //    b.Property(e => e.FinishedDate).HasDefaultValueSql("NULL");
            //    b.Property(e => e.FailedRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovedBy).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovedDate).HasDefaultValueSql("NULL");
            //    b.Property(e => e.UpdatedBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdatedDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //});
            //#endregion

            //#region SYSCODEB
            //modelBuilder.Entity<DTO.Accounting.SYSCODEB>(b =>
            //{
            //    b.HasKey(e => new { e.BranchID, e.SysCode, });
            //    b.Property(e => e.BranchID).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //});
            //#endregion

            //#region TRANSCDHDR
            //modelBuilder.Entity<DTO.Accounting.TRANSCDHDR>(b =>
            //{
            //    b.HasKey(e => new { e.MonthCode, e.PBTCode, e.BatchCode, });
            //    b.Property(e => e.MonthCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PBTCode).HasDefaultValueSql("''");
            //    b.Property(e => e.BatchCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransType).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.TotalRec1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec4).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec5).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt4).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt5).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region TRANSCDITEM
            //modelBuilder.Entity<DTO.Accounting.TRANSCDITEM>(b =>
            //{
            //    b.HasKey(e => new { e.MonthCode, e.PBTCode, e.BizRegID, e.BatchCode, e.SeqNo, });
            //    b.Property(e => e.MonthCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PBTCode).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.CompanyName).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractID).HasDefaultValueSql("''");
            //    b.Property(e => e.BatchCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CNDNDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("(1)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.Amount1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Amount2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark1).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark2).HasDefaultValueSql("''");
            //    b.Property(e => e.SvcType).HasDefaultValueSql("''");
            //    b.Property(e => e.ProcType).HasDefaultValueSql("''");
            //    b.Property(e => e.ErrCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Currency).HasDefaultValueSql("''");
            //    b.Property(e => e.FilePath).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region PURCHANSE ORDER
            //modelBuilder.Entity<Plexform.DTO.Accounting.PURCHASEORDERHDR>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.OrderNo, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderNo).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            //    b.Property(e => e.CashierID).HasDefaultValueSql("''");
            //    b.Property(e => e.EmpType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderStartTime).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderEndTime).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderSubTotal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderAmtRnd).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderAmtSave).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderAmtOrg).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderChgAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderDiscCode).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderDiscType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderDiscValue).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderDiscAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderDiscAuth).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderDiscReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderDiscRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderAmtSpDisc).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderValueSpDisc).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AuthSpDisc).HasDefaultValueSql("''");
            //    b.Property(e => e.SpDiscReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SpDiscRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.CustomerID).HasDefaultValueSql("''");
            //    b.Property(e => e.CustType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CustPrivilege).HasDefaultValueSql("''");
            //    b.Property(e => e.AcctNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TotalPoints).HasDefaultValueSql("(0)");
            //    b.Property(e => e.InSvcID).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Training).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Profiled).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OrderPoints).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<Plexform.DTO.Accounting.PURCHASEORDERDTL>(b =>
            //{
            //    b.HasKey(e => new { e.BizLocID, e.BizRegID, e.OrderNo, e.OrderSeq, e.ItemCode, });
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderNo).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.EntryTime).HasDefaultValueSql("''");
            //    b.Property(e => e.StkCode).HasDefaultValueSql("''");
            //    b.Property(e => e.StkDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.StkType).HasDefaultValueSql("''");
            //    b.Property(e => e.BehvType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitCost).HasDefaultValueSql("(1)");
            //    b.Property(e => e.OrgPrice).HasDefaultValueSql("(1)");
            //    b.Property(e => e.NettPrice).HasDefaultValueSql("(1)");
            //    b.Property(e => e.TolAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.DiscAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.NettAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.SubPoints).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Points).HasDefaultValueSql("(1)");
            //    b.Property(e => e.PriceOverrided).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Discounted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Taxable).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ReturnCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.SerialNo).HasDefaultValueSql("''");
            //    b.Property(e => e.PriceAuthID).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("''");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            //    b.Property(e => e.PrcDisplayType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PromoCode).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.ExCode1).HasDefaultValueSql("''");
            //    b.Property(e => e.ExCode2).HasDefaultValueSql("''");
            //    b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CoRate1H).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CoRate1G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate2H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate2G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate3H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate3G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate4H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate4G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate5H).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CoRate5G).HasDefaultValueSql("(1)");
            //    b.Property(e => e.WarSerialNo).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<Plexform.DTO.Accounting.SAP_PO>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.OrderNo, e.SupplierInvoice, e.OrderType, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderNo).HasDefaultValueSql("''");
            //    b.Property(e => e.SupplierInvoice).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderType).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderGroup).HasDefaultValueSql("''");
            //    b.Property(e => e.Description).HasDefaultValueSql("''");
            //    b.Property(e => e.OrderDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.OrderCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.ExchangeRate).HasDefaultValueSql("NULL");
            //    b.Property(e => e.OrderAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActionID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActionDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PostDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TID).HasDefaultValueSql("(2)");
            //    b.Property(e => e.POstatus).HasDefaultValueSql("''");
            //    b.Property(e => e.InvoiceStatus).HasDefaultValueSql("''");
            //});

            //#endregion

            //#endregion

            //#region PAYMENT

            //#region PAYMENTHDR
            //modelBuilder.Entity<DTO.Payment.PAYMENTHDR>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.PaymentTransID, e.PaymentRef, e.MerchantCode, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.PaymentTransID).HasDefaultValueSql("''");
            //    b.Property(e => e.PaymentRef).HasDefaultValueSql("''");
            //    b.Property(e => e.MerchantCode).HasDefaultValueSql("''");
            //    b.Property(e => e.BaseCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.TransCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.TransTotalAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransPaidAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDueAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ProductDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.UserName).HasDefaultValueSql("''");
            //    b.Property(e => e.UserEmail).HasDefaultValueSql("''");
            //    b.Property(e => e.UserContact).HasDefaultValueSql("''");
            //    b.Property(e => e.ResponseURL).HasDefaultValueSql("''");
            //    b.Property(e => e.AdditionalURL).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Signature).HasDefaultValueSql("''");
            //    b.Property(e => e.TransStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region PAYMENTDTL
            //modelBuilder.Entity<DTO.Payment.PAYMENTDTL>(b =>
            //{
            //    b.HasKey(e => new { e.BizLocID, e.BizRegID, e.PaymentID, e.TransRef, e.SeqNo, });
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.PaymentID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransRef).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.NextDueDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.NextDueAmount).HasDefaultValueSql("(1)");
            //    b.Property(e => e.RemindAttempt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsLatest).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AttemptCount).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RemindLog).HasDefaultValueSql("''");
            //    b.Property(e => e.LineTotal).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LineTax).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LineFee).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LineCharge).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LineVAT).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LineOth).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LineDisc).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LineGST).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Currency).HasDefaultValueSql("''");
            //    b.Property(e => e.IsOverride).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region PAYMENTTENDER
            //modelBuilder.Entity<DTO.Payment.PAYMENTTENDER>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.PaymentTransID, e.TenderID, e.TenderCode, e.SeqNo, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.PaymentTransID).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderID).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TenderType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MerchantCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderRef).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderDate).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.BaseCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.ExchgRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TenderAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.FeeType).HasDefaultValueSql("''");
            //    b.Property(e => e.FeeAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.PayAmt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.TransStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region PAYMENTLOG
            //modelBuilder.Entity<DTO.Payment.PAYMENTLOG>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.LogID, e.PaymentTransID, e.TenderID, e.TenderCode, e.SeqNo, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.LogID).HasDefaultValueSql("''");
            //    b.Property(e => e.PaymentTransID).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderID).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefNo).HasDefaultValueSql("''");
            //    b.Property(e => e.LogRef).HasDefaultValueSql("''");
            //    b.Property(e => e.Currency).HasDefaultValueSql("''");
            //    b.Property(e => e.LogAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AuthorizationCode).HasDefaultValueSql("''");
            //    b.Property(e => e.MerchantCode).HasDefaultValueSql("''");
            //    b.Property(e => e.BankCode).HasDefaultValueSql("''");
            //    b.Property(e => e.BankName).HasDefaultValueSql("''");
            //    b.Property(e => e.CheckSum).HasDefaultValueSql("''");
            //    b.Property(e => e.CheckSumString).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region TENDERTYPE
            //modelBuilder.Entity<DTO.Payment.TENDERTYPE>(b =>
            //{
            //    b.HasKey(e => new { e.TenderCode, });
            //    b.Property(e => e.TenderCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TenderType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TenderDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.EffDate).HasDefaultValueSql("''");
            //    b.Property(e => e.EndDate).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#endregion

            #region CREDIT
            modelBuilder.Entity<DTO.Credit.MASTERBALANCE>(b =>
            {
                b.HasKey(e => new { e.UserID, e.BizRegID, e.BizLocID, });
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("(0)");
                b.Property(e => e.Status).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            });
            #endregion

            //#region KA Approval
            ////#region EMPAPPROVER
            ////modelBuilder.Entity<DTO.Approval.KA.EMPAPPROVER>(b =>
            ////{
            ////    b.HasKey(e => new { e.EmployeeID, e.EmpApprID, });
            ////    b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmpApprID).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmpApprCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmpApprType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.EmpApprDesc).HasDefaultValueSql("''");
            ////    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            ////    b.Property(e => e.LocID).HasDefaultValueSql("''");
            ////    b.Property(e => e.Level).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.Ishost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////});
            ////#endregion

            ////#region LOARULES
            ////modelBuilder.Entity<DTO.Approval.KA.LOARULES>(b =>
            ////{
            ////    b.HasKey(e => new { e.RulesID, });
            ////    b.Property(e => e.RulesID).HasDefaultValueSql("''");
            ////    b.Property(e => e.RulesCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.RulesType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.EmpApprCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.RulesBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.RulesLvl).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            ////    b.Property(e => e.RulesReff).HasDefaultValueSql("''");
            ////    b.Property(e => e.LowerBudgetAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LowerUnBudgetAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LowerLimitCurrency).HasDefaultValueSql("''");
            ////    b.Property(e => e.LowerSign).HasDefaultValueSql("''");
            ////    b.Property(e => e.UpperBudgetAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.UpperUnBudgetAmt).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.UpperLimitCurrency).HasDefaultValueSql("''");
            ////    b.Property(e => e.LogicCondition).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.MinApprover).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            ////    b.Property(e => e.Seq).HasDefaultValueSql("''");
            ////    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            ////    b.Property(e => e.RoleID).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("NULL");
            ////    b.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.Ishost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.RejectAction).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ActionLink).HasDefaultValueSql("''");
            ////    b.Property(e => e.ReminderTemplate).HasDefaultValueSql("''");
            ////    b.Property(e => e.NotificationTemplate).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalTemplate).HasDefaultValueSql("''");
            ////    b.Property(e => e.RejectionTemplate).HasDefaultValueSql("''");
            ////    b.Property(e => e.ExpiryTemplate).HasDefaultValueSql("''");
            ////});
            ////#endregion

            ////#region APPTRAIL
            ////modelBuilder.Entity<DTO.Approval.KA.APPTRAIL>(b =>
            ////{
            ////    b.HasKey(e => new { e.ApprovalID, });
            ////    b.Property(e => e.ApprovalID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ProjectID).HasDefaultValueSql("''");
            ////    b.Property(e => e.RulesID).HasDefaultValueSql("''");
            ////    b.Property(e => e.RulesLvl).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.EmpApprID).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.RefID).HasDefaultValueSql("''");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.Ishost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.ActionLink).HasDefaultValueSql("''");
            ////});
            ////#endregion

            ////#region LOA
            ////modelBuilder.Entity<DTO.Approval.KA.LOA>(b =>
            ////{
            ////    b.HasKey(e => new { e.LOAID, });
            ////    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            ////    b.Property(e => e.LOACode).HasDefaultValueSql("''");
            ////    b.Property(e => e.LOAType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LOADesc).HasDefaultValueSql("''");
            ////    b.Property(e => e.ProjectID).HasDefaultValueSql("''");
            ////    b.Property(e => e.RulesID).HasDefaultValueSql("''");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.Ishost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////});
            ////#endregion

            ////#region TASKASSIGN
            ////modelBuilder.Entity<DTO.Approval.KA.TASKASSIGN>(b =>
            ////{
            ////    b.HasKey(e => new { e.TaskID, e.Seq, });
            ////    b.Property(e => e.TaskID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TaskCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ProjectID).HasDefaultValueSql("''");
            ////    b.Property(e => e.RulesID).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmpApprID).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.RefID).HasDefaultValueSql("''");
            ////    b.Property(e => e.Seq).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.Ishost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Remark).HasDefaultValueSql("NULL");
            ////});
            ////#endregion

            ////#region TASKLOG
            ////modelBuilder.Entity<DTO.Approval.KA.TASKLOG>(b =>
            ////{
            ////    b.HasKey(e => new { e.TaskID, });
            ////    b.Property(e => e.TaskID).HasDefaultValueSql("''");
            ////    b.Property(e => e.TaskCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.TaskType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ProjectID).HasDefaultValueSql("''");
            ////    b.Property(e => e.RulesID).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmpApprID).HasDefaultValueSql("''");
            ////    b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.RefID).HasDefaultValueSql("''");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            ////    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.Ishost).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////});
            ////#endregion

            ////#region ApprovalHDR
            ////modelBuilder.Entity<DTO.Approval.KA.ApprovalHDR>(b =>
            ////{
            ////    b.HasKey(e => new { e.ApprovalID, });
            ////    b.Property(e => e.ApprovalID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            ////    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalType).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ProjectID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.RefID).HasDefaultValueSql("''");
            ////    b.Property(e => e.AppObj).HasDefaultValueSql("''");
            ////    b.Property(e => e.AppDesc).HasDefaultValueSql("''");
            ////    b.Property(e => e.AppActionCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.AppAction).HasDefaultValueSql("''");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            ////});
            ////#endregion

            ////#region ApprovalDTL
            ////modelBuilder.Entity<DTO.Approval.KA.ApprovalDTL>(b =>
            ////{
            ////    b.HasKey(e => new { e.ApprovalID, });
            ////    b.Property(e => e.ApprovalID).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalCode).HasDefaultValueSql("''");
            ////    b.Property(e => e.ApprovalDetail).HasDefaultValueSql("''");
            ////    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            ////    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            ////    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            ////    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            ////});
            ////#endregion
            //#endregion

            //#region Approval

            //#region LOA
            //modelBuilder.Entity<DTO.Approval.LOA>(b =>
            //{
            //    b.HasKey(e => new { e.LOAID, });
            //    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            //    b.Property(e => e.LOACode).HasDefaultValueSql("''");
            //    b.Property(e => e.LOAType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LOADesc).HasDefaultValueSql("''");
            //    b.Property(e => e.ProjectID).HasDefaultValueSql("''");
            //    b.Property(e => e.RulesID).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RulesType).HasDefaultValueSql("(1)");
            //    b.Property(e => e.AppliedUrl).HasDefaultValueSql("''");
            //});

            //#endregion

            //#region LOARULES
            //modelBuilder.Entity<DTO.Approval.LOARULES>(b =>
            //{
            //    b.HasKey(e => new { e.RulesID, });
            //    b.Property(e => e.RulesID).HasDefaultValueSql("''");
            //    b.Property(e => e.RulesCode).HasDefaultValueSql("''");
            //    b.Property(e => e.RulesType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.EmpApprCode).HasDefaultValueSql("''");
            //    b.Property(e => e.RulesBy).HasDefaultValueSql("''");
            //    b.Property(e => e.RulesLvl).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            //    b.Property(e => e.RulesReff).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LowerBudgetAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LowerUnBudgetAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LowerSign).HasDefaultValueSql("''");
            //    b.Property(e => e.UpperSign).HasDefaultValueSql("''");
            //    b.Property(e => e.UpperBudgetAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UpperUnBudgetAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LogicCondition).HasDefaultValueSql("''");
            //    b.Property(e => e.MinApprover).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.Seq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.RoleID).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region TASKLOG
            //modelBuilder.Entity<DTO.Approval.TASKLOG>(b =>
            //{
            //    b.HasKey(e => new { e.TaskID, });
            //    b.Property(e => e.TaskID).HasDefaultValueSql("''");
            //    b.Property(e => e.TaskCode).HasDefaultValueSql("''");
            //    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovalID).HasDefaultValueSql("''");
            //    b.Property(e => e.ProjectID).HasDefaultValueSql("''");
            //    b.Property(e => e.RulesID).HasDefaultValueSql("''");
            //    b.Property(e => e.EmpApprID).HasDefaultValueSql("''");
            //    b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovalDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.RefID).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region APPTRAIL
            //modelBuilder.Entity<DTO.Approval.APPTRAIL>(b =>
            //{
            //    b.HasKey(e => new { e.ApprovalID, });
            //    b.Property(e => e.ApprovalID).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovalCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovalType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            //    b.Property(e => e.ProjectID).HasDefaultValueSql("''");
            //    b.Property(e => e.RulesID).HasDefaultValueSql("''");
            //    b.Property(e => e.RulesLvl).HasDefaultValueSql("(0)");
            //    b.Property(e => e.EmpApprID).HasDefaultValueSql("''");
            //    b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovalDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.RefID).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Seq).HasDefaultValueSql("(0)");
            //});
            //#endregion


            //#region TASKASSIGN
            //modelBuilder.Entity<DTO.Approval.TASKASSIGN>(b =>
            //{
            //    b.HasKey(e => new { e.TaskID, });
            //    b.Property(e => e.TaskID).HasDefaultValueSql("''");
            //    b.Property(e => e.TaskCode).HasDefaultValueSql("''");
            //    b.Property(e => e.LOAID).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovalID).HasDefaultValueSql("''");
            //    b.Property(e => e.ProjectID).HasDefaultValueSql("''");
            //    b.Property(e => e.RulesID).HasDefaultValueSql("''");
            //    b.Property(e => e.EmpApprID).HasDefaultValueSql("''");
            //    b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovalDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.RefID).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //});
            //#endregion
            //#endregion

            #region CORE
            #region ENTITY
            #region BIZCATEGORY
            modelBuilder.Entity<DTO.Core.Entity.BIZCATEGORY>(b =>
            {
                b.HasKey(e => new { e.CatgCode, });
                b.Property(e => e.CatgCode).HasDefaultValueSql("(1)");
                b.Property(e => e.CatgDesc).HasDefaultValueSql("''");
                b.Property(e => e.CatgShortDesc).HasDefaultValueSql("''");
                b.Property(e => e.Definition).HasDefaultValueSql("''");
                b.Property(e => e.Prefix).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            });
            #endregion

            #region BIZDOCUMENT
            modelBuilder.Entity<Plexform.DTO.Core.Entity.BIZDOCUMENT>(b =>
            {
                b.HasKey(e => new { e.DocCode, e.BizRegID, e.BizLocID, e.DocType, });
                b.Property(e => e.DocCode).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.DocType).HasDefaultValueSql("''");
                b.Property(e => e.DocMode).HasDefaultValueSql("(0)");
                b.Property(e => e.Duration).HasDefaultValueSql("(0)");
                b.Property(e => e.DocNo).HasDefaultValueSql("''");
                b.Property(e => e.Description).HasDefaultValueSql("''");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.PathRef).HasDefaultValueSql("''");
                b.Property(e => e.DataKey).HasDefaultValueSql("''");
                b.Property(e => e.Signature).HasDefaultValueSql("NULL");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(1)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region BIZENTITY
            modelBuilder.Entity<DTO.Core.Entity.BIZENTITY>(b =>
            {
                b.HasKey(e => new { e.BizRegID, });
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.CompanyName).HasDefaultValueSql("''");
                b.Property(e => e.InitName).HasDefaultValueSql("''");
                b.Property(e => e.CompanyType).HasDefaultValueSql("''");
                b.Property(e => e.RegDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.FileNo).HasDefaultValueSql("''");
                b.Property(e => e.RefNo1).HasDefaultValueSql("''");
                b.Property(e => e.RefNo2).HasDefaultValueSql("''");
                b.Property(e => e.Owner).HasDefaultValueSql("''");
                b.Property(e => e.ICNo).HasDefaultValueSql("''");
                b.Property(e => e.SubGrp).HasDefaultValueSql("''");
                b.Property(e => e.BizGrp).HasDefaultValueSql("(0)");
                b.Property(e => e.BizCatgID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegType).HasDefaultValueSql("(0)");
                b.Property(e => e.BizRegStatus).HasDefaultValueSql("(0)");
                b.Property(e => e.CommID).HasDefaultValueSql("''");
                b.Property(e => e.IndustryType).HasDefaultValueSql("''");
                b.Property(e => e.BusinessType).HasDefaultValueSql("''");
                b.Property(e => e.RegNo).HasDefaultValueSql("''");
                b.Property(e => e.StoreStatus).HasDefaultValueSql("(0)");
                b.Property(e => e.PrivilegeCode).HasDefaultValueSql("''");
                b.Property(e => e.Address1).HasDefaultValueSql("''");
                b.Property(e => e.Address2).HasDefaultValueSql("''");
                b.Property(e => e.Address3).HasDefaultValueSql("''");
                b.Property(e => e.Address4).HasDefaultValueSql("''");
                b.Property(e => e.Address5).HasDefaultValueSql("''");
                b.Property(e => e.WCAddress1).HasDefaultValueSql("''");
                b.Property(e => e.WCAddress2).HasDefaultValueSql("''");
                b.Property(e => e.WCAddress3).HasDefaultValueSql("''");
                b.Property(e => e.WCAddress4).HasDefaultValueSql("''");
                b.Property(e => e.PostalCode).HasDefaultValueSql("''");
                b.Property(e => e.Country).HasDefaultValueSql("''");
                b.Property(e => e.State).HasDefaultValueSql("''");
                b.Property(e => e.PBT).HasDefaultValueSql("''");
                b.Property(e => e.City).HasDefaultValueSql("''");
                b.Property(e => e.Area).HasDefaultValueSql("''");
                b.Property(e => e.TelNo).HasDefaultValueSql("''");
                b.Property(e => e.FaxNo).HasDefaultValueSql("''");
                b.Property(e => e.Email).HasDefaultValueSql("''");
                b.Property(e => e.CoWebsite).HasDefaultValueSql("''");
                b.Property(e => e.ContactPerson).HasDefaultValueSql("''");
                b.Property(e => e.ContactRace).HasDefaultValueSql("''");
                b.Property(e => e.ContactDesignation).HasDefaultValueSql("''");
                b.Property(e => e.ContactPersonEmail).HasDefaultValueSql("''");
                b.Property(e => e.ContactPersonTelNo).HasDefaultValueSql("''");
                b.Property(e => e.ContactPersonFaxNo).HasDefaultValueSql("''");
                b.Property(e => e.ContactPersonMobile).HasDefaultValueSql("''");
                b.Property(e => e.ContactPerson2).HasDefaultValueSql("''");
                b.Property(e => e.ContactDesignation2).HasDefaultValueSql("''");
                b.Property(e => e.ContactPersonEmail2).HasDefaultValueSql("''");
                b.Property(e => e.ContactPersonTelNo2).HasDefaultValueSql("''");
                b.Property(e => e.ContactPersonFaxNo2).HasDefaultValueSql("''");
                b.Property(e => e.ContactPersonMobile2).HasDefaultValueSql("''");
                b.Property(e => e.SMSAlertNo).HasDefaultValueSql("''");
                b.Property(e => e.AcctNo).HasDefaultValueSql("''");
                b.Property(e => e.AgrNo).HasDefaultValueSql("''");
                b.Property(e => e.AgrRenew).HasDefaultValueSql("(0)");
                b.Property(e => e.AcctNo2).HasDefaultValueSql("''");
                b.Property(e => e.AgrNo2).HasDefaultValueSql("''");
                b.Property(e => e.AgrRenew2).HasDefaultValueSql("(0)");
                b.Property(e => e.BankCode1).HasDefaultValueSql("''");
                b.Property(e => e.BankAccount1).HasDefaultValueSql("''");
                b.Property(e => e.BankCode2).HasDefaultValueSql("''");
                b.Property(e => e.BankAccount2).HasDefaultValueSql("''");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Remark2).HasDefaultValueSql("''");
                b.Property(e => e.ReqSupp).HasDefaultValueSql("(0)");
                b.Property(e => e.ReqNo).HasDefaultValueSql("''");
                b.Property(e => e.ReqCode).HasDefaultValueSql("''");
                b.Property(e => e.RefAmount1).HasDefaultValueSql("(0)");
                b.Property(e => e.RefAmount2).HasDefaultValueSql("(0)");
                b.Property(e => e.IsTermAgr).HasDefaultValueSql("(0)");
                b.Property(e => e.IsRateAgr).HasDefaultValueSql("(0)");
                b.Property(e => e.ImagePath).HasDefaultValueSql("''");
                b.Property(e => e.MediaUrl1).HasDefaultValueSql("''");
                b.Property(e => e.MediaUrl2).HasDefaultValueSql("''");
                b.Property(e => e.MediaUrl3).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.ApprovedBy).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.IsNew).HasDefaultValueSql("(1)");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.BizType).HasDefaultValueSql("(0)");
                b.Property(e => e.RefID).HasDefaultValueSql("''");
                b.Property(e => e.RefNo3).HasDefaultValueSql("''");
                b.Property(e => e.RefID2).HasDefaultValueSql("''");
            });
            #endregion

            #region BIZGROUP
            modelBuilder.Entity<DTO.Core.Entity.BIZGROUP>(b =>
            {
                b.HasKey(e => new { e.BizRegID, e.BizLocID, e.BizState, e.BizPBT, e.BizArea, });
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.BizState).HasDefaultValueSql("''");
                b.Property(e => e.BizPBT).HasDefaultValueSql("''");
                b.Property(e => e.BizArea).HasDefaultValueSql("''");
                b.Property(e => e.BizTery).HasDefaultValueSql("''");
                b.Property(e => e.BizGrp).HasDefaultValueSql("(0)");
                b.Property(e => e.ReqSupp).HasDefaultValueSql("(0)");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region BIZLOCATE
            modelBuilder.Entity<DTO.Core.Entity.BIZLOCATE>(b =>
            {
                b.HasKey(e => new { e.BizRegID, e.BizLocID, });
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.RefID).HasDefaultValueSql("''");
                b.Property(e => e.BranchType).HasDefaultValueSql("(1)");
                b.Property(e => e.BranchName).HasDefaultValueSql("''");
                b.Property(e => e.BranchCode).HasDefaultValueSql("''");
                b.Property(e => e.BizRegType).HasDefaultValueSql("(0)");
                b.Property(e => e.BizRegStatus).HasDefaultValueSql("(0)");
                b.Property(e => e.BizCatgID).HasDefaultValueSql("''");
                b.Property(e => e.CommID).HasDefaultValueSql("''");
                b.Property(e => e.IndustryType).HasDefaultValueSql("''");
                b.Property(e => e.BusinessType).HasDefaultValueSql("''");
                b.Property(e => e.AccNo).HasDefaultValueSql("''");
                b.Property(e => e.Address1).HasDefaultValueSql("''");
                b.Property(e => e.Address2).HasDefaultValueSql("''");
                b.Property(e => e.Address3).HasDefaultValueSql("''");
                b.Property(e => e.Address4).HasDefaultValueSql("''");
                b.Property(e => e.Address5).HasDefaultValueSql("''");
                b.Property(e => e.PostalCode).HasDefaultValueSql("''");
                b.Property(e => e.ContactPerson).HasDefaultValueSql("''");
                b.Property(e => e.ContactDesignation).HasDefaultValueSql("''");
                b.Property(e => e.ContactEmail).HasDefaultValueSql("''");
                b.Property(e => e.ContactTelNo).HasDefaultValueSql("''");
                b.Property(e => e.ContactMobile).HasDefaultValueSql("''");
                b.Property(e => e.BankName).HasDefaultValueSql("''");
                b.Property(e => e.BankAccount).HasDefaultValueSql("''");
                b.Property(e => e.StoreType).HasDefaultValueSql("''");
                b.Property(e => e.Email).HasDefaultValueSql("''");
                b.Property(e => e.Tel).HasDefaultValueSql("''");
                b.Property(e => e.Fax).HasDefaultValueSql("''");
                b.Property(e => e.Region).HasDefaultValueSql("''");
                b.Property(e => e.Country).HasDefaultValueSql("''");
                b.Property(e => e.State).HasDefaultValueSql("''");
                b.Property(e => e.PBT).HasDefaultValueSql("''");
                b.Property(e => e.City).HasDefaultValueSql("''");
                b.Property(e => e.Area).HasDefaultValueSql("''");
                b.Property(e => e.Currency).HasDefaultValueSql("''");
                b.Property(e => e.RefAmount1).HasDefaultValueSql("(0)");
                b.Property(e => e.RefAmount2).HasDefaultValueSql("(0)");
                b.Property(e => e.StoreStatus).HasDefaultValueSql("(0)");
                b.Property(e => e.OpPrevBook).HasDefaultValueSql("(0)");
                b.Property(e => e.OpTimeStart).HasDefaultValueSql("''");
                b.Property(e => e.OpTimeEnd).HasDefaultValueSql("''");
                b.Property(e => e.OpDay1).HasDefaultValueSql("(0)");
                b.Property(e => e.OpDay2).HasDefaultValueSql("(0)");
                b.Property(e => e.OpDay3).HasDefaultValueSql("(0)");
                b.Property(e => e.OpDay4).HasDefaultValueSql("(0)");
                b.Property(e => e.OpDay5).HasDefaultValueSql("(0)");
                b.Property(e => e.OpDay6).HasDefaultValueSql("(0)");
                b.Property(e => e.OpDay7).HasDefaultValueSql("(0)");
                b.Property(e => e.OpBookAlwDY).HasDefaultValueSql("(0)");
                b.Property(e => e.OpBookAlwHR).HasDefaultValueSql("(0)");
                b.Property(e => e.OpBookFirst).HasDefaultValueSql("''");
                b.Property(e => e.OpBookLast).HasDefaultValueSql("''");
                b.Property(e => e.OpBookIntv).HasDefaultValueSql("(0)");
                b.Property(e => e.SalesItemType).HasDefaultValueSql("''");
                b.Property(e => e.InSvcItemType).HasDefaultValueSql("''");
                b.Property(e => e.GenInSvcID).HasDefaultValueSql("(0)");
                b.Property(e => e.RcpHeader).HasDefaultValueSql("''");
                b.Property(e => e.RcpFooter).HasDefaultValueSql("''");
                b.Property(e => e.PriceLevel).HasDefaultValueSql("(0)");
                b.Property(e => e.CapacityLevel).HasDefaultValueSql("(0)");
                b.Property(e => e.IsStockTake).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.UnitID).HasDefaultValueSql("''");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
            });
            #endregion

            #region BIZMEMBER
            modelBuilder.Entity<DTO.Core.Entity.BIZMEMBER>(b =>
            {
                b.HasKey(e => new { e.BizRegID, e.BizLocID, e.MemberCode, });
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.MemberCode).HasDefaultValueSql("''");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region BIZITEM
            modelBuilder.Entity<DTO.Core.Entity.BIZITEM>(b =>
            {
                b.HasKey(e => new { e.BizRegID, e.BizLocID, e.ItemCode, e.SeqNo, });
                b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
                b.Property(e => e.ItemName).HasDefaultValueSql("''");
                b.Property(e => e.StorageID).HasDefaultValueSql("''");
                b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
                b.Property(e => e.ShortDesc).HasDefaultValueSql("''");
                b.Property(e => e.ItemComponent).HasDefaultValueSql("''");
                b.Property(e => e.TariffCode).HasDefaultValueSql("''");
                b.Property(e => e.OrgCountry).HasDefaultValueSql("''");
                b.Property(e => e.MATNo).HasDefaultValueSql("''");
                b.Property(e => e.MarkNo).HasDefaultValueSql("''");
                b.Property(e => e.ItmSize2).HasDefaultValueSql("''");
                b.Property(e => e.ItmSize1).HasDefaultValueSql("''");
                b.Property(e => e.ItmSize).HasDefaultValueSql("''");
                b.Property(e => e.ConSize).HasDefaultValueSql("(0)");
                b.Property(e => e.ConUOM).HasDefaultValueSql("''");
                b.Property(e => e.DefUOM).HasDefaultValueSql("''");
                b.Property(e => e.ClassType).HasDefaultValueSql("''");
                b.Property(e => e.TypeCode).HasDefaultValueSql("''");
                b.Property(e => e.BehvType).HasDefaultValueSql("(0)");
                b.Property(e => e.BehvShow).HasDefaultValueSql("(0)");
                b.Property(e => e.ComboItem).HasDefaultValueSql("(0)");
                b.Property(e => e.ItmCatgCode).HasDefaultValueSql("''");
                b.Property(e => e.ItmBrand).HasDefaultValueSql("''");
                b.Property(e => e.LooseUOM).HasDefaultValueSql("''");
                b.Property(e => e.PackUOM).HasDefaultValueSql("''");
                b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.IsSales).HasDefaultValueSql("(0)");
                b.Property(e => e.IsEmpDisc).HasDefaultValueSql("(0)");
                b.Property(e => e.IsRtnable).HasDefaultValueSql("(0)");
                b.Property(e => e.IsDisc).HasDefaultValueSql("(0)");
                b.Property(e => e.IsFOC).HasDefaultValueSql("(0)");
                b.Property(e => e.IsTaxable).HasDefaultValueSql("(0)");
                b.Property(e => e.AvgCost).HasDefaultValueSql("(0)");
                b.Property(e => e.StdCost).HasDefaultValueSql("(0)");
                b.Property(e => e.StdMarkup).HasDefaultValueSql("(0)");
                b.Property(e => e.StdSellPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.IsSelected).HasDefaultValueSql("(0)");
                b.Property(e => e.IsBestBuy).HasDefaultValueSql("(0)");
                b.Property(e => e.IsPurchase).HasDefaultValueSql("(0)");
                b.Property(e => e.IsWLength).HasDefaultValueSql("(0)");
                b.Property(e => e.IsRecycle).HasDefaultValueSql("(0)");
                b.Property(e => e.TrackSerial).HasDefaultValueSql("(0)");
                b.Property(e => e.MinQty).HasDefaultValueSql("(0)");
                b.Property(e => e.MaxQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ImageName).HasDefaultValueSql("''");
                b.Property(e => e.IncomingQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ReOrderLvl).HasDefaultValueSql("(0)");
                b.Property(e => e.ReOrderQty).HasDefaultValueSql("(0)");
                b.Property(e => e.QtyOnHand).HasDefaultValueSql("(0)");
                b.Property(e => e.QtySellable).HasDefaultValueSql("(0)");
                b.Property(e => e.QtyBalance).HasDefaultValueSql("(0)");
                b.Property(e => e.POQty).HasDefaultValueSql("(0)");
                b.Property(e => e.OutgoingQty).HasDefaultValueSql("(0)");
                b.Property(e => e.QtyAdj).HasDefaultValueSql("(0)");
                b.Property(e => e.FirstIn).HasDefaultValueSql("(0)");
                b.Property(e => e.LastIn).HasDefaultValueSql("(0)");
                b.Property(e => e.LastPO).HasDefaultValueSql("(0)");
                b.Property(e => e.LastOut).HasDefaultValueSql("(0)");
                b.Property(e => e.LastRV).HasDefaultValueSql("(0)");
                b.Property(e => e.CummQty).HasDefaultValueSql("(0)");
                b.Property(e => e.DayQty).HasDefaultValueSql("(0)");
                b.Property(e => e.LDayQty).HasDefaultValueSql("(0)");
                b.Property(e => e.MthQty).HasDefaultValueSql("(0)");
                b.Property(e => e.LMthQty).HasDefaultValueSql("(0)");
                b.Property(e => e.MtdQty).HasDefaultValueSql("(0)");
                b.Property(e => e.YrQty).HasDefaultValueSql("(0)");
                b.Property(e => e.LYrQty).HasDefaultValueSql("(0)");
                b.Property(e => e.YtdQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ExpiredQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ExpiryDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.ProcessDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            });
            #endregion

            #region EMPLOYEE
            modelBuilder.Entity<DTO.Core.Entity.EMPLOYEE>(b =>
            {
                b.HasKey(e => new { e.EmployeeID, e.BizRegID, });
                b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.LocID).HasDefaultValueSql("''");
                b.Property(e => e.EmployeeType).HasDefaultValueSql("(0)");
                b.Property(e => e.ReferralCode).HasDefaultValueSql("''");
                b.Property(e => e.ReferralID).HasDefaultValueSql("''");
                b.Property(e => e.NickName).HasDefaultValueSql("''");
                b.Property(e => e.SurName).HasDefaultValueSql("''");
                b.Property(e => e.FirstName).HasDefaultValueSql("''");
                b.Property(e => e.Salutation).HasDefaultValueSql("''");
                b.Property(e => e.Sex).HasDefaultValueSql("''");
                b.Property(e => e.PlaceOfBirth).HasDefaultValueSql("''");
                b.Property(e => e.NRICNo).HasDefaultValueSql("''");
                b.Property(e => e.Nationality).HasDefaultValueSql("''");
                b.Property(e => e.Race).HasDefaultValueSql("''");
                b.Property(e => e.Religion).HasDefaultValueSql("''");
                b.Property(e => e.Marital).HasDefaultValueSql("''");
                b.Property(e => e.CoAddress1).HasDefaultValueSql("''");
                b.Property(e => e.CoAddress2).HasDefaultValueSql("''");
                b.Property(e => e.CoAddress3).HasDefaultValueSql("''");
                b.Property(e => e.CoAddress4).HasDefaultValueSql("''");
                b.Property(e => e.CoPostalCode).HasDefaultValueSql("''");
                b.Property(e => e.CoState).HasDefaultValueSql("''");
                b.Property(e => e.CoCountry).HasDefaultValueSql("''");
                b.Property(e => e.PnAddress1).HasDefaultValueSql("''");
                b.Property(e => e.PnAddress2).HasDefaultValueSql("''");
                b.Property(e => e.PnAddress3).HasDefaultValueSql("''");
                b.Property(e => e.PnAddress4).HasDefaultValueSql("''");
                b.Property(e => e.PnPostalCode).HasDefaultValueSql("''");
                b.Property(e => e.PnState).HasDefaultValueSql("''");
                b.Property(e => e.PnCountry).HasDefaultValueSql("''");
                b.Property(e => e.EmerContactPerson).HasDefaultValueSql("''");
                b.Property(e => e.EmerContactNo).HasDefaultValueSql("''");
                b.Property(e => e.EmailAddress).HasDefaultValueSql("''");
                b.Property(e => e.Designation).HasDefaultValueSql("''");
                b.Property(e => e.ForeignLocal).HasDefaultValueSql("''");
                b.Property(e => e.CommID).HasDefaultValueSql("''");
                b.Property(e => e.Salary).HasDefaultValueSql("(0)");
                b.Property(e => e.OffDay).HasDefaultValueSql("(0)");
                b.Property(e => e.Overtime).HasDefaultValueSql("(0)");
                b.Property(e => e.Leave).HasDefaultValueSql("(0)");
                b.Property(e => e.Levy).HasDefaultValueSql("(0)");
                b.Property(e => e.Allergies).HasDefaultValueSql("''");
                b.Property(e => e.ClerkNo).HasDefaultValueSql("''");
                b.Property(e => e.TransportAllowance).HasDefaultValueSql("''");
                b.Property(e => e.ServiceAllowance).HasDefaultValueSql("''");
                b.Property(e => e.OtherAllowance).HasDefaultValueSql("''");
                b.Property(e => e.Remarks).HasDefaultValueSql("''");
                b.Property(e => e.PrivilegeCode).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.AccessLvl).HasDefaultValueSql("(0)");
                b.Property(e => e.LoginType).HasDefaultValueSql("(0)");
                b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
                b.Property(e => e.Department).HasDefaultValueSql("''");
                b.Property(e => e.FromTransporter).HasDefaultValueSql("(0)");
                b.Property(e => e.StatusAdd).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Position1).HasDefaultValueSql("''");
                b.Property(e => e.Position2).HasDefaultValueSql("''");
                b.Property(e => e.Role1).HasDefaultValueSql("''");
                b.Property(e => e.Role2).HasDefaultValueSql("''");
                b.Property(e => e.Role3).HasDefaultValueSql("''");
                b.Property(e => e.WorkerType).HasDefaultValueSql("(0)");
            });
            #endregion

            #region LICENSE
            modelBuilder.Entity<DTO.Core.Entity.LICENSE>(b =>
            {
                b.HasKey(e => new { e.ContractNo, e.CompanyID, });
                b.Property(e => e.ContractNo).HasDefaultValueSql("''");
                b.Property(e => e.CompanyID).HasDefaultValueSql("''");
                b.Property(e => e.ContType).HasDefaultValueSql("''");
                b.Property(e => e.ContCategory).HasDefaultValueSql("''");
                b.Property(e => e.InquiryNo).HasDefaultValueSql("''");
                b.Property(e => e.InquiryDate).HasDefaultValueSql("''");
                b.Property(e => e.CompletedDate).HasDefaultValueSql("''");
                b.Property(e => e.ValidityStart).HasDefaultValueSql("''");
                b.Property(e => e.ValidityEnd).HasDefaultValueSql("''");
                b.Property(e => e.FileNo).HasDefaultValueSql("''");
                b.Property(e => e.SchemeNo).HasDefaultValueSql("''");
                b.Property(e => e.RefNo).HasDefaultValueSql("''");
                b.Property(e => e.LocID).HasDefaultValueSql("''");
                b.Property(e => e.Country).HasDefaultValueSql("''");
                b.Property(e => e.State).HasDefaultValueSql("''");
                b.Property(e => e.PBT).HasDefaultValueSql("''");
                b.Property(e => e.City).HasDefaultValueSql("''");
                b.Property(e => e.Area).HasDefaultValueSql("''");
                b.Property(e => e.ComplianceNo).HasDefaultValueSql("''");
                b.Property(e => e.Compliance).HasDefaultValueSql("''");
                b.Property(e => e.Remark1).HasDefaultValueSql("''");
                b.Property(e => e.Remark2).HasDefaultValueSql("''");
                b.Property(e => e.Remark3).HasDefaultValueSql("''");
                b.Property(e => e.Remark4).HasDefaultValueSql("''");
                b.Property(e => e.Remark5).HasDefaultValueSql("''");
                b.Property(e => e.LicenceQty).HasDefaultValueSql("(0)");
                b.Property(e => e.DestinationID).HasDefaultValueSql("''");
                b.Property(e => e.LicenseNo).HasDefaultValueSql("''");
                b.Property(e => e.LicenseDate).HasDefaultValueSql("''");
                b.Property(e => e.PaymentAmount).HasDefaultValueSql("(0)");
                b.Property(e => e.PaymentDate).HasDefaultValueSql("''");
                b.Property(e => e.ReceiptNo).HasDefaultValueSql("''");
                b.Property(e => e.Renew).HasDefaultValueSql("(0)");
                b.Property(e => e.AuthID).HasDefaultValueSql("''");
                b.Property(e => e.AuthPOS).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.ApproveDate).HasDefaultValueSql("''");
                b.Property(e => e.ApproveBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
                b.Property(e => e.isHost).HasDefaultValueSql("(0)");
                b.Property(e => e.IDPREMIS).HasDefaultValueSql("''");
            });
            #endregion

            #region EMPBRANCH
            modelBuilder.Entity<DTO.Core.Entity.EMPBRANCH>(b =>
            {
                b.HasKey(e => new { e.EmployeeID, e.BizLocID, });
                b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.InAppt).HasDefaultValueSql("(1)");
                b.Property(e => e.IsServer).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            });
            #endregion

            #region USRPROFILE
            modelBuilder.Entity<DTO.Core.Entity.USRPROFILE>(b =>
            {
                b.HasKey(e => new { e.UserID, });
                b.Property(e => e.UserID).HasDefaultValueSql("''");
                b.Property(e => e.UserName).HasDefaultValueSql("''");
                b.Property(e => e.Password).HasDefaultValueSql("''");
                b.Property(e => e.RefID).HasDefaultValueSql("''");
                b.Property(e => e.RefType).HasDefaultValueSql("(0)");
                b.Property(e => e.ParentID).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.Logged).HasDefaultValueSql("(1)");
                b.Property(e => e.LogStation).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.RoleCode).HasDefaultValueSql("''");
                b.Property(e => e.IsShared).HasDefaultValueSql("(0)");
            });
            #endregion

            #region USRGROUP
            modelBuilder.Entity<DTO.Core.Entity.USRGROUP>(b =>
            {
                b.HasKey(e => new { e.APPID, e.GroupCode, });
                b.Property(e => e.GroupCode).HasDefaultValueSql("''");
                b.Property(e => e.GroupName).HasDefaultValueSql("''");
                b.Property(e => e.AccessLevel).HasDefaultValueSql("(1)");
                b.Property(e => e.Status).HasDefaultValueSql("(1)");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            });
            #endregion

            #region USRAPP
            modelBuilder.Entity<DTO.Core.Entity.USRAPP>(b =>
            {
                b.HasKey(e => new { e.UserID, e.AppID, });
                b.Property(e => e.UserID).HasDefaultValueSql("''");
                b.Property(e => e.AppID).HasDefaultValueSql("(1)");
                b.Property(e => e.AccessCode).HasDefaultValueSql("''");
                b.Property(e => e.IsInherit).HasDefaultValueSql("(1)");
                b.Property(e => e.PermissionAPI).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            });
            #endregion

            #region USRVERIFY
            modelBuilder.Entity<DTO.Core.Entity.USRVERIFY>(b =>
            {
                b.HasKey(e => new { e.UserID, e.VeriKey, });
                b.Property(e => e.VeriKey).HasDefaultValueSql("''");
                b.Property(e => e.UserType).HasDefaultValueSql("(1)");
                b.Property(e => e.KeyIndex).HasDefaultValueSql("(1)");
                b.Property(e => e.VeriCode).HasDefaultValueSql("(0)");
                b.Property(e => e.VeriType).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.Status).HasDefaultValueSql("(1)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.DeviceBrand).HasDefaultValueSql("''");
                b.Property(e => e.RejectRemark).HasDefaultValueSql("''");
            });
            #endregion

            #region ACCVERIFY
            modelBuilder.Entity<DTO.Core.Entity.ACCVERIFY>(b =>
            {
                b.HasKey(e => new { e.UserID, e.VeriKey, });
                b.Property(e => e.VeriKey).HasDefaultValueSql("''");
                b.Property(e => e.UserType).HasDefaultValueSql("(1)");
                b.Property(e => e.KeyIndex).HasDefaultValueSql("(1)");
                b.Property(e => e.VeriCode).HasDefaultValueSql("(0)");
                b.Property(e => e.VeriType).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.Status).HasDefaultValueSql("(1)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.DeviceBrand).HasDefaultValueSql("''");
                b.Property(e => e.RejectRemark).HasDefaultValueSql("''");
            });
            #endregion

            #region EMAIL
            modelBuilder.Entity<DTO.Core.Entity.EMAIL>(b =>
            {
                b.HasKey(e => new { e.BatchNo, e.MsgID, });
                b.Property(e => e.MsgID).HasDefaultValueSql("''");
                b.Property(e => e.TransID).HasDefaultValueSql("''");
                b.Property(e => e.AgentID).HasDefaultValueSql("''");
                b.Property(e => e.RecordLocator).HasDefaultValueSql("''");
                b.Property(e => e.QueueCode).HasDefaultValueSql("''");
                b.Property(e => e.CreatedDate).HasDefaultValueSql("NULL");
                b.Property(e => e.ExecutionID).HasDefaultValueSql("''");
                b.Property(e => e.EmailType).HasDefaultValueSql("(0)");
                b.Property(e => e.ExpiryDate).HasDefaultValueSql("NULL");
                b.Property(e => e.Currency).HasDefaultValueSql("''");
                b.Property(e => e.BalanceDue).HasDefaultValueSql("(0)");
                b.Property(e => e.PaymentAmt).HasDefaultValueSql("(0)");
                b.Property(e => e.TransTotalAmt).HasDefaultValueSql("(0)");
                b.Property(e => e.AttemptCountSender).HasDefaultValueSql("(0)");
                b.Property(e => e.AttemptCountSenderDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.EmailFailedRemark).HasDefaultValueSql("''");
                b.Property(e => e.IsSent).HasDefaultValueSql("(0)");
                b.Property(e => e.HelpLinePassword).HasDefaultValueSql("''");
                b.Property(e => e.EmailTemplate).HasDefaultValueSql("''");
                b.Property(e => e.NotifyDate).HasDefaultValueSql("NULL");
                b.Property(e => e.IsTemplateUpdated).HasDefaultValueSql("(0)");
                b.Property(e => e.ApprovedBy).HasDefaultValueSql("''");
                b.Property(e => e.ApprovedDate).HasDefaultValueSql("NULL");
                b.Property(e => e.UpdatedBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdatedDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("''");
            });
            #endregion

            #region BIZREFERENCE
            modelBuilder.Entity<Plexform.DTO.Core.Entity.BIZREFERENCE>(b =>
            {
                b.HasKey(e => new { e.BizRegID, e.BizLocID, e.DOEFileNo, });
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.DOEFileNo).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.Posted).HasDefaultValueSql("(1)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            });
            #endregion

            #region BIZRELATION
            modelBuilder.Entity<DTO.Core.Entity.BIZRELATION>(b =>
            {
                b.HasKey(e => new { e.BizRegID, e.PaxRegID, e.PaxUserID, e.TypeCode, });
                b.Property(e => e.TypeCode).HasDefaultValueSql("''");
                b.Property(e => e.IsApproved).HasDefaultValueSql("(0)");
                b.Property(e => e.ApprovedBy).HasDefaultValueSql("''");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region AbpUserProfile
            modelBuilder.Entity<DTO.Core.Entity.AbpUserProfile>(b =>
            {
                b.HasKey(e => new { e.UPFID, e.BizRegID, });
                b.Property(e => e.UPFID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.LocID).HasDefaultValueSql("''");
                b.Property(e => e.UPFType).HasDefaultValueSql("(0)");
                b.Property(e => e.ReferralCode).HasDefaultValueSql("''");
                b.Property(e => e.ReferralID).HasDefaultValueSql("''");
                b.Property(e => e.REFUSR).HasDefaultValueSql("''");
                b.Property(e => e.NickName).HasDefaultValueSql("''");
                b.Property(e => e.LastName).HasDefaultValueSql("''");
                b.Property(e => e.FirstName).HasDefaultValueSql("''");
                b.Property(e => e.Salutation).HasDefaultValueSql("''");
                b.Property(e => e.Sex).HasDefaultValueSql("''");
                b.Property(e => e.PlaceOfBirth).HasDefaultValueSql("''");
                b.Property(e => e.NRICNo).HasDefaultValueSql("''");
                b.Property(e => e.Nationality).HasDefaultValueSql("''");
                b.Property(e => e.Race).HasDefaultValueSql("''");
                b.Property(e => e.Religion).HasDefaultValueSql("''");
                b.Property(e => e.Marital).HasDefaultValueSql("''");
                b.Property(e => e.DirectNo).HasDefaultValueSql("''");
                b.Property(e => e.MobileNo).HasDefaultValueSql("''");
                b.Property(e => e.EmailAddress).HasDefaultValueSql("''");
                b.Property(e => e.Designation).HasDefaultValueSql("''");
                b.Property(e => e.CoAddress1).HasDefaultValueSql("''");
                b.Property(e => e.CoAddress2).HasDefaultValueSql("''");
                b.Property(e => e.CoAddress3).HasDefaultValueSql("''");
                b.Property(e => e.CoAddress4).HasDefaultValueSql("''");
                b.Property(e => e.CoPostalCode).HasDefaultValueSql("''");
                b.Property(e => e.CoState).HasDefaultValueSql("''");
                b.Property(e => e.CoCountry).HasDefaultValueSql("''");
                b.Property(e => e.PnAddress1).HasDefaultValueSql("''");
                b.Property(e => e.PnAddress2).HasDefaultValueSql("''");
                b.Property(e => e.PnAddress3).HasDefaultValueSql("''");
                b.Property(e => e.PnAddress4).HasDefaultValueSql("''");
                b.Property(e => e.PnPostalCode).HasDefaultValueSql("''");
                b.Property(e => e.PnState).HasDefaultValueSql("''");
                b.Property(e => e.PnCountry).HasDefaultValueSql("''");
                b.Property(e => e.EmerContactPerson).HasDefaultValueSql("''");
                b.Property(e => e.EmerContactNo).HasDefaultValueSql("''");
                b.Property(e => e.ForeignLocal).HasDefaultValueSql("''");
                b.Property(e => e.CommID).HasDefaultValueSql("''");
                b.Property(e => e.Salary).HasDefaultValueSql("(0)");
                b.Property(e => e.OffDay).HasDefaultValueSql("(0)");
                b.Property(e => e.Overtime).HasDefaultValueSql("(0)");
                b.Property(e => e.Leave).HasDefaultValueSql("(0)");
                b.Property(e => e.Levy).HasDefaultValueSql("(0)");
                b.Property(e => e.Allergies).HasDefaultValueSql("''");
                b.Property(e => e.ClerkNo).HasDefaultValueSql("''");
                b.Property(e => e.TransportAllowance).HasDefaultValueSql("''");
                b.Property(e => e.ServiceAllowance).HasDefaultValueSql("''");
                b.Property(e => e.OtherAllowance).HasDefaultValueSql("''");
                b.Property(e => e.Remarks).HasDefaultValueSql("''");
                b.Property(e => e.PrivilegeCode).HasDefaultValueSql("''");
                b.Property(e => e.AccessLvl).HasDefaultValueSql("(0)");
                b.Property(e => e.LoginType).HasDefaultValueSql("(0)");
                b.Property(e => e.Department).HasDefaultValueSql("''");
                b.Property(e => e.FromTransporter).HasDefaultValueSql("(0)");
                b.Property(e => e.StatusAdd).HasDefaultValueSql("(0)");
                b.Property(e => e.Position1).HasDefaultValueSql("''");
                b.Property(e => e.Position2).HasDefaultValueSql("''");
                b.Property(e => e.Role1).HasDefaultValueSql("''");
                b.Property(e => e.Role2).HasDefaultValueSql("''");
                b.Property(e => e.Role3).HasDefaultValueSql("''");
                b.Property(e => e.WorkerType).HasDefaultValueSql("(0)");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.EmailAdd2).HasDefaultValueSql("''");
                b.Property(e => e.EmailAdd3).HasDefaultValueSql("''");
                b.Property(e => e.ExtSocial1).HasDefaultValueSql("''");
                b.Property(e => e.ExtSocial2).HasDefaultValueSql("''");
                b.Property(e => e.ExtSocial3).HasDefaultValueSql("''");
                b.Property(e => e.ExtSocial4).HasDefaultValueSql("''");
                b.Property(e => e.ExtSocial5).HasDefaultValueSql("''");
                b.Property(e => e.ExtNote1).HasDefaultValueSql("''");
                b.Property(e => e.ExtNote2).HasDefaultValueSql("''");
                b.Property(e => e.ExtNote3).HasDefaultValueSql("''");
            });
            #endregion

            #endregion

            #region LOCATION
            #region COUNTRY
            modelBuilder.Entity<DTO.Core.Location.COUNTRY>(b =>
            {
                b.HasKey(e => new { e.CountryCode, });
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            });
            #endregion

            #region STATE
            modelBuilder.Entity<Plexform.DTO.Core.Location.STATE>(b =>
            {
                b.HasKey(e => new { e.CountryCode, e.StateCode, });
                b.Property(e => e.CountryCode).HasDefaultValueSql("''");
                b.Property(e => e.StateCode).HasDefaultValueSql("''");
                b.Property(e => e.RegionCode).HasDefaultValueSql("''");
                b.Property(e => e.OldStateCode).HasDefaultValueSql("''");
                b.Property(e => e.StateDesc).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.EmailState).HasDefaultValueSql("''");
            });
            #endregion

            #region AREA
            modelBuilder.Entity<DTO.Core.Location.AREA>(b =>
            {
                b.HasKey(e => new { e.CountryCode, e.StateCode, e.CityCode, e.AreaCode, });
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            });
            #endregion

            #region ZONE
            //modelBuilder.Entity<DTO.Core.Location.ZONE>(b =>
            //{
            //    b.HasKey(e => new { e.CountryCode, e.StateCode, e.PBTCode, e.SchemeNo, e.ZoneNo, });
            //    b.Property(e => e.CountryCode).HasDefaultValueSql("''");
            //    b.Property(e => e.StateCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PBTCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SchemeNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ZoneNo).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.ZoneDesc).HasDefaultValueSql("''");
            //});
            #endregion

            #region CITY
            modelBuilder.Entity<DTO.Core.Location.CITY>(b =>
            {
                b.HasKey(e => new { e.CountryCode, e.StateCode, e.CityCode, });
                b.Property(e => e.CountryCode).HasDefaultValueSql("''");
                b.Property(e => e.StateCode).HasDefaultValueSql("''");
                b.Property(e => e.CityCode).HasDefaultValueSql("''");
                b.Property(e => e.CityDesc).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            });
            #endregion

            #region
            modelBuilder.Entity<DTO.Core.Location.DISTRICT>(b =>
            {
                b.HasKey(e => new { e.CountryCode, e.StateCode, e.DistrictCode, });
                b.Property(e => e.CountryCode).HasDefaultValueSql("''");
                b.Property(e => e.StateCode).HasDefaultValueSql("''");
                b.Property(e => e.DistrictCode).HasDefaultValueSql("''");
                b.Property(e => e.DistrictDesc).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region PBT
            modelBuilder.Entity<DTO.Core.Location.PBT>(b =>
            {
                b.HasKey(e => new { e.CountryCode, e.StateCode, e.PBTCode, });
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            });
            #endregion
            #endregion

            #region MASTER
            #region APPMASTER
            modelBuilder.Entity<Plexform.DTO.Core.General.APPMASTER>(b =>
            {
                b.HasKey(e => new { e.AppID });
                b.Property(e => e.AppType).HasDefaultValueSql("(0)");
                b.Property(e => e.AppDesc).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region CODEMASTER
            modelBuilder.Entity<DTO.Core.General.CODEMASTER>(b =>
            {
                b.HasKey(e => new { e.CodeType, e.Code, });
                b.Property(e => e.CodeType).HasDefaultValueSql("''");
                b.Property(e => e.Code).HasDefaultValueSql("''");
                b.Property(e => e.CodeDesc).HasDefaultValueSql("''");
                b.Property(e => e.CodeRemark).HasDefaultValueSql("''");
                b.Property(e => e.CodeSeq).HasDefaultValueSql("(0)");
                b.Property(e => e.CodeRef).HasDefaultValueSql("''");
                b.Property(e => e.CodeVal1).HasDefaultValueSql("''");
                b.Property(e => e.CodeVal2).HasDefaultValueSql("''");
                b.Property(e => e.CodeVal3).HasDefaultValueSql("''");
                b.Property(e => e.SysCode).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.CodeNum).HasDefaultValueSql("(0)");
            });
            #endregion

            #region SYSPREFT
            modelBuilder.Entity<DTO.Core.General.SYSPREFT>(b =>
            {
                b.HasKey(e => new { e.AppID, e.GrpID, e.SYSKey, });
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            });
            #endregion

            #region SYSPREFB
            modelBuilder.Entity<DTO.Core.General.SYSPREFB>(b =>
            {
                b.HasKey(e => new { e.BranchID, e.SYSKey, });
                b.Property(e => e.SYSValue).HasDefaultValueSql("''");
                b.Property(e => e.SYSSet).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            });
            #endregion

            #region CURRENCY
            modelBuilder.Entity<DTO.Core.General.CURRENCY>(b =>
            {
                b.HasKey(e => new { e.CountryCode, e.CurrencyCode, });
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region CODENUM
            modelBuilder.Entity<DTO.Core.General.CODENUM>(b =>
            {
                b.HasKey(e => new { e.CodeType, e.Code, });
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            });
            #endregion

            #region SIC
            //modelBuilder.Entity<DTO.Core.Base.SIC>(b =>
            //{
            //    b.HasKey(e => new { e.SICCode, });
            //    b.Property(e => e.SICCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SICDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.SICDescEng).HasDefaultValueSql("''");
            //    b.Property(e => e.SICType).HasDefaultValueSql("''");
            //    b.Property(e => e.CapacityLevel).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            #endregion

            #region SUBSIC
            //modelBuilder.Entity<DTO.Core.Base.SUBSIC>(b =>
            //{
            //    b.HasKey(e => new { e.SICCode, e.SUBSICCode, });
            //    b.Property(e => e.SICCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SUBSICCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SUBSICDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.SICType).HasDefaultValueSql("''");
            //    b.Property(e => e.OldSIC).HasDefaultValueSql("''");
            //    b.Property(e => e.PremiseCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PremiseType).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            #endregion            

            #region PROJECT
            modelBuilder.Entity<DTO.Core.General.PROJECT>(b =>
            {
                b.HasKey(e => new { e.ProjectID, });
                b.Property(e => e.ProjectID).HasDefaultValueSql("''");
                b.Property(e => e.ProjectCode).HasDefaultValueSql("''");
                b.Property(e => e.ProjectType).HasDefaultValueSql("(0)");
                b.Property(e => e.ProjectDesc).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.Ishost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(0)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(0)");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
            });
            #endregion

            #region PFI
            modelBuilder.Entity<DTO.Core.General.PFI>(b =>
            {
                b.HasKey(e => new { e.BatchCode, e.SeqNo, });
                b.Property(e => e.BatchCode).HasDefaultValueSql("''");
                b.Property(e => e.SeqNo).HasDefaultValueSql("''");
                b.Property(e => e.Distributor).HasDefaultValueSql("''");
                b.Property(e => e.BatchDate).HasDefaultValueSql("''");
                b.Property(e => e.ErrorCode).HasDefaultValueSql("''");
                b.Property(e => e.FileName).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("''");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("''");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("''");
                b.Property(e => e.Inuse).HasDefaultValueSql("''");
                b.Property(e => e.TID).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("''");
                b.Property(e => e.Flag).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("''");
            });
            #endregion
            #endregion

            #region MAMEE
            modelBuilder.Entity<DTO.Core.General.PRODUCTISMUPLOAD>(b =>
            {
                b.HasKey(e => new { e.LastUpdate, e.Code, });
                b.Property(e => e.Code).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.SysCode).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.CodeNum).HasDefaultValueSql("(0)");
            });
            #endregion

            #region QUESTIONNAIRE

            #region QUESTIONDTL
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.QUESTIONDTL>(b =>
            {
                b.HasKey(e => new { e.QuizID, e.BizRegID, e.BizLocID, e.SecNo, });
                b.Property(e => e.QuizID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.SecNo).HasDefaultValueSql("(0)");
                b.Property(e => e.QuizType).HasDefaultValueSql("''");
                b.Property(e => e.Role).HasDefaultValueSql("''");
                b.Property(e => e.Description).HasDefaultValueSql("''");
                b.Property(e => e.ParentID).HasDefaultValueSql("''");
                b.Property(e => e.TotalQty).HasDefaultValueSql("(0)");
                b.Property(e => e.DocReq).HasDefaultValueSql("(0)");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region QUESTIONHDR
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.QUESTIONHDR>(b =>
            {
                b.HasKey(e => new { e.QuizID, e.BizRegID, e.BizLocID, });
                b.Property(e => e.QuizType).HasDefaultValueSql("''");
                b.Property(e => e.Role).HasDefaultValueSql("''");
                b.Property(e => e.ScoreWeight).HasDefaultValueSql("(0)");
                b.Property(e => e.Description).HasDefaultValueSql("''");
                b.Property(e => e.ParentID).HasDefaultValueSql("''");
                b.Property(e => e.DocReq).HasDefaultValueSql("(0)");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.TID).HasDefaultValueSql("''");
            });
            #endregion

            #region Question Group
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.QUESTIONGROUP>(b =>
            {
                b.HasKey(e => new { e.QuizID, e.BizRegID, e.BizLocID, e.SecNo, e.GrpNo, });
                b.Property(e => e.QuizID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.SecNo).HasDefaultValueSql("(0)");
                b.Property(e => e.GrpNo).HasDefaultValueSql("(0)");
                b.Property(e => e.QuizType).HasDefaultValueSql("''");
                b.Property(e => e.QuizValue).HasDefaultValueSql("''");
                b.Property(e => e.OptType).HasDefaultValueSql("''");
                b.Property(e => e.OptValue).HasDefaultValueSql("''");
                b.Property(e => e.ScoreWeight).HasDefaultValueSql("NULL");
                b.Property(e => e.Description).HasDefaultValueSql("''");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region QUESTIONITEM
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.QUESTIONITEM>(b =>
            {
                b.HasKey(e => new { e.QuizID, e.BizRegID, e.BizLocID, e.SecNo, e.GrpNo, e.SeqNo, });
                b.Property(e => e.QuizID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.SecNo).HasDefaultValueSql("(0)");
                b.Property(e => e.GrpNo).HasDefaultValueSql("(0)");
                b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
                b.Property(e => e.QuizType).HasDefaultValueSql("''");
                b.Property(e => e.QuizValue).HasDefaultValueSql("''");
                b.Property(e => e.OptType).HasDefaultValueSql("''");
                b.Property(e => e.OptValue).HasDefaultValueSql("''");
                b.Property(e => e.ScoreWeight).HasDefaultValueSql("NULL");
                b.Property(e => e.Description).HasDefaultValueSql("''");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region questionpaxscore
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.QUESTIONPAXSCORE>(b =>
            {
                b.HasKey(e => new { e.QuizID, e.BizRegID, e.BizLocID, e.PaxRegID, e.PaxLocID, e.ParentID, e.SecNo, e.GrpNo, e.SeqNo, e.UserID, e.TransNo, });
                b.Property(e => e.QuizID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.PaxRegID).HasDefaultValueSql("''");
                b.Property(e => e.PaxLocID).HasDefaultValueSql("''");
                b.Property(e => e.ParentID).HasDefaultValueSql("''");
                b.Property(e => e.SecNo).HasDefaultValueSql("(0)");
                b.Property(e => e.GrpNo).HasDefaultValueSql("(0)");
                b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
                b.Property(e => e.UserID).HasDefaultValueSql("(0)");
                b.Property(e => e.TransNo).HasDefaultValueSql("''");
                b.Property(e => e.ReviewedBy).HasDefaultValueSql("''");
                b.Property(e => e.Score).HasDefaultValueSql("(0)");
                b.Property(e => e.ScoreDefault).HasDefaultValueSql("(0)");
                b.Property(e => e.DocNo).HasDefaultValueSql("''");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Note).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region QUESTIONPAX
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.QUESTIONPAX>(b =>
            {
                b.HasKey(e => new { e.QuizID, e.BizRegID, e.BizLocID, e.PaxRegID, e.PaxLocID, e.ParentID, e.SecNo, e.UserID, e.TransNo, });
                b.Property(e => e.QuizID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.PaxRegID).HasDefaultValueSql("''");
                b.Property(e => e.PaxLocID).HasDefaultValueSql("''");
                b.Property(e => e.ParentID).HasDefaultValueSql("''");
                b.Property(e => e.SecNo).HasDefaultValueSql("(0)");
                b.Property(e => e.UserID).HasDefaultValueSql("(0)");
                b.Property(e => e.TransNo).HasDefaultValueSql("''");
                b.Property(e => e.QuizType).HasDefaultValueSql("''");
                b.Property(e => e.TotalAmt).HasDefaultValueSql("(0)");
                b.Property(e => e.TotalQty).HasDefaultValueSql("(0)");
                b.Property(e => e.Response).HasDefaultValueSql("''");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region QUESTIONPAXITEM
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.QUESTIONPAXITEM>(b =>
            {
                b.HasKey(e => new { e.QuizID, e.BizRegID, e.BizLocID, e.PaxRegID, e.PaxLocID, e.ParentID, e.SecNo, e.GrpNo, e.SeqNo, e.UserID, e.TransNo, });
                b.Property(e => e.QuizID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.PaxRegID).HasDefaultValueSql("''");
                b.Property(e => e.PaxLocID).HasDefaultValueSql("''");
                b.Property(e => e.ParentID).HasDefaultValueSql("''");
                b.Property(e => e.SecNo).HasDefaultValueSql("(0)");
                b.Property(e => e.GrpNo).HasDefaultValueSql("(0)");
                b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
                b.Property(e => e.UserID).HasDefaultValueSql("(0)");
                b.Property(e => e.TransNo).HasDefaultValueSql("''");
                b.Property(e => e.OptType).HasDefaultValueSql("''");
                b.Property(e => e.Value).HasDefaultValueSql("''");
                b.Property(e => e.DocNo).HasDefaultValueSql("''");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Note).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region QUESTIONPAXSUM
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.QUESTIONPAXSUM>(b =>
            {
                b.HasKey(e => new { e.QuizID, e.BizRegID, e.BizLocID, e.PaxRegID, e.PaxLocID, e.ParentID, });
                b.Property(e => e.QuizType).HasDefaultValueSql("''");
                b.Property(e => e.TotalAmt).HasDefaultValueSql("(0)");
                b.Property(e => e.TotalQty).HasDefaultValueSql("(0)");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ANSWEROPT
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.ANSWEROPT>(b =>
            {
                b.HasKey(e => new { e.OptID, e.BizRegID, e.BizLocID, });
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ANSWERGROUP
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.ANSWERGROUP>(b =>
            {
                b.HasKey(e => new { e.GroupID, e.BizRegID, e.BizLocID, });
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ANSWEROPTGROUP
            modelBuilder.Entity<Plexform.DTO.Core.Questionnaire.ANSWEROPTGROUP>(b =>
            {
                b.HasKey(e => new { e.GroupID, e.BizRegID, e.BizLocID, e.OptID, });
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #endregion
            #endregion

            //#region CROSSMARQ
            //#region Campaign
            //#region CAMPAIGNDOCUMENT
            //modelBuilder.Entity<DTO.CrossmarQ.Campaign.CAMPAIGNDOCUMENT>(b =>
            //{
            //    b.HasKey(e => new { e.BizLocID, e.BizRegID, e.CampNo, e.DocNo, e.SeqNo, e.LineCode, });
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("''");
            //    b.Property(e => e.LineCode).HasDefaultValueSql("''");
            //    b.Property(e => e.DocCode).HasDefaultValueSql("''");
            //    b.Property(e => e.DocType).HasDefaultValueSql("''");
            //    b.Property(e => e.DocMode).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Name).HasDefaultValueSql("''");
            //    b.Property(e => e.Description).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateMethod).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.PathRef).HasDefaultValueSql("''");
            //    b.Property(e => e.URLRef).HasDefaultValueSql("''");
            //    b.Property(e => e.Signature).HasDefaultValueSql("NULL");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region CAMPAIGNDTL
            //modelBuilder.Entity<DTO.CrossmarQ.Campaign.CAMPAIGNDTL>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.CampNo, e.SeqNo, e.LineCode, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.CampNo).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LineCode).HasDefaultValueSql("''");
            //    b.Property(e => e.LineType).HasDefaultValueSql("''");
            //    b.Property(e => e.LineName).HasDefaultValueSql("''");
            //    b.Property(e => e.LineDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.LineImage).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChangedBy_B).HasDefaultValueSql("''");
            //    b.Property(e => e.UnitPriceReq_B).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChangedBy_C).HasDefaultValueSql("''");
            //    b.Property(e => e.UnitPriceReq_C).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region CAMPAIGNHDR
            //modelBuilder.Entity<DTO.CrossmarQ.Campaign.CAMPAIGNHDR>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.TransNo, e.CampNo, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            //    b.Property(e => e.CampNo).HasDefaultValueSql("''");
            //    b.Property(e => e.CampType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Description).HasDefaultValueSql("''");
            //    b.Property(e => e.CustomerID).HasDefaultValueSql("''");
            //    b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
            //    b.Property(e => e.CampOrgAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CampDisc).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalCampAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ApprovedBy).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovedBy_B).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region CAMPAIGNITEM
            //modelBuilder.Entity<Plexform.DTO.CrossmarQ.Campaign.CAMPAIGNITEM>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.CampNo, e.SeqNo, e.ItemCode, e.PackageCode, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.CampNo).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PackageCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemDesc_B).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemName).HasDefaultValueSql("''");
            //    b.Property(e => e.LineCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UOM).HasDefaultValueSql("''");
            //    b.Property(e => e.CurrencyBase).HasDefaultValueSql("''");
            //    b.Property(e => e.ExchangeRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceBase).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalPriceBase).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CurrencyReq).HasDefaultValueSql("''");
            //    b.Property(e => e.UnitPriceReq_B).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReq_C).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChangedBy_B).HasDefaultValueSql("''");
            //    b.Property(e => e.ChangedBy_C).HasDefaultValueSql("''");
            //    b.Property(e => e.QtyReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceRReq).HasDefaultValueSql("''");
            //    b.Property(e => e.QtyRmrkReq).HasDefaultValueSql("''");
            //    b.Property(e => e.TaxAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.DiscAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SubTotalReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalPriceReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PointReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PointRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceRRef).HasDefaultValueSql("''");
            //    b.Property(e => e.QtyRmrkRef).HasDefaultValueSql("''");
            //    b.Property(e => e.TotalPriceRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceAdd).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceAvg).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceAvgVar).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReqVar).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Variance).HasDefaultValueSql("(0)");
            //    b.Property(e => e.VatAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AppInfo1).HasDefaultValueSql("''");
            //    b.Property(e => e.AppInfo2).HasDefaultValueSql("''");
            //    b.Property(e => e.Mechanic).HasDefaultValueSql("''");
            //    b.Property(e => e.UOMRef).HasDefaultValueSql("''");
            //    b.Property(e => e.UnitPriceCamp).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefNo).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo_B).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region CAMPAIGNITEMSUPP
            //modelBuilder.Entity<DTO.CrossmarQ.Campaign.CAMPAIGNITEMSUPP>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.CampNo, e.SeqNo, e.PackageCode, e.ItemCode, });
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PackageCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemName).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UOM).HasDefaultValueSql("''");
            //    b.Property(e => e.UnitPriceBase).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CurrencyReq).HasDefaultValueSql("''");
            //    b.Property(e => e.QtyReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReq_B).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReq_C).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChangedBy_B).HasDefaultValueSql("''");
            //    b.Property(e => e.ChangedBy_C).HasDefaultValueSql("''");
            //    b.Property(e => e.DiscAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TaxAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //});
            //#endregion

            //#region CAMPAIGNAFFILIATE
            //modelBuilder.Entity<DTO.CrossmarQ.Campaign.CAMPAIGNAFFILIATE>(b =>
            //{
            //    b.HasKey(e => new { e.BizLocID, e.BizRegID, e.CampNo, e.DocNo, e.SeqNo, e.LineCode, });
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("''");
            //    b.Property(e => e.LineCode).HasDefaultValueSql("''");
            //    b.Property(e => e.DocCode).HasDefaultValueSql("''");
            //    b.Property(e => e.DocType).HasDefaultValueSql("''");
            //    b.Property(e => e.DocMode).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Name).HasDefaultValueSql("''");
            //    b.Property(e => e.Description).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateMethod).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.PathRef).HasDefaultValueSql("''");
            //    b.Property(e => e.URLRef).HasDefaultValueSql("''");
            //    b.Property(e => e.Signature).HasDefaultValueSql("NULL");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion


            //#endregion

            //#region Affiliate
            //#region IMPRESSION
            //modelBuilder.Entity<DTO.CrossmarQ.Affiliate.IMPRESSION>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.UniqueID, e.ImpressionID, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.UniqueID).HasDefaultValueSql("''");
            //    b.Property(e => e.ImpressionID).HasDefaultValueSql("''");
            //    b.Property(e => e.CampNo).HasDefaultValueSql("''");
            //    b.Property(e => e.PackageCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ImpressionNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ClickNo).HasDefaultValueSql("''");
            //    b.Property(e => e.SubmitNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ApproveNo).HasDefaultValueSql("''");
            //    b.Property(e => e.Validated).HasDefaultValueSql("''");
            //    b.Property(e => e.UserID).HasDefaultValueSql("''");
            //    b.Property(e => e.ImpressionType).HasDefaultValueSql("''");
            //    b.Property(e => e.ImpressionCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //});
            //#endregion

            //#region IMPRESSIONPROGRESS
            //modelBuilder.Entity<DTO.CrossmarQ.Affiliate.IMPRESSIONPROGRESS>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.UniqueID, e.ImpressionID, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.UniqueID).HasDefaultValueSql("''");
            //    b.Property(e => e.ImpressionID).HasDefaultValueSql("''");
            //    b.Property(e => e.CampNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ClickNo).HasDefaultValueSql("''");
            //    b.Property(e => e.SubmitNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ApproveNo).HasDefaultValueSql("''");
            //    b.Property(e => e.Validated).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UserID).HasDefaultValueSql("''");
            //    b.Property(e => e.ImpressionType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ImpressionCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.Ishost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //});
            //#endregion

            //#region LOGEVENT
            //modelBuilder.Entity<DTO.CrossmarQ.Affiliate.LOGEVENT>(b =>
            //{
            //    b.HasKey(e => new { e.EventID, });
            //    b.Property(e => e.EventID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.EventType).HasDefaultValueSql("''");
            //    b.Property(e => e.EventDescription).HasDefaultValueSql("''");
            //    b.Property(e => e.Browser).HasDefaultValueSql("''");
            //    b.Property(e => e.IP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.StartTime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ScheduleID).HasDefaultValueSql("''");
            //    b.Property(e => e.ScheduleType).HasDefaultValueSql("''");
            //    b.Property(e => e.EndTime).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Source).HasDefaultValueSql("''");
            //    b.Property(e => e.Destination).HasDefaultValueSql("''");
            //    b.Property(e => e.SuccessExec).HasDefaultValueSql("''");
            //    b.Property(e => e.ExecMessage).HasDefaultValueSql("''");
            //    b.Property(e => e.BusinessObject).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.ErrorMessage).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreatedBy).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //});
            //#endregion
            //#endregion

            //#endregion

            #region INVENTORY

            #region CUSTOMER
            modelBuilder.Entity<DTO.Core.Entity.CUSTOMER>(b =>
            {
                b.HasKey(e => new { e.CustomerID, e.BizRegID, e.BizLocID, });
                b.Property(e => e.CustomerID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.BranchID).HasDefaultValueSql("''");
                b.Property(e => e.CategoryID).HasDefaultValueSql("''");
                b.Property(e => e.PrivilegeCode).HasDefaultValueSql("''");
                b.Property(e => e.CustType).HasDefaultValueSql("''");
                b.Property(e => e.Salutation).HasDefaultValueSql("''");
                b.Property(e => e.Surname).HasDefaultValueSql("''");
                b.Property(e => e.FirstName).HasDefaultValueSql("''");
                b.Property(e => e.NRICNo).HasDefaultValueSql("''");
                b.Property(e => e.Address1).HasDefaultValueSql("''");
                b.Property(e => e.Address2).HasDefaultValueSql("''");
                b.Property(e => e.Address3).HasDefaultValueSql("''");
                b.Property(e => e.Address4).HasDefaultValueSql("''");
                b.Property(e => e.PostalCode).HasDefaultValueSql("''");
                b.Property(e => e.State).HasDefaultValueSql("''");
                b.Property(e => e.Country).HasDefaultValueSql("''");
                b.Property(e => e.DOB).HasDefaultValueSql("''");
                b.Property(e => e.Sex).HasDefaultValueSql("''");
                b.Property(e => e.Race).HasDefaultValueSql("''");
                b.Property(e => e.Religion).HasDefaultValueSql("''");
                b.Property(e => e.Nationality).HasDefaultValueSql("''");
                b.Property(e => e.Marital).HasDefaultValueSql("''");
                b.Property(e => e.Occupation).HasDefaultValueSql("''");
                b.Property(e => e.HomeTel).HasDefaultValueSql("''");
                b.Property(e => e.OfficeTel).HasDefaultValueSql("''");
                b.Property(e => e.FaxNo).HasDefaultValueSql("''");
                b.Property(e => e.MobileNo).HasDefaultValueSql("''");
                b.Property(e => e.Email).HasDefaultValueSql("''");
                b.Property(e => e.LoyaltyMember).HasDefaultValueSql("''");
                b.Property(e => e.MemberID).HasDefaultValueSql("''");
                b.Property(e => e.AccumPoints).HasDefaultValueSql("''");
                b.Property(e => e.RefID).HasDefaultValueSql("''");
                b.Property(e => e.Remarks).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.CommID).HasDefaultValueSql("''");
                b.Property(e => e.IsEmployee).HasDefaultValueSql("''");
                b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
                b.Property(e => e.CrAccNo).HasDefaultValueSql("''");
                b.Property(e => e.FeedBack).HasDefaultValueSql("''");
                b.Property(e => e.Referral).HasDefaultValueSql("''");
                b.Property(e => e.RefInfo).HasDefaultValueSql("''");
                b.Property(e => e.IMAGE).HasDefaultValueSql("''");
                b.Property(e => e.Expiry).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.isHost).HasDefaultValueSql("(0)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.TID).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.Status1).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ITEM
            modelBuilder.Entity<DTO.Inventory.ITEM>(b =>
            {
                b.HasKey(e => new { e.ItemCode, });
                b.Property(e => e.ItemCode).HasDefaultValueSql("''");
                b.Property(e => e.ItmCatgCode).HasDefaultValueSql("''");
                b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
                b.Property(e => e.ShortDesc).HasDefaultValueSql("''");
                b.Property(e => e.ItmBrand).HasDefaultValueSql("''");
                b.Property(e => e.TypeCode).HasDefaultValueSql("''");
                b.Property(e => e.ItmSize).HasDefaultValueSql("''");
                b.Property(e => e.ActType).HasDefaultValueSql("''");
                b.Property(e => e.BehvType).HasDefaultValueSql("(0)");
                b.Property(e => e.ClassType).HasDefaultValueSql("''");
                b.Property(e => e.RegType).HasDefaultValueSql("(0)");
                b.Property(e => e.TariffCode).HasDefaultValueSql("''");
                b.Property(e => e.OrgCountry).HasDefaultValueSql("''");
                b.Property(e => e.MATNo).HasDefaultValueSql("''");
                b.Property(e => e.MarkNo).HasDefaultValueSql("(1)");
                b.Property(e => e.ItmSize1).HasDefaultValueSql("''");
                b.Property(e => e.ItmSize2).HasDefaultValueSql("''");
                b.Property(e => e.ConSize).HasDefaultValueSql("(1)");
                b.Property(e => e.ConUOM).HasDefaultValueSql("''");
                b.Property(e => e.DefUOM).HasDefaultValueSql("''");
                b.Property(e => e.BehvShow).HasDefaultValueSql("(0)");
                b.Property(e => e.ComboItem).HasDefaultValueSql("(0)");
                b.Property(e => e.FreqNum).HasDefaultValueSql("(0)");
                b.Property(e => e.FreqType).HasDefaultValueSql("''");
                b.Property(e => e.LooseUOM).HasDefaultValueSql("''");
                b.Property(e => e.PackUOM).HasDefaultValueSql("''");
                b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.IsSales).HasDefaultValueSql("(0)");
                b.Property(e => e.IsEmpDisc).HasDefaultValueSql("(0)");
                b.Property(e => e.IsRtnable).HasDefaultValueSql("(0)");
                b.Property(e => e.IsDisc).HasDefaultValueSql("(0)");
                b.Property(e => e.IsFOC).HasDefaultValueSql("(0)");
                b.Property(e => e.IsTaxable).HasDefaultValueSql("(0)");
                b.Property(e => e.AvgCost).HasDefaultValueSql("(0)");
                b.Property(e => e.StdCost).HasDefaultValueSql("(0)");
                b.Property(e => e.StdMarkup).HasDefaultValueSql("(0)");
                b.Property(e => e.StdSellPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.IsSelected).HasDefaultValueSql("(0)");
                b.Property(e => e.IsBestBuy).HasDefaultValueSql("(0)");
                b.Property(e => e.IsPurchase).HasDefaultValueSql("(0)");
                b.Property(e => e.IsWLength).HasDefaultValueSql("(0)");
                b.Property(e => e.IsPack).HasDefaultValueSql("(0)");
                b.Property(e => e.IsConsumable).HasDefaultValueSql("(0)");
                b.Property(e => e.PriceType).HasDefaultValueSql("(1)");
                b.Property(e => e.ImagePath).HasDefaultValueSql("''");
                b.Property(e => e.AppID).HasDefaultValueSql("(0)");
                b.Property(e => e.RemarkA).HasDefaultValueSql("''");
                b.Property(e => e.RemarkB).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            });
            #endregion

            #region VOC_VOUCHER
            modelBuilder.Entity<DTO.Inventory.VOC_VOUCHER>(b =>
            {
                b.HasKey(e => new { e.BizRegID, e.BizLocID, e.BizUnitID, e.ItemCode, e.VoucherNo, e.RandCode, });
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.BizUnitID).HasDefaultValueSql("''");
                b.Property(e => e.ItemCode).HasDefaultValueSql("''");
                b.Property(e => e.VoucherNo).HasDefaultValueSql("''");
                b.Property(e => e.RandCode).HasDefaultValueSql("''");
                b.Property(e => e.RefNo).HasDefaultValueSql("''");
                b.Property(e => e.RefType).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
                b.Property(e => e.RedeemTransNo).HasDefaultValueSql("''");
                b.Property(e => e.RedeemRegNo).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.TransNo).HasDefaultValueSql("''");
                b.Property(e => e.TransferNo).HasDefaultValueSql("''");
                b.Property(e => e.VoidTransNo).HasDefaultValueSql("''");
                b.Property(e => e.VoidRegNo).HasDefaultValueSql("''");
                b.Property(e => e.VoidBranchID).HasDefaultValueSql("''");
                b.Property(e => e.UserID).HasDefaultValueSql("''");
                b.Property(e => e.VoucherType).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.DAY1).HasDefaultValueSql("(0)");
                b.Property(e => e.DAY2).HasDefaultValueSql("(0)");
                b.Property(e => e.DAY3).HasDefaultValueSql("(0)");
                b.Property(e => e.DAY4).HasDefaultValueSql("(0)");
                b.Property(e => e.DAY5).HasDefaultValueSql("(0)");
                b.Property(e => e.DAY6).HasDefaultValueSql("(0)");
                b.Property(e => e.DAY7).HasDefaultValueSql("(0)");
                b.Property(e => e.TMID).HasDefaultValueSql("(0)");
                b.Property(e => e.UnitPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.FileRef1).HasDefaultValueSql("''");
                b.Property(e => e.FileRef2).HasDefaultValueSql("''");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ITMTRANSDTL
            modelBuilder.Entity<DTO.Inventory.ITMTRANSDTL>(b =>
            {
                b.HasKey(e => new { e.DocCode, e.ItemCode, e.ItemName, e.BizLocID, });
                b.Property(e => e.DocCode).HasDefaultValueSql("''");
                b.Property(e => e.ItemCode).HasDefaultValueSql("''");
                b.Property(e => e.ItemName).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.StorageID).HasDefaultValueSql("''");
                b.Property(e => e.TermID).HasDefaultValueSql("(0)");
                b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.TransType).HasDefaultValueSql("(0)");
                b.Property(e => e.OperationType).HasDefaultValueSql("''");
                b.Property(e => e.ItmPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.ReqQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ReqPackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.OpeningQty).HasDefaultValueSql("(0)");
                b.Property(e => e.OpeningPackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.Qty).HasDefaultValueSql("(0)");
                b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.HandlingQty).HasDefaultValueSql("(0)");
                b.Property(e => e.HandlingPackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ClosingQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ClosingPackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.LastInQty).HasDefaultValueSql("(0)");
                b.Property(e => e.LastInPackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.LastOutQty).HasDefaultValueSql("(0)");
                b.Property(e => e.LastOutPackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.RtnPackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.RtnQty).HasDefaultValueSql("(0)");
                b.Property(e => e.RecPackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.RecQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ExpiredQty).HasDefaultValueSql("(0)");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.LotNo).HasDefaultValueSql("''");
                b.Property(e => e.AreaCode).HasDefaultValueSql("''");
                b.Property(e => e.SecCode).HasDefaultValueSql("''");
                b.Property(e => e.BinCode).HasDefaultValueSql("''");
                b.Property(e => e.RowGuid).HasDefaultValueSql("newid()");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.isHost).HasDefaultValueSql("(0)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ITMTRANSHDR
            modelBuilder.Entity<DTO.Inventory.ITMTRANSHDR>(b =>
            {
                b.HasKey(e => new { e.DocCode, e.BizLocID, e.TransType, });
                b.Property(e => e.DocCode).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.TransType).HasDefaultValueSql("(0)");
                b.Property(e => e.RequestCode).HasDefaultValueSql("''");
                b.Property(e => e.BatchCode).HasDefaultValueSql("''");
                b.Property(e => e.TermID).HasDefaultValueSql("(0)");
                b.Property(e => e.RegistedSupp).HasDefaultValueSql("(0)");
                b.Property(e => e.CompanyID).HasDefaultValueSql("''");
                b.Property(e => e.CompanyName).HasDefaultValueSql("''");
                b.Property(e => e.CompanyType).HasDefaultValueSql("''");
                b.Property(e => e.TransInit).HasDefaultValueSql("''");
                b.Property(e => e.TransSrc).HasDefaultValueSql("''");
                b.Property(e => e.TransDest).HasDefaultValueSql("''");
                b.Property(e => e.InterTrans).HasDefaultValueSql("(0)");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Reason).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("(0)");
                b.Property(e => e.Status).HasDefaultValueSql("(0)");
                b.Property(e => e.AuthID).HasDefaultValueSql("''");
                b.Property(e => e.AuthPOS).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.ApproveBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.isHost).HasDefaultValueSql("(0)");
                b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ITEMLOC
            modelBuilder.Entity<DTO.Inventory.ITEMLOC>(b =>
            {
                b.HasKey(e => new { e.BizRegID, e.BizLocID, e.ItemCode, e.ItemType, e.SeqNo, e.ItemName, });
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.ItemCode).HasDefaultValueSql("''");
                b.Property(e => e.ItemType).HasDefaultValueSql("''");
                b.Property(e => e.SeqNo).HasDefaultValueSql("(1)");
                b.Property(e => e.ItemName).HasDefaultValueSql("''");
                b.Property(e => e.StorageID).HasDefaultValueSql("''");
                b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
                b.Property(e => e.ShortDesc).HasDefaultValueSql("''");
                b.Property(e => e.ItemComponent).HasDefaultValueSql("''");
                b.Property(e => e.TariffCode).HasDefaultValueSql("''");
                b.Property(e => e.OrgCountry).HasDefaultValueSql("''");
                b.Property(e => e.MATNo).HasDefaultValueSql("''");
                b.Property(e => e.MarkNo).HasDefaultValueSql("''");
                b.Property(e => e.ItmSize2).HasDefaultValueSql("''");
                b.Property(e => e.ItmSize1).HasDefaultValueSql("''");
                b.Property(e => e.ItmSize).HasDefaultValueSql("''");
                b.Property(e => e.ConSize).HasDefaultValueSql("(0)");
                b.Property(e => e.ConUOM).HasDefaultValueSql("''");
                b.Property(e => e.DefUOM).HasDefaultValueSql("''");
                b.Property(e => e.ClassType).HasDefaultValueSql("''");
                b.Property(e => e.TypeCode).HasDefaultValueSql("''");
                b.Property(e => e.BehvType).HasDefaultValueSql("(0)");
                b.Property(e => e.BehvShow).HasDefaultValueSql("(0)");
                b.Property(e => e.ComboItem).HasDefaultValueSql("(0)");
                b.Property(e => e.ItmCatgCode).HasDefaultValueSql("''");
                b.Property(e => e.ItmBrand).HasDefaultValueSql("''");
                b.Property(e => e.LooseUOM).HasDefaultValueSql("''");
                b.Property(e => e.PackUOM).HasDefaultValueSql("''");
                b.Property(e => e.IsSales).HasDefaultValueSql("(0)");
                b.Property(e => e.IsEmpDisc).HasDefaultValueSql("(0)");
                b.Property(e => e.IsRtnable).HasDefaultValueSql("(0)");
                b.Property(e => e.IsDisc).HasDefaultValueSql("(0)");
                b.Property(e => e.IsFOC).HasDefaultValueSql("(0)");
                b.Property(e => e.IsTaxable).HasDefaultValueSql("(0)");
                b.Property(e => e.AvgCost).HasDefaultValueSql("(0)");
                b.Property(e => e.StdCost).HasDefaultValueSql("(0)");
                b.Property(e => e.StdMarkup).HasDefaultValueSql("(0)");
                b.Property(e => e.StdSellPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.IsRecycle).HasDefaultValueSql("(0)");
                b.Property(e => e.IsSelected).HasDefaultValueSql("(0)");
                b.Property(e => e.IsBestBuy).HasDefaultValueSql("(0)");
                b.Property(e => e.IsPurchase).HasDefaultValueSql("(0)");
                b.Property(e => e.IsWLength).HasDefaultValueSql("(0)");
                b.Property(e => e.TrackSerial).HasDefaultValueSql("(0)");
                b.Property(e => e.MinQty).HasDefaultValueSql("(0)");
                b.Property(e => e.MaxQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ImageName).HasDefaultValueSql("''");
                b.Property(e => e.IncomingQty).HasDefaultValueSql("(0)");
                b.Property(e => e.IncomingPackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ReOrderLvl).HasDefaultValueSql("(0)");
                b.Property(e => e.ReOrderQty).HasDefaultValueSql("(0)");
                b.Property(e => e.QtyOnHand).HasDefaultValueSql("(0)");
                b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.QtySellable).HasDefaultValueSql("(0)");
                b.Property(e => e.QtyBalance).HasDefaultValueSql("(0)");
                b.Property(e => e.PackQtyBalance).HasDefaultValueSql("(0)");
                b.Property(e => e.POQty).HasDefaultValueSql("(0)");
                b.Property(e => e.OutgoingQty).HasDefaultValueSql("(0)");
                b.Property(e => e.OutgoingPackQty).HasDefaultValueSql("(0)");
                b.Property(e => e.QtyAdj).HasDefaultValueSql("(0)");
                b.Property(e => e.PackQtyAdj).HasDefaultValueSql("(0)");
                b.Property(e => e.FirstIn).HasDefaultValueSql("(0)");
                b.Property(e => e.LastIn).HasDefaultValueSql("(0)");
                b.Property(e => e.LastPackIn).HasDefaultValueSql("(0)");
                b.Property(e => e.LastPO).HasDefaultValueSql("(0)");
                b.Property(e => e.LastOut).HasDefaultValueSql("(0)");
                b.Property(e => e.LastPackOut).HasDefaultValueSql("(0)");
                b.Property(e => e.LastRV).HasDefaultValueSql("(0)");
                b.Property(e => e.LastAdj).HasDefaultValueSql("(0)");
                b.Property(e => e.LastPackAdj).HasDefaultValueSql("(0)");
                b.Property(e => e.CummQty).HasDefaultValueSql("(0)");
                b.Property(e => e.DayQty).HasDefaultValueSql("(0)");
                b.Property(e => e.LDayQty).HasDefaultValueSql("(0)");
                b.Property(e => e.MthQty).HasDefaultValueSql("(0)");
                b.Property(e => e.LMthQty).HasDefaultValueSql("(0)");
                b.Property(e => e.MtdQty).HasDefaultValueSql("(0)");
                b.Property(e => e.YrQty).HasDefaultValueSql("(0)");
                b.Property(e => e.LYrQty).HasDefaultValueSql("(0)");
                b.Property(e => e.YtdQty).HasDefaultValueSql("(0)");
                b.Property(e => e.ExpiredQty).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ITEMCOMBO
            modelBuilder.Entity<DTO.Inventory.ITEMCOMBO>(b =>
            {
                b.HasKey(e => new { e.BranchID, e.ItemCombo, e.ItemCode, e.ComboType, });
                b.Property(e => e.BranchID).HasDefaultValueSql("(1)");
                b.Property(e => e.ComboType).HasDefaultValueSql("(0)");
                b.Property(e => e.StdSellPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.FixedPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.Qty).HasDefaultValueSql("(1)");
                b.Property(e => e.PerSession).HasDefaultValueSql("(1)");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            });
            #endregion            

            #region ITEMPRICE
            modelBuilder.Entity<DTO.Inventory.ITEMPRICE>(b =>
            {
                b.HasKey(e => new { e.DocCode, e.ItemCode, e.ItmCatgCode, e.ItemType, e.Criteria, e.Mode, e.FreqCode, e.FreqNum, e.FreqType, e.SvcType, e.EffDate, e.PriceLevel, });
                b.Property(e => e.DocCode).HasDefaultValueSql("''");
                b.Property(e => e.ItemCode).HasDefaultValueSql("''");
                b.Property(e => e.ItmCatgCode).HasDefaultValueSql("''");
                b.Property(e => e.ItemType).HasDefaultValueSql("''");
                b.Property(e => e.Criteria).HasDefaultValueSql("''");
                b.Property(e => e.Mode).HasDefaultValueSql("(0)");
                b.Property(e => e.FreqCode).HasDefaultValueSql("''");
                b.Property(e => e.FreqNum).HasDefaultValueSql("(0)");
                b.Property(e => e.FreqType).HasDefaultValueSql("''");
                b.Property(e => e.SvcType).HasDefaultValueSql("''");
                b.Property(e => e.EffDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.PriceLevel).HasDefaultValueSql("(0)");
                b.Property(e => e.BranchID).HasDefaultValueSql("''");
                b.Property(e => e.SellPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.RangeFrm).HasDefaultValueSql("(0)");
                b.Property(e => e.RangeTo).HasDefaultValueSql("(0)");
                b.Property(e => e.Margin).HasDefaultValueSql("(0)");
                b.Property(e => e.Points).HasDefaultValueSql("(0)");
                b.Property(e => e.RedeemFull).HasDefaultValueSql("(0)");
                b.Property(e => e.RedeemMixPoint).HasDefaultValueSql("(0)");
                b.Property(e => e.RedeemMixValue).HasDefaultValueSql("(0)");
                b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate1H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate1G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate2H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate2G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate3H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate3G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate4H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate4G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate5H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate5G).HasDefaultValueSql("(0)");
                b.Property(e => e.CCID).HasDefaultValueSql("(0)");
                b.Property(e => e.SellPrice1).HasDefaultValueSql("(0)");
                b.Property(e => e.SellPrice2).HasDefaultValueSql("(0)");
                b.Property(e => e.SellPrice3).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
                b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion            

            #region ITEMPRICEHDR
            modelBuilder.Entity<DTO.Inventory.ITEMPRICEHDR>(b =>
            {
                b.HasKey(e => new { e.DocCode, e.BizLocID, e.TransType, });
                b.Property(e => e.DocCode).HasDefaultValueSql("''");
                b.Property(e => e.BizLocID).HasDefaultValueSql("''");
                b.Property(e => e.TransType).HasDefaultValueSql("''");
                b.Property(e => e.PriceLevel).HasDefaultValueSql("''");
                b.Property(e => e.SvcType).HasDefaultValueSql("''");
                b.Property(e => e.RequestCode).HasDefaultValueSql("''");
                b.Property(e => e.BatchCode).HasDefaultValueSql("''");
                b.Property(e => e.TermID).HasDefaultValueSql("(0)");
                b.Property(e => e.RegistedSupp).HasDefaultValueSql("(0)");
                b.Property(e => e.CompanyID).HasDefaultValueSql("''");
                b.Property(e => e.CompanyName).HasDefaultValueSql("''");
                b.Property(e => e.CompanyType).HasDefaultValueSql("''");
                b.Property(e => e.TransInit).HasDefaultValueSql("''");
                b.Property(e => e.TransSrc).HasDefaultValueSql("''");
                b.Property(e => e.TransDest).HasDefaultValueSql("''");
                b.Property(e => e.InterTrans).HasDefaultValueSql("(0)");
                b.Property(e => e.Remark).HasDefaultValueSql("''");
                b.Property(e => e.Reason).HasDefaultValueSql("''");
                b.Property(e => e.Posted).HasDefaultValueSql("''");
                b.Property(e => e.Status).HasDefaultValueSql("(1)");
                b.Property(e => e.AuthID).HasDefaultValueSql("''");
                b.Property(e => e.AuthPOS).HasDefaultValueSql("''");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.ApproveBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.RowGuid).HasDefaultValueSql("newid()");
            });
            #endregion

            #region ITEMSELLGRP
            modelBuilder.Entity<DTO.Inventory.ITEMSELLGRP>(b =>
            {
                b.HasKey(e => new { e.DocCode, e.ItemCode, e.ItmCatgCode, e.ItemType, e.Criteria, e.Mode, e.FreqCode, e.FreqNum, e.FreqType, e.SvcType, e.EffDate, e.PriceLevel, });
                b.Property(e => e.DocCode).HasDefaultValueSql("''");
                b.Property(e => e.ItemCode).HasDefaultValueSql("''");
                b.Property(e => e.ItmCatgCode).HasDefaultValueSql("''");
                b.Property(e => e.ItemType).HasDefaultValueSql("''");
                b.Property(e => e.Criteria).HasDefaultValueSql("''");
                b.Property(e => e.Mode).HasDefaultValueSql("(0)");
                b.Property(e => e.FreqCode).HasDefaultValueSql("''");
                b.Property(e => e.FreqNum).HasDefaultValueSql("(0)");
                b.Property(e => e.FreqType).HasDefaultValueSql("''");
                b.Property(e => e.SvcType).HasDefaultValueSql("''");
                b.Property(e => e.EffDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.PriceLevel).HasDefaultValueSql("(0)");
                b.Property(e => e.BranchID).HasDefaultValueSql("''");
                b.Property(e => e.SellPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.RangeFrm).HasDefaultValueSql("(0)");
                b.Property(e => e.RangeTo).HasDefaultValueSql("(0)");
                b.Property(e => e.Margin).HasDefaultValueSql("(0)");
                b.Property(e => e.Points).HasDefaultValueSql("(0)");
                b.Property(e => e.RedeemFull).HasDefaultValueSql("(0)");
                b.Property(e => e.RedeemMixPoint).HasDefaultValueSql("(0)");
                b.Property(e => e.RedeemMixValue).HasDefaultValueSql("(0)");
                b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate1H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate1G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate2H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate2G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate3H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate3G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate4H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate4G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate5H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate5G).HasDefaultValueSql("(0)");
                b.Property(e => e.CCID).HasDefaultValueSql("(0)");
                b.Property(e => e.SellPrice1).HasDefaultValueSql("(0)");
                b.Property(e => e.SellPrice2).HasDefaultValueSql("(0)");
                b.Property(e => e.SellPrice3).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ITEMCOSTGRP
            modelBuilder.Entity<DTO.Inventory.ITEMCOSTGRP>(b =>
            {
                b.HasKey(e => new { e.DocCode, e.ItemCode, e.ItmCatgCode, e.ItemType, e.Criteria, e.Mode, e.FreqCode, e.FreqNum, e.FreqType, e.SvcType, e.EffDate, e.PriceLevel, });
                b.Property(e => e.DocCode).HasDefaultValueSql("''");
                b.Property(e => e.ItemCode).HasDefaultValueSql("''");
                b.Property(e => e.ItmCatgCode).HasDefaultValueSql("''");
                b.Property(e => e.ItemType).HasDefaultValueSql("''");
                b.Property(e => e.Criteria).HasDefaultValueSql("''");
                b.Property(e => e.Mode).HasDefaultValueSql("(0)");
                b.Property(e => e.FreqCode).HasDefaultValueSql("''");
                b.Property(e => e.FreqNum).HasDefaultValueSql("(0)");
                b.Property(e => e.FreqType).HasDefaultValueSql("''");
                b.Property(e => e.SvcType).HasDefaultValueSql("''");
                b.Property(e => e.EffDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.PriceLevel).HasDefaultValueSql("(0)");
                b.Property(e => e.BranchID).HasDefaultValueSql("''");
                b.Property(e => e.CostPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.RangeFrm).HasDefaultValueSql("(0)");
                b.Property(e => e.RangeTo).HasDefaultValueSql("(0)");
                b.Property(e => e.Margin).HasDefaultValueSql("(0)");
                b.Property(e => e.Points).HasDefaultValueSql("(0)");
                b.Property(e => e.RedeemFull).HasDefaultValueSql("(0)");
                b.Property(e => e.RedeemMixPoint).HasDefaultValueSql("(0)");
                b.Property(e => e.RedeemMixValue).HasDefaultValueSql("(0)");
                b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate1H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate1G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate2H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate2G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate3H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate3G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate4H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate4G).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate5H).HasDefaultValueSql("(0)");
                b.Property(e => e.CoRate5G).HasDefaultValueSql("(0)");
                b.Property(e => e.CCID).HasDefaultValueSql("(0)");
                b.Property(e => e.CostPrice1).HasDefaultValueSql("(0)");
                b.Property(e => e.CostPrice2).HasDefaultValueSql("(0)");
                b.Property(e => e.CostPrice3).HasDefaultValueSql("(0)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncCreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ITEMCATEGORY
            modelBuilder.Entity<DTO.Inventory.ITEMCATEGORY>(b =>
            {
                b.HasKey(e => new { e.DeptCode, e.CatgCode, });
                b.Property(e => e.CatgDesc).HasDefaultValueSql("''");
                b.Property(e => e.TypeCode).HasDefaultValueSql("''");
                b.Property(e => e.SalesTarget).HasDefaultValueSql("(0)");
                b.Property(e => e.DesireStock).HasDefaultValueSql("(0)");
                b.Property(e => e.DualReceipt).HasDefaultValueSql("(0)");
                b.Property(e => e.PrintLineId).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            });
            #endregion

            #region SAP_ITEMPRICE
            modelBuilder.Entity<DTO.Inventory.SAP_ITEMPRICE>(b =>
            {
                b.HasKey(e => new { e.ConditionKey, });
                b.Property(e => e.ConditionKey).HasDefaultValueSql("''");
                b.Property(e => e.RefGrp).HasDefaultValueSql("''");
                b.Property(e => e.Material).HasDefaultValueSql("''");
                b.Property(e => e.BranchID).HasDefaultValueSql("''");
                b.Property(e => e.BizRegID).HasDefaultValueSql("''");
                b.Property(e => e.CustomerID).HasDefaultValueSql("''");
                b.Property(e => e.PriceType).HasDefaultValueSql("''");
                b.Property(e => e.State).HasDefaultValueSql("''");
                b.Property(e => e.CostCenter).HasDefaultValueSql("''");
                b.Property(e => e.EffDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.ItemType).HasDefaultValueSql("''");
                b.Property(e => e.SellPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.UnitPrice).HasDefaultValueSql("(0)");
                b.Property(e => e.Currency).HasDefaultValueSql("''");
                b.Property(e => e.UOM).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
                b.Property(e => e.ActionID).HasDefaultValueSql("(0)");
                b.Property(e => e.ActionDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            });
            #endregion

            #region ITEMDEPT
            modelBuilder.Entity<DTO.Inventory.ITEMDEPT>(b =>
            {
                b.HasKey(e => new { e.DivCode, e.DeptCode, });
                b.Property(e => e.DivCode).HasDefaultValueSql("''");
                b.Property(e => e.DeptCode).HasDefaultValueSql("''");
                b.Property(e => e.DeptDesc).HasDefaultValueSql("''");
                b.Property(e => e.MarginPercent).HasDefaultValueSql("(0)");
                b.Property(e => e.AllowAltSupplier).HasDefaultValueSql("(0)");
                b.Property(e => e.AllowOverRecv).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            });
            #endregion

            #region ITEMGROUP
            modelBuilder.Entity<DTO.Inventory.ITEMGROUP>(b =>
            {
                b.HasKey(e => new { e.DeptCode, e.GroupCode, });
                b.Property(e => e.DeptCode).HasDefaultValueSql("''");
                b.Property(e => e.GroupCode).HasDefaultValueSql("''");
                b.Property(e => e.GroupDesc).HasDefaultValueSql("''");
                b.Property(e => e.SalesTarget).HasDefaultValueSql("(0)");
                b.Property(e => e.DesireStock).HasDefaultValueSql("(0)");
                b.Property(e => e.DualReceipt).HasDefaultValueSql("(0)");
                b.Property(e => e.PrintLineId).HasDefaultValueSql("(0)");
                b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
                b.Property(e => e.CreateBy).HasDefaultValueSql("''");
                b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
                b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
                b.Property(e => e.Active).HasDefaultValueSql("(1)");
                b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
                b.Property(e => e.Flag).HasDefaultValueSql("(1)");
                b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
                b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
                b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
                b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
                b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            });
            #endregion

            #endregion

            //#region QUESTIL
            //#region CONTRACT
            //#region CONTRACTDOCUMENT
            //modelBuilder.Entity<DTO.Questil.Contract.CONTRACTDOCUMENT>(b =>
            //{
            //    b.HasKey(e => new { e.BizLocID, e.BizRegID, e.ContractID, e.DocNo, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractID).HasDefaultValueSql("''");
            //    b.Property(e => e.DocNo).HasDefaultValueSql("''");
            //    b.Property(e => e.DocCode).HasDefaultValueSql("''");
            //    b.Property(e => e.DocType).HasDefaultValueSql("''");
            //    b.Property(e => e.DocMode).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Description).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.RefID).HasDefaultValueSql("''");
            //    b.Property(e => e.PathRef).HasDefaultValueSql("''");
            //    b.Property(e => e.Signature).HasDefaultValueSql("NULL");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region CONTRACTHDR
            //modelBuilder.Entity<DTO.Questil.Contract.CONTRACTHDR>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.ContractID, e.ContractType, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractID).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ContNature).HasDefaultValueSql("''");
            //    b.Property(e => e.ContComp).HasDefaultValueSql("''");
            //    b.Property(e => e.ParentID).HasDefaultValueSql("''");
            //    b.Property(e => e.RelatedID).HasDefaultValueSql("''");
            //    b.Property(e => e.RefBatchCode1).HasDefaultValueSql("''");
            //    b.Property(e => e.RefBatchCode2).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractNo).HasDefaultValueSql("''");
            //    b.Property(e => e.CompanyID).HasDefaultValueSql("''");
            //    b.Property(e => e.DestRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.CollectionAddress).HasDefaultValueSql("''");
            //    b.Property(e => e.RequestID).HasDefaultValueSql("''");
            //    b.Property(e => e.BatchCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ReferID).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo1).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo2).HasDefaultValueSql("''");
            //    b.Property(e => e.Description).HasDefaultValueSql("''");
            //    b.Property(e => e.VersionNo).HasDefaultValueSql("''");
            //    b.Property(e => e.PartitionNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ContCountry).HasDefaultValueSql("''");
            //    b.Property(e => e.ContState).HasDefaultValueSql("''");
            //    b.Property(e => e.ContPBT).HasDefaultValueSql("''");
            //    b.Property(e => e.ContDuration).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ContDaysLeft).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BizLicID).HasDefaultValueSql("''");
            //    b.Property(e => e.IsLapsed).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SourceSystem).HasDefaultValueSql("''");
            //    b.Property(e => e.ProcureUnit).HasDefaultValueSql("''");
            //    b.Property(e => e.IsReceivable).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsInvoiceable).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsService).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ServiceType).HasDefaultValueSql("''");
            //    b.Property(e => e.RegistedSupp).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ReqResCnt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActResCnt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtCommitment).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtCommitMax).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtCommitMin).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtReconcile).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtReconcileP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtReconcileA).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtUsed).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtUsedP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtInvoiced).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtInvoicedP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtInvoicedA).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtLeftAVG).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtLeftAVGP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Tolerance).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtCommitOrg1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtCommitOrg2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.NextPayID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.NextPayAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AuthID).HasDefaultValueSql("''");
            //    b.Property(e => e.AuthPOS).HasDefaultValueSql("''");
            //    b.Property(e => e.IsApproved).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ApprovalFlow).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.DeclineBy).HasDefaultValueSql("''");
            //    b.Property(e => e.TerminateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Reason1).HasDefaultValueSql("''");
            //    b.Property(e => e.Reason2).HasDefaultValueSql("''");
            //    b.Property(e => e.Reason3).HasDefaultValueSql("''");
            //    b.Property(e => e.VerifiedBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LocCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.DefCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.CurrRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.KppVerifiedBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region CONTRACTITEM
            //modelBuilder.Entity<DTO.Questil.Contract.CONTRACTITEM>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.ContractID, e.SeqNo, e.RefBatchCode1, e.RefBatchCode2, e.ContractNo, e.ItemFreqNum, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefBatchCode1).HasDefaultValueSql("''");
            //    b.Property(e => e.RefBatchCode2).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ScopeType).HasDefaultValueSql("''");
            //    b.Property(e => e.RefSeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LineType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.ItmCatgCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SerialNo).HasDefaultValueSql("''");
            //    b.Property(e => e.SupplierCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SuppPartNo).HasDefaultValueSql("''");
            //    b.Property(e => e.RevenueID).HasDefaultValueSql("''");
            //    b.Property(e => e.ProjectID).HasDefaultValueSql("''");
            //    b.Property(e => e.CommodityERP).HasDefaultValueSql("''");
            //    b.Property(e => e.Commodity).HasDefaultValueSql("''");
            //    b.Property(e => e.StatisticCode).HasDefaultValueSql("''");
            //    b.Property(e => e.AssetCode).HasDefaultValueSql("''");
            //    b.Property(e => e.AccountCode).HasDefaultValueSql("''");
            //    b.Property(e => e.CostCenter).HasDefaultValueSql("''");
            //    b.Property(e => e.WBSElement).HasDefaultValueSql("''");
            //    b.Property(e => e.InternalOrder).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ScopeID).HasDefaultValueSql("''");
            //    b.Property(e => e.SchemeNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ZoneNo).HasDefaultValueSql("''");
            //    b.Property(e => e.MaterialNo1).HasDefaultValueSql("''");
            //    b.Property(e => e.MaterialNo2).HasDefaultValueSql("''");
            //    b.Property(e => e.StartTime).HasDefaultValueSql("''");
            //    b.Property(e => e.EndTime).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemFreqCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemFreqNum).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemFreqType).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemFrequency).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemCost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemPrice).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemUOM).HasDefaultValueSql("''");
            //    b.Property(e => e.ItmCatgQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemQtyMax).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PackUOM).HasDefaultValueSql("''");
            //    b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyOrdered).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyOrdLeft).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyOrdLeftP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyReceived).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyRecLeft).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyRecLeftP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyReconcile).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyReconLeft).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyReconLeftP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemContSplitP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemAmtMax).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtOrdered).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtOrdLeft).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtOrdLeftP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtReceived).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtRecLeft).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtRecLeftP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtReconcile).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtReconcileP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AmtReconcileA).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ReleaseType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PayMethod).HasDefaultValueSql("''");
            //    b.Property(e => e.PayFreqType).HasDefaultValueSql("''");
            //    b.Property(e => e.PayFreq).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsRecycle).HasDefaultValueSql("(0)");
            //    b.Property(e => e.InitQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AddQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsPack).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemName).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LocCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.DefCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.CurrRate).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region CONTRACTRESOURCE
            //modelBuilder.Entity<DTO.Questil.Contract.CONTRACTRESOURCE>(b =>
            //{
            //    b.HasKey(e => new { e.ContractID, e.ResourceID, e.ResourceType, e.SeqNo, });
            //    b.Property(e => e.ContractID).HasDefaultValueSql("''");
            //    b.Property(e => e.ResourceID).HasDefaultValueSql("''");
            //    b.Property(e => e.ResourceType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SchemeNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ZoneNo).HasDefaultValueSql("''");
            //    b.Property(e => e.MastType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MastCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Reference1).HasDefaultValueSql("''");
            //    b.Property(e => e.Reference2).HasDefaultValueSql("''");
            //    b.Property(e => e.Reference3).HasDefaultValueSql("''");
            //    b.Property(e => e.Reference4).HasDefaultValueSql("''");
            //    b.Property(e => e.Reference5).HasDefaultValueSql("''");
            //    b.Property(e => e.Port1).HasDefaultValueSql("''");
            //    b.Property(e => e.Port2).HasDefaultValueSql("''");
            //    b.Property(e => e.Station).HasDefaultValueSql("''");
            //    b.Property(e => e.LicID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransportType).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region CONTRACTSCOPESUM
            //modelBuilder.Entity<DTO.Questil.Contract.CONTRACTSCOPESUM>(b =>
            //{
            //    b.HasKey(e => new { e.ScopeID, e.MonthCode, e.BizRegID, e.CustBizRegID, e.ContractID, e.BatchCode, e.SeqNo, e.ItemFreqNum, });
            //    b.Property(e => e.ScopeID).HasDefaultValueSql("''");
            //    b.Property(e => e.MonthCode).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.CustBizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractID).HasDefaultValueSql("''");
            //    b.Property(e => e.BatchCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CompanyName).HasDefaultValueSql("''");
            //    b.Property(e => e.CustomerName).HasDefaultValueSql("''");
            //    b.Property(e => e.CollectionAddress).HasDefaultValueSql("''");
            //    b.Property(e => e.ScopeType).HasDefaultValueSql("''");
            //    b.Property(e => e.RouteSchNo).HasDefaultValueSql("''");
            //    b.Property(e => e.RouteSchType).HasDefaultValueSql("''");
            //    b.Property(e => e.PBTCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SchemeNo).HasDefaultValueSql("''");
            //    b.Property(e => e.RouteNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ParentID).HasDefaultValueSql("''");
            //    b.Property(e => e.StreetCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ReqResCnt1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ReqResCnt2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ReqResCnt3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ReqResCnt4).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActResCnt1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActResCnt2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActResCnt3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActResCnt4).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MastType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MastCode).HasDefaultValueSql("''");
            //    b.Property(e => e.MastQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemCycle).HasDefaultValueSql("(1)");
            //    b.Property(e => e.StartTime).HasDefaultValueSql("''");
            //    b.Property(e => e.EndTime).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemFreqCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemFreqNum).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemFreqType).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemFrequency).HasDefaultValueSql("''");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UOM).HasDefaultValueSql("''");
            //    b.Property(e => e.Packaging).HasDefaultValueSql("''");
            //    b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Price).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastPrice).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AvgPrice).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Rate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark2).HasDefaultValueSql("''");
            //    b.Property(e => e.SvcType).HasDefaultValueSql("''");
            //    b.Property(e => e.ProcType).HasDefaultValueSql("''");
            //    b.Property(e => e.VariationID).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    //b.Property(e => e.isHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ErrCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LocCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.DefCurrency).HasDefaultValueSql("''");
            //    b.Property(e => e.CurrRate).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region STGAPPROVAL
            //modelBuilder.Entity<DTO.Questil.Contract.STGAPPROVAL>(b =>
            //{
            //    b.HasKey(e => new { e.StagingID, e.BizRegID, });
            //    b.Property(e => e.StagingID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.CompanyName).HasDefaultValueSql("''");
            //    b.Property(e => e.RefID).HasDefaultValueSql("''");
            //    b.Property(e => e.AddressType).HasDefaultValueSql("''");
            //    b.Property(e => e.AddressChange).HasDefaultValueSql("''");
            //    b.Property(e => e.Address1).HasDefaultValueSql("''");
            //    b.Property(e => e.Address2).HasDefaultValueSql("''");
            //    b.Property(e => e.Address3).HasDefaultValueSql("''");
            //    b.Property(e => e.Address4).HasDefaultValueSql("''");
            //    b.Property(e => e.PackageType).HasDefaultValueSql("''");
            //    b.Property(e => e.Email).HasDefaultValueSql("''");
            //    b.Property(e => e.PostalCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Country).HasDefaultValueSql("''");
            //    b.Property(e => e.State).HasDefaultValueSql("''");
            //    b.Property(e => e.City).HasDefaultValueSql("''");
            //    b.Property(e => e.District).HasDefaultValueSql("''");
            //    b.Property(e => e.TransporterID).HasDefaultValueSql("''");
            //    b.Property(e => e.BankCode1).HasDefaultValueSql("''");
            //    b.Property(e => e.ContactPerson2).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.QtyBin).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.RefNo1).HasDefaultValueSql("''");
            //    b.Property(e => e.IsRead).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RejectRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.StatusApproval).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#endregion

            //#region RESOURCE
            //#region VEHICLE
            //modelBuilder.Entity<DTO.Questil.Resources.VEHICLE>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.VehicleID, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.VehicleID).HasDefaultValueSql("''");
            //    b.Property(e => e.RegNo).HasDefaultValueSql("''");
            //    b.Property(e => e.GrpCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Ownership).HasDefaultValueSql("(1)");
            //    b.Property(e => e.VehicleType).HasDefaultValueSql("''");
            //    b.Property(e => e.BDM).HasDefaultValueSql("''");
            //    b.Property(e => e.BTM).HasDefaultValueSql("''");
            //    b.Property(e => e.ManufactYear).HasDefaultValueSql("''");
            //    b.Property(e => e.RegisterYear).HasDefaultValueSql("''");
            //    b.Property(e => e.RegisterCard).HasDefaultValueSql("(0)");
            //    b.Property(e => e.WithGPS).HasDefaultValueSql("(0)");
            //    b.Property(e => e.WithCont).HasDefaultValueSql("(0)");
            //    b.Property(e => e.WithLifter).HasDefaultValueSql("(0)");
            //    b.Property(e => e.WithPaint).HasDefaultValueSql("(0)");
            //    b.Property(e => e.WithPhoto).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OptWith1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OptDesc1).HasDefaultValueSql("''");
            //    b.Property(e => e.OptWith2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OptDesc2).HasDefaultValueSql("''");
            //    b.Property(e => e.OptWith3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OptDesc3).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region WORKER
            //modelBuilder.Entity<DTO.Questil.Resources.WORKER>(b =>
            //{
            //    b.HasKey(e => new { e.WorkerID, e.BizRegID, e.BizLocID, });
            //    b.Property(e => e.WorkerID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.WorkerType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ReferralCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ReferralID).HasDefaultValueSql("''");
            //    b.Property(e => e.NickName).HasDefaultValueSql("''");
            //    b.Property(e => e.SurName).HasDefaultValueSql("''");
            //    b.Property(e => e.FirstName).HasDefaultValueSql("''");
            //    b.Property(e => e.Salutation).HasDefaultValueSql("''");
            //    b.Property(e => e.Sex).HasDefaultValueSql("(0)");
            //    b.Property(e => e.DOB).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.PlaceOfBirth).HasDefaultValueSql("''");
            //    b.Property(e => e.NRICNo).HasDefaultValueSql("''");
            //    b.Property(e => e.Nationality).HasDefaultValueSql("''");
            //    b.Property(e => e.Race).HasDefaultValueSql("''");
            //    b.Property(e => e.Religion).HasDefaultValueSql("''");
            //    b.Property(e => e.Marital).HasDefaultValueSql("''");
            //    b.Property(e => e.CoAddress1).HasDefaultValueSql("''");
            //    b.Property(e => e.CoAddress2).HasDefaultValueSql("''");
            //    b.Property(e => e.CoAddress3).HasDefaultValueSql("''");
            //    b.Property(e => e.CoAddress4).HasDefaultValueSql("''");
            //    b.Property(e => e.CoPostalCode).HasDefaultValueSql("''");
            //    b.Property(e => e.CoState).HasDefaultValueSql("''");
            //    b.Property(e => e.CoCountry).HasDefaultValueSql("''");
            //    b.Property(e => e.PnAddress1).HasDefaultValueSql("''");
            //    b.Property(e => e.PnAddress2).HasDefaultValueSql("''");
            //    b.Property(e => e.PnAddress3).HasDefaultValueSql("''");
            //    b.Property(e => e.PnAddress4).HasDefaultValueSql("''");
            //    b.Property(e => e.PnPostalCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PnState).HasDefaultValueSql("''");
            //    b.Property(e => e.PnCountry).HasDefaultValueSql("''");
            //    b.Property(e => e.EmerContactPerson).HasDefaultValueSql("''");
            //    b.Property(e => e.EmerContactNo).HasDefaultValueSql("''");
            //    b.Property(e => e.EmailAddress).HasDefaultValueSql("''");
            //    b.Property(e => e.Designation).HasDefaultValueSql("''");
            //    b.Property(e => e.ForeignLocal).HasDefaultValueSql("''");
            //    b.Property(e => e.Position1).HasDefaultValueSql("''");
            //    b.Property(e => e.Position2).HasDefaultValueSql("''");
            //    b.Property(e => e.Role1).HasDefaultValueSql("''");
            //    b.Property(e => e.Role2).HasDefaultValueSql("''");
            //    b.Property(e => e.Role3).HasDefaultValueSql("''");
            //    b.Property(e => e.CommID).HasDefaultValueSql("''");
            //    b.Property(e => e.Salary).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OffDay).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Overtime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Leave).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Levy).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Allergies).HasDefaultValueSql("''");
            //    b.Property(e => e.ClerkNo).HasDefaultValueSql("''");
            //    b.Property(e => e.DateHired).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.DateLeft).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.TransportAllowance).HasDefaultValueSql("''");
            //    b.Property(e => e.ServiceAllowance).HasDefaultValueSql("''");
            //    b.Property(e => e.OtherAllowance).HasDefaultValueSql("''");
            //    b.Property(e => e.Remarks).HasDefaultValueSql("''");
            //    b.Property(e => e.PrivilegeCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.AccessLvl).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LocID).HasDefaultValueSql("''");
            //});
            //#endregion

            //#region VEHICLEDOCUMENT
            //modelBuilder.Entity<DTO.Questil.Resources.VEHICLEDOCUMENT>(b =>
            //{
            //    b.HasKey(e => new { e.DocCode, e.BizRegID, e.VehicleID, });
            //    b.Property(e => e.ValidityStart).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.ValidityEnd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.DocNo).HasDefaultValueSql("''");
            //    b.Property(e => e.RemindDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //});
            //#endregion

            //#endregion

            //#region SCHEDULE
            //#region SCHEDULEDTL
            //modelBuilder.Entity<DTO.Questil.Contract.SCHEDULEDTL>(b =>
            //{
            //    b.HasKey(e => new { e.ScheduleID, e.SeqNo, });
            //    b.Property(e => e.ScheduleID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.VehicleNo).HasDefaultValueSql("''");
            //    b.Property(e => e.WorkerID).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region SCHEDULEHDR
            //modelBuilder.Entity<DTO.Questil.Contract.SCHEDULEHDR>(b =>
            //{
            //    b.HasKey(e => new { e.MSTRID, e.PlanID, e.ScheduleID, e.ContractID, e.BizLocID, e.LocID, e.CustomerID, e.TransDate, e.SeqNo, });
            //    b.Property(e => e.MSTRID).HasDefaultValueSql("''");
            //    b.Property(e => e.PlanID).HasDefaultValueSql("''");
            //    b.Property(e => e.ScheduleID).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.LocID).HasDefaultValueSql("''");
            //    b.Property(e => e.CustomerID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RequestID).HasDefaultValueSql("''");
            //    b.Property(e => e.SubRequestID).HasDefaultValueSql("''");
            //    b.Property(e => e.WorkType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.VehicleID).HasDefaultValueSql("''");
            //    b.Property(e => e.PlannedStartDate).HasDefaultValueSql("''");
            //    b.Property(e => e.PlannedEndDate).HasDefaultValueSql("''");
            //    b.Property(e => e.PlannedStartTime).HasDefaultValueSql("''");
            //    b.Property(e => e.PlannedEndTime).HasDefaultValueSql("''");
            //    b.Property(e => e.ActualStartDate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActualEndDate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActualStartTime).HasDefaultValueSql("''");
            //    b.Property(e => e.ActualEndTime).HasDefaultValueSql("''");
            //    b.Property(e => e.ReferenceNo).HasDefaultValueSql("''");
            //    b.Property(e => e.LocDesc1).HasDefaultValueSql("''");
            //    b.Property(e => e.LocDesc2).HasDefaultValueSql("''");
            //    b.Property(e => e.LocDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.SubOri1).HasDefaultValueSql("''");
            //    b.Property(e => e.SubOri2).HasDefaultValueSql("''");
            //    b.Property(e => e.SubDest1).HasDefaultValueSql("''");
            //    b.Property(e => e.SubDest2).HasDefaultValueSql("''");
            //    b.Property(e => e.LocRemark1).HasDefaultValueSql("''");
            //    b.Property(e => e.LocRemark2).HasDefaultValueSql("''");
            //    b.Property(e => e.IsReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsCompleted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.DestRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.SvcType).HasDefaultValueSql("'COL'");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //});
            //#endregion

            //#region SCHEDULEITEM
            //modelBuilder.Entity<DTO.Questil.Contract.SCHEDULEITEM>(b =>
            //{
            //    b.HasKey(e => new { e.ScheduleID, e.SeqNo, e.MastType, e.ItemCode, });
            //    b.Property(e => e.ScheduleID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("''");
            //    b.Property(e => e.MastType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("''");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UOM).HasDefaultValueSql("''");
            //    b.Property(e => e.PackUOM).HasDefaultValueSql("''");
            //    b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Multiplier).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellPrice).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellPrice1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellPrice2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellPrice3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotAmt1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotAmt2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotAmt3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SvcType).HasDefaultValueSql("''");
            //    b.Property(e => e.IsPack).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("''");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.InitQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AddQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CostAmt1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CostAmt2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CostAmt3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //});
            //#endregion
            //#endregion

            //#region WORKORDER
            //#region WORKORDERPERSON
            //modelBuilder.Entity<DTO.Questil.WorkOrder.WORKORDERPERSON>(b =>
            //{
            //    b.HasKey(e => new { e.WOID, e.SeqNo, });
            //    b.Property(e => e.WOID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.InitVehicleNo).HasDefaultValueSql("''");
            //    b.Property(e => e.VehicleNo).HasDefaultValueSql("''");
            //    b.Property(e => e.InitWorkerID).HasDefaultValueSql("''");
            //    b.Property(e => e.WorkerID).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});
            //#endregion
            //#region WORKORDERHDR
            //modelBuilder.Entity<DTO.Questil.WorkOrder.WORKORDERHDR>(b =>
            //{
            //    b.HasKey(e => new { e.MSTRID, e.ScheduleID, e.WOID, e.ContractID, e.BizLocID, });
            //    b.Property(e => e.MSTRID).HasDefaultValueSql("''");
            //    b.Property(e => e.ScheduleID).HasDefaultValueSql("''");
            //    b.Property(e => e.WOID).HasDefaultValueSql("''");
            //    b.Property(e => e.ContractID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.CustomerID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.RefID).HasDefaultValueSql("''");
            //    b.Property(e => e.PaymentType).HasDefaultValueSql("''");
            //    b.Property(e => e.ReceiptNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ChequeNo).HasDefaultValueSql("''");
            //    b.Property(e => e.WorkType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.VehicleID).HasDefaultValueSql("''");
            //    b.Property(e => e.StartTime).HasDefaultValueSql("''");
            //    b.Property(e => e.EndTime).HasDefaultValueSql("''");
            //    b.Property(e => e.ReferenceNo).HasDefaultValueSql("''");
            //    b.Property(e => e.LocDesc1).HasDefaultValueSql("''");
            //    b.Property(e => e.LocDesc2).HasDefaultValueSql("''");
            //    b.Property(e => e.LocDesc3).HasDefaultValueSql("''");
            //    b.Property(e => e.SubOri1).HasDefaultValueSql("''");
            //    b.Property(e => e.SubOri2).HasDefaultValueSql("''");
            //    b.Property(e => e.SubDest1).HasDefaultValueSql("''");
            //    b.Property(e => e.SubDest2).HasDefaultValueSql("''");
            //    b.Property(e => e.IsParent).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ProcStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ProcType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.DestRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransportType).HasDefaultValueSql("''");
            //    b.Property(e => e.TransportQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BankID).HasDefaultValueSql("''");
            //    b.Property(e => e.SvcType).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.PICName).HasDefaultValueSql("''");
            //    b.Property(e => e.PICID).HasDefaultValueSql("''");
            //    b.Property(e => e.LocID).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo1).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo2).HasDefaultValueSql("''");
            //    b.Property(e => e.CODFilePath).HasDefaultValueSql("''");
            //    b.Property(e => e.CODCreateDate).HasDefaultValueSql("getdate()");
            //});
            //#endregion
            //#region WORKORDERDTL
            //modelBuilder.Entity<DTO.Questil.WorkOrder.WORKORDERDTL>(b =>
            //{
            //    b.HasKey(e => new { e.WOID, e.SeqNo, e.MastType, e.ItemCode, });
            //    b.Property(e => e.WOID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MastType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("''");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RecQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SentQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AdjQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActualQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActualQty1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActualQty2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UOM).HasDefaultValueSql("''");
            //    b.Property(e => e.PackUOM).HasDefaultValueSql("''");
            //    b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RecPackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SentPackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AdjPackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActualPackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Multiplier).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellPrice).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellPrice1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellPrice2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellPrice3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BaseRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotAmt1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotAmt2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotAmt3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SvcType).HasDefaultValueSql("''");
            //    b.Property(e => e.IsPack).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Rating1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Rating2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Rating3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ImageRes1).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageRes2).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageRes3).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageSign1).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageSign2).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageSign3).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark1).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark2).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark3).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.InitQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AddQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SellType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TreatmentType).HasDefaultValueSql("''");
            //    b.Property(e => e.CostAmt1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CostAmt2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CostAmt3).HasDefaultValueSql("(0)");
            //});
            //#endregion
            //#region WORKORDERLOG
            //modelBuilder.Entity<DTO.Questil.WorkOrder.WORKORDERLOG>(b =>
            //{
            //    b.HasKey(e => new { e.MSTRID, e.ScheduleID, e.WorkerID, e.VehicleID, e.LogDate, e.Status, });
            //    b.Property(e => e.MSTRID).HasDefaultValueSql("''");
            //    b.Property(e => e.ScheduleID).HasDefaultValueSql("''");
            //    b.Property(e => e.WorkerID).HasDefaultValueSql("''");
            //    b.Property(e => e.VehicleID).HasDefaultValueSql("''");
            //    b.Property(e => e.LogDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.SubDest1).HasDefaultValueSql("''");
            //    b.Property(e => e.SubDest2).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark1).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark2).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("''");
            //});
            //#endregion
            //#region WORKORDERDTLLOG
            //modelBuilder.Entity<DTO.Questil.WorkOrder.WORKORDERDTLLOG>(b =>
            //{
            //    b.HasKey(e => new { e.WOID, e.SeqNo, e.ItemCode, e.SellType, e.LogDate, e.RowVersion, });
            //    b.Property(e => e.LogDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.PrevQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PrevSentQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SentQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PrevRecQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RecQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PrevActualQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActualQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PrevUOM).HasDefaultValueSql("''");
            //    b.Property(e => e.UOM).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //});
            //#endregion
            //#region WORKRESULT
            //modelBuilder.Entity<DTO.Questil.WorkOrder.WORKRESULT>(b =>
            //{
            //    b.HasKey(e => new { e.BatchCode, e.WID, e.SeqNo, });
            //    b.Property(e => e.BatchCode).HasDefaultValueSql("''");
            //    b.Property(e => e.WID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("''");
            //    b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
            //    b.Property(e => e.InspectStartDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.InspectEndDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.ResultTitle).HasDefaultValueSql("''");
            //    b.Property(e => e.SubDest1).HasDefaultValueSql("''");
            //    b.Property(e => e.SubDest2).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageRes1).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageRes2).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageRes3).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageSign1).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageSign2).HasDefaultValueSql("''");
            //    b.Property(e => e.ImageSign3).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Rating).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark2).HasDefaultValueSql("''");
            //    b.Property(e => e.IsRedo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefWID).HasDefaultValueSql("''");
            //    b.Property(e => e.AssignTo).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActualQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ActualPackQty).HasDefaultValueSql("(0)");
            //});
            //#endregion
            //#region WORKORDERBIN
            //modelBuilder.Entity<DTO.Questil.WorkOrder.WORKORDERBIN>(b =>
            //{
            //    b.HasKey(e => new { e.WOID, e.SeqNo, e.MastType, e.ItemCode, e.PackSerial, });
            //    b.Property(e => e.WOID).HasDefaultValueSql("''");
            //    b.Property(e => e.MastType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PackSerial).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo).HasDefaultValueSql("''");
            //    b.Property(e => e.UOM).HasDefaultValueSql("''");
            //    b.Property(e => e.PackUOM).HasDefaultValueSql("''");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark1).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark2).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark3).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});
            //#endregion
            //#region INSPECTCHECK
            //modelBuilder.Entity<DTO.Questil.WorkOrder.INSPECTCHECK>(b =>
            //{
            //    b.HasKey(e => new { e.InspectCode, e.SiteCode, e.LotCode, e.SeqNo, e.SubDest1, e.SubDest2, });
            //    b.Property(e => e.InspectCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SiteCode).HasDefaultValueSql("''");
            //    b.Property(e => e.LotCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SubDest1).HasDefaultValueSql("''");
            //    b.Property(e => e.SubDest2).HasDefaultValueSql("''");
            //    b.Property(e => e.SiteType).HasDefaultValueSql("''");
            //    b.Property(e => e.LotType).HasDefaultValueSql("''");
            //    b.Property(e => e.MHECode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ClassType).HasDefaultValueSql("''");
            //    b.Property(e => e.TypeCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RecQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SentQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AdjQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UOM).HasDefaultValueSql("''");
            //    b.Property(e => e.PackUOM).HasDefaultValueSql("''");
            //    b.Property(e => e.PackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RecPackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SentPackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AdjPackQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SYSKey).HasDefaultValueSql("''");
            //    b.Property(e => e.SYSType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SYSValue).HasDefaultValueSql("''");
            //    b.Property(e => e.Condition).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.EmployeeID).HasDefaultValueSql("''");
            //    b.Property(e => e.Rating1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Images).HasDefaultValueSql("''");
            //    b.Property(e => e.Rating2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Images2).HasDefaultValueSql("''");
            //    b.Property(e => e.ConfirmID).HasDefaultValueSql("''");
            //    b.Property(e => e.IsLocked).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion
            //#region MOB_QUEST
            //modelBuilder.Entity<DTO.Questil.WorkOrder.MOB_QUEST>(b =>
            //{
            //    b.HasKey(e => new { e.AppID, e.GrpID, e.ActType, e.SYSKey, });
            //    b.Property(e => e.AppID).HasDefaultValueSql("(1)");
            //    b.Property(e => e.GrpID).HasDefaultValueSql("''");
            //    b.Property(e => e.ActType).HasDefaultValueSql("''");
            //    b.Property(e => e.SYSKey).HasDefaultValueSql("''");
            //    b.Property(e => e.SYSType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SYSDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.RefType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefValue).HasDefaultValueSql("''");
            //    b.Property(e => e.IsCheck).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChkType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChkValue).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});
            //#endregion
            //modelBuilder.Entity<DTO.Questil.WorkOrder.IMAGEUPLOAD>(b =>
            //{
            //    b.HasKey(e => new { e.UploadImageID, e.RefNo, e.SeqNo, e.UploadType, });
            //    b.Property(e => e.PathImage).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region paymentq
            //modelBuilder.Entity<Plexform.DTO.Questil.Payment.INVOICEHDR_CWMS>(b =>
            //{
            //    b.HasKey(e => new { e.MonthCode, e.PBTCode, e.BatchCode, });
            //    b.Property(e => e.MonthCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PBTCode).HasDefaultValueSql("''");
            //    b.Property(e => e.BatchCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TotalRec1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec4).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalRec5).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt1).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt2).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt3).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt4).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalAmt5).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});
            //#endregion

            //#region Report
            //modelBuilder.Entity<DTO.Questil.Report.SYSREPORT>(b =>
            //{
            //    b.HasKey(e => new { e.APPID, e.RPTCode, });
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //});
            //#endregion

            //#region questil payment
            //modelBuilder.Entity<DTO.Questil.Payment.INSERVICEHDR>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.InSvcID, e.CustLocID, e.InSvcDate, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.InSvcID).HasDefaultValueSql("''");
            //    b.Property(e => e.MonthCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TermID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CustRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.CustLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.CustName).HasDefaultValueSql("''");
            //    b.Property(e => e.CustAddress).HasDefaultValueSql("''");
            //    b.Property(e => e.CustPIC).HasDefaultValueSql("''");
            //    b.Property(e => e.CustTelNo).HasDefaultValueSql("''");
            //    b.Property(e => e.CustEmail).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo).HasDefaultValueSql("''");
            //    b.Property(e => e.RefStatus).HasDefaultValueSql("''");
            //    b.Property(e => e.InSvcTime).HasDefaultValueSql("''");
            //    b.Property(e => e.OutSvcTime).HasDefaultValueSql("''");
            //    b.Property(e => e.ServerID).HasDefaultValueSql("''");
            //    b.Property(e => e.EmpType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransSubTotal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransAmtRnd).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransAmtSave).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransAmtOrg).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransChgAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDiscType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscValue).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransDiscAuth).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDiscReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransDiscRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.TransAmtSpDisc).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransValueSpDisc).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Currency).HasDefaultValueSql("''");
            //    b.Property(e => e.ExchgRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CurrencyPaid).HasDefaultValueSql("''");
            //    b.Property(e => e.CollectedAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastPaidID).HasDefaultValueSql("''");
            //    b.Property(e => e.LastPaidAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AuthSpDisc).HasDefaultValueSql("''");
            //    b.Property(e => e.IsSent).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SentAttempt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SpDiscReasonCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SpDiscRemark).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Reason).HasDefaultValueSql("''");
            //    b.Property(e => e.PrintedRpt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.IsCompleted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AnalysisSts).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChkOutTermID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.FilePath).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<DTO.Questil.Payment.INSERVICEDTL>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.InSvcID, e.MSTRID, e.SeqNo, e.DeliveryDate, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.InSvcID).HasDefaultValueSql("''");
            //    b.Property(e => e.MSTRID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(1)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("''");
            //    b.Property(e => e.BehvType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Qty).HasDefaultValueSql("(1)");
            //    b.Property(e => e.UnitCost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.DeliveryDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.OrgPrice).HasDefaultValueSql("(0)");
            //    b.Property(e => e.NettPrice).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SubTotal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.DiscAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.NettAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Currency).HasDefaultValueSql("''");
            //    b.Property(e => e.SubPoints).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Points).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PriceOverrided).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Discounted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Taxable).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ReturnCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.SerialNo).HasDefaultValueSql("''");
            //    b.Property(e => e.PriceAuthID).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CustPkgID).HasDefaultValueSql("''");
            //    b.Property(e => e.PrcDisplayType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PromoCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.QGroupID).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //});

            //#endregion

            //#endregion

            //#region CAMPAIGN
            //modelBuilder.Entity<Plexform.DTO.Campaign.CAMPDOC>(b =>
            //{
            //    b.HasKey(e => new { e.BizLocID, e.BizRegID, e.CampID, e.DocNo, e.SeqNo, e.LineCode, });
            //    b.Property(e => e.DocNo).HasDefaultValueSql("''");
            //    b.Property(e => e.CampID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("''");
            //    b.Property(e => e.LineCode).HasDefaultValueSql("''");
            //    b.Property(e => e.DocCode).HasDefaultValueSql("''");
            //    b.Property(e => e.DocType).HasDefaultValueSql("''");
            //    b.Property(e => e.DocMode).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Name).HasDefaultValueSql("''");
            //    b.Property(e => e.Description).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateMethod).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.PathRef).HasDefaultValueSql("''");
            //    b.Property(e => e.URLRef).HasDefaultValueSql("''");
            //    b.Property(e => e.Signature).HasDefaultValueSql("NULL");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<Plexform.DTO.Campaign.CAMPDTL>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.CampID, e.SeqNo, e.LineCode, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.CampID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LineCode).HasDefaultValueSql("''");
            //    b.Property(e => e.LineType).HasDefaultValueSql("''");
            //    b.Property(e => e.LineName).HasDefaultValueSql("''");
            //    b.Property(e => e.LineDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.LineImage).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChangedBy_B).HasDefaultValueSql("''");
            //    b.Property(e => e.UnitPriceReq_B).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChangedBy_C).HasDefaultValueSql("''");
            //    b.Property(e => e.UnitPriceReq_C).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<DTO.Campaign.CAMPHDR>(b =>
            //{
            //    b.HasKey(e => new { e.CampID, e.BizRegID, e.BizLocID, });
            //    b.Property(e => e.DocumentNo).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo1).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo2).HasDefaultValueSql("''");
            //    b.Property(e => e.Name).HasDefaultValueSql("''");
            //    b.Property(e => e.Description).HasDefaultValueSql("''");
            //    b.Property(e => e.ParentID).HasDefaultValueSql("''");
            //    b.Property(e => e.Owner).HasDefaultValueSql("''");
            //    b.Property(e => e.CampType).HasDefaultValueSql("''");
            //    b.Property(e => e.CampReason).HasDefaultValueSql("''");
            //    b.Property(e => e.CampMonths).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CampNote).HasDefaultValueSql("''");
            //    b.Property(e => e.CampOrgAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CampDisc).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalCampAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RowType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Currency).HasDefaultValueSql("''");
            //    b.Property(e => e.Regions).HasDefaultValueSql("''");
            //    b.Property(e => e.CommID).HasDefaultValueSql("''");
            //    b.Property(e => e.QuizID).HasDefaultValueSql("''");
            //    b.Property(e => e.QuizIDSuppDoc).HasDefaultValueSql("''");
            //    b.Property(e => e.ExecStrategy).HasDefaultValueSql("''");
            //    b.Property(e => e.Version).HasDefaultValueSql("''");
            //    b.Property(e => e.Template).HasDefaultValueSql("''");
            //    b.Property(e => e.BaseLineSpend).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TargetSaving).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsSetTime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsRun).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PreBidOpt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotBiddingOpt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.FirstLotRunTime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.FirstLotRunTimeOpt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TimeLotClose).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TimeLotCloseOpt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsAllowBidOvrTime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OvrTimeTrigger).HasDefaultValueSql("(0)");
            //    b.Property(e => e.StartOvrTime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.OvrTimePeriod).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ImproveBidBy).HasDefaultValueSql("''");
            //    b.Property(e => e.SubmitTieBidOpt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsAllowSelBidCurr).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsDispExchRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ViewMktInfoOpt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsShowLeadBid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsCanSeeRank).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SeeRankAfter).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsSpecifyInitValue).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsCopy).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefID).HasDefaultValueSql("''");
            //    b.Property(e => e.EventStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.IsApproved).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ApprovalFlow).HasDefaultValueSql("''");
            //    b.Property(e => e.ApprovedDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<Plexform.DTO.Campaign.CAMPITEM>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.CampID, e.SeqNo, e.ItemCode, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.CampID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemDesc_B).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemName).HasDefaultValueSql("''");
            //    b.Property(e => e.LineCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PackageCode).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UOM).HasDefaultValueSql("''");
            //    b.Property(e => e.CurrencyBase).HasDefaultValueSql("''");
            //    b.Property(e => e.ExchangeRate).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceBase).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalPriceBase).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CurrencyReq).HasDefaultValueSql("''");
            //    b.Property(e => e.UnitPriceReq_B).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReq_C).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChangedBy_B).HasDefaultValueSql("''");
            //    b.Property(e => e.ChangedBy_C).HasDefaultValueSql("''");
            //    b.Property(e => e.QtyReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceRReq).HasDefaultValueSql("''");
            //    b.Property(e => e.QtyRmrkReq).HasDefaultValueSql("''");
            //    b.Property(e => e.TaxAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.DiscAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SubTotalReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotalPriceReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PointReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PointRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceRRef).HasDefaultValueSql("''");
            //    b.Property(e => e.QtyRmrkRef).HasDefaultValueSql("''");
            //    b.Property(e => e.TotalPriceRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceAdd).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceAvg).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceAvgVar).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReqVar).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Variance).HasDefaultValueSql("(0)");
            //    b.Property(e => e.VatAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.AppInfo1).HasDefaultValueSql("''");
            //    b.Property(e => e.AppInfo2).HasDefaultValueSql("''");
            //    b.Property(e => e.Mechanic).HasDefaultValueSql("''");
            //    b.Property(e => e.UOMRef).HasDefaultValueSql("''");
            //    b.Property(e => e.UnitPriceCamp).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefNo).HasDefaultValueSql("''");
            //    b.Property(e => e.RefNo_B).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<Plexform.DTO.Campaign.CAMPITEMSUPP>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.CampID, e.SeqNo, e.PackageCode, e.ItemCode, });
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.CampID).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PackageCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemName).HasDefaultValueSql("''");
            //    b.Property(e => e.TransVoid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UOM).HasDefaultValueSql("''");
            //    b.Property(e => e.UnitPriceBase).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceRef).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CurrencyReq).HasDefaultValueSql("''");
            //    b.Property(e => e.QtyReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReq_B).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UnitPriceReq_C).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ChangedBy_B).HasDefaultValueSql("''");
            //    b.Property(e => e.ChangedBy_C).HasDefaultValueSql("''");
            //    b.Property(e => e.DiscAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TaxAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LiveCal).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<DTO.Campaign.CAMPLOT>(b =>
            //{
            //    b.HasKey(e => new { e.LotID, e.CampID, e.LotSeq, e.LotStatus, });
            //    b.Property(e => e.LotID).HasDefaultValueSql("''");
            //    b.Property(e => e.CampID).HasDefaultValueSql("''");
            //    b.Property(e => e.LotSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Category).HasDefaultValueSql("''");
            //    b.Property(e => e.LotCode).HasDefaultValueSql("''");
            //    b.Property(e => e.LotName).HasDefaultValueSql("''");
            //    b.Property(e => e.LotDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.LotType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CommID).HasDefaultValueSql("''");
            //    b.Property(e => e.IsVisible).HasDefaultValueSql("(1)");
            //    b.Property(e => e.SubmitTieBidOpt).HasDefaultValueSql("(1)");
            //    b.Property(e => e.ImproveBidBy).HasDefaultValueSql("''");
            //    b.Property(e => e.DecreaseAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.FrontBufferAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BackBufferAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotInitAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotMaxAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotMinAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotHistAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotTotAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotTotAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotTotMaxP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotTotMax).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotTotMinP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotTotMin).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotTotHistP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotTotHist).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotSaveAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotSaveAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotCurr).HasDefaultValueSql("''");
            //    b.Property(e => e.LeadBidPartRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.LeadBidPartLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.LeadBidInitAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LeadBidQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LeadBidTotAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LeadBidTotAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastBidPartRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.LastBidPartLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.LastBidInitAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastBidQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastBidTotAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastBidTotAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SelBidPartRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.SelBidPartLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.SelBidInitAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SelBidQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SelBidTotAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SelBidTotAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsOvertime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CntOvertime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsSelected).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ShowSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastActTime).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<DTO.Campaign.CAMPLOTITEM>(b =>
            //{
            //    b.HasKey(e => new { e.LotID, e.CampID, e.DocNo, e.SeqNo, e.ItemCode, });
            //    b.Property(e => e.LotID).HasDefaultValueSql("''");
            //    b.Property(e => e.CampID).HasDefaultValueSql("''");
            //    b.Property(e => e.DocNo).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemName).HasDefaultValueSql("''");
            //    b.Property(e => e.ItemDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.BidType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CommID).HasDefaultValueSql("''");
            //    b.Property(e => e.IsVisible).HasDefaultValueSql("(1)");
            //    b.Property(e => e.ItemInitAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemMaxAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemMinAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemHistAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemTotAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemTotAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemTotMaxP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemTotMax).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemTotMinP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemTotMin).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemTotHistP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemTotHist).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemSaveAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemSaveAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemCurr).HasDefaultValueSql("''");
            //    b.Property(e => e.LeadBidPartRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.LeadBidPartLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.LeadBidInitAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LeadBidQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LeadBidTotAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LeadBidTotAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastBidPartRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.LastBidPartLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.LastBidInitAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastBidQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastBidTotAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LastBidTotAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SelBidPartRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.SelBidPartLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.SelBidInitAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SelBidQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SelBidTotAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.SelBidTotAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsOvertime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CntOvertime).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsSelected).HasDefaultValueSql("(0)");
            //    b.Property(e => e.LotStatus).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<Plexform.DTO.Campaign.CAMPLOTPAX>(b =>
            //{
            //    b.HasKey(e => new { e.LotID, e.CampID, e.BizRegID, e.BizLocID, e.SeqNo, e.PaxRegID, e.PaxLocID, });
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PaxRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.PaxLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.PaxMode).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PaxRole).HasDefaultValueSql("(0)");
            //    b.Property(e => e.JoinDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.ContactPerson).HasDefaultValueSql("''");
            //    b.Property(e => e.ContactDesignation).HasDefaultValueSql("''");
            //    b.Property(e => e.ContactEmail).HasDefaultValueSql("''");
            //    b.Property(e => e.ContactTelNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ContactMobile).HasDefaultValueSql("''");
            //    b.Property(e => e.IsReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsResponse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsLocked).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsApproved).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MaxAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotMaxP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TotMax).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<Plexform.DTO.Campaign.CAMPPAX>(b =>
            //{
            //    b.HasKey(e => new { e.CampID, e.BizRegID, e.BizLocID, e.SeqNo, e.TransNo, });
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TransNo).HasDefaultValueSql("''");
            //    b.Property(e => e.PaxRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.PaxLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.PaxMode).HasDefaultValueSql("(0)");
            //    b.Property(e => e.PaxRole).HasDefaultValueSql("(0)");
            //    b.Property(e => e.JoinDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.ContactPerson).HasDefaultValueSql("''");
            //    b.Property(e => e.ContactDesignation).HasDefaultValueSql("''");
            //    b.Property(e => e.ContactEmail).HasDefaultValueSql("''");
            //    b.Property(e => e.ContactTelNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ContactMobile).HasDefaultValueSql("''");
            //    b.Property(e => e.IsReq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsResponse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsLocked).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsApproved).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QualificationStep).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsQualified).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Remark).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});


            //modelBuilder.Entity<Plexform.DTO.Campaign.PROMOPOLICY>(b =>
            //{
            //    b.HasKey(e => new { e.BizRegID, e.BizLocID, e.PromoID, e.PolicyNo, e.ItemCode, e.SeqNo, });
            //    b.Property(e => e.PolicyNo).HasDefaultValueSql("''");
            //    b.Property(e => e.PromoID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizRegID).HasDefaultValueSql("''");
            //    b.Property(e => e.BizLocID).HasDefaultValueSql("''");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Description).HasDefaultValueSql("''");
            //    b.Property(e => e.EffectiveDay).HasDefaultValueSql("(0)");
            //    b.Property(e => e.EntAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ExpiryDay).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.GST).HasDefaultValueSql("(0)");
            //    b.Property(e => e.GroupCode).HasDefaultValueSql("''");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsGST).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsMix).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MaxAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MinAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MixDesc).HasDefaultValueSql("''");
            //    b.Property(e => e.Name).HasDefaultValueSql("''");
            //    b.Property(e => e.OptPolicy).HasDefaultValueSql("''");
            //    b.Property(e => e.PeriodDay).HasDefaultValueSql("''");
            //    b.Property(e => e.PeriodMonth).HasDefaultValueSql("''");
            //    b.Property(e => e.PeriodType).HasDefaultValueSql("''");
            //    b.Property(e => e.PeriodWeek).HasDefaultValueSql("''");
            //    b.Property(e => e.PolicyCode).HasDefaultValueSql("''");
            //    b.Property(e => e.PolicyType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.RefID).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark1).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark2).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark3).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark4).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark5).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark6).HasDefaultValueSql("''");
            //    b.Property(e => e.Remark7).HasDefaultValueSql("''");
            //    b.Property(e => e.Status).HasDefaultValueSql("(0)");
            //    b.Property(e => e.TradeupAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.MaxQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.MinQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.ItemCode).HasDefaultValueSql("''");
            //    b.Property(e => e.SeqNo).HasDefaultValueSql("''");
            //    b.Property(e => e.ExpiryType).HasDefaultValueSql("(0)");
            //    b.Property(e => e.QtyType).HasDefaultValueSql("(0)");
            //});

            //modelBuilder.Entity<DTO.Campaign.CAMPAFFILIATE>(b =>
            //{
            //    b.HasKey(e => new { e.BizLocID, e.BizRegID, e.CampNo, e.DocNo, e.SeqNo, e.LineCode, });
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //});

            //#region CAMPCOMMITTEE
            //modelBuilder.Entity<DTO.Campaign.CAMPCOMMITTEE>(b =>
            //{
            //    b.HasKey(e => new { e.CampID, e.BizRegID, e.BizLocID, e.SeqNo, e.UserID, });
            //});
            //#endregion
            //#endregion

            //#region BIDDING
            //modelBuilder.Entity<DTO.Clobid.CBXBIDDING>(b =>
            //{
            //    b.HasKey(e => new { e.BidID, e.LotID, e.CampID, e.PaxRegID, e.PaxLocID, e.BidSeq, });
            //    b.Property(e => e.BidSeq).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BidInitAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BidQty).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BidTotAmtP).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BidTotAmt).HasDefaultValueSql("(0)");
            //    b.Property(e => e.BidCurr).HasDefaultValueSql("''");
            //    b.Property(e => e.BidRank).HasDefaultValueSql("(0)");
            //    b.Property(e => e.IsPrebid).HasDefaultValueSql("(0)");
            //    b.Property(e => e.CreateDate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.CreateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.UpdateBy).HasDefaultValueSql("''");
            //    b.Property(e => e.Posted).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Active).HasDefaultValueSql("(1)");
            //    b.Property(e => e.Inuse).HasDefaultValueSql("(0)");
            //    b.Property(e => e.Flag).HasDefaultValueSql("(1)");
            //    b.Property(e => e.rowguid).HasDefaultValueSql("newid()");
            //    b.Property(e => e.SyncCreate).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.SyncLastUpd).HasDefaultValueSql("getdate()");
            //    b.Property(e => e.LastSyncBy).HasDefaultValueSql("''");
            //    b.Property(e => e.IsHost).HasDefaultValueSql("(0)");
            //});
            //#endregion

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
