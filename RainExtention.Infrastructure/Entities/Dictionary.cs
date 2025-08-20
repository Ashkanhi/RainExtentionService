using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Dictionary")]
public partial class Dictionary
{
    [Key]
    [Column("DictionaryID")]
    public int DictionaryId { get; set; }

    public int? DictionaryType { get; set; }

    [InverseProperty("Type")]
    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    [InverseProperty("Language")]
    public virtual ICollection<ApplicationMenuCaption> ApplicationMenuCaptions { get; set; } = new List<ApplicationMenuCaption>();

    [InverseProperty("ActionType")]
    public virtual ICollection<ApplicationMenu> ApplicationMenus { get; set; } = new List<ApplicationMenu>();

    [InverseProperty("Type")]
    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    [InverseProperty("Period")]
    public virtual ICollection<AutomaticOrderPlan> AutomaticOrderPlanPeriods { get; set; } = new List<AutomaticOrderPlan>();

    [InverseProperty("PlanType")]
    public virtual ICollection<AutomaticOrderPlan> AutomaticOrderPlanPlanTypes { get; set; } = new List<AutomaticOrderPlan>();

    [InverseProperty("Status")]
    public virtual ICollection<AutomaticOrderPlan> AutomaticOrderPlanStatuses { get; set; } = new List<AutomaticOrderPlan>();

    [InverseProperty("Status")]
    public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; } = new List<BillOfMaterial>();

    [InverseProperty("Type")]
    public virtual ICollection<CashLoan> CashLoans { get; set; } = new List<CashLoan>();

    [InverseProperty("Status")]
    public virtual ICollection<CashSettelment> CashSettelments { get; set; } = new List<CashSettelment>();

    [InverseProperty("Type")]
    public virtual ICollection<CustomerRelationship> CustomerRelationships { get; set; } = new List<CustomerRelationship>();

    [InverseProperty("Status")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    [InverseProperty("Status")]
    public virtual ICollection<DetailAccount> DetailAccountStatuses { get; set; } = new List<DetailAccount>();

    [InverseProperty("Type")]
    public virtual ICollection<DetailAccount> DetailAccountTypes { get; set; } = new List<DetailAccount>();

    [InverseProperty("Dictionary")]
    public virtual ICollection<DictionaryImage> DictionaryImages { get; set; } = new List<DictionaryImage>();

    [InverseProperty("Dictionary")]
    public virtual ICollection<DictionaryTranslation> DictionaryTranslations { get; set; } = new List<DictionaryTranslation>();

    [InverseProperty("Dictionary")]
    public virtual ICollection<DictionaryValue> DictionaryValues { get; set; } = new List<DictionaryValue>();

    [InverseProperty("DiscountType")]
    public virtual ICollection<Discount> DiscountDiscountTypes { get; set; } = new List<Discount>();

    [InverseProperty("DiscountType")]
    public virtual ICollection<DiscountPriceLevel> DiscountPriceLevels { get; set; } = new List<DiscountPriceLevel>();

    [InverseProperty("Status")]
    public virtual ICollection<Discount> DiscountStatuses { get; set; } = new List<Discount>();

    [InverseProperty("ThersholdType")]
    public virtual ICollection<Discount> DiscountThersholdTypes { get; set; } = new List<Discount>();

    [InverseProperty("Type")]
    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();

    [InverseProperty("Status")]
    public virtual ICollection<FileRepository> FileRepositories { get; set; } = new List<FileRepository>();

    [InverseProperty("DocumentType")]
    public virtual ICollection<FinancialDocument> FinancialDocumentDocumentTypes { get; set; } = new List<FinancialDocument>();

    [InverseProperty("Status")]
    public virtual ICollection<FinancialDocument> FinancialDocumentStatuses { get; set; } = new List<FinancialDocument>();

    [InverseProperty("Status")]
    public virtual ICollection<FinancialYear> FinancialYears { get; set; } = new List<FinancialYear>();

    [InverseProperty("Status")]
    public virtual ICollection<ItemSerializedStockState> ItemSerializedStockStates { get; set; } = new List<ItemSerializedStockState>();

    [InverseProperty("Status")]
    public virtual ICollection<Item> ItemStatuses { get; set; } = new List<Item>();

    [InverseProperty("Status")]
    public virtual ICollection<ItemStockState> ItemStockStates { get; set; } = new List<ItemStockState>();

    [InverseProperty("Type")]
    public virtual ICollection<Item> ItemTypes { get; set; } = new List<Item>();

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<Item> ItemUnitOfMeasures { get; set; } = new List<Item>();

    [InverseProperty("CalculationType")]
    public virtual ICollection<Lottery> LotteryCalculationTypes { get; set; } = new List<Lottery>();

    [InverseProperty("ThresholdType")]
    public virtual ICollection<Lottery> LotteryThresholdTypes { get; set; } = new List<Lottery>();

    [InverseProperty("Status")]
    public virtual ICollection<PartialPaymentRule> PartialPaymentRules { get; set; } = new List<PartialPaymentRule>();

    [InverseProperty("Salution")]
    public virtual ICollection<Person1> Person1s { get; set; } = new List<Person1>();

    [InverseProperty("Status")]
    public virtual ICollection<ProductCatalogDetail> ProductCatalogDetails { get; set; } = new List<ProductCatalogDetail>();

    [InverseProperty("Type")]
    public virtual ICollection<ProductCatalog> ProductCatalogs { get; set; } = new List<ProductCatalog>();

    [InverseProperty("Status")]
    public virtual ICollection<ProductionDocument> ProductionDocuments { get; set; } = new List<ProductionDocument>();

    [InverseProperty("Status")]
    public virtual ICollection<ProductionOrder> ProductionOrders { get; set; } = new List<ProductionOrder>();

    [InverseProperty("Season")]
    public virtual ICollection<ProductionPlan> ProductionPlanSeasons { get; set; } = new List<ProductionPlan>();

    [InverseProperty("Status")]
    public virtual ICollection<ProductionPlan> ProductionPlanStatuses { get; set; } = new List<ProductionPlan>();

    [InverseProperty("Type")]
    public virtual ICollection<Reason> Reasons { get; set; } = new List<Reason>();

    [InverseProperty("Type")]
    public virtual ICollection<RecentItem> RecentItems { get; set; } = new List<RecentItem>();

    [InverseProperty("Status")]
    public virtual ICollection<Repository> RepositoryStatuses { get; set; } = new List<Repository>();

    [InverseProperty("Type")]
    public virtual ICollection<Repository> RepositoryTypes { get; set; } = new List<Repository>();

    [InverseProperty("Status")]
    public virtual ICollection<SaleInvoiceLineItem> SaleInvoiceLineItemStatuses { get; set; } = new List<SaleInvoiceLineItem>();

    [InverseProperty("Type")]
    public virtual ICollection<SaleInvoiceLineItem> SaleInvoiceLineItemTypes { get; set; } = new List<SaleInvoiceLineItem>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<SaleInvoicePartialPayment> SaleInvoicePartialPaymentPaymentTypes { get; set; } = new List<SaleInvoicePartialPayment>();

    [InverseProperty("Status")]
    public virtual ICollection<SaleInvoicePartialPayment> SaleInvoicePartialPaymentStatuses { get; set; } = new List<SaleInvoicePartialPayment>();

    [InverseProperty("InvoiceType")]
    public virtual ICollection<SaleInvoice> SaleInvoices { get; set; } = new List<SaleInvoice>();

    [InverseProperty("Status")]
    public virtual ICollection<SaleItemDelivery> SaleItemDeliveries { get; set; } = new List<SaleItemDelivery>();

    [InverseProperty("ChangeType")]
    public virtual ICollection<SalePriceLineItem> SalePriceLineItems { get; set; } = new List<SalePriceLineItem>();

    [InverseProperty("PriceType")]
    public virtual ICollection<SalePrice> SalePricePriceTypes { get; set; } = new List<SalePrice>();

    [InverseProperty("Status")]
    public virtual ICollection<SalePrice> SalePriceStatuses { get; set; } = new List<SalePrice>();

    [InverseProperty("QoutaType")]
    public virtual ICollection<SaleQoutum> SaleQoutumQoutaTypes { get; set; } = new List<SaleQoutum>();

    [InverseProperty("Status")]
    public virtual ICollection<SaleQoutum> SaleQoutumStatuses { get; set; } = new List<SaleQoutum>();

    [InverseProperty("ChangeAmountType")]
    public virtual ICollection<StockDocumentCostModifier> StockDocumentCostModifiers { get; set; } = new List<StockDocumentCostModifier>();

    [InverseProperty("DocumentType")]
    public virtual ICollection<StockDocument> StockDocumentDocumentTypes { get; set; } = new List<StockDocument>();

    [InverseProperty("Month")]
    public virtual ICollection<StockDocumentLineItemMonth> StockDocumentLineItemMonths { get; set; } = new List<StockDocumentLineItemMonth>();

    [InverseProperty("Status")]
    public virtual ICollection<StockDocument> StockDocumentStatuses { get; set; } = new List<StockDocument>();

    [InverseProperty("ContractType")]
    public virtual ICollection<StoreContract> StoreContractContractTypes { get; set; } = new List<StoreContract>();

    [InverseProperty("Status")]
    public virtual ICollection<StoreContract> StoreContractStatuses { get; set; } = new List<StoreContract>();

    [InverseProperty("Status")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();

    [InverseProperty("ContractType")]
    public virtual ICollection<SupplierContract> SupplierContractContractTypes { get; set; } = new List<SupplierContract>();

    [InverseProperty("Status")]
    public virtual ICollection<SupplierContract> SupplierContractStatuses { get; set; } = new List<SupplierContract>();

    [InverseProperty("Status")]
    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();

    [InverseProperty("Status")]
    public virtual ICollection<TableManagement> TableManagements { get; set; } = new List<TableManagement>();

    [InverseProperty("Status")]
    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    [InverseProperty("CountryCode")]
    public virtual ICollection<Telephone> TelephoneCountryCodes { get; set; } = new List<Telephone>();

    [InverseProperty("Type")]
    public virtual ICollection<Telephone> TelephoneTypes { get; set; } = new List<Telephone>();

    [InverseProperty("ActionType")]
    public virtual ICollection<Tender> TenderActionTypes { get; set; } = new List<Tender>();

    [InverseProperty("TenderType")]
    public virtual ICollection<Tender> TenderTenderTypes { get; set; } = new List<Tender>();

    [InverseProperty("Status")]
    public virtual ICollection<ThirdParty> ThirdParties { get; set; } = new List<ThirdParty>();

    [InverseProperty("Type")]
    public virtual ICollection<TreasuryAccount> TreasuryAccounts { get; set; } = new List<TreasuryAccount>();

    [InverseProperty("DocumentType")]
    public virtual ICollection<TreasuryDocument> TreasuryDocumentDocumentTypes { get; set; } = new List<TreasuryDocument>();

    [InverseProperty("State")]
    public virtual ICollection<TreasuryDocumentLineItemDetail> TreasuryDocumentLineItemDetails { get; set; } = new List<TreasuryDocumentLineItemDetail>();

    [InverseProperty("State")]
    public virtual ICollection<TreasuryDocumentLineItem> TreasuryDocumentLineItems { get; set; } = new List<TreasuryDocumentLineItem>();

    [InverseProperty("Status")]
    public virtual ICollection<TreasuryDocument> TreasuryDocumentStatuses { get; set; } = new List<TreasuryDocument>();

    [InverseProperty("Language")]
    public virtual ICollection<User> UserLanguages { get; set; } = new List<User>();

    [InverseProperty("Status")]
    public virtual ICollection<User> UserStatuses { get; set; } = new List<User>();

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<WebSite> WebSites { get; set; } = new List<WebSite>();

    [InverseProperty("Type")]
    public virtual ICollection<Workstation> Workstations { get; set; } = new List<Workstation>();
}
