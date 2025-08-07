using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Item")]
[Index("Barcode", Name = "IX_Barcode")]
[Index("BrandId", Name = "IX_BrandID")]
[Index("ContractId", Name = "IX_ContractID")]
[Index("CreationUser", "CreationDate", Name = "IX_Create")]
[Index("DiscountFlag", Name = "IX_DiscountFlag")]
[Index("ExternalId", Name = "IX_ExternalID")]
[Index("IsQuick", Name = "IX_IsQuick")]
[Index("ModifyUser", "ModifyDate", Name = "IX_Modify")]
[Index("PackUnitCount", Name = "IX_PackUnit")]
[Index("ParentId", Name = "IX_ParentID")]
[Index("ShowInVitrin", Name = "IX_ShowInVitrin")]
[Index("StatusId", Name = "IX_Status")]
[Index("TypeId", Name = "IX_Type")]
[Index("UnitOfMeasureId", Name = "IX_UnitOfMeasure")]
public partial class Item
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    public byte[]? ItemImage { get; set; }

    public string? AllBarcode { get; set; }

    [Column("BrandID")]
    public Guid? BrandId { get; set; }

    [Column("UnitOfMeasureID")]
    public int? UnitOfMeasureId { get; set; }

    public int? QualityRate { get; set; }

    public bool? DiscountFlag { get; set; }

    public bool? ExpireableFlag { get; set; }

    public bool? IsQuick { get; set; }

    public bool? ShowInVitrin { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MinPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PackUnitCount { get; set; }

    [Column("ExternalID")]
    [StringLength(50)]
    public string? ExternalId { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [Column("DiscountTypeID")]
    public int? DiscountTypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? LastPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BulkPriceAmount { get; set; }

    [Column("TemplateID")]
    public int? TemplateId { get; set; }

    public bool? AllowSerial { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Point { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Weight { get; set; }

    [Column("ContractID")]
    public Guid? ContractId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentCost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Length { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Width { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Height { get; set; }

    public bool? AllowToChangePrice { get; set; }

    public bool? AllowToPublish { get; set; }

    [Column("ProcurementTypeID")]
    public int? ProcurementTypeId { get; set; }

    public int? InHouseProduction { get; set; }

    [Column("NatureTypeID")]
    public int? NatureTypeId { get; set; }

    public bool? CalcServiceTime { get; set; }

    public int? TimePeriod { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PriceOfTimePeriod { get; set; }

    [StringLength(20)]
    public string? GenericCode { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<AutomaticOrderPlanItemAssignment> AutomaticOrderPlanItemAssignments { get; set; } = new List<AutomaticOrderPlanItemAssignment>();

    [InverseProperty("Item")]
    public virtual ICollection<AutomaticOrderPlanItemEvent> AutomaticOrderPlanItemEvents { get; set; } = new List<AutomaticOrderPlanItemEvent>();

    [InverseProperty("Child")]
    public virtual ICollection<BillOfMaterialItemRelatedItem> BillOfMaterialItemRelatedItemChildren { get; set; } = new List<BillOfMaterialItemRelatedItem>();

    [InverseProperty("Item")]
    public virtual ICollection<BillOfMaterialItemRelatedItem> BillOfMaterialItemRelatedItemItems { get; set; } = new List<BillOfMaterialItemRelatedItem>();

    [InverseProperty("Child")]
    public virtual ICollection<BillOfMaterialItemStep> BillOfMaterialItemSteps { get; set; } = new List<BillOfMaterialItemStep>();

    [InverseProperty("Child")]
    public virtual ICollection<BillOfMaterialItem> BillOfMaterialItems { get; set; } = new List<BillOfMaterialItem>();

    [InverseProperty("Item")]
    public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; } = new List<BillOfMaterial>();

    [ForeignKey("BrandId")]
    [InverseProperty("Items")]
    public virtual Brand? Brand { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("ItemCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<DiscountItemAssignment> DiscountItemAssignments { get; set; } = new List<DiscountItemAssignment>();

    [InverseProperty("BonusItem")]
    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();

    [InverseProperty("Parent")]
    public virtual ICollection<Item> InverseParent { get; set; } = new List<Item>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemAssortment> ItemAssortments { get; set; } = new List<ItemAssortment>();

    [InverseProperty("Child")]
    public virtual ICollection<ItemAttributeItem> ItemAttributeItems { get; set; } = new List<ItemAttributeItem>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemAttribute> ItemAttributes { get; set; } = new List<ItemAttribute>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemBarcode> ItemBarcodes { get; set; } = new List<ItemBarcode>();

    [InverseProperty("ChildItem")]
    public virtual ICollection<ItemCollection> ItemCollectionChildItems { get; set; } = new List<ItemCollection>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemCollection> ItemCollectionItems { get; set; } = new List<ItemCollection>();

    [InverseProperty("Item")]
    public virtual ItemCustomField? ItemCustomField { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<ItemDepartmentAssignment> ItemDepartmentAssignments { get; set; } = new List<ItemDepartmentAssignment>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemDepartmentLog> ItemDepartmentLogs { get; set; } = new List<ItemDepartmentLog>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemImage> ItemImages { get; set; } = new List<ItemImage>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemSerializedStockState> ItemSerializedStockStates { get; set; } = new List<ItemSerializedStockState>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemServiceRule> ItemServiceRules { get; set; } = new List<ItemServiceRule>();

    [InverseProperty("Item")]
    public virtual ItemState? ItemState { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<ItemStockQuantity> ItemStockQuantities { get; set; } = new List<ItemStockQuantity>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemStockSection> ItemStockSections { get; set; } = new List<ItemStockSection>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemStockState> ItemStockStates { get; set; } = new List<ItemStockState>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemTranslation> ItemTranslations { get; set; } = new List<ItemTranslation>();

    [InverseProperty("Item")]
    public virtual ICollection<LoyalityAwardRuleItem> LoyalityAwardRuleItems { get; set; } = new List<LoyalityAwardRuleItem>();

    [ForeignKey("ModifyUser")]
    [InverseProperty("ItemModifyUserNavigations")]
    public virtual User? ModifyUserNavigation { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<OrderDocumentLineItem> OrderDocumentLineItems { get; set; } = new List<OrderDocumentLineItem>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual Item? Parent { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<PartialPaymentRuleItemAssignment> PartialPaymentRuleItemAssignments { get; set; } = new List<PartialPaymentRuleItemAssignment>();

    [InverseProperty("Item")]
    public virtual ICollection<ProductCatalog> ProductCatalogs { get; set; } = new List<ProductCatalog>();

    [InverseProperty("Item")]
    public virtual ICollection<ProductionDocumentLineItem> ProductionDocumentLineItems { get; set; } = new List<ProductionDocumentLineItem>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductionDocument> ProductionDocuments { get; set; } = new List<ProductionDocument>();

    [InverseProperty("Item")]
    public virtual ICollection<ProductionOrderLineItem> ProductionOrderLineItems { get; set; } = new List<ProductionOrderLineItem>();

    [InverseProperty("Item")]
    public virtual ICollection<SaleInvoiceLineItemDetail> SaleInvoiceLineItemDetailItems { get; set; } = new List<SaleInvoiceLineItemDetail>();

    [InverseProperty("ParentItem")]
    public virtual ICollection<SaleInvoiceLineItemDetail> SaleInvoiceLineItemDetailParentItems { get; set; } = new List<SaleInvoiceLineItemDetail>();

    [InverseProperty("Item")]
    public virtual ICollection<SaleInvoiceLineItem> SaleInvoiceLineItems { get; set; } = new List<SaleInvoiceLineItem>();

    [InverseProperty("Item")]
    public virtual ICollection<SalePriceLineItem> SalePriceLineItems { get; set; } = new List<SalePriceLineItem>();

    [InverseProperty("Item")]
    public virtual ICollection<SaleQoutaItemAssignment> SaleQoutaItemAssignments { get; set; } = new List<SaleQoutaItemAssignment>();

    [InverseProperty("Item")]
    public virtual ICollection<ShelfPriceItem> ShelfPriceItems { get; set; } = new List<ShelfPriceItem>();

    [InverseProperty("Item")]
    public virtual ICollection<ShelfPricePrintHistory> ShelfPricePrintHistories { get; set; } = new List<ShelfPricePrintHistory>();

    [InverseProperty("Item")]
    public virtual ICollection<ShelfPricePrint> ShelfPricePrints { get; set; } = new List<ShelfPricePrint>();

    [ForeignKey("StatusId")]
    [InverseProperty("ItemStatuses")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<StockDocumentLineItem> StockDocumentLineItems { get; set; } = new List<StockDocumentLineItem>();

    [InverseProperty("Item")]
    public virtual ICollection<StoreDailyTurnOverLineItem> StoreDailyTurnOverLineItems { get; set; } = new List<StoreDailyTurnOverLineItem>();

    [InverseProperty("Item")]
    public virtual ICollection<SupplierContractLineItem> SupplierContractLineItems { get; set; } = new List<SupplierContractLineItem>();

    [InverseProperty("Item")]
    public virtual ICollection<SupplierItem> SupplierItems { get; set; } = new List<SupplierItem>();

    [InverseProperty("Item")]
    public virtual ICollection<SupplierNewPriceProclamation> SupplierNewPriceProclamations { get; set; } = new List<SupplierNewPriceProclamation>();

    [InverseProperty("Item")]
    public virtual ICollection<SupplierSaleLineItem> SupplierSaleLineItems { get; set; } = new List<SupplierSaleLineItem>();

    [ForeignKey("TypeId")]
    [InverseProperty("ItemTypes")]
    public virtual Dictionary? Type { get; set; }

    [ForeignKey("UnitOfMeasureId")]
    [InverseProperty("ItemUnitOfMeasures")]
    public virtual Dictionary? UnitOfMeasure { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("Items")]
    public virtual ICollection<ItemTag> Tags { get; set; } = new List<ItemTag>();
}
