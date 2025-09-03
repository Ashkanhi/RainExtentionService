using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RainExtention.Infrastructure.Entities;
namespace RainExtention.Infrastructure.Context;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActivePartialPaymentRule> ActivePartialPaymentRules { get; set; }

    public virtual DbSet<ActiveQuestion> ActiveQuestions { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AlternativeItem> AlternativeItems { get; set; }

    public virtual DbSet<AlternativeItem1> AlternativeItems1 { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<ApplicationMenu> ApplicationMenus { get; set; }

    public virtual DbSet<ApplicationMenuCaption> ApplicationMenuCaptions { get; set; }

    public virtual DbSet<RainExtention.Infrastructure.Entities.Attribute> Attributes { get; set; }

    public virtual DbSet<AttributeValue> AttributeValues { get; set; }

    public virtual DbSet<AutomaticOrderPlan> AutomaticOrderPlans { get; set; }

    public virtual DbSet<AutomaticOrderPlanDepartmentAssignment> AutomaticOrderPlanDepartmentAssignments { get; set; }

    public virtual DbSet<AutomaticOrderPlanDepartmentAssignmentView> AutomaticOrderPlanDepartmentAssignmentViews { get; set; }

    public virtual DbSet<AutomaticOrderPlanDepartmentEvent> AutomaticOrderPlanDepartmentEvents { get; set; }

    public virtual DbSet<AutomaticOrderPlanHistory> AutomaticOrderPlanHistories { get; set; }

    public virtual DbSet<AutomaticOrderPlanItemAssignment> AutomaticOrderPlanItemAssignments { get; set; }

    public virtual DbSet<AutomaticOrderPlanItemAssignmentView> AutomaticOrderPlanItemAssignmentViews { get; set; }

    public virtual DbSet<AutomaticOrderPlanItemEvent> AutomaticOrderPlanItemEvents { get; set; }

    public virtual DbSet<AutomaticOrderPlanStoreAssignmentView> AutomaticOrderPlanStoreAssignmentViews { get; set; }

    public virtual DbSet<AutomaticOrderPlanStoreGroupAssignmentView> AutomaticOrderPlanStoreGroupAssignmentViews { get; set; }

    public virtual DbSet<AutomaticOrderPlanSupplierAssignmentView> AutomaticOrderPlanSupplierAssignmentViews { get; set; }

    public virtual DbSet<AutomaticOrderPlanView> AutomaticOrderPlanViews { get; set; }

    public virtual DbSet<AutomaticOrderProposal> AutomaticOrderProposals { get; set; }

    public virtual DbSet<AutomaticOrderProposalLineItem> AutomaticOrderProposalLineItems { get; set; }

    public virtual DbSet<AutomaticOrderProposalLineItemView> AutomaticOrderProposalLineItemViews { get; set; }

    public virtual DbSet<AutomaticOrderProposalReferDocument> AutomaticOrderProposalReferDocuments { get; set; }

    public virtual DbSet<Bakhshi> Bakhshis { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<BillOfMaterial> BillOfMaterials { get; set; }

    public virtual DbSet<BillOfMaterialCustomField> BillOfMaterialCustomFields { get; set; }

    public virtual DbSet<BillOfMaterialImage> BillOfMaterialImages { get; set; }

    public virtual DbSet<BillOfMaterialItem> BillOfMaterialItems { get; set; }

    public virtual DbSet<BillOfMaterialItemRelatedItem> BillOfMaterialItemRelatedItems { get; set; }

    public virtual DbSet<BillOfMaterialItemRelatedItemsView> BillOfMaterialItemRelatedItemsViews { get; set; }

    public virtual DbSet<BillOfMaterialItemStep> BillOfMaterialItemSteps { get; set; }

    public virtual DbSet<BillOfMaterialItemStepView> BillOfMaterialItemStepViews { get; set; }

    public virtual DbSet<BillOfMaterialItemView> BillOfMaterialItemViews { get; set; }

    public virtual DbSet<BillOfMaterialView> BillOfMaterialViews { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Calendar> Calendars { get; set; }

    public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }

    public virtual DbSet<CalendarEventFix> CalendarEventFixes { get; set; }

    public virtual DbSet<CalendarView> CalendarViews { get; set; }

    public virtual DbSet<CashBackHistory> CashBackHistories { get; set; }

    public virtual DbSet<CashBackHistory1> CashBackHistory1s { get; set; }

    public virtual DbSet<CashLoan> CashLoans { get; set; }

    public virtual DbSet<CashSettelment> CashSettelments { get; set; }

    public virtual DbSet<CashSettelmentCustomField> CashSettelmentCustomFields { get; set; }

    public virtual DbSet<CashSettelmentLineItem> CashSettelmentLineItems { get; set; }

    public virtual DbSet<CashSettelmentLineItemView> CashSettelmentLineItemViews { get; set; }

    public virtual DbSet<CashSettelmentView> CashSettelmentViews { get; set; }

    public virtual DbSet<Checkapi> Checkapis { get; set; }

    public virtual DbSet<ChildWorkstation> ChildWorkstations { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyCustomField> CompanyCustomFields { get; set; }

    public virtual DbSet<CompanyNameTranslation> CompanyNameTranslations { get; set; }

    public virtual DbSet<CompanyView> CompanyViews { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CurrencyHistory> CurrencyHistories { get; set; }

    public virtual DbSet<CurrencyView> CurrencyViews { get; set; }

    public virtual DbSet<CurrentDiscount> CurrentDiscounts { get; set; }

    public virtual DbSet<CurrentItemPriceView> CurrentItemPriceViews { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerCard> CustomerCards { get; set; }

    public virtual DbSet<CustomerCreditHistory> CustomerCreditHistories { get; set; }

    public virtual DbSet<CustomerCustomField> CustomerCustomFields { get; set; }

    public virtual DbSet<CustomerFavorite> CustomerFavorites { get; set; }

    public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }

    public virtual DbSet<CustomerGroupAssignment> CustomerGroupAssignments { get; set; }

    public virtual DbSet<CustomerGroupAssignmentView> CustomerGroupAssignmentViews { get; set; }

    public virtual DbSet<CustomerGroupType> CustomerGroupTypes { get; set; }

    public virtual DbSet<CustomerGroupTypeView> CustomerGroupTypeViews { get; set; }

    public virtual DbSet<CustomerItemFavoritesView> CustomerItemFavoritesViews { get; set; }

    public virtual DbSet<CustomerNameView> CustomerNameViews { get; set; }

    public virtual DbSet<CustomerRelationship> CustomerRelationships { get; set; }

    public virtual DbSet<CustomerRelationshipView> CustomerRelationshipViews { get; set; }

    public virtual DbSet<CustomerResult> CustomerResults { get; set; }

    public virtual DbSet<CustomerStoreFavoritesView> CustomerStoreFavoritesViews { get; set; }

    public virtual DbSet<CustomerView> CustomerViews { get; set; }

    public virtual DbSet<Customerduplicate> Customerduplicates { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DepartmentType> DepartmentTypes { get; set; }

    public virtual DbSet<DepartmentTypeView> DepartmentTypeViews { get; set; }

    public virtual DbSet<DetailAccount> DetailAccounts { get; set; }

    public virtual DbSet<DetailAccountView> DetailAccountViews { get; set; }

    public virtual DbSet<Dictionary> Dictionaries { get; set; }

    public virtual DbSet<DictionaryImage> DictionaryImages { get; set; }

    public virtual DbSet<DictionaryTranslation> DictionaryTranslations { get; set; }

    public virtual DbSet<DictionaryValue> DictionaryValues { get; set; }

    public virtual DbSet<DictionaryValue14020528> DictionaryValue14020528s { get; set; }

    public virtual DbSet<DictionaryView> DictionaryViews { get; set; }

    public virtual DbSet<DimWorkstation> DimWorkstations { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<DiscountActiveTime> DiscountActiveTimes { get; set; }

    public virtual DbSet<DiscountCategory> DiscountCategories { get; set; }

    public virtual DbSet<DiscountCondition> DiscountConditions { get; set; }

    public virtual DbSet<DiscountCustomerGroupAssignmentView> DiscountCustomerGroupAssignmentViews { get; set; }

    public virtual DbSet<DiscountDepartmentAssignment> DiscountDepartmentAssignments { get; set; }

    public virtual DbSet<DiscountDepartmentAssignmentView> DiscountDepartmentAssignmentViews { get; set; }

    public virtual DbSet<DiscountItemAssignment> DiscountItemAssignments { get; set; }

    public virtual DbSet<DiscountItemAssignmentView> DiscountItemAssignmentViews { get; set; }

    public virtual DbSet<DiscountPriceLevel> DiscountPriceLevels { get; set; }

    public virtual DbSet<DiscountStoreAssignmentView> DiscountStoreAssignmentViews { get; set; }

    public virtual DbSet<DiscountStoreGroupAssignmentView> DiscountStoreGroupAssignmentViews { get; set; }

    public virtual DbSet<DiscountTender> DiscountTenders { get; set; }

    public virtual DbSet<DiscountTenderView> DiscountTenderViews { get; set; }

    public virtual DbSet<DiscountView> DiscountViews { get; set; }

    public virtual DbSet<DistributeDataView> DistributeDataViews { get; set; }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employee1> Employees1 { get; set; }

    public virtual DbSet<EmployeeCustomField> EmployeeCustomFields { get; set; }

    public virtual DbSet<EmployeeLocationAssignmentView> EmployeeLocationAssignmentViews { get; set; }

    public virtual DbSet<EmployeeView> EmployeeViews { get; set; }

    public virtual DbSet<ExportDataConfig> ExportDataConfigs { get; set; }

    public virtual DbSet<FactSale> FactSales { get; set; }

    public virtual DbSet<FactSaleTemp> FactSaleTemps { get; set; }

    public virtual DbSet<FactSupplierAgreement> FactSupplierAgreements { get; set; }

    public virtual DbSet<FileRepository> FileRepositories { get; set; }

    public virtual DbSet<FileRepositoryView> FileRepositoryViews { get; set; }

    public virtual DbSet<FinancialAccount> FinancialAccounts { get; set; }

    public virtual DbSet<FinancialDocument> FinancialDocuments { get; set; }

    public virtual DbSet<FinancialDocumentLineItem> FinancialDocumentLineItems { get; set; }

    public virtual DbSet<FinancialExport> FinancialExports { get; set; }

    public virtual DbSet<FinancialExportView> FinancialExportViews { get; set; }

    public virtual DbSet<FinancialExportedView> FinancialExportedViews { get; set; }

    public virtual DbSet<FinancialMapping> FinancialMappings { get; set; }

    public virtual DbSet<FinancialYear> FinancialYears { get; set; }

    public virtual DbSet<FriendOf> FriendOfs { get; set; }

    public virtual DbSet<GiftCard> GiftCards { get; set; }

    public virtual DbSet<GiftCardInvoice> GiftCardInvoices { get; set; }

    public virtual DbSet<GiftCardSerial> GiftCardSerials { get; set; }

    public virtual DbSet<GiftCardSerialLog> GiftCardSerialLogs { get; set; }

    public virtual DbSet<GiftCardSerialView> GiftCardSerialViews { get; set; }

    public virtual DbSet<GiftCardStoreAssignmentView> GiftCardStoreAssignmentViews { get; set; }

    public virtual DbSet<GiftCardView> GiftCardViews { get; set; }

    public virtual DbSet<ImageRepository> ImageRepositories { get; set; }

    public virtual DbSet<ImportCardex> ImportCardices { get; set; }

    public virtual DbSet<ImportDataItem> ImportDataItems { get; set; }

    public virtual DbSet<ImportDatum> ImportData { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemAssortment> ItemAssortments { get; set; }

    public virtual DbSet<ItemAttribute> ItemAttributes { get; set; }

    public virtual DbSet<ItemAttributeItem> ItemAttributeItems { get; set; }

    public virtual DbSet<ItemAttributeTemplate> ItemAttributeTemplates { get; set; }

    public virtual DbSet<ItemBarcode> ItemBarcodes { get; set; }

    public virtual DbSet<ItemCardex> ItemCardices { get; set; }

    public virtual DbSet<ItemCardexView> ItemCardexViews { get; set; }

    public virtual DbSet<ItemCardexView2> ItemCardexView2s { get; set; }

    public virtual DbSet<ItemCollection> ItemCollections { get; set; }

    public virtual DbSet<ItemCollectionView> ItemCollectionViews { get; set; }

    public virtual DbSet<ItemCustomField> ItemCustomFields { get; set; }

    public virtual DbSet<ItemDepartmentAssignment> ItemDepartmentAssignments { get; set; }

    public virtual DbSet<ItemDepartmentAssignmentView> ItemDepartmentAssignmentViews { get; set; }

    public virtual DbSet<ItemDepartmentLog> ItemDepartmentLogs { get; set; }

    public virtual DbSet<ItemDepartmentView> ItemDepartmentViews { get; set; }

    public virtual DbSet<ItemForMobileView> ItemForMobileViews { get; set; }

    public virtual DbSet<ItemImage> ItemImages { get; set; }

    public virtual DbSet<ItemImageView> ItemImageViews { get; set; }

    public virtual DbSet<ItemNameView> ItemNameViews { get; set; }

    public virtual DbSet<ItemSalePriceView> ItemSalePriceViews { get; set; }

    public virtual DbSet<ItemSerializedStockState> ItemSerializedStockStates { get; set; }

    public virtual DbSet<ItemServiceRule> ItemServiceRules { get; set; }

    public virtual DbSet<ItemState> ItemStates { get; set; }

    public virtual DbSet<ItemStockQuantity> ItemStockQuantities { get; set; }

    public virtual DbSet<ItemStockSection> ItemStockSections { get; set; }

    public virtual DbSet<ItemStockSectionView> ItemStockSectionViews { get; set; }

    public virtual DbSet<ItemStockState> ItemStockStates { get; set; }

    public virtual DbSet<ItemStockStateView> ItemStockStateViews { get; set; }

    public virtual DbSet<ItemTag> ItemTags { get; set; }

    public virtual DbSet<ItemTagDepartmentAssignmentView> ItemTagDepartmentAssignmentViews { get; set; }

    public virtual DbSet<ItemTagItemAssignmentView> ItemTagItemAssignmentViews { get; set; }

    public virtual DbSet<ItemTranslation> ItemTranslations { get; set; }

    public virtual DbSet<ItemView> ItemViews { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Kart> Karts { get; set; }

    public virtual DbSet<LastWeekDailySale> LastWeekDailySales { get; set; }

    public virtual DbSet<LastWeekDepartmentSale> LastWeekDepartmentSales { get; set; }

    public virtual DbSet<LastWeekTenderAmount> LastWeekTenderAmounts { get; set; }

    public virtual DbSet<LogTable> LogTables { get; set; }

    public virtual DbSet<Lottery> Lotteries { get; set; }

    public virtual DbSet<LotteryCustomerGroupAssignmentView> LotteryCustomerGroupAssignmentViews { get; set; }

    public virtual DbSet<LotteryDepartmentAssignmentView> LotteryDepartmentAssignmentViews { get; set; }

    public virtual DbSet<LotteryLineItem> LotteryLineItems { get; set; }

    public virtual DbSet<LotteryLineItemView> LotteryLineItemViews { get; set; }

    public virtual DbSet<LotteryStoreAssignmentView> LotteryStoreAssignmentViews { get; set; }

    public virtual DbSet<LotteryTicket> LotteryTickets { get; set; }

    public virtual DbSet<LoyalityAwardRule> LoyalityAwardRules { get; set; }

    public virtual DbSet<LoyalityAwardRuleItem> LoyalityAwardRuleItems { get; set; }

    public virtual DbSet<LoyalityAwardRuleItemsView> LoyalityAwardRuleItemsViews { get; set; }

    public virtual DbSet<LoyalityAwardRuleStoreView> LoyalityAwardRuleStoreViews { get; set; }

    public virtual DbSet<LoyalityAwardRuleView> LoyalityAwardRuleViews { get; set; }

    public virtual DbSet<LoyalityContract> LoyalityContracts { get; set; }

    public virtual DbSet<LoyalityContractCustomerAssignment> LoyalityContractCustomerAssignments { get; set; }

    public virtual DbSet<LoyalityContractCustomerAssignmentView> LoyalityContractCustomerAssignmentViews { get; set; }

    public virtual DbSet<LoyalityContractView> LoyalityContractViews { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MessageEntityAssignment> MessageEntityAssignments { get; set; }

    public virtual DbSet<MessageFileAttachment> MessageFileAttachments { get; set; }

    public virtual DbSet<MessageUserAssignment> MessageUserAssignments { get; set; }

    public virtual DbSet<MessageUserAssignmentView> MessageUserAssignmentViews { get; set; }

    public virtual DbSet<MessageView> MessageViews { get; set; }

    public virtual DbSet<Moadi> Moadis { get; set; }

    public virtual DbSet<NewProduct> NewProducts { get; set; }

    public virtual DbSet<OrderDocument> OrderDocuments { get; set; }

    public virtual DbSet<OrderDocumentLineItem> OrderDocumentLineItems { get; set; }

    public virtual DbSet<OrderDocumentLineItemCustomField> OrderDocumentLineItemCustomFields { get; set; }

    public virtual DbSet<OrderDocumentLineItemView> OrderDocumentLineItemViews { get; set; }

    public virtual DbSet<OrderDocumentView> OrderDocumentViews { get; set; }

    public virtual DbSet<OwnUserPermissionView> OwnUserPermissionViews { get; set; }

    public virtual DbSet<PartialInvoice> PartialInvoices { get; set; }

    public virtual DbSet<PartialPaymentRule> PartialPaymentRules { get; set; }

    public virtual DbSet<PartialPaymentRuleCustomerGroupAssignmentView> PartialPaymentRuleCustomerGroupAssignmentViews { get; set; }

    public virtual DbSet<PartialPaymentRuleDepartmentAssignment> PartialPaymentRuleDepartmentAssignments { get; set; }

    public virtual DbSet<PartialPaymentRuleDepartmentAssignmentView> PartialPaymentRuleDepartmentAssignmentViews { get; set; }

    public virtual DbSet<PartialPaymentRuleItemAssignment> PartialPaymentRuleItemAssignments { get; set; }

    public virtual DbSet<PartialPaymentRuleItemAssignmentView> PartialPaymentRuleItemAssignmentViews { get; set; }

    public virtual DbSet<PartialPaymentRuleStoreAssignmentView> PartialPaymentRuleStoreAssignmentViews { get; set; }

    public virtual DbSet<PartialPaymentRuleStoreGroupAssignmentView> PartialPaymentRuleStoreGroupAssignmentViews { get; set; }

    public virtual DbSet<PartialPaymentRuleView> PartialPaymentRuleViews { get; set; }

    public virtual DbSet<Party> Parties { get; set; }

    public virtual DbSet<PeriodicCosting> PeriodicCostings { get; set; }

    public virtual DbSet<PeriodicCostingExtend> PeriodicCostingExtends { get; set; }

    public virtual DbSet<PeriodicCostingItem> PeriodicCostingItems { get; set; }

    public virtual DbSet<PeriodicCostingStore> PeriodicCostingStores { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Person> People1 { get; set; }

    public virtual DbSet<PersonCustomField> PersonCustomFields { get; set; }

    public virtual DbSet<PersonNameTranslation> PersonNameTranslations { get; set; }

    public virtual DbSet<PersonView> PersonViews { get; set; }

    public virtual DbSet<PhysicalDocumentConfig> PhysicalDocumentConfigs { get; set; }

    public virtual DbSet<PlanningCalendar> PlanningCalendars { get; set; }

    public virtual DbSet<PlanningCalendarItem> PlanningCalendarItems { get; set; }

    public virtual DbSet<PredefineResult> PredefineResults { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCatalog> ProductCatalogs { get; set; }

    public virtual DbSet<ProductCatalogColor> ProductCatalogColors { get; set; }

    public virtual DbSet<ProductCatalogDetail> ProductCatalogDetails { get; set; }

    public virtual DbSet<ProductCatalogSize> ProductCatalogSizes { get; set; }

    public virtual DbSet<ProductCatalogStep> ProductCatalogSteps { get; set; }

    public virtual DbSet<ProductCatalogStepDepartmentView> ProductCatalogStepDepartmentViews { get; set; }

    public virtual DbSet<ProductCatalogView> ProductCatalogViews { get; set; }

    public virtual DbSet<ProductSize> ProductSizes { get; set; }

    public virtual DbSet<ProductSizeItem> ProductSizeItems { get; set; }

    public virtual DbSet<ProductionDocument> ProductionDocuments { get; set; }

    public virtual DbSet<ProductionDocumentCustomField> ProductionDocumentCustomFields { get; set; }

    public virtual DbSet<ProductionDocumentLineItem> ProductionDocumentLineItems { get; set; }

    public virtual DbSet<ProductionDocumentLineItemRemainView> ProductionDocumentLineItemRemainViews { get; set; }

    public virtual DbSet<ProductionDocumentLineItemView> ProductionDocumentLineItemViews { get; set; }

    public virtual DbSet<ProductionDocumentView> ProductionDocumentViews { get; set; }

    public virtual DbSet<ProductionOrder> ProductionOrders { get; set; }

    public virtual DbSet<ProductionOrderCustomField> ProductionOrderCustomFields { get; set; }

    public virtual DbSet<ProductionOrderLineItem> ProductionOrderLineItems { get; set; }

    public virtual DbSet<ProductionOrderLineItemView> ProductionOrderLineItemViews { get; set; }

    public virtual DbSet<ProductionPlan> ProductionPlans { get; set; }

    public virtual DbSet<ProductionPlanCustomField> ProductionPlanCustomFields { get; set; }

    public virtual DbSet<ProductionPlanDepartment> ProductionPlanDepartments { get; set; }

    public virtual DbSet<ProductionPlanDepartmentView> ProductionPlanDepartmentViews { get; set; }

    public virtual DbSet<ProductionSeries> ProductionSeries { get; set; }

    public virtual DbSet<ProductionStep> ProductionSteps { get; set; }

    public virtual DbSet<ProductionStepView> ProductionStepViews { get; set; }

    public virtual DbSet<QualityControlResult> QualityControlResults { get; set; }

    public virtual DbSet<QualityControlSize> QualityControlSizes { get; set; }

    public virtual DbSet<QualityControlTask> QualityControlTasks { get; set; }

    public virtual DbSet<QualityControlTaskDepartmentView> QualityControlTaskDepartmentViews { get; set; }

    public virtual DbSet<QualityControlTaskItem> QualityControlTaskItems { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionCategory> QuestionCategories { get; set; }

    public virtual DbSet<QuestionClientView> QuestionClientViews { get; set; }

    public virtual DbSet<QuestionView> QuestionViews { get; set; }

    public virtual DbSet<Reason> Reasons { get; set; }

    public virtual DbSet<ReasonView> ReasonViews { get; set; }

    public virtual DbSet<RecentItem> RecentItems { get; set; }

    public virtual DbSet<RecentItemView> RecentItemViews { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportField> ReportFields { get; set; }

    public virtual DbSet<ReportFilter> ReportFilters { get; set; }

    public virtual DbSet<Repository> Repositories { get; set; }

    public virtual DbSet<RepositoryView> RepositoryViews { get; set; }

    public virtual DbSet<ReturnInvoiceLineItemView> ReturnInvoiceLineItemViews { get; set; }

    public virtual DbSet<SafeStoreTurnOverView> SafeStoreTurnOverViews { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SaleInvoice> SaleInvoices { get; set; }

    public virtual DbSet<SaleInvoiceCustomDiscount> SaleInvoiceCustomDiscounts { get; set; }

    public virtual DbSet<SaleInvoiceCustomField> SaleInvoiceCustomFields { get; set; }

    public virtual DbSet<SaleInvoiceInfo> SaleInvoiceInfos { get; set; }

    public virtual DbSet<SaleInvoiceLineItem> SaleInvoiceLineItems { get; set; }

    public virtual DbSet<SaleInvoiceLineItemContract> SaleInvoiceLineItemContracts { get; set; }

    public virtual DbSet<SaleInvoiceLineItemCustomField> SaleInvoiceLineItemCustomFields { get; set; }

    public virtual DbSet<SaleInvoiceLineItemDetail> SaleInvoiceLineItemDetails { get; set; }

    public virtual DbSet<SaleInvoiceLineItemDiscount> SaleInvoiceLineItemDiscounts { get; set; }

    public virtual DbSet<SaleInvoiceLineItemPartialPayment> SaleInvoiceLineItemPartialPayments { get; set; }

    public virtual DbSet<SaleInvoiceLineItemReference> SaleInvoiceLineItemReferences { get; set; }

    public virtual DbSet<SaleInvoiceLineItemSalePerson> SaleInvoiceLineItemSalePeople { get; set; }

    public virtual DbSet<SaleInvoiceLineItemTracking> SaleInvoiceLineItemTrackings { get; set; }

    public virtual DbSet<SaleInvoiceLineItemView> SaleInvoiceLineItemViews { get; set; }

    public virtual DbSet<SaleInvoiceLoyality> SaleInvoiceLoyalities { get; set; }

    public virtual DbSet<SaleInvoicePartialPayment> SaleInvoicePartialPayments { get; set; }

    public virtual DbSet<SaleInvoicePartialPaymentView> SaleInvoicePartialPaymentViews { get; set; }

    public virtual DbSet<SaleInvoiceService> SaleInvoiceServices { get; set; }

    public virtual DbSet<SaleInvoiceTaxReference> SaleInvoiceTaxReferences { get; set; }

    public virtual DbSet<SaleInvoiceTender> SaleInvoiceTenders { get; set; }

    public virtual DbSet<SaleInvoiceTenderCheque> SaleInvoiceTenderCheques { get; set; }

    public virtual DbSet<SaleInvoiceTenderCredit> SaleInvoiceTenderCredits { get; set; }

    public virtual DbSet<SaleInvoiceTenderGift> SaleInvoiceTenderGifts { get; set; }

    public virtual DbSet<SaleInvoiceTenderPo> SaleInvoiceTenderPos { get; set; }

    public virtual DbSet<SaleInvoiceTenderView> SaleInvoiceTenderViews { get; set; }

    public virtual DbSet<SaleInvoiceView> SaleInvoiceViews { get; set; }

    public virtual DbSet<SaleItemDelivery> SaleItemDeliveries { get; set; }

    public virtual DbSet<SaleItemDeliveryView> SaleItemDeliveryViews { get; set; }

    public virtual DbSet<SalePrice> SalePrices { get; set; }

    public virtual DbSet<SalePriceActiveTime> SalePriceActiveTimes { get; set; }

    public virtual DbSet<SalePriceConditional> SalePriceConditionals { get; set; }

    public virtual DbSet<SalePriceCustomerGroupAssignmentView> SalePriceCustomerGroupAssignmentViews { get; set; }

    public virtual DbSet<SalePriceLineItem> SalePriceLineItems { get; set; }

    public virtual DbSet<SalePriceLineItemView> SalePriceLineItemViews { get; set; }

    public virtual DbSet<SalePriceStoreAssignmentView> SalePriceStoreAssignmentViews { get; set; }

    public virtual DbSet<SalePriceStoreGroupAssignmentView> SalePriceStoreGroupAssignmentViews { get; set; }

    public virtual DbSet<SalePriceView> SalePriceViews { get; set; }

    public virtual DbSet<SaleQoutaCustomerGroupAssignmentView> SaleQoutaCustomerGroupAssignmentViews { get; set; }

    public virtual DbSet<SaleQoutaDepartmentAssignment> SaleQoutaDepartmentAssignments { get; set; }

    public virtual DbSet<SaleQoutaDepartmentAssignmentView> SaleQoutaDepartmentAssignmentViews { get; set; }

    public virtual DbSet<SaleQoutaItemAssignment> SaleQoutaItemAssignments { get; set; }

    public virtual DbSet<SaleQoutaItemAssignmentView> SaleQoutaItemAssignmentViews { get; set; }

    public virtual DbSet<SaleQoutaStoreAssignmentView> SaleQoutaStoreAssignmentViews { get; set; }

    public virtual DbSet<SaleQoutum> SaleQouta { get; set; }

    public virtual DbSet<ServiceItem> ServiceItems { get; set; }

    public virtual DbSet<ServiceItemView> ServiceItemViews { get; set; }

    public virtual DbSet<ShelfPrice> ShelfPrices { get; set; }

    public virtual DbSet<ShelfPriceItem> ShelfPriceItems { get; set; }

    public virtual DbSet<ShelfPricePrint> ShelfPricePrints { get; set; }

    public virtual DbSet<ShelfPricePrintHistory> ShelfPricePrintHistories { get; set; }

    public virtual DbSet<Sitecost> Sitecosts { get; set; }

    public virtual DbSet<SmsHistory> SmsHistories { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<StockDocument> StockDocuments { get; set; }

    public virtual DbSet<StockDocumentAttachment> StockDocumentAttachments { get; set; }

    public virtual DbSet<StockDocumentCostModifier> StockDocumentCostModifiers { get; set; }

    public virtual DbSet<StockDocumentCostModifierReference> StockDocumentCostModifierReferences { get; set; }

    public virtual DbSet<StockDocumentCostModifierView> StockDocumentCostModifierViews { get; set; }

    public virtual DbSet<StockDocumentCustomField> StockDocumentCustomFields { get; set; }

    public virtual DbSet<StockDocumentLineItem> StockDocumentLineItems { get; set; }

    public virtual DbSet<StockDocumentLineItemAttribute> StockDocumentLineItemAttributes { get; set; }

    public virtual DbSet<StockDocumentLineItemAttributeView> StockDocumentLineItemAttributeViews { get; set; }

    public virtual DbSet<StockDocumentLineItemContract> StockDocumentLineItemContracts { get; set; }

    public virtual DbSet<StockDocumentLineItemCustomDiscount> StockDocumentLineItemCustomDiscounts { get; set; }

    public virtual DbSet<StockDocumentLineItemCustomField> StockDocumentLineItemCustomFields { get; set; }

    public virtual DbSet<StockDocumentLineItemExpiration> StockDocumentLineItemExpirations { get; set; }

    public virtual DbSet<StockDocumentLineItemMonth> StockDocumentLineItemMonths { get; set; }

    public virtual DbSet<StockDocumentLineItemMonthView> StockDocumentLineItemMonthViews { get; set; }

    public virtual DbSet<StockDocumentLineItemReference> StockDocumentLineItemReferences { get; set; }

    public virtual DbSet<StockDocumentLineItemSerial> StockDocumentLineItemSerials { get; set; }

    public virtual DbSet<StockDocumentLineItemTracking> StockDocumentLineItemTrackings { get; set; }

    public virtual DbSet<StockDocumentLineItemView> StockDocumentLineItemViews { get; set; }

    public virtual DbSet<StockDocumentOrderReference> StockDocumentOrderReferences { get; set; }

    public virtual DbSet<StockDocumentPayment> StockDocumentPayments { get; set; }

    public virtual DbSet<StockDocumentReference> StockDocumentReferences { get; set; }

    public virtual DbSet<StockDocumentView> StockDocumentViews { get; set; }

    public virtual DbSet<StockSection> StockSections { get; set; }

    public virtual DbSet<StockView> StockViews { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StoreConfiguration> StoreConfigurations { get; set; }

    public virtual DbSet<StoreContract> StoreContracts { get; set; }

    public virtual DbSet<StoreContractDepartment> StoreContractDepartments { get; set; }

    public virtual DbSet<StoreContractDepartmentsView> StoreContractDepartmentsViews { get; set; }

    public virtual DbSet<StoreContractView> StoreContractViews { get; set; }

    public virtual DbSet<StoreDailyTurnOver> StoreDailyTurnOvers { get; set; }

    public virtual DbSet<StoreDailyTurnOverLineItem> StoreDailyTurnOverLineItems { get; set; }

    public virtual DbSet<StoreDailyTurnOverView> StoreDailyTurnOverViews { get; set; }

    public virtual DbSet<StoreGroup> StoreGroups { get; set; }

    public virtual DbSet<StoreHierarchView> StoreHierarchViews { get; set; }

    public virtual DbSet<StoreRepository> StoreRepositories { get; set; }

    public virtual DbSet<StoreView> StoreViews { get; set; }

    public virtual DbSet<SubSystem> SubSystems { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplierAgreement> SupplierAgreements { get; set; }

    public virtual DbSet<SupplierAgreementCustomField> SupplierAgreementCustomFields { get; set; }

    public virtual DbSet<SupplierAgreementDepartment> SupplierAgreementDepartments { get; set; }

    public virtual DbSet<SupplierAgreementDepartmentView> SupplierAgreementDepartmentViews { get; set; }

    public virtual DbSet<SupplierAgreementLineItem> SupplierAgreementLineItems { get; set; }

    public virtual DbSet<SupplierAgreementLineItemView> SupplierAgreementLineItemViews { get; set; }

    public virtual DbSet<SupplierAgreementStore> SupplierAgreementStores { get; set; }

    public virtual DbSet<SupplierAgreementStoresView> SupplierAgreementStoresViews { get; set; }

    public virtual DbSet<SupplierAgreementView> SupplierAgreementViews { get; set; }

    public virtual DbSet<SupplierContract> SupplierContracts { get; set; }

    public virtual DbSet<SupplierContractLineItem> SupplierContractLineItems { get; set; }

    public virtual DbSet<SupplierContractLineItemsView> SupplierContractLineItemsViews { get; set; }

    public virtual DbSet<SupplierContractStore> SupplierContractStores { get; set; }

    public virtual DbSet<SupplierContractStoresView> SupplierContractStoresViews { get; set; }

    public virtual DbSet<SupplierContractView> SupplierContractViews { get; set; }

    public virtual DbSet<SupplierCustomField> SupplierCustomFields { get; set; }

    public virtual DbSet<SupplierItem> SupplierItems { get; set; }

    public virtual DbSet<SupplierItemView> SupplierItemViews { get; set; }

    public virtual DbSet<SupplierNameView> SupplierNameViews { get; set; }

    public virtual DbSet<SupplierNewItemProclamation> SupplierNewItemProclamations { get; set; }

    public virtual DbSet<SupplierNewPriceProclamation> SupplierNewPriceProclamations { get; set; }

    public virtual DbSet<SupplierSale> SupplierSales { get; set; }

    public virtual DbSet<SupplierSaleAssignmentView> SupplierSaleAssignmentViews { get; set; }

    public virtual DbSet<SupplierSaleLineItem> SupplierSaleLineItems { get; set; }

    public virtual DbSet<SupplierSaleLineItemView> SupplierSaleLineItemViews { get; set; }

    public virtual DbSet<SupplierView> SupplierViews { get; set; }

    public virtual DbSet<SuspendInvoice> SuspendInvoices { get; set; }

    public virtual DbSet<SynchRequest> SynchRequests { get; set; }

    public virtual DbSet<SystemConfiguration> SystemConfigurations { get; set; }

    public virtual DbSet<SystemUpdateView> SystemUpdateViews { get; set; }

    public virtual DbSet<TableManagement> TableManagements { get; set; }

    public virtual DbSet<Tamin> Tamins { get; set; }

    public virtual DbSet<RainExtention.Infrastructure.Entities.Task> Tasks { get; set; }

    public virtual DbSet<TaskCategory> TaskCategories { get; set; }

    public virtual DbSet<TaskEntityAssignment> TaskEntityAssignments { get; set; }

    public virtual DbSet<TaskFileAttachment> TaskFileAttachments { get; set; }

    public virtual DbSet<TaskReminder> TaskReminders { get; set; }

    public virtual DbSet<TaskView> TaskViews { get; set; }

    public virtual DbSet<TaxGovermentInoiceDetailLog> TaxGovermentInoiceDetailLogs { get; set; }

    public virtual DbSet<TaxGovermentInoiceHeaderLog> TaxGovermentInoiceHeaderLogs { get; set; }

    public virtual DbSet<TaxGovermentInvoiceFinal> TaxGovermentInvoiceFinals { get; set; }

    public virtual DbSet<TaxGovermentInvoiceInfo> TaxGovermentInvoiceInfos { get; set; }

    public virtual DbSet<TaxGovermentSendLog> TaxGovermentSendLogs { get; set; }

    public virtual DbSet<TaxGovermentSettingInfo> TaxGovermentSettingInfos { get; set; }

    public virtual DbSet<TaxHistory> TaxHistories { get; set; }

    public virtual DbSet<TaxIdimport> TaxIdimports { get; set; }

    public virtual DbSet<Telephone> Telephones { get; set; }

    public virtual DbSet<TelephoneView> TelephoneViews { get; set; }

    public virtual DbSet<TempInvoiceNumber> TempInvoiceNumbers { get; set; }

    public virtual DbSet<TempItemCost> TempItemCosts { get; set; }

    public virtual DbSet<TempItemPrice> TempItemPrices { get; set; }

    public virtual DbSet<Tender> Tenders { get; set; }

    public virtual DbSet<TenderConfiguration> TenderConfigurations { get; set; }

    public virtual DbSet<TenderConfigurationView> TenderConfigurationViews { get; set; }

    public virtual DbSet<TenderView> TenderViews { get; set; }

    public virtual DbSet<ThirdParty> ThirdParties { get; set; }

    public virtual DbSet<ThirdPartyNameView> ThirdPartyNameViews { get; set; }

    public virtual DbSet<ThirdPartyView> ThirdPartyViews { get; set; }

    public virtual DbSet<TranslationText> TranslationTexts { get; set; }

    public virtual DbSet<TreasuryAccount> TreasuryAccounts { get; set; }

    public virtual DbSet<TreasuryAccountView> TreasuryAccountViews { get; set; }

    public virtual DbSet<TreasuryDocument> TreasuryDocuments { get; set; }

    public virtual DbSet<TreasuryDocumentCustomField> TreasuryDocumentCustomFields { get; set; }

    public virtual DbSet<TreasuryDocumentLineItem> TreasuryDocumentLineItems { get; set; }

    public virtual DbSet<TreasuryDocumentLineItemCheque> TreasuryDocumentLineItemCheques { get; set; }

    public virtual DbSet<TreasuryDocumentLineItemDetail> TreasuryDocumentLineItemDetails { get; set; }

    public virtual DbSet<TreasuryDocumentLineItemView> TreasuryDocumentLineItemViews { get; set; }

    public virtual DbSet<TreasuryDocumentView> TreasuryDocumentViews { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<User1> Users1 { get; set; }

    public virtual DbSet<UserCustomLayout> UserCustomLayouts { get; set; }

    public virtual DbSet<UserDepartmentAssignmentView> UserDepartmentAssignmentViews { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserGroupAssignmentView> UserGroupAssignmentViews { get; set; }

    public virtual DbSet<UserGroupPermission> UserGroupPermissions { get; set; }

    public virtual DbSet<UserGroupPermissionView> UserGroupPermissionViews { get; set; }

    public virtual DbSet<UserGroupTenderAssignmentView> UserGroupTenderAssignmentViews { get; set; }

    public virtual DbSet<UserLocationAssignmentView> UserLocationAssignmentViews { get; set; }

    public virtual DbSet<UserPermission> UserPermissions { get; set; }

    public virtual DbSet<UserPermissionView> UserPermissionViews { get; set; }

    public virtual DbSet<UserStockAssignmentView> UserStockAssignmentViews { get; set; }

    public virtual DbSet<UserTenderView> UserTenderViews { get; set; }

    public virtual DbSet<UserView> UserViews { get; set; }

    public virtual DbSet<UvDupplicateBarCode> UvDupplicateBarCodes { get; set; }

    public virtual DbSet<UvTaxInfoBulkSale> UvTaxInfoBulkSales { get; set; }

    public virtual DbSet<UvTaxInfoOld> UvTaxInfoOlds { get; set; }

    public virtual DbSet<UvTaxInvoiceOld> UvTaxInvoiceOlds { get; set; }

    public virtual DbSet<UvTaxSaleInvocie> UvTaxSaleInvocies { get; set; }

    public virtual DbSet<UvTissInfo> UvTissInfos { get; set; }

    public virtual DbSet<UvTissInvoice> UvTissInvoices { get; set; }

    public virtual DbSet<Visitor> Visitors { get; set; }

    public virtual DbSet<VisitorContract> VisitorContracts { get; set; }

    public virtual DbSet<VisitorContractDepartment> VisitorContractDepartments { get; set; }

    public virtual DbSet<VisitorContractDepartmentView> VisitorContractDepartmentViews { get; set; }

    public virtual DbSet<VisitorContractStore> VisitorContractStores { get; set; }

    public virtual DbSet<VisitorContractStoreView> VisitorContractStoreViews { get; set; }

    public virtual DbSet<VisitorContractView> VisitorContractViews { get; set; }

    public virtual DbSet<VisitorNameView> VisitorNameViews { get; set; }

    public virtual DbSet<VisitorView> VisitorViews { get; set; }

    public virtual DbSet<VwEmployeeSummary> VwEmployeeSummaries { get; set; }

    public virtual DbSet<WebSite> WebSites { get; set; }

    public virtual DbSet<Workstation> Workstations { get; set; }

    public virtual DbSet<WorkstationDepartmentAssignmentView> WorkstationDepartmentAssignmentViews { get; set; }

    public virtual DbSet<WorkstationView> WorkstationViews { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-S0EBT2U\\RWP_2022;User ID=sa;Password=RWP@1393;Database=RWP_Sale_DB_Bakhshi;Trusted_Connection=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RainExtention.Domain.Entities.ItemListDto>(entity =>
        {
            entity.HasNoKey();
            entity.ToView(null);
        });

        modelBuilder.Entity<ActivePartialPaymentRule>(entity =>
        {
            entity.ToView("ActivePartialPaymentRules");
        });

        modelBuilder.Entity<ActiveQuestion>(entity =>
        {
            entity.ToView("ActiveQuestions");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasOne(d => d.Party).WithMany(p => p.Addresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Party");

            entity.HasOne(d => d.Type).WithMany(p => p.Addresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Dictionary");
        });

        modelBuilder.Entity<AlternativeItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.Property(e => e.AppicationId).ValueGeneratedNever();

            entity.HasOne(d => d.Type).WithMany(p => p.Applications).HasConstraintName("FK_Application_Dictionary");
        });

        modelBuilder.Entity<ApplicationMenu>(entity =>
        {
            entity.Property(e => e.MenuId).ValueGeneratedNever();

            entity.HasOne(d => d.ActionType).WithMany(p => p.ApplicationMenus).HasConstraintName("FK_ApplicationMenu_Dictionary");

            entity.HasOne(d => d.Application).WithMany(p => p.ApplicationMenus).HasConstraintName("FK_ApplicationMenu_Application");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_ApplicationMenu_ApplicationMenu");

            entity.HasOne(d => d.Permission).WithMany(p => p.ApplicationMenus).HasConstraintName("FK_ApplicationMenu_Permission");

            entity.HasOne(d => d.SubSystem).WithMany(p => p.ApplicationMenus).HasConstraintName("FK_ApplicationMenu_SubSystem");
        });

        modelBuilder.Entity<ApplicationMenuCaption>(entity =>
        {
            entity.HasOne(d => d.Language).WithMany(p => p.ApplicationMenuCaptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationMenuCaption_Dictionary");

            entity.HasOne(d => d.Menu).WithMany(p => p.ApplicationMenuCaptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationMenuCaption_ApplicationMenu");
        });

        modelBuilder.Entity<global::RainExtention.Infrastructure.Entities.Attribute>(entity =>
        {
            entity.Property(e => e.AttributeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<AttributeValue>(entity =>
        {
            entity.HasOne(d => d.Attribute).WithMany(p => p.AttributeValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttributeValue_Attribute");
        });

        modelBuilder.Entity<AutomaticOrderPlan>(entity =>
        {
            entity.Property(e => e.PlanId).ValueGeneratedNever();

            entity.HasOne(d => d.Calendar).WithMany(p => p.AutomaticOrderPlans).HasConstraintName("FK_AutomaticOrderPlan_PlanningCalendar");

            entity.HasOne(d => d.Period).WithMany(p => p.AutomaticOrderPlanPeriods).HasConstraintName("FK_AutomaticOrderPlan_Period");

            entity.HasOne(d => d.PlanType).WithMany(p => p.AutomaticOrderPlanPlanTypes).HasConstraintName("FK_AutomaticOrderPlan_Type");

            entity.HasOne(d => d.Status).WithMany(p => p.AutomaticOrderPlanStatuses).HasConstraintName("FK_AutomaticOrderPlan_Status");

            entity.HasMany(d => d.Groups).WithMany(p => p.Plans)
                .UsingEntity<Dictionary<string, object>>(
                    "AutomaticOrderPlanStoreGroupAssignment",
                    r => r.HasOne<StoreGroup>().WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AutomaticOrderPlanStoreGroupAssignment_StoreGroup"),
                    l => l.HasOne<AutomaticOrderPlan>().WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AutomaticOrderPlanStoreGroupAssignment_AutomaticOrderPlan"),
                    j =>
                    {
                        j.HasKey("PlanId", "GroupId");
                        j.ToTable("AutomaticOrderPlanStoreGroupAssignment");
                        j.IndexerProperty<Guid>("PlanId").HasColumnName("PlanID");
                        j.IndexerProperty<Guid>("GroupId").HasColumnName("GroupID");
                    });

            entity.HasMany(d => d.Stores).WithMany(p => p.Plans)
                .UsingEntity<Dictionary<string, object>>(
                    "AutomaticOrderPlanStoreAssignment",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AutomaticOrderPlanStoreAssignment_Store"),
                    l => l.HasOne<AutomaticOrderPlan>().WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AutomaticOrderPlanStoreAssignment_AutomaticOrderPlan"),
                    j =>
                    {
                        j.HasKey("PlanId", "StoreId");
                        j.ToTable("AutomaticOrderPlanStoreAssignment");
                        j.IndexerProperty<Guid>("PlanId").HasColumnName("PlanID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });

            entity.HasMany(d => d.Suppliers).WithMany(p => p.Plans)
                .UsingEntity<Dictionary<string, object>>(
                    "AutomaticOrderPlanSupplierAssignment",
                    r => r.HasOne<Supplier>().WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AutomaticOrderPlanSupplierAssignment_Supplier"),
                    l => l.HasOne<AutomaticOrderPlan>().WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AutomaticOrderPlanSupplierAssignment_AutomaticOrderPlan"),
                    j =>
                    {
                        j.HasKey("PlanId", "SupplierId");
                        j.ToTable("AutomaticOrderPlanSupplierAssignment");
                        j.IndexerProperty<Guid>("PlanId").HasColumnName("PlanID");
                        j.IndexerProperty<Guid>("SupplierId").HasColumnName("SupplierID");
                    });
        });

        modelBuilder.Entity<AutomaticOrderPlanDepartmentAssignment>(entity =>
        {
            entity.HasOne(d => d.Department).WithMany(p => p.AutomaticOrderPlanDepartmentAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomaticOrderPlanDepartmentAssignment_Department");

            entity.HasOne(d => d.Plan).WithMany(p => p.AutomaticOrderPlanDepartmentAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomaticOrderPlanDepartmentAssignment_AutomaticOrderPlan");
        });

        modelBuilder.Entity<AutomaticOrderPlanDepartmentAssignmentView>(entity =>
        {
            entity.ToView("AutomaticOrderPlanDepartmentAssignmentView");
        });

        modelBuilder.Entity<AutomaticOrderPlanDepartmentEvent>(entity =>
        {
            entity.HasOne(d => d.Department).WithMany(p => p.AutomaticOrderPlanDepartmentEvents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomaticOrderPlanDepartmentEvent_Department");

            entity.HasOne(d => d.AutomaticOrderPlanDepartmentAssignment).WithMany(p => p.AutomaticOrderPlanDepartmentEvents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomaticOrderPlanDepartmentEvent_AutomaticOrderPlanDepartmentAssignment");
        });

        modelBuilder.Entity<AutomaticOrderPlanHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Plan).WithMany(p => p.AutomaticOrderPlanHistories).HasConstraintName("FK_AutomaticOrderPlanHistory_AutomaticOrderPlan");
        });

        modelBuilder.Entity<AutomaticOrderPlanItemAssignment>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.AutomaticOrderPlanItemAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomaticOrderPlanItemAssignment_Item");

            entity.HasOne(d => d.Plan).WithMany(p => p.AutomaticOrderPlanItemAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomaticOrderPlanItemAssignment_AutomaticOrderPlan");
        });

        modelBuilder.Entity<AutomaticOrderPlanItemAssignmentView>(entity =>
        {
            entity.ToView("AutomaticOrderPlanItemAssignmentView");
        });

        modelBuilder.Entity<AutomaticOrderPlanItemEvent>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.AutomaticOrderPlanItemEvents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomaticOrderPlanItemEvent_Item");

            entity.HasOne(d => d.AutomaticOrderPlanItemAssignment).WithMany(p => p.AutomaticOrderPlanItemEvents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomaticOrderPlanItemEvent_AutomaticOrderPlanItemAssignment");
        });

        modelBuilder.Entity<AutomaticOrderPlanStoreAssignmentView>(entity =>
        {
            entity.ToView("AutomaticOrderPlanStoreAssignmentView");
        });

        modelBuilder.Entity<AutomaticOrderPlanStoreGroupAssignmentView>(entity =>
        {
            entity.ToView("AutomaticOrderPlanStoreGroupAssignmentView");
        });

        modelBuilder.Entity<AutomaticOrderPlanSupplierAssignmentView>(entity =>
        {
            entity.ToView("AutomaticOrderPlanSupplierAssignmentView");
        });

        modelBuilder.Entity<AutomaticOrderPlanView>(entity =>
        {
            entity.ToView("AutomaticOrderPlanView");
        });

        modelBuilder.Entity<AutomaticOrderProposal>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AutomaticOrderProposalLineItem>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.AutomaticOrderProposalLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomaticOrderProposalLineItem_AutomaticOrderProposal");
        });

        modelBuilder.Entity<AutomaticOrderProposalLineItemView>(entity =>
        {
            entity.ToView("AutomaticOrderProposalLineItemView");
        });

        modelBuilder.Entity<AutomaticOrderProposalReferDocument>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.AutomaticOrderProposalReferDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomaticOrderProposalReferDocuments_AutomaticOrderProposal");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.Property(e => e.BankId).ValueGeneratedNever();
        });

        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.Property(e => e.AccountId).ValueGeneratedNever();
            entity.Property(e => e.BranchCode).IsFixedLength();

            entity.HasOne(d => d.Bank).WithMany(p => p.BankAccounts).HasConstraintName("FK_BankAccount_Bank");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.BankAccountCreationUserNavigations).HasConstraintName("FK_BankAccount_CreationUser");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.BankAccountModifyUserNavigations).HasConstraintName("FK_BankAccount_ModifyUser");
        });

        modelBuilder.Entity<BillOfMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BuildOfMaterial");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.BillOfMaterialApproveUserNavigations).HasConstraintName("FK_BuildOfMaterial_User1");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.BillOfMaterialCreationUserNavigations).HasConstraintName("FK_BuildOfMaterial_User");

            entity.HasOne(d => d.Item).WithMany(p => p.BillOfMaterials).HasConstraintName("FK_BuildOfMaterial_Item");

            entity.HasOne(d => d.Status).WithMany(p => p.BillOfMaterials).HasConstraintName("FK_BuildOfMaterial_Dictionary");

            entity.HasOne(d => d.VoidUserNavigation).WithMany(p => p.BillOfMaterialVoidUserNavigations).HasConstraintName("FK_BuildOfMaterial_User2");
        });

        modelBuilder.Entity<BillOfMaterialCustomField>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.BillOfMaterialCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterialCustomField_BillOfMaterial");
        });

        modelBuilder.Entity<BillOfMaterialImage>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.BillOfMaterialImages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterialImage_BillOfMaterial");
        });

        modelBuilder.Entity<BillOfMaterialItem>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.ChildId }).HasName("PK_BuildOfMaterialItem");

            entity.HasOne(d => d.Child).WithMany(p => p.BillOfMaterialItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BuildOfMaterialItem_Item");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.BillOfMaterialItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BuildOfMaterialItem_BuildOfMaterial");

            entity.HasMany(d => d.AttributeValues).WithMany(p => p.BillOfMaterialItems)
                .UsingEntity<Dictionary<string, object>>(
                    "BillOfMaterialItemAttributeValue",
                    r => r.HasOne<AttributeValue>().WithMany()
                        .HasForeignKey("AttributeId", "ValueId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_BillOfMaterialItemAttributeValue_AttributeValue"),
                    l => l.HasOne<BillOfMaterialItem>().WithMany()
                        .HasForeignKey("Id", "ChildId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_BillOfMaterialItemAttributeValue_BillOfMaterialItem"),
                    j =>
                    {
                        j.HasKey("Id", "ChildId", "AttributeId", "ValueId");
                        j.ToTable("BillOfMaterialItemAttributeValue");
                        j.IndexerProperty<Guid>("Id").HasColumnName("ID");
                        j.IndexerProperty<Guid>("ChildId").HasColumnName("ChildID");
                        j.IndexerProperty<Guid>("AttributeId").HasColumnName("AttributeID");
                        j.IndexerProperty<Guid>("ValueId").HasColumnName("ValueID");
                    });
        });

        modelBuilder.Entity<BillOfMaterialItemRelatedItem>(entity =>
        {
            entity.HasOne(d => d.Child).WithMany(p => p.BillOfMaterialItemRelatedItemChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterialItemRelatedItems_Item");

            entity.HasOne(d => d.Item).WithMany(p => p.BillOfMaterialItemRelatedItemItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterialItemRelatedItems_Item1");

            entity.HasOne(d => d.BillOfMaterialItem).WithMany(p => p.BillOfMaterialItemRelatedItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterialItemRelatedItems_BillOfMaterialItem");
        });

        modelBuilder.Entity<BillOfMaterialItemRelatedItemsView>(entity =>
        {
            entity.ToView("BillOfMaterialItemRelatedItemsView");
        });

        modelBuilder.Entity<BillOfMaterialItemStep>(entity =>
        {
            entity.HasOne(d => d.Child).WithMany(p => p.BillOfMaterialItemSteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterialItemStep_Item");

            entity.HasOne(d => d.Step).WithMany(p => p.BillOfMaterialItemSteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterialItemStep_ProductionStep");

            entity.HasOne(d => d.BillOfMaterialItem).WithMany(p => p.BillOfMaterialItemSteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterialItemStep_BillOfMaterialItem");
        });

        modelBuilder.Entity<BillOfMaterialItemStepView>(entity =>
        {
            entity.ToView("BillOfMaterialItemStepView");
        });

        modelBuilder.Entity<BillOfMaterialItemView>(entity =>
        {
            entity.ToView("BillOfMaterialItemView");
        });

        modelBuilder.Entity<BillOfMaterialView>(entity =>
        {
            entity.ToView("BillOfMaterialView");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK_Brand_1");

            entity.Property(e => e.BrandId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Calendar>(entity =>
        {
            entity.Property(e => e.Date).IsFixedLength();
        });

        modelBuilder.Entity<CalendarEvent>(entity =>
        {
            entity.HasOne(d => d.FixEvent).WithMany(p => p.CalendarEvents).HasConstraintName("FK_CalendarEvent_CalendarEventFix");
        });

        modelBuilder.Entity<CalendarEventFix>(entity =>
        {
            entity.Property(e => e.EventId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CalendarView>(entity =>
        {
            entity.ToView("CalendarView");

            entity.Property(e => e.Date).IsFixedLength();
        });

        modelBuilder.Entity<CashLoan>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Reason).WithMany(p => p.CashLoans).HasConstraintName("FK_CashLoan_Reason");

            entity.HasOne(d => d.Tender).WithMany(p => p.CashLoans).HasConstraintName("FK_CashLoan_Tender");

            entity.HasOne(d => d.Type).WithMany(p => p.CashLoans).HasConstraintName("FK_CashLoan_Type");

            entity.HasOne(d => d.Workstation).WithMany(p => p.CashLoans).HasConstraintName("FK_CashLoan_Workstation");
        });

        modelBuilder.Entity<CashSettelment>(entity =>
        {
            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.CashSettelmentCreationUserNavigations).HasConstraintName("FK_CashSettelment_CreationUser");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.CashSettelmentModifyUserNavigations).HasConstraintName("FK_CashSettelment_ModifyUser");

            entity.HasOne(d => d.Status).WithMany(p => p.CashSettelments).HasConstraintName("FK_CashSettelment_Dictionary");

            entity.HasOne(d => d.Store).WithMany(p => p.CashSettelments).HasConstraintName("FK_CashSettelment_Store");

            entity.HasOne(d => d.User).WithMany(p => p.CashSettelmentUsers).HasConstraintName("FK_CashSettelment_User");

            entity.HasOne(d => d.Workstation).WithMany(p => p.CashSettelments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashSettelment_Workstation");
        });

        modelBuilder.Entity<CashSettelmentCustomField>(entity =>
        {
            entity.HasOne(d => d.CashSettelment).WithOne(p => p.CashSettelmentCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashSettelmentCustomField_CashSettelment");
        });

        modelBuilder.Entity<CashSettelmentLineItem>(entity =>
        {
            entity.HasOne(d => d.Tender).WithMany(p => p.CashSettelmentLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashSettelmentLineItem_Tender");

            entity.HasOne(d => d.CashSettelment).WithMany(p => p.CashSettelmentLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashSettelmentLineItem_CashSettelmentLineItem");
        });

        modelBuilder.Entity<CashSettelmentLineItemView>(entity =>
        {
            entity.ToView("CashSettelmentLineItemView");
        });

        modelBuilder.Entity<CashSettelmentView>(entity =>
        {
            entity.ToView("CashSettelmentView");
        });

        modelBuilder.Entity<ChildWorkstation>(entity =>
        {
            entity.ToView("ChildWorkstations");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK_Company_1");

            entity.Property(e => e.CompanyId).ValueGeneratedNever();

            entity.HasOne(d => d.DetailedAccount).WithOne(p => p.Company).HasConstraintName("FK_Company_DetailAccount");

            entity.HasOne(d => d.OperationalManager).WithMany(p => p.Companies).HasConstraintName("FK_Company_Person");

            entity.HasOne(d => d.Party).WithOne(p => p.Company).HasConstraintName("FK_Company_Party");

            entity.HasOne(d => d.ThirdParty).WithOne(p => p.Company).HasConstraintName("FK_Company_ThirdParty");
        });

        modelBuilder.Entity<CompanyCustomField>(entity =>
        {
            entity.Property(e => e.CompanyId).ValueGeneratedNever();

            entity.HasOne(d => d.Company).WithOne(p => p.CompanyCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyCustomField_Company");
        });

        modelBuilder.Entity<CompanyNameTranslation>(entity =>
        {
            entity.HasKey(e => new { e.CompanyId, e.LanguageId }).HasName("PK_CompanyNameTranslations_1");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyNameTranslations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyNameTranslations_Company");
        });

        modelBuilder.Entity<CompanyView>(entity =>
        {
            entity.ToView("CompanyView");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DecimalSymbol).IsFixedLength();
            entity.Property(e => e.GroupingSymbol).IsFixedLength();
            entity.Property(e => e.Symbol).IsFixedLength();
        });

        modelBuilder.Entity<CurrencyHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Currency).WithMany(p => p.CurrencyHistories).HasConstraintName("FK_CurrencyHistory_Currency");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.CurrencyHistories).HasConstraintName("FK_CurrencyHistory_User");
        });

        modelBuilder.Entity<CurrencyView>(entity =>
        {
            entity.ToView("CurrencyView");

            entity.Property(e => e.DecimalSymbol).IsFixedLength();
            entity.Property(e => e.GroupingSymbol).IsFixedLength();
            entity.Property(e => e.Symbol).IsFixedLength();
        });

        modelBuilder.Entity<CurrentDiscount>(entity =>
        {
            entity.ToView("CurrentDiscounts");
        });

        modelBuilder.Entity<CurrentItemPriceView>(entity =>
        {
            entity.ToView("CurrentItemPriceView");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_Customer_1");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();

            entity.HasOne(d => d.Agent).WithMany(p => p.Customers).HasConstraintName("FK_Customer_Employee");

            entity.HasOne(d => d.Corporate).WithMany(p => p.InverseCorporate).HasConstraintName("FK_Customer_Corporate");

            entity.HasOne(d => d.Party).WithMany(p => p.Customers).HasConstraintName("FK_Customer_Party");

            entity.HasOne(d => d.Reagent).WithMany(p => p.InverseReagent).HasConstraintName("FK_Customer_Reagent");

            entity.HasOne(d => d.SalePerson).WithMany(p => p.Customers).HasConstraintName("FK_Customer_Visitor");

            entity.HasOne(d => d.Status).WithMany(p => p.Customers).HasConstraintName("FK_Customer_Dictionary");
        });

        modelBuilder.Entity<CustomerCard>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerCards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerCard_Customer");
        });

        modelBuilder.Entity<CustomerCreditHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerCreditHistories).HasConstraintName("FK_CustomerCreditHistory_Customer");
        });

        modelBuilder.Entity<CustomerCustomField>(entity =>
        {
            entity.Property(e => e.CustomerId).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithOne(p => p.CustomerCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerCustomField_Customer");
        });

        modelBuilder.Entity<CustomerFavorite>(entity =>
        {
            entity.HasOne(d => d.Customer).WithMany().HasConstraintName("FK_CustomerFavorites_Customer");
        });

        modelBuilder.Entity<CustomerGroup>(entity =>
        {
            entity.HasKey(e => e.CustomerGroupId).HasName("PK_CustomerGroup_1");

            entity.Property(e => e.CustomerGroupId).ValueGeneratedNever();

            entity.HasOne(d => d.Type).WithMany(p => p.CustomerGroups).HasConstraintName("FK_CustomerGroup_CustomerGroupType");
        });

        modelBuilder.Entity<CustomerGroupAssignment>(entity =>
        {
            entity.HasOne(d => d.CustomerGroup).WithMany(p => p.CustomerGroupAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerGroupAssignment_CustomerGroup");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerGroupAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerGroupAssignment_Customer");
        });

        modelBuilder.Entity<CustomerGroupAssignmentView>(entity =>
        {
            entity.ToView("CustomerGroupAssignmentView");
        });

        modelBuilder.Entity<CustomerGroupType>(entity =>
        {
            entity.Property(e => e.TypeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CustomerGroupTypeView>(entity =>
        {
            entity.ToView("CustomerGroupTypeView");
        });

        modelBuilder.Entity<CustomerItemFavoritesView>(entity =>
        {
            entity.ToView("CustomerItemFavoritesView");
        });

        modelBuilder.Entity<CustomerNameView>(entity =>
        {
            entity.ToView("CustomerNameView");
        });

        modelBuilder.Entity<CustomerRelationship>(entity =>
        {
            entity.HasOne(d => d.Child).WithMany(p => p.CustomerRelationshipChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerRelationship_Customer1");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerRelationshipCustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerRelationship_Customer");

            entity.HasOne(d => d.Type).WithMany(p => p.CustomerRelationships)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerRelationship_Dictionary");
        });

        modelBuilder.Entity<CustomerRelationshipView>(entity =>
        {
            entity.ToView("CustomerRelationshipView");
        });

        modelBuilder.Entity<CustomerResult>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerResults).HasConstraintName("FK_CustomerResults_CustomerInfo");

            entity.HasOne(d => d.Store).WithMany(p => p.CustomerResults).HasConstraintName("FK_CustomerResults_ClientInfo");

            entity.HasOne(d => d.PredefineResult).WithMany(p => p.CustomerResults).HasConstraintName("FK_CustomerResults_PredefineResult");
        });

        modelBuilder.Entity<CustomerStoreFavoritesView>(entity =>
        {
            entity.ToView("CustomerStoreFavoritesView");
        });

        modelBuilder.Entity<CustomerView>(entity =>
        {
            entity.ToView("CustomerView");

            entity.Property(e => e.AreaCode).IsFixedLength();
            entity.Property(e => e.Mobile).IsFixedLength();
            entity.Property(e => e.Telephone).IsFixedLength();
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK_Department_1");

            entity.Property(e => e.DepartmentId).ValueGeneratedNever();

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_Department_Department");

            entity.HasOne(d => d.Type).WithMany(p => p.Departments).HasConstraintName("FK_Department_DepartmentType");

            entity.HasMany(d => d.Attributes).WithMany(p => p.Departments)
                .UsingEntity<Dictionary<string, object>>(
                    "DepartmentAttribute",
                    r => r.HasOne<RainExtention.Infrastructure.Entities.Attribute>().WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DepartmentAttribute_Attribute"),
                    l => l.HasOne<Department>().WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DepartmentAttribute_Department"),
                    j =>
                    {
                        j.HasKey("DepartmentId", "AttributeId");
                        j.ToTable("DepartmentAttribute");
                        j.IndexerProperty<Guid>("DepartmentId").HasColumnName("DepartmentID");
                        j.IndexerProperty<Guid>("AttributeId").HasColumnName("AttributeID");
                    });
        });

        modelBuilder.Entity<DepartmentType>(entity =>
        {
            entity.Property(e => e.TypeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DepartmentTypeView>(entity =>
        {
            entity.ToView("DepartmentTypeView");
        });

        modelBuilder.Entity<DetailAccount>(entity =>
        {
            entity.Property(e => e.DetailAccountId).ValueGeneratedNever();

            entity.HasOne(d => d.Status).WithMany(p => p.DetailAccountStatuses).HasConstraintName("FK_DetailAccount_Dictionary");

            entity.HasOne(d => d.Type).WithMany(p => p.DetailAccountTypes).HasConstraintName("FK_DetailAccount_Type");
        });

        modelBuilder.Entity<DetailAccountView>(entity =>
        {
            entity.ToView("DetailAccountView");
        });

        modelBuilder.Entity<Dictionary>(entity =>
        {
            entity.Property(e => e.DictionaryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DictionaryImage>(entity =>
        {
            entity.HasOne(d => d.Dictionary).WithMany(p => p.DictionaryImages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DictionaryImage_Dictionary");
        });

        modelBuilder.Entity<DictionaryTranslation>(entity =>
        {
            entity.HasOne(d => d.Dictionary).WithMany(p => p.DictionaryTranslations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DictionaryTranslations_Dictionary");
        });

        modelBuilder.Entity<DictionaryValue>(entity =>
        {
            entity.HasOne(d => d.Dictionary).WithMany(p => p.DictionaryValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DictionaryValue_Dictionary");
        });

        modelBuilder.Entity<DictionaryView>(entity =>
        {
            entity.ToView("DictionaryView");
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.Property(e => e.DiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.BonusItem).WithMany(p => p.Discounts).HasConstraintName("FK_Discount_Item");

            entity.HasOne(d => d.DiscountCategory).WithMany(p => p.Discounts).HasConstraintName("FK_Discount_DiscountCategory");

            entity.HasOne(d => d.DiscountType).WithMany(p => p.DiscountDiscountTypes).HasConstraintName("FK_Discount_Dictionary");

            entity.HasOne(d => d.Status).WithMany(p => p.DiscountStatuses).HasConstraintName("FK_Discount_Dictionary2");

            entity.HasOne(d => d.ThersholdType).WithMany(p => p.DiscountThersholdTypes).HasConstraintName("FK_Discount_Dictionary1");

            entity.HasMany(d => d.CustomerGroups).WithMany(p => p.Discounts)
                .UsingEntity<Dictionary<string, object>>(
                    "DiscountCustomerGroupAssignment",
                    r => r.HasOne<CustomerGroup>().WithMany()
                        .HasForeignKey("CustomerGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DiscountCustomerGroupAssignment_CustomerGroup"),
                    l => l.HasOne<Discount>().WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DiscountCustomerGroupAssignment_Discount"),
                    j =>
                    {
                        j.HasKey("DiscountId", "CustomerGroupId").HasName("PK_DiscountCustomerGroupAssignment_1");
                        j.ToTable("DiscountCustomerGroupAssignment");
                        j.IndexerProperty<Guid>("DiscountId").HasColumnName("DiscountID");
                        j.IndexerProperty<Guid>("CustomerGroupId").HasColumnName("CustomerGroupID");
                    });

            entity.HasMany(d => d.Groups).WithMany(p => p.Discounts)
                .UsingEntity<Dictionary<string, object>>(
                    "DiscountStoreGroupAssignment",
                    r => r.HasOne<StoreGroup>().WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DiscountStoreGroupAssignment_StoreGroup"),
                    l => l.HasOne<Discount>().WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DiscountStoreGroupAssignment_Discount"),
                    j =>
                    {
                        j.HasKey("DiscountId", "GroupId");
                        j.ToTable("DiscountStoreGroupAssignment");
                        j.IndexerProperty<Guid>("DiscountId").HasColumnName("DiscountID");
                        j.IndexerProperty<Guid>("GroupId").HasColumnName("GroupID");
                    });

            entity.HasMany(d => d.Stores).WithMany(p => p.Discounts)
                .UsingEntity<Dictionary<string, object>>(
                    "DiscountStoreAssignment",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DiscountStoreAssignment_Store"),
                    l => l.HasOne<Discount>().WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DiscountStoreAssignment_Discount"),
                    j =>
                    {
                        j.HasKey("DiscountId", "StoreId").HasName("PK_DiscountStoreAssignment_1");
                        j.ToTable("DiscountStoreAssignment");
                        j.IndexerProperty<Guid>("DiscountId").HasColumnName("DiscountID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });
        });

        modelBuilder.Entity<DiscountActiveTime>(entity =>
        {
            entity.HasOne(d => d.Discount).WithMany(p => p.DiscountActiveTimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountActiveTime_Discount");
        });

        modelBuilder.Entity<DiscountCategory>(entity =>
        {
            entity.Property(e => e.DiscountCategoryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DiscountCondition>(entity =>
        {
            entity.HasOne(d => d.Discount).WithMany(p => p.DiscountConditions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountCondition_Discount");
        });

        modelBuilder.Entity<DiscountCustomerGroupAssignmentView>(entity =>
        {
            entity.ToView("DiscountCustomerGroupAssignmentView");
        });

        modelBuilder.Entity<DiscountDepartmentAssignment>(entity =>
        {
            entity.HasKey(e => new { e.DiscountId, e.DepartmentId }).HasName("PK_DiscountDepartmentAssignment_1");

            entity.HasOne(d => d.Department).WithMany(p => p.DiscountDepartmentAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountDepartmentAssignment_Department");

            entity.HasOne(d => d.Discount).WithMany(p => p.DiscountDepartmentAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountDepartmentAssignment_Discount");
        });

        modelBuilder.Entity<DiscountDepartmentAssignmentView>(entity =>
        {
            entity.ToView("DiscountDepartmentAssignmentView");
        });

        modelBuilder.Entity<DiscountItemAssignment>(entity =>
        {
            entity.HasKey(e => new { e.DiscountId, e.ItemId }).HasName("PK_DiscountItemAssignment_1");

            entity.HasOne(d => d.DiscountNavigation).WithMany(p => p.DiscountItemAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountItemAssignment_Discount");

            entity.HasOne(d => d.Item).WithMany(p => p.DiscountItemAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountItemAssignment_Item");
        });

        modelBuilder.Entity<DiscountItemAssignmentView>(entity =>
        {
            entity.ToView("DiscountItemAssignmentView");
        });

        modelBuilder.Entity<DiscountPriceLevel>(entity =>
        {
            entity.HasOne(d => d.DiscountType).WithMany(p => p.DiscountPriceLevels).HasConstraintName("FK_DiscountPriceLevel_Dictionary");
        });

        modelBuilder.Entity<DiscountStoreAssignmentView>(entity =>
        {
            entity.ToView("DiscountStoreAssignmentView");
        });

        modelBuilder.Entity<DiscountStoreGroupAssignmentView>(entity =>
        {
            entity.ToView("DiscountStoreGroupAssignmentView");
        });

        modelBuilder.Entity<DiscountTender>(entity =>
        {
            entity.HasOne(d => d.Discount).WithMany(p => p.DiscountTenders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountTender_Discount");
        });

        modelBuilder.Entity<DiscountTenderView>(entity =>
        {
            entity.ToView("DiscountTenderView");
        });

        modelBuilder.Entity<DiscountView>(entity =>
        {
            entity.ToView("DiscountView");
        });

        modelBuilder.Entity<DistributeDataView>(entity =>
        {
            entity.ToView("DistributeDataView");
        });

        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasOne(d => d.Party).WithMany(p => p.Emails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Email_Party");

            entity.HasOne(d => d.Type).WithMany(p => p.Emails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Email_Dictionary");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK_Employee_1");

            entity.Property(e => e.EmployeeId).ValueGeneratedNever();

            entity.HasOne(d => d.Party).WithMany(p => p.Employees).HasConstraintName("FK_Employee_Party");

            entity.HasMany(d => d.Stores).WithMany(p => p.Employees)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeeLocationAssignment",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeeLocationAssignment_Store"),
                    l => l.HasOne<Employee>().WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeeLocationAssignment_Employee"),
                    j =>
                    {
                        j.HasKey("EmployeeId", "StoreId");
                        j.ToTable("EmployeeLocationAssignment");
                        j.IndexerProperty<Guid>("EmployeeId").HasColumnName("EmployeeID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });
        });

        modelBuilder.Entity<Employee1>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF10DF9C40C");

            entity.Property(e => e.EmployeeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmployeeCustomField>(entity =>
        {
            entity.Property(e => e.EmployeeId).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithOne(p => p.EmployeeCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeCustomField_Employee");
        });

        modelBuilder.Entity<EmployeeLocationAssignmentView>(entity =>
        {
            entity.ToView("EmployeeLocationAssignmentView");
        });

        modelBuilder.Entity<EmployeeView>(entity =>
        {
            entity.ToView("EmployeeView");
        });

        modelBuilder.Entity<ExportDataConfig>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FileRepository>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FileRepository_1");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Department).WithMany(p => p.FileRepositories).HasConstraintName("FK_FileRepository_Department");

            entity.HasOne(d => d.Status).WithMany(p => p.FileRepositories).HasConstraintName("FK_FileRepository_Dictionary");
        });

        modelBuilder.Entity<FileRepositoryView>(entity =>
        {
            entity.ToView("FileRepositoryView");
        });

        modelBuilder.Entity<FinancialDocument>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.BookerWorkstationId, e.DocumentId }).HasName("PK_FinancialDocument_1");

            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.FinancialDocumentApproveUserNavigations).HasConstraintName("FK_FinancialDocument_ApproveUser");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.FinancialDocumentCreationUserNavigations).HasConstraintName("FK_FinancialDocument_CreateUser");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.FinancialDocumentDocumentTypes).HasConstraintName("FK_FinancialDocument_Type");

            entity.HasOne(d => d.FinancialYear).WithMany(p => p.FinancialDocuments).HasConstraintName("FK_FinancialDocument_FinancialYear");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.FinancialDocumentModifyUserNavigations).HasConstraintName("FK_FinancialDocument_ModifyUser");

            entity.HasOne(d => d.Status).WithMany(p => p.FinancialDocumentStatuses).HasConstraintName("FK_FinancialDocument_Status");

            entity.HasOne(d => d.TempUserNavigation).WithMany(p => p.FinancialDocumentTempUserNavigations).HasConstraintName("FK_FinancialDocument_TempUser");
        });

        modelBuilder.Entity<FinancialDocumentLineItem>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.BookerWorkstationId, e.DocumentId, e.LineItemId }).HasName("PK_FinancialDocumentLineItem_1");

            entity.HasOne(d => d.FinancialDocument).WithMany(p => p.FinancialDocumentLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FinancialDocumentLineItem_FinancialDocumentLineItem");
        });

        modelBuilder.Entity<FinancialExportView>(entity =>
        {
            entity.ToView("FinancialExportView");
        });

        modelBuilder.Entity<FinancialExportedView>(entity =>
        {
            entity.ToView("FinancialExportedView");
        });

        modelBuilder.Entity<FinancialMapping>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Operation).WithMany(p => p.FinancialMappings).HasConstraintName("FK_FinancialMapping_ExportDataConfig");
        });

        modelBuilder.Entity<FinancialYear>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Status).WithMany(p => p.FinancialYears).HasConstraintName("FK_FinancialYear_Dictionary");
        });

        modelBuilder.Entity<GiftCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GiftCrad");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasMany(d => d.Stores).WithMany(p => p.Ids)
                .UsingEntity<Dictionary<string, object>>(
                    "GiftCardStoreAssignment",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_GiftCardStoreAssignment_Store"),
                    l => l.HasOne<GiftCard>().WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_GiftCardStoreAssignment_GiftCard"),
                    j =>
                    {
                        j.HasKey("Id", "StoreId");
                        j.ToTable("GiftCardStoreAssignment");
                        j.IndexerProperty<Guid>("Id").HasColumnName("ID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });
        });

        modelBuilder.Entity<GiftCardInvoice>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.GiftCardInvoice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GiftCardInvoice_GiftCard");
        });

        modelBuilder.Entity<GiftCardSerial>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.GiftCardSerials).HasConstraintName("FK_GiftCardSerial_GiftCrad");
        });

        modelBuilder.Entity<GiftCardSerialLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.SerialNumberNavigation).WithMany(p => p.GiftCardSerialLogs).HasConstraintName("FK_GiftCardSerialLog_GiftCardSerial");
        });

        modelBuilder.Entity<GiftCardSerialView>(entity =>
        {
            entity.ToView("GiftCardSerialView");
        });

        modelBuilder.Entity<GiftCardStoreAssignmentView>(entity =>
        {
            entity.ToView("GiftCardStoreAssignmentView");
        });

        modelBuilder.Entity<GiftCardView>(entity =>
        {
            entity.ToView("GiftCardView");
        });

        modelBuilder.Entity<ImageRepository>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ImageRepository_1");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ImportDataItem>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.ImportDataItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportDataItem_ImportData");
        });

        modelBuilder.Entity<ImportDatum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.ImportData).HasConstraintName("FK_ImportData_User");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK_Item_1");

            entity.Property(e => e.ItemId).ValueGeneratedNever();

            entity.HasOne(d => d.Brand).WithMany(p => p.Items).HasConstraintName("FK_Item_Brand");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.ItemCreationUserNavigations).HasConstraintName("FK_Item_CreationUser");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.ItemModifyUserNavigations).HasConstraintName("FK_Item_ModifyUser");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_Item_ParentItem");

            entity.HasOne(d => d.Status).WithMany(p => p.ItemStatuses).HasConstraintName("FK_Item_Dictionary2");

            entity.HasOne(d => d.Type).WithMany(p => p.ItemTypes).HasConstraintName("FK_Item_Dictionary");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.ItemUnitOfMeasures).HasConstraintName("FK_Item_Dictionary1");
        });

        modelBuilder.Entity<ItemAssortment>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemAssortments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemAssortment_Item");

            entity.HasOne(d => d.AttributeValue).WithMany(p => p.ItemAssortments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemAssortment_AttributeValue");
        });

        modelBuilder.Entity<ItemAttribute>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemAttributes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemAttribute_Item");
        });

        modelBuilder.Entity<ItemAttributeItem>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.AttributeId, e.ValueId, e.ChildId }).HasName("PK_ItemAttributeItem_1");

            entity.HasOne(d => d.Child).WithMany(p => p.ItemAttributeItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemAttributeItem_Item");

            entity.HasOne(d => d.AttributeValue).WithMany(p => p.ItemAttributeItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemAttributeItem_AttributeValue");
        });

        modelBuilder.Entity<ItemAttributeTemplate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemBarcode>(entity =>
        {
            entity.HasKey(e => e.BarcodeId).HasName("PK_ItemBarcode_1");

            entity.Property(e => e.BarcodeId).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithMany(p => p.ItemBarcodes).HasConstraintName("FK_ItemBarcode_Item");
        });

        modelBuilder.Entity<ItemCardexView>(entity =>
        {
            entity.ToView("ItemCardexView");
        });

        modelBuilder.Entity<ItemCardexView2>(entity =>
        {
            entity.ToView("ItemCardexView2");
        });

        modelBuilder.Entity<ItemCollection>(entity =>
        {
            entity.HasOne(d => d.ChildItem).WithMany(p => p.ItemCollectionChildItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemCollection_Item1");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemCollectionItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemCollection_Item");
        });

        modelBuilder.Entity<ItemCollectionView>(entity =>
        {
            entity.ToView("ItemCollectionView");
        });

        modelBuilder.Entity<ItemCustomField>(entity =>
        {
            entity.Property(e => e.ItemId).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithOne(p => p.ItemCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemCustomField_Item");
        });

        modelBuilder.Entity<ItemDepartmentAssignment>(entity =>
        {
            entity.HasOne(d => d.Department).WithMany(p => p.ItemDepartmentAssignments).HasConstraintName("FK_ItemDepartmentAssignment_Department");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemDepartmentAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemDepartmentAssignment_Item");
        });

        modelBuilder.Entity<ItemDepartmentAssignmentView>(entity =>
        {
            entity.ToView("ItemDepartmentAssignmentView");
        });

        modelBuilder.Entity<ItemDepartmentLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Department).WithMany(p => p.ItemDepartmentLogs).HasConstraintName("FK_ItemDepartmentLog_Department");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemDepartmentLogs).HasConstraintName("FK_ItemDepartmentLog_Item");

            entity.HasOne(d => d.User).WithMany(p => p.ItemDepartmentLogs).HasConstraintName("FK_ItemDepartmentLog_User");
        });

        modelBuilder.Entity<ItemDepartmentView>(entity =>
        {
            entity.ToView("ItemDepartmentView");
        });

        modelBuilder.Entity<ItemForMobileView>(entity =>
        {
            entity.ToView("ItemForMobileView");
        });

        modelBuilder.Entity<ItemImage>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithMany(p => p.ItemImages).HasConstraintName("FK_ItemImage_Item");
        });

        modelBuilder.Entity<ItemImageView>(entity =>
        {
            entity.ToView("ItemImageView");
        });

        modelBuilder.Entity<ItemNameView>(entity =>
        {
            entity.ToView("ItemNameView");
        });

        modelBuilder.Entity<ItemSalePriceView>(entity =>
        {
            entity.ToView("ItemSalePriceView");
        });

        modelBuilder.Entity<ItemSerializedStockState>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.SerialNumber }).HasName("PK_ItemSerializedStockState_1");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemSerializedStockStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemSerializedStockState_Item");

            entity.HasOne(d => d.Status).WithMany(p => p.ItemSerializedStockStates).HasConstraintName("FK_ItemSerializedStockState_Dictionary");

            entity.HasOne(d => d.Stock).WithMany(p => p.ItemSerializedStockStates).HasConstraintName("FK_ItemSerializedStockState_Stock");
        });

        modelBuilder.Entity<ItemServiceRule>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemServiceRules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemServiceRule_Item");
        });

        modelBuilder.Entity<ItemState>(entity =>
        {
            entity.Property(e => e.ItemId).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithOne(p => p.ItemState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemState_Item");
        });

        modelBuilder.Entity<ItemStockQuantity>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemStockQuantities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemStockQuantity_Item");

            entity.HasOne(d => d.Stock).WithMany(p => p.ItemStockQuantities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemStockQuantity_Stock");
        });

        modelBuilder.Entity<ItemStockSection>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemStockSections)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemStockSection_Item");

            entity.HasOne(d => d.Section).WithMany(p => p.ItemStockSections)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemStockSection_StockSection");
        });

        modelBuilder.Entity<ItemStockSectionView>(entity =>
        {
            entity.ToView("ItemStockSectionView");
        });

        modelBuilder.Entity<ItemStockState>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemStockStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemStockState_Item");

            entity.HasOne(d => d.Status).WithMany(p => p.ItemStockStates).HasConstraintName("FK_ItemStockState_Dictionary");

            entity.HasOne(d => d.Stock).WithMany(p => p.ItemStockStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemStockState_Stock");
        });

        modelBuilder.Entity<ItemStockStateView>(entity =>
        {
            entity.ToView("ItemStockStateView");
        });

        modelBuilder.Entity<ItemTag>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasMany(d => d.Departments).WithMany(p => p.Tags)
                .UsingEntity<Dictionary<string, object>>(
                    "ItemTagDepartmentAssignment",
                    r => r.HasOne<Department>().WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ItemTagDepartmentAssignment_Department"),
                    l => l.HasOne<ItemTag>().WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ItemTagDepartmentAssignment_ItemTag"),
                    j =>
                    {
                        j.HasKey("TagId", "DepartmentId");
                        j.ToTable("ItemTagDepartmentAssignment");
                        j.IndexerProperty<Guid>("TagId").HasColumnName("TagID");
                        j.IndexerProperty<Guid>("DepartmentId").HasColumnName("DepartmentID");
                    });

            entity.HasMany(d => d.Items).WithMany(p => p.Tags)
                .UsingEntity<Dictionary<string, object>>(
                    "ItemTagItemAssignment",
                    r => r.HasOne<Item>().WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ItemTagItemAssignment_Item"),
                    l => l.HasOne<ItemTag>().WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ItemTagItemAssignment_ItemTag"),
                    j =>
                    {
                        j.HasKey("TagId", "ItemId");
                        j.ToTable("ItemTagItemAssignment");
                        j.IndexerProperty<Guid>("TagId").HasColumnName("TagID");
                        j.IndexerProperty<Guid>("ItemId").HasColumnName("ItemID");
                    });
        });

        modelBuilder.Entity<ItemTagDepartmentAssignmentView>(entity =>
        {
            entity.ToView("ItemTagDepartmentAssignmentView");
        });

        modelBuilder.Entity<ItemTagItemAssignmentView>(entity =>
        {
            entity.ToView("ItemTagItemAssignmentView");
        });

        modelBuilder.Entity<ItemTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.LanguageId }).HasName("PK_ItemTranslations_1");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemTranslations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTranslations_Item");
        });

        modelBuilder.Entity<ItemView>(entity =>
        {
            entity.ToView("ItemView");
        });

        modelBuilder.Entity<LastWeekDailySale>(entity =>
        {
            entity.ToView("LastWeekDailySale");

            entity.Property(e => e.Date).IsFixedLength();
        });

        modelBuilder.Entity<LastWeekDepartmentSale>(entity =>
        {
            entity.ToView("LastWeekDepartmentSale");
        });

        modelBuilder.Entity<LastWeekTenderAmount>(entity =>
        {
            entity.ToView("LastWeekTenderAmount");
        });

        modelBuilder.Entity<Lottery>(entity =>
        {
            entity.Property(e => e.LotteryId).ValueGeneratedNever();

            entity.HasOne(d => d.CalculationType).WithMany(p => p.LotteryCalculationTypes).HasConstraintName("FK_Table_1_CalculationType");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.Lotteries).HasConstraintName("FK_Lottery_User");

            entity.HasOne(d => d.ThresholdType).WithMany(p => p.LotteryThresholdTypes).HasConstraintName("FK_Table_1_ThresholdType");

            entity.HasMany(d => d.CustomerGroups).WithMany(p => p.Lotteries)
                .UsingEntity<Dictionary<string, object>>(
                    "LotteryCustomerGroupAssignment",
                    r => r.HasOne<CustomerGroup>().WithMany()
                        .HasForeignKey("CustomerGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LotteryCustomerGroupAssignment_CustomerGroup"),
                    l => l.HasOne<Lottery>().WithMany()
                        .HasForeignKey("LotteryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LotteryCustomerGroupAssignment_Lottery"),
                    j =>
                    {
                        j.HasKey("LotteryId", "CustomerGroupId");
                        j.ToTable("LotteryCustomerGroupAssignment");
                        j.IndexerProperty<Guid>("LotteryId").HasColumnName("LotteryID");
                        j.IndexerProperty<Guid>("CustomerGroupId").HasColumnName("CustomerGroupID");
                    });

            entity.HasMany(d => d.Departments).WithMany(p => p.Lotteries)
                .UsingEntity<Dictionary<string, object>>(
                    "LotteryDepartmentAssignment",
                    r => r.HasOne<Department>().WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LotteryDepartmentAssignment_Department"),
                    l => l.HasOne<Lottery>().WithMany()
                        .HasForeignKey("LotteryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LotteryDepartmentAssignment_Lottery"),
                    j =>
                    {
                        j.HasKey("LotteryId", "DepartmentId");
                        j.ToTable("LotteryDepartmentAssignment");
                        j.IndexerProperty<Guid>("LotteryId").HasColumnName("LotteryID");
                        j.IndexerProperty<Guid>("DepartmentId").HasColumnName("DepartmentID");
                    });

            entity.HasMany(d => d.Stores).WithMany(p => p.Lotteries)
                .UsingEntity<Dictionary<string, object>>(
                    "LotteryStoreAssignment",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LotteryStoreAssignment_Store"),
                    l => l.HasOne<Lottery>().WithMany()
                        .HasForeignKey("LotteryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LotteryStoreAssignment_Lottery"),
                    j =>
                    {
                        j.HasKey("LotteryId", "StoreId");
                        j.ToTable("LotteryStoreAssignment");
                        j.IndexerProperty<Guid>("LotteryId").HasColumnName("LotteryID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });
        });

        modelBuilder.Entity<LotteryCustomerGroupAssignmentView>(entity =>
        {
            entity.ToView("LotteryCustomerGroupAssignmentView");
        });

        modelBuilder.Entity<LotteryDepartmentAssignmentView>(entity =>
        {
            entity.ToView("LotteryDepartmentAssignmentView");
        });

        modelBuilder.Entity<LotteryLineItem>(entity =>
        {
            entity.HasOne(d => d.Lottery).WithMany(p => p.LotteryLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LotteryLineItem_Lottery");
        });

        modelBuilder.Entity<LotteryLineItemView>(entity =>
        {
            entity.ToView("LotteryLineItemView");

            entity.Property(e => e.Mobile).IsFixedLength();
            entity.Property(e => e.Telephone).IsFixedLength();
        });

        modelBuilder.Entity<LotteryStoreAssignmentView>(entity =>
        {
            entity.ToView("LotteryStoreAssignmentView");
        });

        modelBuilder.Entity<LotteryTicket>(entity =>
        {
            entity.Property(e => e.TicketId).ValueGeneratedNever();
        });

        modelBuilder.Entity<LoyalityAwardRule>(entity =>
        {
            entity.HasKey(e => e.RuleId).HasName("PK_LoyaltyAwardRule_1");

            entity.Property(e => e.RuleId).ValueGeneratedNever();

            entity.HasOne(d => d.CustomerGroup).WithMany(p => p.LoyalityAwardRules).HasConstraintName("FK_LoyaltyAwardRule_CustomerGroup");

            entity.HasMany(d => d.Stores).WithMany(p => p.Rules)
                .UsingEntity<Dictionary<string, object>>(
                    "LoyalityAwardRuleStore",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LoyalityAwardRuleStore_Store"),
                    l => l.HasOne<LoyalityAwardRule>().WithMany()
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LoyalityAwardRuleStore_LoyalityAwardRule"),
                    j =>
                    {
                        j.HasKey("RuleId", "StoreId");
                        j.ToTable("LoyalityAwardRuleStore");
                        j.IndexerProperty<Guid>("RuleId").HasColumnName("RuleID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });
        });

        modelBuilder.Entity<LoyalityAwardRuleItem>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.LoyalityAwardRuleItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoyalityAwardRuleItems_Item");

            entity.HasOne(d => d.Rule).WithMany(p => p.LoyalityAwardRuleItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoyalityAwardRuleItems_LoyaltyAwardRule");
        });

        modelBuilder.Entity<LoyalityAwardRuleItemsView>(entity =>
        {
            entity.ToView("LoyalityAwardRuleItemsView");
        });

        modelBuilder.Entity<LoyalityAwardRuleStoreView>(entity =>
        {
            entity.ToView("LoyalityAwardRuleStoreView");
        });

        modelBuilder.Entity<LoyalityAwardRuleView>(entity =>
        {
            entity.ToView("LoyalityAwardRuleView");
        });

        modelBuilder.Entity<LoyalityContract>(entity =>
        {
            entity.Property(e => e.ContractId).ValueGeneratedNever();
        });

        modelBuilder.Entity<LoyalityContractCustomerAssignmentView>(entity =>
        {
            entity.ToView("LoyalityContractCustomerAssignmentView");
        });

        modelBuilder.Entity<LoyalityContractView>(entity =>
        {
            entity.ToView("LoyalityContractView");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.ManagerId).HasName("PK__Managers__3BA2AA8163E2AB80");

            entity.Property(e => e.ManagerId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_Message_Message");
        });

        modelBuilder.Entity<MessageEntityAssignment>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.MessageEntityAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageEntityAssignment_Message");
        });

        modelBuilder.Entity<MessageFileAttachment>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.MessageFileAttachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageFileAttachment_Message");
        });

        modelBuilder.Entity<MessageUserAssignment>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.MessageUserAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageUserAssignment_Message");

            entity.HasOne(d => d.User).WithMany(p => p.MessageUserAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageUserAssignment_User");
        });

        modelBuilder.Entity<MessageUserAssignmentView>(entity =>
        {
            entity.ToView("MessageUserAssignmentView");
        });

        modelBuilder.Entity<MessageView>(entity =>
        {
            entity.ToView("MessageView");
        });

        modelBuilder.Entity<NewProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__NewProdu__B40CC6ED224C57D6");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
        });

        modelBuilder.Entity<OrderDocument>(entity =>
        {
            entity.Property(e => e.OrderCode).IsFixedLength();

            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.OrderDocumentApproveUserNavigations).HasConstraintName("FK_OrderDocument_ApproveUser");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.OrderDocumentCreationUserNavigations).HasConstraintName("FK_OrderDocument_User");

            entity.HasOne(d => d.Store).WithMany(p => p.OrderDocuments).HasConstraintName("FK_OrderDocument_Store");

            entity.HasOne(d => d.VoidUserNavigation).WithMany(p => p.OrderDocumentVoidUserNavigations).HasConstraintName("FK_OrderDocument_VoidUser");

            entity.HasOne(d => d.Workstation).WithMany(p => p.OrderDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDocument_Workstation");
        });

        modelBuilder.Entity<OrderDocumentLineItem>(entity =>
        {
            entity.HasOne(d => d.Customer).WithMany(p => p.OrderDocumentLineItems).HasConstraintName("FK_OrderDocumentLineItem_Customer");

            entity.HasOne(d => d.Item).WithMany(p => p.OrderDocumentLineItems).HasConstraintName("FK_OrderDocumentLineItem_Item");

            entity.HasOne(d => d.OrderDocument).WithMany(p => p.OrderDocumentLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDocumentLineItem_OrderDocument");
        });

        modelBuilder.Entity<OrderDocumentLineItemCustomField>(entity =>
        {
            entity.HasOne(d => d.OrderDocumentLineItem).WithOne(p => p.OrderDocumentLineItemCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDocumentLineItemCustomField_OrderDocumentLineItem");
        });

        modelBuilder.Entity<OrderDocumentLineItemView>(entity =>
        {
            entity.ToView("OrderDocumentLineItemView");

            entity.Property(e => e.Mobile).IsFixedLength();
        });

        modelBuilder.Entity<OrderDocumentView>(entity =>
        {
            entity.ToView("OrderDocumentView");

            entity.Property(e => e.Date).IsFixedLength();
            entity.Property(e => e.OrderCode).IsFixedLength();
        });

        modelBuilder.Entity<OwnUserPermissionView>(entity =>
        {
            entity.ToView("OwnUserPermissionView");
        });

        modelBuilder.Entity<PartialInvoice>(entity =>
        {
            entity.ToView("PartialInvoices");

            entity.Property(e => e.InvoiceDate).IsFixedLength();
            entity.Property(e => e.SettelmentDate).IsFixedLength();
        });

        modelBuilder.Entity<PartialPaymentRule>(entity =>
        {
            entity.Property(e => e.RuleId).ValueGeneratedNever();

            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.PartialPaymentRuleApproveUserNavigations).HasConstraintName("FK_PartialPaymentRule_User1");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.PartialPaymentRuleCreationUserNavigations).HasConstraintName("FK_PartialPaymentRule_User");

            entity.HasOne(d => d.Status).WithMany(p => p.PartialPaymentRules).HasConstraintName("FK_PartialPaymentRule_Dictionary");

            entity.HasOne(d => d.VoidUserNavigation).WithMany(p => p.PartialPaymentRuleVoidUserNavigations).HasConstraintName("FK_PartialPaymentRule_User2");

            entity.HasMany(d => d.CustomerGroups).WithMany(p => p.Rules)
                .UsingEntity<Dictionary<string, object>>(
                    "PartialPaymentRuleCustomerGroupAssignment",
                    r => r.HasOne<CustomerGroup>().WithMany()
                        .HasForeignKey("CustomerGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PartialPaymentRuleCustomerGroupAssignment_CustomerGroup"),
                    l => l.HasOne<PartialPaymentRule>().WithMany()
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PartialPaymentRuleCustomerGroupAssignment_PartialPaymentRule"),
                    j =>
                    {
                        j.HasKey("RuleId", "CustomerGroupId");
                        j.ToTable("PartialPaymentRuleCustomerGroupAssignment");
                        j.IndexerProperty<Guid>("RuleId").HasColumnName("RuleID");
                        j.IndexerProperty<Guid>("CustomerGroupId").HasColumnName("CustomerGroupID");
                    });

            entity.HasMany(d => d.StoreGroups).WithMany(p => p.Rules)
                .UsingEntity<Dictionary<string, object>>(
                    "PartialPaymentRuleStoreGroupAssignment",
                    r => r.HasOne<StoreGroup>().WithMany()
                        .HasForeignKey("StoreGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PartialPaymentRuleStoreGroupAssignment_StoreGroup"),
                    l => l.HasOne<PartialPaymentRule>().WithMany()
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PartialPaymentRuleStoreGroupAssignment_PartialPaymentRule"),
                    j =>
                    {
                        j.HasKey("RuleId", "StoreGroupId");
                        j.ToTable("PartialPaymentRuleStoreGroupAssignment");
                        j.IndexerProperty<Guid>("RuleId").HasColumnName("RuleID");
                        j.IndexerProperty<Guid>("StoreGroupId").HasColumnName("StoreGroupID");
                    });

            entity.HasMany(d => d.Stores).WithMany(p => p.RulesNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "PartialPaymentRuleStoreAssignment",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PartialPaymentRuleStoreAssignment_Store"),
                    l => l.HasOne<PartialPaymentRule>().WithMany()
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PartialPaymentRuleStoreAssignment_PartialPaymentRule"),
                    j =>
                    {
                        j.HasKey("RuleId", "StoreId");
                        j.ToTable("PartialPaymentRuleStoreAssignment");
                        j.IndexerProperty<Guid>("RuleId").HasColumnName("RuleID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });
        });

        modelBuilder.Entity<PartialPaymentRuleCustomerGroupAssignmentView>(entity =>
        {
            entity.ToView("PartialPaymentRuleCustomerGroupAssignmentView");
        });

        modelBuilder.Entity<PartialPaymentRuleDepartmentAssignment>(entity =>
        {
            entity.HasOne(d => d.Department).WithMany(p => p.PartialPaymentRuleDepartmentAssignments).HasConstraintName("FK_PartialPaymentRuleDepartmentAssignment_Department");

            entity.HasOne(d => d.Rule).WithMany(p => p.PartialPaymentRuleDepartmentAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartialPaymentRuleDepartmentAssignment_PartialPaymentRule");
        });

        modelBuilder.Entity<PartialPaymentRuleDepartmentAssignmentView>(entity =>
        {
            entity.ToView("PartialPaymentRuleDepartmentAssignmentView");
        });

        modelBuilder.Entity<PartialPaymentRuleItemAssignment>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.PartialPaymentRuleItemAssignments).HasConstraintName("FK_PartialPaymentRuleItemAssignment_Item");

            entity.HasOne(d => d.Rule).WithMany(p => p.PartialPaymentRuleItemAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartialPaymentRuleItemAssignment_PartialPaymentRuleItemAssignment");
        });

        modelBuilder.Entity<PartialPaymentRuleItemAssignmentView>(entity =>
        {
            entity.ToView("PartialPaymentRuleItemAssignmentView");
        });

        modelBuilder.Entity<PartialPaymentRuleStoreAssignmentView>(entity =>
        {
            entity.ToView("PartialPaymentRuleStoreAssignmentView");
        });

        modelBuilder.Entity<PartialPaymentRuleStoreGroupAssignmentView>(entity =>
        {
            entity.ToView("PartialPaymentRuleStoreGroupAssignmentView");
        });

        modelBuilder.Entity<PartialPaymentRuleView>(entity =>
        {
            entity.ToView("PartialPaymentRuleView");
        });

        modelBuilder.Entity<Party>(entity =>
        {
            entity.HasKey(e => e.PartyId).HasName("PK_Party_1");

            entity.Property(e => e.PartyId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PeriodicCosting>(entity =>
        {
            entity.HasOne(d => d.BookerStore).WithMany(p => p.PeriodicCostings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PeriodicCosting_Store");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.PeriodicCostings).HasConstraintName("FK_PeriodicCosting_User");
        });

        modelBuilder.Entity<PeriodicCostingExtend>(entity =>
        {
            entity.Property(e => e.Description).IsFixedLength();

            entity.HasOne(d => d.Reason).WithMany(p => p.PeriodicCostingExtends)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PeriodicCostingExtend_Reason");

            entity.HasOne(d => d.Step).WithMany(p => p.PeriodicCostingExtends).HasConstraintName("FK_PeriodicCostingExtend_Step");

            entity.HasOne(d => d.PeriodicCosting).WithMany(p => p.PeriodicCostingExtends)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PeriodicCostingExtend_PeriodicCosting");
        });

        modelBuilder.Entity<PeriodicCostingItem>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.Id, e.ItemId }).HasName("PK_PeriodicCostItems");

            entity.HasOne(d => d.PeriodicCosting).WithMany(p => p.PeriodicCostingItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PeriodicCostItems_PeriodicCosting");
        });

        modelBuilder.Entity<PeriodicCostingStore>(entity =>
        {
            entity.HasOne(d => d.PeriodicCosting).WithMany(p => p.PeriodicCostingStores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PeriodicCostingStores_PeriodicCosting");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.Property(e => e.PermissionId).ValueGeneratedNever();

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_Permission_Permission");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__People__AA2FFB851FF720F1");

            entity.Property(e => e.PersonId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK_Person_1");

            entity.Property(e => e.PersonId).ValueGeneratedNever();

            entity.HasOne(d => d.DetailAccount).WithOne(p => p.Person1).HasConstraintName("FK_Person_DetailAccount");

            entity.HasOne(d => d.Party).WithOne(p => p.Person).HasConstraintName("FK_Person_Party");

            entity.HasOne(d => d.Salution).WithMany(p => p.Person1s).HasConstraintName("FK_Person_Dictionary");

            entity.HasOne(d => d.ThirdParty).WithOne(p => p.Person).HasConstraintName("FK_Person_ThirdParty");
        });

        modelBuilder.Entity<PersonCustomField>(entity =>
        {
            entity.Property(e => e.PersonId).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithOne(p => p.PersonCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonCustomField_Person");
        });

        modelBuilder.Entity<PersonNameTranslation>(entity =>
        {
            entity.HasKey(e => new { e.PersonId, e.LanguageId }).HasName("PK_PersonNameTranslations_1");

            entity.HasOne(d => d.Person).WithMany(p => p.PersonNameTranslations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonNameTranslations_Person");
        });

        modelBuilder.Entity<PersonView>(entity =>
        {
            entity.ToView("PersonView");
        });

        modelBuilder.Entity<PhysicalDocumentConfig>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasMany(d => d.Stores).WithMany(p => p.IdsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "PhysicalDocumentConfigStore",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PhysicalDocumentConfigStores_Store"),
                    l => l.HasOne<PhysicalDocumentConfig>().WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PhysicalDocumentConfigStores_PhysicalDocumentConfig"),
                    j =>
                    {
                        j.HasKey("Id", "StoreId");
                        j.ToTable("PhysicalDocumentConfigStores");
                        j.IndexerProperty<Guid>("Id").HasColumnName("ID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });
        });

        modelBuilder.Entity<PlanningCalendar>(entity =>
        {
            entity.Property(e => e.CalendarId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PlanningCalendarItem>(entity =>
        {
            entity.HasOne(d => d.Calendar).WithMany(p => p.PlanningCalendarItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanningCalendarItem_PlanningCalendar");
        });

        modelBuilder.Entity<PredefineResult>(entity =>
        {
            entity.HasKey(e => new { e.QuestionId, e.ResultId }).HasName("PK_PredefineResult_1");

            entity.HasOne(d => d.Question).WithMany(p => p.PredefineResults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PredefineResult_Question");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6ED558EE361");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProductCatalog>(entity =>
        {
            entity.HasKey(e => e.CatalogId).HasName("PK_ProdcutCatalog");

            entity.Property(e => e.CatalogId).ValueGeneratedNever();

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.ProductCatalogCreationUserNavigations).HasConstraintName("FK_ProdcutCatalog_User");

            entity.HasOne(d => d.Item).WithMany(p => p.ProductCatalogs).HasConstraintName("FK_ProdcutCatalog_Item");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.ProductCatalogModifyUserNavigations).HasConstraintName("FK_ProdcutCatalog_User1");

            entity.HasOne(d => d.Type).WithMany(p => p.ProductCatalogs).HasConstraintName("FK_ProdcutCatalog_Dictionary");

            entity.HasMany(d => d.Steps).WithMany(p => p.Catalogs)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductCatalogCustomField",
                    r => r.HasOne<ProductCatalogStep>().WithMany()
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductCatalogCustomField_ProductCatalogStep"),
                    l => l.HasOne<ProductCatalog>().WithMany()
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductCatalogCustomField_ProductCatalog"),
                    j =>
                    {
                        j.HasKey("CatalogId", "StepId");
                        j.ToTable("ProductCatalogCustomField");
                        j.IndexerProperty<Guid>("CatalogId").HasColumnName("CatalogID");
                        j.IndexerProperty<int>("StepId").HasColumnName("StepID");
                    });
        });

        modelBuilder.Entity<ProductCatalogColor>(entity =>
        {
            entity.HasOne(d => d.Catalog).WithMany(p => p.ProductCatalogColors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductCatalogColor_ProductCatalog");

            entity.HasOne(d => d.AttributeValue).WithMany(p => p.ProductCatalogColors).HasConstraintName("FK_ProductCatalogColor_AttributeValue");
        });

        modelBuilder.Entity<ProductCatalogDetail>(entity =>
        {
            entity.HasOne(d => d.Catalog).WithMany(p => p.ProductCatalogDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductCatalogDetail_ProdcutCatalog");

            entity.HasOne(d => d.Status).WithMany(p => p.ProductCatalogDetails).HasConstraintName("FK_ProductCatalogDetail_Status");

            entity.HasOne(d => d.Step).WithMany(p => p.ProductCatalogDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductCatalogDetail_ProductCatalogStep");
        });

        modelBuilder.Entity<ProductCatalogSize>(entity =>
        {
            entity.HasOne(d => d.Catalog).WithMany(p => p.ProductCatalogSizes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductCatalogSize_ProductCatalog");

            entity.HasOne(d => d.ProductSizeItem).WithMany(p => p.ProductCatalogSizes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductCatalogSize_ProductSizeItem");
        });

        modelBuilder.Entity<ProductCatalogStep>(entity =>
        {
            entity.Property(e => e.StepId).ValueGeneratedNever();

            entity.HasOne(d => d.Permission).WithMany(p => p.ProductCatalogSteps).HasConstraintName("FK_ProductCatalogStep_Permission");

            entity.HasMany(d => d.Departments).WithMany(p => p.Steps)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductCatalogStepDepartment",
                    r => r.HasOne<Department>().WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductCatalogStepDepartment_Department"),
                    l => l.HasOne<ProductCatalogStep>().WithMany()
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductCatalogStepDepartment_ProductCatalogStep"),
                    j =>
                    {
                        j.HasKey("StepId", "DepartmentId");
                        j.ToTable("ProductCatalogStepDepartment");
                        j.IndexerProperty<int>("StepId").HasColumnName("StepID");
                        j.IndexerProperty<Guid>("DepartmentId").HasColumnName("DepartmentID");
                    });
        });

        modelBuilder.Entity<ProductCatalogStepDepartmentView>(entity =>
        {
            entity.ToView("ProductCatalogStepDepartmentView");
        });

        modelBuilder.Entity<ProductCatalogView>(entity =>
        {
            entity.ToView("ProductCatalogView");
        });

        modelBuilder.Entity<ProductSize>(entity =>
        {
            entity.Property(e => e.SizeId).ValueGeneratedNever();

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.ProductSizes).HasConstraintName("FK_ProductSize_User");

            entity.HasOne(d => d.Department).WithMany(p => p.ProductSizes).HasConstraintName("FK_ProductSize_Department");
        });

        modelBuilder.Entity<ProductSizeItem>(entity =>
        {
            entity.HasOne(d => d.Size).WithMany(p => p.ProductSizeItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSizeItem_ProductSize");
        });

        modelBuilder.Entity<ProductionDocument>(entity =>
        {
            entity.Property(e => e.DocumentId).ValueGeneratedNever();

            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.ProductionDocumentApproveUserNavigations).HasConstraintName("FK_ProductionDocument_ApproveUser");

            entity.HasOne(d => d.Batch).WithMany(p => p.ProductionDocuments).HasConstraintName("FK_ProductionDocument_ProductionSeries");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.ProductionDocumentCreationUserNavigations).HasConstraintName("FK_ProductionDocument_CreationUser");

            entity.HasOne(d => d.FinanceApproveUserNavigation).WithMany(p => p.ProductionDocumentFinanceApproveUserNavigations).HasConstraintName("FK_ProductionDocument_FinanceApproveUser");

            entity.HasOne(d => d.Order).WithMany(p => p.ProductionDocuments).HasConstraintName("FK_ProductionDocument_ProductionOrder");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductionDocuments).HasConstraintName("FK_ProductionDocument_Product");

            entity.HasOne(d => d.ReferDocument).WithMany(p => p.InverseReferDocument).HasConstraintName("FK_ProductionDocument_ProductionDocument");

            entity.HasOne(d => d.Status).WithMany(p => p.ProductionDocuments).HasConstraintName("FK_ProductionDocument_Dictionary");

            entity.HasOne(d => d.Step).WithMany(p => p.ProductionDocuments).HasConstraintName("FK_ProductionDocument_ProductionStep");

            entity.HasOne(d => d.Stock).WithMany(p => p.ProductionDocuments).HasConstraintName("FK_ProductionDocument_Stock");

            entity.HasOne(d => d.ThirdParty).WithMany(p => p.ProductionDocuments).HasConstraintName("FK_ProductionDocument_ThirdParty");

            entity.HasOne(d => d.VoidUserNavigation).WithMany(p => p.ProductionDocumentVoidUserNavigations).HasConstraintName("FK_ProductionDocument_VoidUser");
        });

        modelBuilder.Entity<ProductionDocumentCustomField>(entity =>
        {
            entity.Property(e => e.DocumentId).ValueGeneratedNever();

            entity.HasOne(d => d.Document).WithOne(p => p.ProductionDocumentCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionDocumentCustomField_ProductionDocument");
        });

        modelBuilder.Entity<ProductionDocumentLineItem>(entity =>
        {
            entity.HasKey(e => new { e.DocumentId, e.LineItemId }).HasName("PK_ProductionDocumentLineItem_1");

            entity.HasOne(d => d.Bom).WithMany(p => p.ProductionDocumentLineItems).HasConstraintName("FK_ProductionDocumentLineItem_BillOfMaterial");

            entity.HasOne(d => d.Document).WithMany(p => p.ProductionDocumentLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionDocumentLineItem_ProductionDocument");

            entity.HasOne(d => d.Item).WithMany(p => p.ProductionDocumentLineItems).HasConstraintName("FK_ProductionDocumentLineItem_Item");
        });

        modelBuilder.Entity<ProductionDocumentLineItemRemainView>(entity =>
        {
            entity.ToView("ProductionDocumentLineItemRemainView");
        });

        modelBuilder.Entity<ProductionDocumentLineItemView>(entity =>
        {
            entity.ToView("ProductionDocumentLineItemView");
        });

        modelBuilder.Entity<ProductionDocumentView>(entity =>
        {
            entity.ToView("ProductionDocumentView");
        });

        modelBuilder.Entity<ProductionOrder>(entity =>
        {
            entity.Property(e => e.OrderId).ValueGeneratedNever();

            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.ProductionOrderApproveUserNavigations).HasConstraintName("FK_ProductionOrder_ApproveUser");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.ProductionOrderCreationUserNavigations).HasConstraintName("FK_ProductionOrder_CreationUser");

            entity.HasOne(d => d.Status).WithMany(p => p.ProductionOrders).HasConstraintName("FK_ProductionOrder_Dictionary");

            entity.HasOne(d => d.VoidUserNavigation).WithMany(p => p.ProductionOrderVoidUserNavigations).HasConstraintName("FK_ProductionOrder_VoidUser");
        });

        modelBuilder.Entity<ProductionOrderCustomField>(entity =>
        {
            entity.Property(e => e.OrderId).ValueGeneratedNever();

            entity.HasOne(d => d.Order).WithOne(p => p.ProductionOrderCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionOrderCustomField_ProductionOrder");
        });

        modelBuilder.Entity<ProductionOrderLineItem>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ProductionOrderLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionOrderLineItem_Item");

            entity.HasOne(d => d.Order).WithMany(p => p.ProductionOrderLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionOrderLineItem_ProductionOrder");

            entity.HasOne(d => d.Plan).WithMany(p => p.ProductionOrderLineItems).HasConstraintName("FK_ProductionOrderLineItem_ProductionPlan");

            entity.HasOne(d => d.Supplier).WithMany(p => p.ProductionOrderLineItems).HasConstraintName("FK_ProductionOrderLineItem_Supplier");
        });

        modelBuilder.Entity<ProductionOrderLineItemView>(entity =>
        {
            entity.ToView("ProductionOrderLineItemView");
        });

        modelBuilder.Entity<ProductionPlan>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.ProductionPlanApproveUserNavigations).HasConstraintName("FK_ProductionPlan_ApproveUser");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.ProductionPlanCreationUserNavigations).HasConstraintName("FK_ProductionPlan_CreationUser");

            entity.HasOne(d => d.Season).WithMany(p => p.ProductionPlanSeasons).HasConstraintName("FK_ProductionPlan_Season");

            entity.HasOne(d => d.Status).WithMany(p => p.ProductionPlanStatuses).HasConstraintName("FK_ProductionPlan_Dictionary");

            entity.HasOne(d => d.VoidUserNavigation).WithMany(p => p.ProductionPlanVoidUserNavigations).HasConstraintName("FK_ProductionPlan_VoidUser");
        });

        modelBuilder.Entity<ProductionPlanCustomField>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ProductionPlanCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionPlanCustomField_ProductionPlan");
        });

        modelBuilder.Entity<ProductionPlanDepartment>(entity =>
        {
            entity.HasOne(d => d.Department).WithMany(p => p.ProductionPlanDepartments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionPlanDepartment_Department");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.ProductionPlanDepartments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionPlanDepartment_ProductionPlan");
        });

        modelBuilder.Entity<ProductionPlanDepartmentView>(entity =>
        {
            entity.ToView("ProductionPlanDepartmentView");
        });

        modelBuilder.Entity<ProductionSeries>(entity =>
        {
            entity.Property(e => e.BatchId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProductionStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProductionFlow");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ApprovePermission).WithMany(p => p.ProductionStepApprovePermissions).HasConstraintName("FK_ProductionStep_ApprovePermission");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_ProductionFlow_ProductionFlow");

            entity.HasOne(d => d.Permission).WithMany(p => p.ProductionStepPermissions).HasConstraintName("FK_ProductionStep_Permission");

            entity.HasOne(d => d.Stock).WithMany(p => p.ProductionSteps).HasConstraintName("FK_ProductionFlow_Stock");

            entity.HasOne(d => d.VoidPermission).WithMany(p => p.ProductionStepVoidPermissions).HasConstraintName("FK_ProductionStep_VoidPermission");
        });

        modelBuilder.Entity<ProductionStepView>(entity =>
        {
            entity.ToView("ProductionStepView");
        });

        modelBuilder.Entity<QualityControlResult>(entity =>
        {
            entity.HasOne(d => d.QualityControlTaskItem).WithMany(p => p.QualityControlResults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityControlResult_QualityControlTaskItem");

            entity.HasOne(d => d.ProductionDocumentLineItem).WithMany(p => p.QualityControlResults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityControlResult_ProductionDocumentLineItem");
        });

        modelBuilder.Entity<QualityControlSize>(entity =>
        {
            entity.HasOne(d => d.ProductionDocumentLineItem).WithMany(p => p.QualityControlSizes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityControlSize_ProductionDocumentLineItem");

            entity.HasOne(d => d.ProductSizeItem).WithMany(p => p.QualityControlSizes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityControlSize_ProductSizeItem");
        });

        modelBuilder.Entity<QualityControlTask>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.QualityControlTasks).HasConstraintName("FK_QualityControlTask_User");

            entity.HasMany(d => d.Departments).WithMany(p => p.Ids)
                .UsingEntity<Dictionary<string, object>>(
                    "QualityControlTaskDepartment",
                    r => r.HasOne<Department>().WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_QualityControlTaskDepartment_Department"),
                    l => l.HasOne<QualityControlTask>().WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_QualityControlTaskDepartment_QualityControlTask"),
                    j =>
                    {
                        j.HasKey("Id", "DepartmentId");
                        j.ToTable("QualityControlTaskDepartment");
                        j.IndexerProperty<Guid>("Id").HasColumnName("ID");
                        j.IndexerProperty<Guid>("DepartmentId").HasColumnName("DepartmentID");
                    });
        });

        modelBuilder.Entity<QualityControlTaskDepartmentView>(entity =>
        {
            entity.ToView("QualityControlTaskDepartmentView");
        });

        modelBuilder.Entity<QualityControlTaskItem>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.QualityControlTaskItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityControlTaskItem_QualityControlTask");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Question_1");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Category).WithMany(p => p.Questions).HasConstraintName("FK_Question_QuestionCategory");

            entity.HasMany(d => d.Stores).WithMany(p => p.Questions)
                .UsingEntity<Dictionary<string, object>>(
                    "QuestionClient",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_QuestionClient_Store"),
                    l => l.HasOne<Question>().WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_QuestionClient_Question"),
                    j =>
                    {
                        j.HasKey("QuestionId", "StoreId");
                        j.ToTable("QuestionClient");
                        j.IndexerProperty<Guid>("QuestionId").HasColumnName("QuestionID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });
        });

        modelBuilder.Entity<QuestionCategory>(entity =>
        {
            entity.Property(e => e.CategoryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<QuestionClientView>(entity =>
        {
            entity.ToView("QuestionClientView");
        });

        modelBuilder.Entity<QuestionView>(entity =>
        {
            entity.ToView("QuestionView");
        });

        modelBuilder.Entity<Reason>(entity =>
        {
            entity.Property(e => e.ReasonId).ValueGeneratedNever();

            entity.HasOne(d => d.Type).WithMany(p => p.Reasons).HasConstraintName("FK_Reason_Dictionary");
        });

        modelBuilder.Entity<ReasonView>(entity =>
        {
            entity.ToView("ReasonView");
        });

        modelBuilder.Entity<RecentItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RecentItems");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Type).WithMany(p => p.RecentItems).HasConstraintName("FK_RecentItem_Type");

            entity.HasOne(d => d.User).WithMany(p => p.RecentItems).HasConstraintName("FK_RecentItem_User");
        });

        modelBuilder.Entity<RecentItemView>(entity =>
        {
            entity.ToView("RecentItemView");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.Property(e => e.ReportId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReportField>(entity =>
        {
            entity.HasOne(d => d.Report).WithMany(p => p.ReportFields)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportField_Report");
        });

        modelBuilder.Entity<ReportFilter>(entity =>
        {
            entity.HasOne(d => d.Report).WithMany(p => p.ReportFilters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportFilter_Report");
        });

        modelBuilder.Entity<Repository>(entity =>
        {
            entity.Property(e => e.RepositoryId).ValueGeneratedNever();

            entity.HasOne(d => d.DetailAccount).WithMany(p => p.Repositories).HasConstraintName("FK_Repository_DetailAccount");

            entity.HasOne(d => d.Status).WithMany(p => p.RepositoryStatuses).HasConstraintName("FK_Repository_Status");

            entity.HasOne(d => d.Type).WithMany(p => p.RepositoryTypes).HasConstraintName("FK_Repository_Type");
        });

        modelBuilder.Entity<RepositoryView>(entity =>
        {
            entity.ToView("RepositoryView");
        });

        modelBuilder.Entity<ReturnInvoiceLineItemView>(entity =>
        {
            entity.ToView("ReturnInvoiceLineItemView");
        });

        modelBuilder.Entity<SafeStoreTurnOverView>(entity =>
        {
            entity.ToView("SafeStoreTurnOverView");
        });

        modelBuilder.Entity<SaleInvoice>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.BookerWorkstationId, e.InvoiceId }).HasName("PK_SaleInvoice_1");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.SaleInvoiceCreationUserNavigations).HasConstraintName("FK_SaleInvoice_User");

            entity.HasOne(d => d.Customer).WithMany(p => p.SaleInvoices).HasConstraintName("FK_SaleInvoice_Customer");

            entity.HasOne(d => d.InvoiceType).WithMany(p => p.SaleInvoices).HasConstraintName("FK_SaleInvoice_Dictionary");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.SaleInvoiceModifyUserNavigations).HasConstraintName("FK_SaleInvoice_ModifyUser");

            entity.HasOne(d => d.Stock).WithMany(p => p.SaleInvoices).HasConstraintName("FK_SaleInvoice_Stock");

            entity.HasOne(d => d.Workstation).WithMany(p => p.SaleInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoice_Workstation");
        });

        modelBuilder.Entity<SaleInvoiceCustomDiscount>(entity =>
        {
            entity.HasOne(d => d.SaleInvoice).WithOne(p => p.SaleInvoiceCustomDiscount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceCustomDiscount_SaleInvoice");
        });

        modelBuilder.Entity<SaleInvoiceCustomField>(entity =>
        {
            entity.HasOne(d => d.SaleInvoice).WithOne(p => p.SaleInvoiceCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceCustomField_SaleInvoice");
        });

        modelBuilder.Entity<SaleInvoiceInfo>(entity =>
        {
            entity.HasOne(d => d.Reason).WithMany(p => p.SaleInvoiceInfos).HasConstraintName("FK_SaleInvoiceInfo_Reason");

            entity.HasOne(d => d.Table).WithMany(p => p.SaleInvoiceInfos).HasConstraintName("FK_SaleInvoiceInfo_Table");

            entity.HasOne(d => d.SaleInvoice).WithOne(p => p.SaleInvoiceInfo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceInfo_SaleInvoice");
        });

        modelBuilder.Entity<SaleInvoiceLineItem>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.BookerWorkstationId, e.InvoiceId, e.LineItemId }).HasName("PK_SaleInvoiceLineItem_1");

            entity.HasOne(d => d.Item).WithMany(p => p.SaleInvoiceLineItems).HasConstraintName("FK_SaleInvoiceLineItem_Item");

            entity.HasOne(d => d.Reason).WithMany(p => p.SaleInvoiceLineItems).HasConstraintName("FK_SaleInvoiceLineItem_Reason");

            entity.HasOne(d => d.Status).WithMany(p => p.SaleInvoiceLineItemStatuses).HasConstraintName("FK_SaleInvoiceLineItem_Status");

            entity.HasOne(d => d.Type).WithMany(p => p.SaleInvoiceLineItemTypes).HasConstraintName("FK_SaleInvoiceLineItem_Dictionary");

            entity.HasOne(d => d.SaleInvoice).WithMany(p => p.SaleInvoiceLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLineItem_SaleInvoice");
        });

        modelBuilder.Entity<SaleInvoiceLineItemContract>(entity =>
        {
            entity.HasOne(d => d.Contract).WithMany(p => p.SaleInvoiceLineItemContracts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLineItemContract_SupplierContract");

            entity.HasOne(d => d.SaleInvoiceLineItem).WithMany(p => p.SaleInvoiceLineItemContracts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLineItemContract_SaleInvoiceLineItem");
        });

        modelBuilder.Entity<SaleInvoiceLineItemCustomField>(entity =>
        {
            entity.HasOne(d => d.SaleInvoiceLineItem).WithOne(p => p.SaleInvoiceLineItemCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLineItemCustomField_SaleInvoiceLineItem");
        });

        modelBuilder.Entity<SaleInvoiceLineItemDetail>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.SaleInvoiceLineItemDetailItems).HasConstraintName("FK_SaleInvoiceLineItemDetail_Item");

            entity.HasOne(d => d.ParentItem).WithMany(p => p.SaleInvoiceLineItemDetailParentItems).HasConstraintName("FK_SaleInvoiceLineItemDetail_ParentItem");

            entity.HasOne(d => d.SaleInvoiceLineItem).WithMany(p => p.SaleInvoiceLineItemDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLineItemDetail_SaleInvoiceLineItem");
        });

        modelBuilder.Entity<SaleInvoiceLineItemPartialPayment>(entity =>
        {
            entity.HasOne(d => d.SaleInvoiceLineItem).WithOne(p => p.SaleInvoiceLineItemPartialPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLineItemPartialPayment_SaleInvoiceLineItem");
        });

        modelBuilder.Entity<SaleInvoiceLineItemReference>(entity =>
        {
            entity.HasOne(d => d.SaleInvoiceLineItem).WithOne(p => p.SaleInvoiceLineItemReference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLineItemReference_SaleInvoiceLineItem");
        });

        modelBuilder.Entity<SaleInvoiceLineItemSalePerson>(entity =>
        {
            entity.HasOne(d => d.SalePerson).WithMany(p => p.SaleInvoiceLineItemSalePeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLineItemSalePerson_Employee");

            entity.HasOne(d => d.SaleInvoiceLineItem).WithMany(p => p.SaleInvoiceLineItemSalePeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLineItemSalePerson_SaleInvoiceLineItem");
        });

        modelBuilder.Entity<SaleInvoiceLineItemTracking>(entity =>
        {
            entity.HasOne(d => d.Stock).WithMany(p => p.SaleInvoiceLineItemTrackings).HasConstraintName("FK_SaleInvoiceLineItemTracking_Stock");

            entity.HasOne(d => d.SaleInvoiceLineItem).WithOne(p => p.SaleInvoiceLineItemTracking)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLineItemTracking_SaleInvoiceLineItem");
        });

        modelBuilder.Entity<SaleInvoiceLineItemView>(entity =>
        {
            entity.ToView("SaleInvoiceLineItemView");
        });

        modelBuilder.Entity<SaleInvoiceLoyality>(entity =>
        {
            entity.HasOne(d => d.SaleInvoice).WithOne(p => p.SaleInvoiceLoyality)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceLoyality_SaleInvoice");
        });

        modelBuilder.Entity<SaleInvoicePartialPayment>(entity =>
        {
            entity.HasOne(d => d.PaymentType).WithMany(p => p.SaleInvoicePartialPaymentPaymentTypes).HasConstraintName("FK_SaleInvoicePartialPayment_Dictionary");

            entity.HasOne(d => d.Status).WithMany(p => p.SaleInvoicePartialPaymentStatuses).HasConstraintName("FK_SaleInvoicePartialPayment_Status");

            entity.HasOne(d => d.SaleInvoice).WithMany(p => p.SaleInvoicePartialPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoicePartialPayment_SaleInvoice");

            entity.HasMany(d => d.TreasuryDocuments).WithMany(p => p.SaleInvoicePartialPayments)
                .UsingEntity<Dictionary<string, object>>(
                    "SaleInvoicePartialPaymentReference",
                    r => r.HasOne<TreasuryDocument>().WithMany()
                        .HasForeignKey("TreasuryBookerStoreId", "TreasuryBookerWorkstationId", "TreasuryDocumentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SaleInvoicePartialPaymentReference_TreasuryDocument"),
                    l => l.HasOne<SaleInvoicePartialPayment>().WithMany()
                        .HasForeignKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "PaymentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SaleInvoicePartialPaymentReference_SaleInvoicePartialPayment"),
                    j =>
                    {
                        j.HasKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "PaymentId", "TreasuryBookerStoreId", "TreasuryBookerWorkstationId", "TreasuryDocumentId");
                        j.ToTable("SaleInvoicePartialPaymentReference");
                        j.IndexerProperty<int>("BookerStoreId").HasColumnName("BookerStoreID");
                        j.IndexerProperty<int>("BookerWorkstationId").HasColumnName("BookerWorkstationID");
                        j.IndexerProperty<Guid>("InvoiceId").HasColumnName("InvoiceID");
                        j.IndexerProperty<int>("PaymentId").HasColumnName("PaymentID");
                        j.IndexerProperty<int>("TreasuryBookerStoreId").HasColumnName("TreasuryBookerStoreID");
                        j.IndexerProperty<int>("TreasuryBookerWorkstationId").HasColumnName("TreasuryBookerWorkstationID");
                        j.IndexerProperty<Guid>("TreasuryDocumentId").HasColumnName("TreasuryDocumentID");
                    });
        });

        modelBuilder.Entity<SaleInvoicePartialPaymentView>(entity =>
        {
            entity.ToView("SaleInvoicePartialPaymentView");
        });

        modelBuilder.Entity<SaleInvoiceService>(entity =>
        {
            entity.HasOne(d => d.Operator).WithMany(p => p.SaleInvoiceServices).HasConstraintName("FK_SaleInvoiceService_Employee");

            entity.HasOne(d => d.Service).WithMany(p => p.SaleInvoiceServices).HasConstraintName("FK_SaleInvoiceService_ServiceItem");

            entity.HasOne(d => d.SaleInvoice).WithMany(p => p.SaleInvoiceServices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceService_SaleInvoice");
        });

        modelBuilder.Entity<SaleInvoiceTaxReference>(entity =>
        {
            entity.HasOne(d => d.SaleInvoice).WithMany(p => p.SaleInvoiceTaxReferences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceTaxReference_SaleInvoice");
        });

        modelBuilder.Entity<SaleInvoiceTender>(entity =>
        {
            entity.HasOne(d => d.Tender).WithMany(p => p.SaleInvoiceTenders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceTender_Tender");

            entity.HasOne(d => d.SaleInvoice).WithMany(p => p.SaleInvoiceTenders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceTender_SaleInvoice");
        });

        modelBuilder.Entity<SaleInvoiceTenderCheque>(entity =>
        {
            entity.HasOne(d => d.SaleInvoiceTender).WithOne(p => p.SaleInvoiceTenderCheque)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceTenderCheque_SaleInvoiceTender");
        });

        modelBuilder.Entity<SaleInvoiceTenderCredit>(entity =>
        {
            entity.HasOne(d => d.SaleInvoiceTender).WithOne(p => p.SaleInvoiceTenderCredit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceTenderCredit_SaleInvoiceTender");
        });

        modelBuilder.Entity<SaleInvoiceTenderGift>(entity =>
        {
            entity.HasOne(d => d.SaleInvoiceTender).WithOne(p => p.SaleInvoiceTenderGift)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceTenderGift_SaleInvoiceTender");
        });

        modelBuilder.Entity<SaleInvoiceTenderPo>(entity =>
        {
            entity.HasOne(d => d.SaleInvoiceTender).WithOne(p => p.SaleInvoiceTenderPo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleInvoiceTenderPOS_SaleInvoiceTender");
        });

        modelBuilder.Entity<SaleInvoiceTenderView>(entity =>
        {
            entity.ToView("SaleInvoiceTenderView");
        });

        modelBuilder.Entity<SaleInvoiceView>(entity =>
        {
            entity.ToView("SaleInvoiceView");
        });

        modelBuilder.Entity<SaleItemDelivery>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.BookerWorkstationId, e.InvoiceId, e.DeliveryId }).HasName("PK_SaleItemDelivery_1");

            entity.HasOne(d => d.DeliveryPerson).WithMany(p => p.SaleItemDeliveryDeliveryPeople).HasConstraintName("FK_SaleItemDelivery_DeliveryEmployee");

            entity.HasOne(d => d.InstallPerson).WithMany(p => p.SaleItemDeliveryInstallPeople).HasConstraintName("FK_SaleItemDelivery_InstallEmployee");

            entity.HasOne(d => d.Status).WithMany(p => p.SaleItemDeliveries).HasConstraintName("FK_SaleItemDelivery_Dictionary");

            entity.HasOne(d => d.SaleInvoice).WithMany(p => p.SaleItemDeliveries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleItemDelivery_SaleInvoice");
        });

        modelBuilder.Entity<SaleItemDeliveryView>(entity =>
        {
            entity.ToView("SaleItemDeliveryView");
        });

        modelBuilder.Entity<SalePrice>(entity =>
        {
            entity.HasKey(e => e.PriceId).HasName("PK_SalePrice_1");

            entity.Property(e => e.PriceId).ValueGeneratedNever();

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.SalePriceCreationUserNavigations).HasConstraintName("FK_SalePrice_CreationUser");

            entity.HasOne(d => d.Currency).WithMany(p => p.SalePrices).HasConstraintName("FK_SalePrice_Currency");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.SalePriceModifyUserNavigations).HasConstraintName("FK_SalePrice_User");

            entity.HasOne(d => d.PriceType).WithMany(p => p.SalePricePriceTypes).HasConstraintName("FK_SalePrice_Dictionary");

            entity.HasOne(d => d.Status).WithMany(p => p.SalePriceStatuses).HasConstraintName("FK_SalePrice_Dictionary1");

            entity.HasMany(d => d.CustomerGroups).WithMany(p => p.Prices)
                .UsingEntity<Dictionary<string, object>>(
                    "SalePriceCustomerGroupAssignment",
                    r => r.HasOne<CustomerGroup>().WithMany()
                        .HasForeignKey("CustomerGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SalePriceCustomerGroupAssignment_CustomerGroup"),
                    l => l.HasOne<SalePrice>().WithMany()
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SalePriceCustomerGroupAssignment_SalePrice"),
                    j =>
                    {
                        j.HasKey("PriceId", "CustomerGroupId").HasName("PK_SalePriceCustomerGroupAssignment_1");
                        j.ToTable("SalePriceCustomerGroupAssignment");
                        j.IndexerProperty<Guid>("PriceId").HasColumnName("PriceID");
                        j.IndexerProperty<Guid>("CustomerGroupId").HasColumnName("CustomerGroupID");
                    });

            entity.HasMany(d => d.Groups).WithMany(p => p.Prices)
                .UsingEntity<Dictionary<string, object>>(
                    "SalePriceStoreGroupAssignment",
                    r => r.HasOne<StoreGroup>().WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SalePriceStoreGroupAssignment_StoreGroup"),
                    l => l.HasOne<SalePrice>().WithMany()
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SalePriceStoreGroupAssignment_Price"),
                    j =>
                    {
                        j.HasKey("PriceId", "GroupId");
                        j.ToTable("SalePriceStoreGroupAssignment");
                        j.IndexerProperty<Guid>("PriceId").HasColumnName("PriceID");
                        j.IndexerProperty<Guid>("GroupId").HasColumnName("GroupID");
                    });

            entity.HasMany(d => d.Stores).WithMany(p => p.Prices)
                .UsingEntity<Dictionary<string, object>>(
                    "SalePriceStoreAssignment",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SalePriceStoreAssignment_Store"),
                    l => l.HasOne<SalePrice>().WithMany()
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SalePriceStoreAssignment_SalePrice"),
                    j =>
                    {
                        j.HasKey("PriceId", "StoreId").HasName("PK_SalePriceStoreAssignment_1");
                        j.ToTable("SalePriceStoreAssignment");
                        j.IndexerProperty<Guid>("PriceId").HasColumnName("PriceID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });
        });

        modelBuilder.Entity<SalePriceActiveTime>(entity =>
        {
            entity.HasOne(d => d.Price).WithMany(p => p.SalePriceActiveTimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalePriceActiveTime_SalePrice");
        });

        modelBuilder.Entity<SalePriceConditional>(entity =>
        {
            entity.HasOne(d => d.Price).WithMany(p => p.SalePriceConditionals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalePriceConditional_SalePrice");
        });

        modelBuilder.Entity<SalePriceCustomerGroupAssignmentView>(entity =>
        {
            entity.ToView("SalePriceCustomerGroupAssignmentView");
        });

        modelBuilder.Entity<SalePriceLineItem>(entity =>
        {
            entity.HasKey(e => new { e.PriceId, e.LineItemId }).HasName("PK_SalePriceLineItem_1");

            entity.HasOne(d => d.ChangeType).WithMany(p => p.SalePriceLineItems).HasConstraintName("FK_SalePriceLineItem_Dictionary");

            entity.HasOne(d => d.Item).WithMany(p => p.SalePriceLineItems).HasConstraintName("FK_SalePriceLineItem_Item");

            entity.HasOne(d => d.Price).WithMany(p => p.SalePriceLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalePriceLineItem_SalePrice");
        });

        modelBuilder.Entity<SalePriceLineItemView>(entity =>
        {
            entity.ToView("SalePriceLineItemView");
        });

        modelBuilder.Entity<SalePriceStoreAssignmentView>(entity =>
        {
            entity.ToView("SalePriceStoreAssignmentView");
        });

        modelBuilder.Entity<SalePriceStoreGroupAssignmentView>(entity =>
        {
            entity.ToView("SalePriceStoreGroupAssignmentView");
        });

        modelBuilder.Entity<SalePriceView>(entity =>
        {
            entity.ToView("SalePriceView");
        });

        modelBuilder.Entity<SaleQoutaCustomerGroupAssignmentView>(entity =>
        {
            entity.ToView("SaleQoutaCustomerGroupAssignmentView");
        });

        modelBuilder.Entity<SaleQoutaDepartmentAssignment>(entity =>
        {
            entity.HasOne(d => d.Department).WithMany(p => p.SaleQoutaDepartmentAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleQoutaDepartmentAssignment_Department");

            entity.HasOne(d => d.Qouta).WithMany(p => p.SaleQoutaDepartmentAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleQoutaDepartmentAssignment_SaleQouta");
        });

        modelBuilder.Entity<SaleQoutaDepartmentAssignmentView>(entity =>
        {
            entity.ToView("SaleQoutaDepartmentAssignmentView");
        });

        modelBuilder.Entity<SaleQoutaItemAssignment>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.SaleQoutaItemAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleQoutaItemAssignment_Item");

            entity.HasOne(d => d.Qouta).WithMany(p => p.SaleQoutaItemAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleQoutaItemAssignment_SaleQouta");
        });

        modelBuilder.Entity<SaleQoutaItemAssignmentView>(entity =>
        {
            entity.ToView("SaleQoutaItemAssignmentView");
        });

        modelBuilder.Entity<SaleQoutaStoreAssignmentView>(entity =>
        {
            entity.ToView("SaleQoutaStoreAssignmentView");
        });

        modelBuilder.Entity<SaleQoutum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.SaleQoutumApproveUserNavigations).HasConstraintName("FK_SaleQouta_ApproveUser");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.SaleQoutumCreationUserNavigations).HasConstraintName("FK_SaleQouta_CreationUser");

            entity.HasOne(d => d.QoutaType).WithMany(p => p.SaleQoutumQoutaTypes).HasConstraintName("FK_SaleQouta_Type");

            entity.HasOne(d => d.Status).WithMany(p => p.SaleQoutumStatuses).HasConstraintName("FK_SaleQouta_Status");

            entity.HasOne(d => d.VoidUserNavigation).WithMany(p => p.SaleQoutumVoidUserNavigations).HasConstraintName("FK_SaleQouta_VoidUser");

            entity.HasMany(d => d.CustomerGroups).WithMany(p => p.Qouats)
                .UsingEntity<Dictionary<string, object>>(
                    "SaleQoutaCustomerGroupAssignment",
                    r => r.HasOne<CustomerGroup>().WithMany()
                        .HasForeignKey("CustomerGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SaleQoutaCustomerGroupAssignment_CustomerGroup"),
                    l => l.HasOne<SaleQoutum>().WithMany()
                        .HasForeignKey("QouatId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SaleQoutaCustomerGroupAssignment_SaleQouta"),
                    j =>
                    {
                        j.HasKey("QouatId", "CustomerGroupId");
                        j.ToTable("SaleQoutaCustomerGroupAssignment");
                        j.IndexerProperty<Guid>("QouatId").HasColumnName("QouatID");
                        j.IndexerProperty<Guid>("CustomerGroupId").HasColumnName("CustomerGroupID");
                    });

            entity.HasMany(d => d.Stores).WithMany(p => p.Qouats)
                .UsingEntity<Dictionary<string, object>>(
                    "SaleQoutaStoreAssignment",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SaleQoutaStoreAssignment_Store"),
                    l => l.HasOne<SaleQoutum>().WithMany()
                        .HasForeignKey("QouatId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SaleQoutaStoreAssignment_SaleQouta"),
                    j =>
                    {
                        j.HasKey("QouatId", "StoreId");
                        j.ToTable("SaleQoutaStoreAssignment");
                        j.IndexerProperty<Guid>("QouatId").HasColumnName("QouatID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });
        });

        modelBuilder.Entity<ServiceItem>(entity =>
        {
            entity.Property(e => e.ServiceId).ValueGeneratedNever();

            entity.HasOne(d => d.Department).WithMany(p => p.ServiceItems).HasConstraintName("FK_ServiceItem_Department");
        });

        modelBuilder.Entity<ServiceItemView>(entity =>
        {
            entity.ToView("ServiceItemView");
        });

        modelBuilder.Entity<ShelfPrice>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.ShelfPrices).HasConstraintName("FK_ShelfPrice_User");
        });

        modelBuilder.Entity<ShelfPriceItem>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.ShelfPriceItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShelfPriceItem_ShelfPrice");

            entity.HasOne(d => d.Item).WithMany(p => p.ShelfPriceItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShelfPriceItem_Item");
        });

        modelBuilder.Entity<ShelfPricePrint>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ShelfPricePrints)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShelfPricePrint_Item");

            entity.HasOne(d => d.LastUserNavigation).WithMany(p => p.ShelfPricePrints).HasConstraintName("FK_ShelfPricePrint_User");

            entity.HasOne(d => d.Store).WithMany(p => p.ShelfPricePrints)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShelfPricePrint_Store");
        });

        modelBuilder.Entity<ShelfPricePrintHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithMany(p => p.ShelfPricePrintHistories).HasConstraintName("FK_ShelfPricePrintHistory_Item");

            entity.HasOne(d => d.Store).WithMany(p => p.ShelfPricePrintHistories).HasConstraintName("FK_ShelfPricePrintHistory_Store");

            entity.HasOne(d => d.User).WithMany(p => p.ShelfPricePrintHistories).HasConstraintName("FK_ShelfPricePrintHistory_User");
        });

        modelBuilder.Entity<SmsHistory>(entity =>
        {
            entity.Property(e => e.SendTime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.Property(e => e.StockId).ValueGeneratedNever();

            entity.HasOne(d => d.OwnerGroup).WithMany(p => p.Stocks).HasConstraintName("FK_Stock_UserGroup");

            entity.HasOne(d => d.Store).WithMany(p => p.Stocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stock_Store");
        });

        modelBuilder.Entity<StockDocument>(entity =>
        {
            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.StockDocumentApproveUserNavigations).HasConstraintName("FK_StockDocument_ApproveUser");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.StockDocumentCreationUserNavigations).HasConstraintName("FK_StockDocument_CreationUser");

            entity.HasOne(d => d.Currency).WithMany(p => p.StockDocuments).HasConstraintName("FK_StockDocument_Currency");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.StockDocumentDocumentTypes).HasConstraintName("FK_StockDocument_Dictionary");

            entity.HasOne(d => d.FinanceApproveUserNavigation).WithMany(p => p.StockDocumentFinanceApproveUserNavigations).HasConstraintName("FK_StockDocument_User");

            entity.HasOne(d => d.SourceStock).WithMany(p => p.StockDocumentSourceStocks).HasConstraintName("FK_StockDocument_SourceStock");

            entity.HasOne(d => d.Status).WithMany(p => p.StockDocumentStatuses).HasConstraintName("FK_StockDocument_Dictionary1");

            entity.HasOne(d => d.Supplier).WithMany(p => p.StockDocuments).HasConstraintName("FK_StockDocument_Supplier");

            entity.HasOne(d => d.TargetStock).WithMany(p => p.StockDocumentTargetStocks).HasConstraintName("FK_StockDocument_TargetStock");

            entity.HasOne(d => d.Visitor).WithMany(p => p.StockDocuments).HasConstraintName("FK_StockDocument_Visitor");

            entity.HasOne(d => d.VoidUserNavigation).WithMany(p => p.StockDocumentVoidUserNavigations).HasConstraintName("FK_StockDocument_VoidUser");

            entity.HasOne(d => d.Workstation).WithMany(p => p.StockDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocument_Workstation");
        });

        modelBuilder.Entity<StockDocumentAttachment>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.BookerWorkstationId, e.DocumentId, e.LineItemId }).HasName("PK_StockDoumentAttachment");

            entity.HasOne(d => d.StockDocument).WithMany(p => p.StockDocumentAttachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDoumentAttachment_StockDocument");
        });

        modelBuilder.Entity<StockDocumentCostModifier>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.BookerWorkstationId, e.DocumentId, e.LineItemId }).HasName("PK_StockDocumentCostModifier_1");

            entity.HasOne(d => d.ChangeAmountType).WithMany(p => p.StockDocumentCostModifiers).HasConstraintName("FK_StockDocumentCostModifier_Dictionary");

            entity.HasOne(d => d.Reason).WithMany(p => p.StockDocumentCostModifiers).HasConstraintName("FK_StockDocumentCostModifier_Reason");

            entity.HasOne(d => d.StockDocument).WithMany(p => p.StockDocumentCostModifiers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentCostModifier_StockDocument");
        });

        modelBuilder.Entity<StockDocumentCostModifierReference>(entity =>
        {
            entity.HasOne(d => d.StockDocument).WithMany(p => p.StockDocumentCostModifierReferences).HasConstraintName("FK_StockDocumentCostModifierReference_StockDocument");

            entity.HasOne(d => d.StockDocumentCostModifier).WithOne(p => p.StockDocumentCostModifierReference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentCostModifierReference_StockDocumentCostModifier");
        });

        modelBuilder.Entity<StockDocumentCostModifierView>(entity =>
        {
            entity.ToView("StockDocumentCostModifierView");
        });

        modelBuilder.Entity<StockDocumentCustomField>(entity =>
        {
            entity.HasOne(d => d.StockDocument).WithOne(p => p.StockDocumentCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentCustomField_StockDocument");
        });

        modelBuilder.Entity<StockDocumentLineItem>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.BookerWorkstationId, e.DocumentId, e.LineItemId }).HasName("PK_StockDocumentLineItem_1");

            entity.HasOne(d => d.Item).WithMany(p => p.StockDocumentLineItems).HasConstraintName("FK_StockDocumentLineItem_Item");

            entity.HasOne(d => d.StockDocument).WithMany(p => p.StockDocumentLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentLineItem_StockDocument");
        });

        modelBuilder.Entity<StockDocumentLineItemAttribute>(entity =>
        {
            entity.HasOne(d => d.AttributeValue).WithMany(p => p.StockDocumentLineItemAttributes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentLineItemAttribute_Attribute");
        });

        modelBuilder.Entity<StockDocumentLineItemAttributeView>(entity =>
        {
            entity.ToView("StockDocumentLineItemAttributeView");
        });

        modelBuilder.Entity<StockDocumentLineItemContract>(entity =>
        {
            entity.HasOne(d => d.StockDocumentLineItem).WithOne(p => p.StockDocumentLineItemContract)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentLineItemContract_StockDocumentLineItem");
        });

        modelBuilder.Entity<StockDocumentLineItemCustomDiscount>(entity =>
        {
            entity.HasOne(d => d.StockDocumentLineItem).WithOne(p => p.StockDocumentLineItemCustomDiscount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentLineItemCustomDiscount_StockDocumentLineItem");
        });

        modelBuilder.Entity<StockDocumentLineItemCustomField>(entity =>
        {
            entity.HasOne(d => d.StockDocumentLineItem).WithOne(p => p.StockDocumentLineItemCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentLineItemCustomField_StockDocumentLineItem");
        });

        modelBuilder.Entity<StockDocumentLineItemExpiration>(entity =>
        {
            entity.HasOne(d => d.StockDocumentLineItem).WithOne(p => p.StockDocumentLineItemExpiration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentLineItemExpiration_StockDocumentLineItem");
        });

        modelBuilder.Entity<StockDocumentLineItemMonth>(entity =>
        {
            entity.HasOne(d => d.Month).WithMany(p => p.StockDocumentLineItemMonths)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentLineItemMonth_Dictionary");
        });

        modelBuilder.Entity<StockDocumentLineItemMonthView>(entity =>
        {
            entity.ToView("StockDocumentLineItemMonthView");
        });

        modelBuilder.Entity<StockDocumentLineItemReference>(entity =>
        {
            entity.HasOne(d => d.StockDocumentLineItem).WithOne(p => p.StockDocumentLineItemReference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentLineItemReference_StockDocumentLineItem");
        });

        modelBuilder.Entity<StockDocumentLineItemSerial>(entity =>
        {
            entity.HasOne(d => d.StockDocumentLineItem).WithMany(p => p.StockDocumentLineItemSerials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentLineItemSerial_StockDocumentLineItem");
        });

        modelBuilder.Entity<StockDocumentLineItemTracking>(entity =>
        {
            entity.HasOne(d => d.StockDocumentLineItem).WithOne(p => p.StockDocumentLineItemTracking)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentLineItemTracking_StockDocumentLineItem");
        });

        modelBuilder.Entity<StockDocumentLineItemView>(entity =>
        {
            entity.ToView("StockDocumentLineItemView");
        });

        modelBuilder.Entity<StockDocumentOrderReference>(entity =>
        {
            entity.HasOne(d => d.StockDocumentLineItem).WithOne(p => p.StockDocumentOrderReference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentOrderReference_StockDocumentLineItem");

            entity.HasOne(d => d.OrderDocumentLineItem).WithMany(p => p.StockDocumentOrderReferences).HasConstraintName("FK_StockDocumentOrderReference_OrderDocumentLineItem");
        });

        modelBuilder.Entity<StockDocumentPayment>(entity =>
        {
            entity.HasOne(d => d.Tender).WithMany(p => p.StockDocumentPayments).HasConstraintName("FK_StockDocumentPayment_Tender");

            entity.HasOne(d => d.StockDocument).WithMany(p => p.StockDocumentPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentPayment_StockDocument");
        });

        modelBuilder.Entity<StockDocumentReference>(entity =>
        {
            entity.HasOne(d => d.StockDocument).WithOne(p => p.StockDocumentReference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDocumentReference_StockDocument");
        });

        modelBuilder.Entity<StockDocumentView>(entity =>
        {
            entity.ToView("StockDocumentView");
        });

        modelBuilder.Entity<StockSection>(entity =>
        {
            entity.Property(e => e.SectionId).ValueGeneratedNever();

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_StockSection_StockSection");

            entity.HasOne(d => d.Stock).WithMany(p => p.StockSections).HasConstraintName("FK_StockSection_Stock");
        });

        modelBuilder.Entity<StockView>(entity =>
        {
            entity.ToView("StockView");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.Property(e => e.StoreId).ValueGeneratedNever();

            entity.HasOne(d => d.DetailedAccount).WithMany(p => p.Stores).HasConstraintName("FK_Store_DetailAccount");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_Store_Parent");

            entity.HasOne(d => d.Party).WithMany(p => p.Stores).HasConstraintName("FK_Store_Party");

            entity.HasOne(d => d.Status).WithMany(p => p.Stores).HasConstraintName("FK_Store_Dictionary");
        });

        modelBuilder.Entity<StoreConfiguration>(entity =>
        {
            entity.HasOne(d => d.Store).WithMany(p => p.StoreConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreConfiguration_Store");
        });

        modelBuilder.Entity<StoreContract>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.StoreContractApproveUserNavigations).HasConstraintName("FK_Table_1_ApproveUser");

            entity.HasOne(d => d.ContractType).WithMany(p => p.StoreContractContractTypes).HasConstraintName("FK_StoreContract_Dictionary");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.StoreContractCreationUserNavigations).HasConstraintName("FK_Table_1_CreationUser");

            entity.HasOne(d => d.Status).WithMany(p => p.StoreContractStatuses).HasConstraintName("FK_Table_1_Status");

            entity.HasOne(d => d.Store).WithMany(p => p.StoreContracts).HasConstraintName("FK_StoreContract_Store");

            entity.HasOne(d => d.VoidUserNavigation).WithMany(p => p.StoreContractVoidUserNavigations).HasConstraintName("FK_Table_1_VoidUser");
        });

        modelBuilder.Entity<StoreContractDepartment>(entity =>
        {
            entity.HasOne(d => d.Contract).WithMany(p => p.StoreContractDepartments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreContractDepartments_StoreContract");

            entity.HasOne(d => d.Department).WithMany(p => p.StoreContractDepartments).HasConstraintName("FK_StoreContractDepartments_Department");
        });

        modelBuilder.Entity<StoreContractDepartmentsView>(entity =>
        {
            entity.ToView("StoreContractDepartmentsView");
        });

        modelBuilder.Entity<StoreContractView>(entity =>
        {
            entity.ToView("StoreContractView");
        });

        modelBuilder.Entity<StoreDailyTurnOver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StoreDailyTurnOver_1");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Store).WithMany(p => p.StoreDailyTurnOvers).HasConstraintName("FK_StoreDailyTurnOver_Store");
        });

        modelBuilder.Entity<StoreDailyTurnOverLineItem>(entity =>
        {
            entity.HasOne(d => d.Contract).WithMany(p => p.StoreDailyTurnOverLineItems).HasConstraintName("FK_StoreDailyTurnOverLineItem_SupplierContract");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.StoreDailyTurnOverLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreDailyTurnOverLineItem_StoreDailyTurnOver");

            entity.HasOne(d => d.Item).WithMany(p => p.StoreDailyTurnOverLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreDailyTurnOverLineItem_Item");
        });

        modelBuilder.Entity<StoreDailyTurnOverView>(entity =>
        {
            entity.ToView("StoreDailyTurnOverView");
        });

        modelBuilder.Entity<StoreGroup>(entity =>
        {
            entity.Property(e => e.GroupId).ValueGeneratedNever();
        });

        modelBuilder.Entity<StoreHierarchView>(entity =>
        {
            entity.ToView("StoreHierarchView");
        });

        modelBuilder.Entity<StoreRepository>(entity =>
        {
            entity.HasOne(d => d.DetailAccount).WithMany(p => p.StoreRepositories).HasConstraintName("FK_StoreRepository_DetailAccount");

            entity.HasOne(d => d.Repository).WithMany(p => p.StoreRepositories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreRepository_Repository");

            entity.HasOne(d => d.Store).WithMany(p => p.StoreRepositories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreRepository_Store");
        });

        modelBuilder.Entity<StoreView>(entity =>
        {
            entity.ToView("StoreView");

            entity.Property(e => e.Fax).IsFixedLength();
            entity.Property(e => e.Telephone).IsFixedLength();
        });

        modelBuilder.Entity<SubSystem>(entity =>
        {
            entity.Property(e => e.SubSytemId).ValueGeneratedNever();

            entity.HasOne(d => d.Permission).WithMany(p => p.SubSystems).HasConstraintName("FK_SubSystem_Permission");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK_Supplier_1");

            entity.Property(e => e.SupplierId).ValueGeneratedNever();

            entity.HasOne(d => d.Agent).WithMany(p => p.Suppliers).HasConstraintName("FK_Supplier_Person");

            entity.HasOne(d => d.Party).WithMany(p => p.Suppliers).HasConstraintName("FK_Supplier_Party");

            entity.HasOne(d => d.Status).WithMany(p => p.Suppliers).HasConstraintName("FK_Supplier_Dictionary");
        });

        modelBuilder.Entity<SupplierAgreement>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SupplierAgreementCustomField>(entity =>
        {
            entity.HasKey(e => e.AgreementId).HasName("PK_SupplierAgreementCustom");

            entity.Property(e => e.AgreementId).ValueGeneratedNever();

            entity.HasOne(d => d.Agreement).WithOne(p => p.SupplierAgreementCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierAgreementCustomField_SupplierAgreement");
        });

        modelBuilder.Entity<SupplierAgreementDepartment>(entity =>
        {
            entity.HasOne(d => d.Agreement).WithMany(p => p.SupplierAgreementDepartments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierAgreementDepartment_SupplierAgreement");

            entity.HasOne(d => d.Department).WithMany(p => p.SupplierAgreementDepartments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierAgreementDepartment_Department");
        });

        modelBuilder.Entity<SupplierAgreementDepartmentView>(entity =>
        {
            entity.ToView("SupplierAgreementDepartmentView");
        });

        modelBuilder.Entity<SupplierAgreementLineItem>(entity =>
        {
            entity.HasOne(d => d.Agreement).WithMany(p => p.SupplierAgreementLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierAgreementLineItem_SupplierAgreement");
        });

        modelBuilder.Entity<SupplierAgreementLineItemView>(entity =>
        {
            entity.ToView("SupplierAgreementLineItemView");
        });

        modelBuilder.Entity<SupplierAgreementStore>(entity =>
        {
            entity.HasOne(d => d.Agreement).WithMany(p => p.SupplierAgreementStores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierAgreementStores_SupplierAgreement");
        });

        modelBuilder.Entity<SupplierAgreementStoresView>(entity =>
        {
            entity.ToView("SupplierAgreementStoresView");
        });

        modelBuilder.Entity<SupplierAgreementView>(entity =>
        {
            entity.ToView("SupplierAgreementView");
        });

        modelBuilder.Entity<SupplierContract>(entity =>
        {
            entity.HasKey(e => e.ContractId).HasName("PK_SupplierContract_1");

            entity.Property(e => e.ContractId).ValueGeneratedNever();

            entity.HasOne(d => d.ContractType).WithMany(p => p.SupplierContractContractTypes).HasConstraintName("FK_SupplierContract_Dictionary");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.SupplierContractCreationUserNavigations).HasConstraintName("FK_SupplierContract_CreationUser");

            entity.HasOne(d => d.Currency).WithMany(p => p.SupplierContracts).HasConstraintName("FK_SupplierContract_Currency");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.SupplierContractModifyUserNavigations).HasConstraintName("FK_SupplierContract_ModifyUser");

            entity.HasOne(d => d.Status).WithMany(p => p.SupplierContractStatuses).HasConstraintName("FK_SupplierContract_Dictionary1");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierContracts).HasConstraintName("FK_SupplierContract_Supplier");
        });

        modelBuilder.Entity<SupplierContractLineItem>(entity =>
        {
            entity.HasKey(e => new { e.ContractId, e.ItemId }).HasName("PK_SupplierContractLineItems_1");

            entity.HasOne(d => d.Contract).WithMany(p => p.SupplierContractLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierContractLineItems_SupplierContract");

            entity.HasOne(d => d.Item).WithMany(p => p.SupplierContractLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierContractLineItems_Item");
        });

        modelBuilder.Entity<SupplierContractLineItemsView>(entity =>
        {
            entity.ToView("SupplierContractLineItemsView");
        });

        modelBuilder.Entity<SupplierContractStore>(entity =>
        {
            entity.HasOne(d => d.Contract).WithMany(p => p.SupplierContractStores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierContractStores_SupplierContract");
        });

        modelBuilder.Entity<SupplierContractStoresView>(entity =>
        {
            entity.ToView("SupplierContractStoresView");
        });

        modelBuilder.Entity<SupplierContractView>(entity =>
        {
            entity.ToView("SupplierContractView");
        });

        modelBuilder.Entity<SupplierCustomField>(entity =>
        {
            entity.Property(e => e.SupplierId).ValueGeneratedNever();

            entity.HasOne(d => d.Supplier).WithOne(p => p.SupplierCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierCustomField_Supplier");
        });

        modelBuilder.Entity<SupplierItem>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.SupplierItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierItem_Item");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierItem_Supplier");
        });

        modelBuilder.Entity<SupplierItemView>(entity =>
        {
            entity.ToView("SupplierItemView");
        });

        modelBuilder.Entity<SupplierNameView>(entity =>
        {
            entity.ToView("SupplierNameView");
        });

        modelBuilder.Entity<SupplierNewItemProclamation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SupplierNewItem");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierNewItemProclamations).HasConstraintName("FK_SupplierNewItem_Supplier");
        });

        modelBuilder.Entity<SupplierNewPriceProclamation>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithMany(p => p.SupplierNewPriceProclamations).HasConstraintName("FK_SupplierNewPriceProclamation_Item");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierNewPriceProclamations).HasConstraintName("FK_SupplierNewPriceProclamation_Supplier");
        });

        modelBuilder.Entity<SupplierSale>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasMany(d => d.Suppliers).WithMany(p => p.Ids)
                .UsingEntity<Dictionary<string, object>>(
                    "SupplierSaleAssignment",
                    r => r.HasOne<Supplier>().WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SupplierSaleAssignment_Supplier"),
                    l => l.HasOne<SupplierSale>().WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SupplierSaleAssignment_SupplierSale"),
                    j =>
                    {
                        j.HasKey("Id", "SupplierId");
                        j.ToTable("SupplierSaleAssignment");
                        j.IndexerProperty<Guid>("Id").HasColumnName("ID");
                        j.IndexerProperty<Guid>("SupplierId").HasColumnName("SupplierID");
                    });
        });

        modelBuilder.Entity<SupplierSaleAssignmentView>(entity =>
        {
            entity.ToView("SupplierSaleAssignmentView");
        });

        modelBuilder.Entity<SupplierSaleLineItem>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.SupplierSaleLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierSaleLineItem_SupplierSale");

            entity.HasOne(d => d.Item).WithMany(p => p.SupplierSaleLineItems).HasConstraintName("FK_SupplierSaleLineItem_Item");

            entity.HasOne(d => d.StockDocument).WithMany(p => p.SupplierSaleLineItems).HasConstraintName("FK_SupplierSaleLineItem_StockDocument");
        });

        modelBuilder.Entity<SupplierSaleLineItemView>(entity =>
        {
            entity.ToView("SupplierSaleLineItemView");
        });

        modelBuilder.Entity<SupplierView>(entity =>
        {
            entity.ToView("SupplierView");

            entity.Property(e => e.AreaCode).IsFixedLength();
            entity.Property(e => e.Mobile).IsFixedLength();
            entity.Property(e => e.Telephone).IsFixedLength();
        });

        modelBuilder.Entity<SuspendInvoice>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.SuspendInvoices).HasConstraintName("FK_SuspendInvoice_Customer");

            entity.HasOne(d => d.Table).WithMany(p => p.SuspendInvoices).HasConstraintName("FK_SuspendInvoice_Table");
        });

        modelBuilder.Entity<SynchRequest>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SystemConfiguration>(entity =>
        {
            entity.Property(e => e.ConfigId).ValueGeneratedNever();
        });

        modelBuilder.Entity<SystemUpdateView>(entity =>
        {
            entity.ToView("SystemUpdateView");
        });

        modelBuilder.Entity<TableManagement>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Status).WithMany(p => p.TableManagements).HasConstraintName("FK_TableManagement_Status");

            entity.HasOne(d => d.Store).WithMany(p => p.TableManagements).HasConstraintName("FK_TableManagement_Store");
        });

        modelBuilder.Entity<RainExtention.Infrastructure.Entities.Task>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Category).WithMany(p => p.Tasks).HasConstraintName("FK_Task_TaskCategory");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.TaskCreationUserNavigations).HasConstraintName("FK_Task_CreationUser");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.TaskModifyUserNavigations).HasConstraintName("FK_Task_ModifyUser");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_Task_Task");

            entity.HasOne(d => d.Status).WithMany(p => p.Tasks).HasConstraintName("FK_Task_Dictionary");

            entity.HasOne(d => d.User).WithMany(p => p.TaskUsers).HasConstraintName("FK_Task_User");
        });

        modelBuilder.Entity<TaskCategory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TaskEntityAssignment>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.TaskEntityAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskEntityAssignment_Task");
        });

        modelBuilder.Entity<TaskFileAttachment>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.TaskFileAttachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskFileAttachment_Task");
        });

        modelBuilder.Entity<TaskReminder>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.TaskReminder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskReminder_Task");
        });

        modelBuilder.Entity<TaskView>(entity =>
        {
            entity.ToView("TaskView");
        });

        modelBuilder.Entity<TaxGovermentInoiceDetailLog>(entity =>
        {
            entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TaxGovermentInoiceHeaderLog>(entity =>
        {
            entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TaxGovermentInvoiceFinal>(entity =>
        {
            entity.Property(e => e.LastResponseCheckTime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TaxGovermentInvoiceInfo>(entity =>
        {
            entity.Property(e => e.SendDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TaxGovermentSendLog>(entity =>
        {
            entity.Property(e => e.TaxGovermentInvoiceInfoId).IsFixedLength();
        });

        modelBuilder.Entity<TaxIdimport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxIDImp__3214EC2710190ECE");
        });

        modelBuilder.Entity<Telephone>(entity =>
        {
            entity.Property(e => e.AreaCode).IsFixedLength();
            entity.Property(e => e.CallNumber).IsFixedLength();

            entity.HasOne(d => d.CountryCode).WithMany(p => p.TelephoneCountryCodes).HasConstraintName("FK_Telephone_Dictionary");

            entity.HasOne(d => d.Party).WithMany(p => p.Telephones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Telephone_Party");

            entity.HasOne(d => d.Type).WithMany(p => p.TelephoneTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Telephone_Dictionary1");
        });

        modelBuilder.Entity<TelephoneView>(entity =>
        {
            entity.ToView("TelephoneView");

            entity.Property(e => e.AreaCode).IsFixedLength();
            entity.Property(e => e.CallNumber).IsFixedLength();
        });

        modelBuilder.Entity<Tender>(entity =>
        {
            entity.Property(e => e.TenderId).ValueGeneratedNever();

            entity.HasOne(d => d.ActionType).WithMany(p => p.TenderActionTypes).HasConstraintName("FK_Tender_ActionType");

            entity.HasOne(d => d.Currency).WithMany(p => p.Tenders).HasConstraintName("FK_Tender_Currency");

            entity.HasOne(d => d.DetailAccount).WithMany(p => p.Tenders).HasConstraintName("FK_Tender_Tender");

            entity.HasOne(d => d.Repository).WithMany(p => p.Tenders).HasConstraintName("FK_Tender_Repository");

            entity.HasOne(d => d.TenderType).WithMany(p => p.TenderTenderTypes).HasConstraintName("FK_Tender_Type");
        });

        modelBuilder.Entity<TenderConfiguration>(entity =>
        {
            entity.HasOne(d => d.Tender).WithMany(p => p.TenderConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TenderConfiguration_Tender");

            entity.HasOne(d => d.Workstation).WithMany(p => p.TenderConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TenderConfiguration_Workstation");
        });

        modelBuilder.Entity<TenderConfigurationView>(entity =>
        {
            entity.ToView("TenderConfigurationView");
        });

        modelBuilder.Entity<TenderView>(entity =>
        {
            entity.ToView("TenderView");
        });

        modelBuilder.Entity<ThirdParty>(entity =>
        {
            entity.HasKey(e => e.ThirdPartyId).HasName("PK_ThirdParty_1");

            entity.Property(e => e.ThirdPartyId).ValueGeneratedNever();

            entity.HasOne(d => d.Status).WithMany(p => p.ThirdParties).HasConstraintName("FK_ThirdParty_Dictionary");
        });

        modelBuilder.Entity<ThirdPartyNameView>(entity =>
        {
            entity.ToView("ThirdPartyNameView");
        });

        modelBuilder.Entity<ThirdPartyView>(entity =>
        {
            entity.ToView("ThirdPartyView");
        });

        modelBuilder.Entity<TreasuryAccount>(entity =>
        {
            entity.Property(e => e.AccountId).ValueGeneratedNever();

            entity.HasOne(d => d.Type).WithMany(p => p.TreasuryAccounts).HasConstraintName("FK_TreasuryAccount_Dictionary");
        });

        modelBuilder.Entity<TreasuryAccountView>(entity =>
        {
            entity.ToView("TreasuryAccountView");
        });

        modelBuilder.Entity<TreasuryDocument>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.BookerWorkstationId, e.DocumentId }).HasName("PK_TreasuryDocument_1");

            entity.HasOne(d => d.ApproveUserNavigation).WithMany(p => p.TreasuryDocumentApproveUserNavigations).HasConstraintName("FK_TreasuryDocument_ApproveUser");

            entity.HasOne(d => d.CreationUserNavigation).WithMany(p => p.TreasuryDocumentCreationUserNavigations).HasConstraintName("FK_TreasuryDocument_CreationUser");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.TreasuryDocumentDocumentTypes).HasConstraintName("FK_TreasuryDocument_Dictionary");

            entity.HasOne(d => d.Reason).WithMany(p => p.TreasuryDocuments).HasConstraintName("FK_TreasuryDocument_Reason");

            entity.HasOne(d => d.Status).WithMany(p => p.TreasuryDocumentStatuses).HasConstraintName("FK_TreasuryDocument_Dictionary1");

            entity.HasOne(d => d.ThirdParty).WithMany(p => p.TreasuryDocuments).HasConstraintName("FK_TreasuryDocument_ThirdParty");

            entity.HasOne(d => d.VoidUserNavigation).WithMany(p => p.TreasuryDocumentVoidUserNavigations).HasConstraintName("FK_TreasuryDocument_VoidUser");

            entity.HasOne(d => d.Workstation).WithMany(p => p.TreasuryDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreasuryDocument_Workstation");
        });

        modelBuilder.Entity<TreasuryDocumentCustomField>(entity =>
        {
            entity.HasOne(d => d.TreasuryDocument).WithOne(p => p.TreasuryDocumentCustomField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreasuryDocumentCustomField_TreasuryDocument");
        });

        modelBuilder.Entity<TreasuryDocumentLineItem>(entity =>
        {
            entity.HasKey(e => new { e.BookerStoreId, e.BookerWorkstationId, e.DocumentId, e.LineItemId }).HasName("PK_TreasuryDocumentLineItem_1");

            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.TreasuryDocumentLineItems).HasConstraintName("FK_TreasuryDocumentLineItem_User");

            entity.HasOne(d => d.State).WithMany(p => p.TreasuryDocumentLineItems).HasConstraintName("FK_TreasuryDocumentLineItem_Dictionary");

            entity.HasOne(d => d.Tender).WithMany(p => p.TreasuryDocumentLineItems).HasConstraintName("FK_TreasuryDocumentLineItem_Tender");

            entity.HasOne(d => d.TreasuryDocument).WithMany(p => p.TreasuryDocumentLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreasuryDocumentLineItem_TreasuryDocument");
        });

        modelBuilder.Entity<TreasuryDocumentLineItemCheque>(entity =>
        {
            entity.HasOne(d => d.TreasuryDocumentLineItem).WithOne(p => p.TreasuryDocumentLineItemCheque)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreasuryDocumentLineItemCheque_TreasuryDocumentLineItem");
        });

        modelBuilder.Entity<TreasuryDocumentLineItemDetail>(entity =>
        {
            entity.HasOne(d => d.ModifyUserNavigation).WithMany(p => p.TreasuryDocumentLineItemDetails).HasConstraintName("FK_TreasuryDocumentLineItemDetail_TreasuryDocumentLineItemDetail");

            entity.HasOne(d => d.State).WithMany(p => p.TreasuryDocumentLineItemDetails).HasConstraintName("FK_TreasuryDocumentLineItemDetail_Dictionary");

            entity.HasOne(d => d.TreasuryDocumentLineItem).WithMany(p => p.TreasuryDocumentLineItemDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreasuryDocumentLineItemDetail_TreasuryDocumentLineItem");
        });

        modelBuilder.Entity<TreasuryDocumentLineItemView>(entity =>
        {
            entity.ToView("TreasuryDocumentLineItemView");
        });

        modelBuilder.Entity<TreasuryDocumentView>(entity =>
        {
            entity.ToView("TreasuryDocumentView");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.DetailAccount).WithMany(p => p.Users).HasConstraintName("FK_User_DetailAccount");

            entity.HasOne(d => d.Employee).WithMany(p => p.Users).HasConstraintName("FK_User_Employee");

            entity.HasOne(d => d.Language).WithMany(p => p.UserLanguages).HasConstraintName("FK_User_Dictionary1");

            entity.HasOne(d => d.Status).WithMany(p => p.UserStatuses).HasConstraintName("FK_User_Dictionary");

            entity.HasMany(d => d.Departments).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserDepartmentAssignment",
                    r => r.HasOne<Department>().WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserDepartmentAssignment_Department"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserDepartmentAssignment_User"),
                    j =>
                    {
                        j.HasKey("UserId", "DepartmentId");
                        j.ToTable("UserDepartmentAssignment");
                        j.IndexerProperty<Guid>("UserId").HasColumnName("UserID");
                        j.IndexerProperty<Guid>("DepartmentId").HasColumnName("DepartmentID");
                    });

            entity.HasMany(d => d.Stocks).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserStockAssignment",
                    r => r.HasOne<Stock>().WithMany()
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserStockAssignment_Stock"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserStockAssignment_User"),
                    j =>
                    {
                        j.HasKey("UserId", "StockId");
                        j.ToTable("UserStockAssignment");
                        j.IndexerProperty<Guid>("UserId").HasColumnName("UserID");
                        j.IndexerProperty<Guid>("StockId").HasColumnName("StockID");
                    });

            entity.HasMany(d => d.Stores).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserLocationAssignment",
                    r => r.HasOne<Store>().WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserLocationAssignment_Store"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserLocationAssignment_User"),
                    j =>
                    {
                        j.HasKey("UserId", "StoreId");
                        j.ToTable("UserLocationAssignment");
                        j.IndexerProperty<Guid>("UserId").HasColumnName("UserID");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                    });

            entity.HasMany(d => d.Tenders).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserTenderAssignment",
                    r => r.HasOne<Tender>().WithMany()
                        .HasForeignKey("TenderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserTenderAssignment_Tender"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserTenderAssignment_User"),
                    j =>
                    {
                        j.HasKey("UserId", "TenderId");
                        j.ToTable("UserTenderAssignment");
                        j.IndexerProperty<Guid>("UserId").HasColumnName("UserID");
                        j.IndexerProperty<int>("TenderId").HasColumnName("TenderID");
                    });
        });

        modelBuilder.Entity<User1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC27E50AAA3A");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UserCustomLayout>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.UserCustomLayouts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserCustomLayout_User");
        });

        modelBuilder.Entity<UserDepartmentAssignmentView>(entity =>
        {
            entity.ToView("UserDepartmentAssignmentView");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.Property(e => e.GroupId).ValueGeneratedNever();

            entity.HasOne(d => d.Department).WithMany(p => p.UserGroups).HasConstraintName("FK_UserGroup_Department");

            entity.HasMany(d => d.Tenders).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "UserGroupTenderAssignment",
                    r => r.HasOne<Tender>().WithMany()
                        .HasForeignKey("TenderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserGroupTenderAssignment_Tender"),
                    l => l.HasOne<UserGroup>().WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserGroupTenderAssignment_UserGroup"),
                    j =>
                    {
                        j.HasKey("GroupId", "TenderId");
                        j.ToTable("UserGroupTenderAssignment");
                        j.IndexerProperty<int>("GroupId").HasColumnName("GroupID");
                        j.IndexerProperty<int>("TenderId").HasColumnName("TenderID");
                    });

            entity.HasMany(d => d.Users).WithMany(p => p.UserGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "UserGroupAssignment",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserGroupAssignment_User"),
                    l => l.HasOne<UserGroup>().WithMany()
                        .HasForeignKey("UserGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UserGroupAssignment_UserGroup"),
                    j =>
                    {
                        j.HasKey("UserGroupId", "UserId");
                        j.ToTable("UserGroupAssignment");
                        j.IndexerProperty<int>("UserGroupId").HasColumnName("UserGroupID");
                        j.IndexerProperty<Guid>("UserId").HasColumnName("UserID");
                    });
        });

        modelBuilder.Entity<UserGroupAssignmentView>(entity =>
        {
            entity.ToView("UserGroupAssignmentView");
        });

        modelBuilder.Entity<UserGroupPermission>(entity =>
        {
            entity.HasOne(d => d.Group).WithMany(p => p.UserGroupPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserGroupPermission_UserGroup");

            entity.HasOne(d => d.Permission).WithMany(p => p.UserGroupPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserGroupPermission_Permission");
        });

        modelBuilder.Entity<UserGroupPermissionView>(entity =>
        {
            entity.ToView("UserGroupPermissionView");
        });

        modelBuilder.Entity<UserGroupTenderAssignmentView>(entity =>
        {
            entity.ToView("UserGroupTenderAssignmentView");
        });

        modelBuilder.Entity<UserLocationAssignmentView>(entity =>
        {
            entity.ToView("UserLocationAssignmentView");
        });

        modelBuilder.Entity<UserPermission>(entity =>
        {
            entity.HasOne(d => d.Permission).WithMany(p => p.UserPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserPermission_Permission");

            entity.HasOne(d => d.User).WithMany(p => p.UserPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserPermission_User");
        });

        modelBuilder.Entity<UserPermissionView>(entity =>
        {
            entity.ToView("UserPermissionView");
        });

        modelBuilder.Entity<UserStockAssignmentView>(entity =>
        {
            entity.ToView("UserStockAssignmentView");
        });

        modelBuilder.Entity<UserTenderView>(entity =>
        {
            entity.ToView("UserTenderView");

            entity.Property(e => e.DecimalSymbol).IsFixedLength();
            entity.Property(e => e.GroupingSymbol).IsFixedLength();
            entity.Property(e => e.Symbol).IsFixedLength();
        });

        modelBuilder.Entity<UserView>(entity =>
        {
            entity.ToView("UserView");
        });

        modelBuilder.Entity<UvDupplicateBarCode>(entity =>
        {
            entity.ToView("Uv_DupplicateBarCode");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UvTaxInfoBulkSale>(entity =>
        {
            entity.ToView("UV_TaxInfo_BulkSale");
        });

        modelBuilder.Entity<UvTaxInfoOld>(entity =>
        {
            entity.ToView("UV_TaxInfoOld");
        });

        modelBuilder.Entity<UvTaxInvoiceOld>(entity =>
        {
            entity.ToView("Uv_TaxInvoiceOld");
        });

        modelBuilder.Entity<UvTaxSaleInvocie>(entity =>
        {
            entity.ToView("UV_TaxSaleInvocie");
        });

        modelBuilder.Entity<UvTissInfo>(entity =>
        {
            entity.ToView("UV_TissInfo");
        });

        modelBuilder.Entity<UvTissInvoice>(entity =>
        {
            entity.ToView("Uv_TissInvoice");
        });

        modelBuilder.Entity<Visitor>(entity =>
        {
            entity.Property(e => e.VisitorId).ValueGeneratedNever();

            entity.HasOne(d => d.Party).WithMany(p => p.Visitors).HasConstraintName("FK_Visitor_Party");
        });

        modelBuilder.Entity<VisitorContract>(entity =>
        {
            entity.Property(e => e.ContractId).ValueGeneratedNever();

            entity.HasOne(d => d.Parent).WithMany(p => p.VisitorContractParents).HasConstraintName("FK_Parent_Visitor");

            entity.HasOne(d => d.Visitor).WithMany(p => p.VisitorContractVisitors).HasConstraintName("FK_VisitorContract_Visitor");
        });

        modelBuilder.Entity<VisitorContractDepartment>(entity =>
        {
            entity.HasOne(d => d.Contract).WithMany(p => p.VisitorContractDepartments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VisitorContractDepartment_VisitorContract");
        });

        modelBuilder.Entity<VisitorContractDepartmentView>(entity =>
        {
            entity.ToView("VisitorContractDepartmentView");
        });

        modelBuilder.Entity<VisitorContractStore>(entity =>
        {
            entity.HasOne(d => d.Contract).WithMany(p => p.VisitorContractStores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VisitorContractStore_VisitorContract");
        });

        modelBuilder.Entity<VisitorContractStoreView>(entity =>
        {
            entity.ToView("VisitorContractStoreView");
        });

        modelBuilder.Entity<VisitorContractView>(entity =>
        {
            entity.ToView("VisitorContractView");
        });

        modelBuilder.Entity<VisitorNameView>(entity =>
        {
            entity.ToView("VisitorNameView");
        });

        modelBuilder.Entity<VisitorView>(entity =>
        {
            entity.ToView("VisitorView");
        });

        modelBuilder.Entity<VwEmployeeSummary>(entity =>
        {
            entity.ToView("vw_EmployeeSummary");
        });

        modelBuilder.Entity<WebSite>(entity =>
        {
            entity.HasOne(d => d.Party).WithMany(p => p.WebSites)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WebSite_Party");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.WebSites)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WebSite_Dictionary");
        });

        modelBuilder.Entity<Workstation>(entity =>
        {
            entity.HasOne(d => d.Store).WithMany(p => p.Workstations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Workstation_Store");

            entity.HasOne(d => d.Type).WithMany(p => p.Workstations).HasConstraintName("FK_Workstation_Dictionary");

            entity.HasMany(d => d.Departments).WithMany(p => p.Workstations)
                .UsingEntity<Dictionary<string, object>>(
                    "WorkstationDepartmentAssignment",
                    r => r.HasOne<Department>().WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_WorkstationDepartmentAssignment_Department"),
                    l => l.HasOne<Workstation>().WithMany()
                        .HasForeignKey("StoreId", "WorkstationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_WorkstationDepartmentAssignment_Workstation"),
                    j =>
                    {
                        j.HasKey("StoreId", "WorkstationId", "DepartmentId");
                        j.ToTable("WorkstationDepartmentAssignment");
                        j.IndexerProperty<int>("StoreId").HasColumnName("StoreID");
                        j.IndexerProperty<int>("WorkstationId").HasColumnName("WorkstationID");
                        j.IndexerProperty<Guid>("DepartmentId").HasColumnName("DepartmentID");
                    });
        });

        modelBuilder.Entity<WorkstationDepartmentAssignmentView>(entity =>
        {
            entity.ToView("WorkstationDepartmentAssignmentView");
        });

        modelBuilder.Entity<WorkstationView>(entity =>
        {
            entity.ToView("WorkstationView");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
