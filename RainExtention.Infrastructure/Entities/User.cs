using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("User")]
public partial class User
{
    [Key]
    [Column("UserID")]
    public Guid UserId { get; set; }

    [Column("EmployeeID")]
    public Guid? EmployeeId { get; set; }

    [StringLength(50)]
    public string? DisplayName { get; set; }

    [StringLength(50)]
    public string? LoginName { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column("IsNTUser")]
    public bool? IsNtuser { get; set; }

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<BankAccount> BankAccountCreationUserNavigations { get; set; } = new List<BankAccount>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<BankAccount> BankAccountModifyUserNavigations { get; set; } = new List<BankAccount>();

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<BillOfMaterial> BillOfMaterialApproveUserNavigations { get; set; } = new List<BillOfMaterial>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<BillOfMaterial> BillOfMaterialCreationUserNavigations { get; set; } = new List<BillOfMaterial>();

    [InverseProperty("VoidUserNavigation")]
    public virtual ICollection<BillOfMaterial> BillOfMaterialVoidUserNavigations { get; set; } = new List<BillOfMaterial>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<CashSettelment> CashSettelmentCreationUserNavigations { get; set; } = new List<CashSettelment>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<CashSettelment> CashSettelmentModifyUserNavigations { get; set; } = new List<CashSettelment>();

    [InverseProperty("User")]
    public virtual ICollection<CashSettelment> CashSettelmentUsers { get; set; } = new List<CashSettelment>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<CurrencyHistory> CurrencyHistories { get; set; } = new List<CurrencyHistory>();

    [ForeignKey("DetailAccountId")]
    [InverseProperty("Users")]
    public virtual DetailAccount? DetailAccount { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("Users")]
    public virtual Employee? Employee { get; set; }

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<FinancialDocument> FinancialDocumentApproveUserNavigations { get; set; } = new List<FinancialDocument>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<FinancialDocument> FinancialDocumentCreationUserNavigations { get; set; } = new List<FinancialDocument>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<FinancialDocument> FinancialDocumentModifyUserNavigations { get; set; } = new List<FinancialDocument>();

    [InverseProperty("TempUserNavigation")]
    public virtual ICollection<FinancialDocument> FinancialDocumentTempUserNavigations { get; set; } = new List<FinancialDocument>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<ImportDatum> ImportData { get; set; } = new List<ImportDatum>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<Item> ItemCreationUserNavigations { get; set; } = new List<Item>();

    [InverseProperty("User")]
    public virtual ICollection<ItemDepartmentLog> ItemDepartmentLogs { get; set; } = new List<ItemDepartmentLog>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<Item> ItemModifyUserNavigations { get; set; } = new List<Item>();

    [ForeignKey("LanguageId")]
    [InverseProperty("UserLanguages")]
    public virtual Dictionary? Language { get; set; }

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<Lottery> Lotteries { get; set; } = new List<Lottery>();

    [InverseProperty("User")]
    public virtual ICollection<MessageUserAssignment> MessageUserAssignments { get; set; } = new List<MessageUserAssignment>();

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<OrderDocument> OrderDocumentApproveUserNavigations { get; set; } = new List<OrderDocument>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<OrderDocument> OrderDocumentCreationUserNavigations { get; set; } = new List<OrderDocument>();

    [InverseProperty("VoidUserNavigation")]
    public virtual ICollection<OrderDocument> OrderDocumentVoidUserNavigations { get; set; } = new List<OrderDocument>();

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<PartialPaymentRule> PartialPaymentRuleApproveUserNavigations { get; set; } = new List<PartialPaymentRule>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<PartialPaymentRule> PartialPaymentRuleCreationUserNavigations { get; set; } = new List<PartialPaymentRule>();

    [InverseProperty("VoidUserNavigation")]
    public virtual ICollection<PartialPaymentRule> PartialPaymentRuleVoidUserNavigations { get; set; } = new List<PartialPaymentRule>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<PeriodicCosting> PeriodicCostings { get; set; } = new List<PeriodicCosting>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<ProductCatalog> ProductCatalogCreationUserNavigations { get; set; } = new List<ProductCatalog>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<ProductCatalog> ProductCatalogModifyUserNavigations { get; set; } = new List<ProductCatalog>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<ProductSize> ProductSizes { get; set; } = new List<ProductSize>();

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<ProductionDocument> ProductionDocumentApproveUserNavigations { get; set; } = new List<ProductionDocument>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<ProductionDocument> ProductionDocumentCreationUserNavigations { get; set; } = new List<ProductionDocument>();

    [InverseProperty("FinanceApproveUserNavigation")]
    public virtual ICollection<ProductionDocument> ProductionDocumentFinanceApproveUserNavigations { get; set; } = new List<ProductionDocument>();

    [InverseProperty("VoidUserNavigation")]
    public virtual ICollection<ProductionDocument> ProductionDocumentVoidUserNavigations { get; set; } = new List<ProductionDocument>();

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<ProductionOrder> ProductionOrderApproveUserNavigations { get; set; } = new List<ProductionOrder>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<ProductionOrder> ProductionOrderCreationUserNavigations { get; set; } = new List<ProductionOrder>();

    [InverseProperty("VoidUserNavigation")]
    public virtual ICollection<ProductionOrder> ProductionOrderVoidUserNavigations { get; set; } = new List<ProductionOrder>();

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<ProductionPlan> ProductionPlanApproveUserNavigations { get; set; } = new List<ProductionPlan>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<ProductionPlan> ProductionPlanCreationUserNavigations { get; set; } = new List<ProductionPlan>();

    [InverseProperty("VoidUserNavigation")]
    public virtual ICollection<ProductionPlan> ProductionPlanVoidUserNavigations { get; set; } = new List<ProductionPlan>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<QualityControlTask> QualityControlTasks { get; set; } = new List<QualityControlTask>();

    [InverseProperty("User")]
    public virtual ICollection<RecentItem> RecentItems { get; set; } = new List<RecentItem>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<SaleInvoice> SaleInvoiceCreationUserNavigations { get; set; } = new List<SaleInvoice>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<SaleInvoice> SaleInvoiceModifyUserNavigations { get; set; } = new List<SaleInvoice>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<SalePrice> SalePriceCreationUserNavigations { get; set; } = new List<SalePrice>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<SalePrice> SalePriceModifyUserNavigations { get; set; } = new List<SalePrice>();

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<SaleQoutum> SaleQoutumApproveUserNavigations { get; set; } = new List<SaleQoutum>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<SaleQoutum> SaleQoutumCreationUserNavigations { get; set; } = new List<SaleQoutum>();

    [InverseProperty("VoidUserNavigation")]
    public virtual ICollection<SaleQoutum> SaleQoutumVoidUserNavigations { get; set; } = new List<SaleQoutum>();

    [InverseProperty("User")]
    public virtual ICollection<ShelfPricePrintHistory> ShelfPricePrintHistories { get; set; } = new List<ShelfPricePrintHistory>();

    [InverseProperty("LastUserNavigation")]
    public virtual ICollection<ShelfPricePrint> ShelfPricePrints { get; set; } = new List<ShelfPricePrint>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<ShelfPrice> ShelfPrices { get; set; } = new List<ShelfPrice>();

    [ForeignKey("StatusId")]
    [InverseProperty("UserStatuses")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<StockDocument> StockDocumentApproveUserNavigations { get; set; } = new List<StockDocument>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<StockDocument> StockDocumentCreationUserNavigations { get; set; } = new List<StockDocument>();

    [InverseProperty("FinanceApproveUserNavigation")]
    public virtual ICollection<StockDocument> StockDocumentFinanceApproveUserNavigations { get; set; } = new List<StockDocument>();

    [InverseProperty("VoidUserNavigation")]
    public virtual ICollection<StockDocument> StockDocumentVoidUserNavigations { get; set; } = new List<StockDocument>();

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<StoreContract> StoreContractApproveUserNavigations { get; set; } = new List<StoreContract>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<StoreContract> StoreContractCreationUserNavigations { get; set; } = new List<StoreContract>();

    [InverseProperty("VoidUserNavigation")]
    public virtual ICollection<StoreContract> StoreContractVoidUserNavigations { get; set; } = new List<StoreContract>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<SupplierContract> SupplierContractCreationUserNavigations { get; set; } = new List<SupplierContract>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<SupplierContract> SupplierContractModifyUserNavigations { get; set; } = new List<SupplierContract>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<Task> TaskCreationUserNavigations { get; set; } = new List<Task>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<Task> TaskModifyUserNavigations { get; set; } = new List<Task>();

    [InverseProperty("User")]
    public virtual ICollection<Task> TaskUsers { get; set; } = new List<Task>();

    [InverseProperty("ApproveUserNavigation")]
    public virtual ICollection<TreasuryDocument> TreasuryDocumentApproveUserNavigations { get; set; } = new List<TreasuryDocument>();

    [InverseProperty("CreationUserNavigation")]
    public virtual ICollection<TreasuryDocument> TreasuryDocumentCreationUserNavigations { get; set; } = new List<TreasuryDocument>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<TreasuryDocumentLineItemDetail> TreasuryDocumentLineItemDetails { get; set; } = new List<TreasuryDocumentLineItemDetail>();

    [InverseProperty("ModifyUserNavigation")]
    public virtual ICollection<TreasuryDocumentLineItem> TreasuryDocumentLineItems { get; set; } = new List<TreasuryDocumentLineItem>();

    [InverseProperty("VoidUserNavigation")]
    public virtual ICollection<TreasuryDocument> TreasuryDocumentVoidUserNavigations { get; set; } = new List<TreasuryDocument>();

    [InverseProperty("User")]
    public virtual ICollection<UserCustomLayout> UserCustomLayouts { get; set; } = new List<UserCustomLayout>();

    [InverseProperty("User")]
    public virtual ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<Tender> Tenders { get; set; } = new List<Tender>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();
}
