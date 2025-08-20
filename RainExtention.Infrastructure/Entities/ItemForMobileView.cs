using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemForMobileView
{
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    [Column("NameInPOS")]
    [StringLength(255)]
    public string? NameInPos { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    public byte[]? ItemImage { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [Column("ReportGroupID")]
    public Guid? ReportGroupId { get; set; }

    [Column("TaxGroupID")]
    public Guid? TaxGroupId { get; set; }

    [Column("DiscountGroupID")]
    public Guid? DiscountGroupId { get; set; }

    [Column("BrandID")]
    public Guid? BrandId { get; set; }

    [Column("UnitOfMeasureID")]
    public int? UnitOfMeasureId { get; set; }

    public int? QualityRate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Point { get; set; }

    public bool? DiscountFlag { get; set; }

    public bool? ExpireableFlag { get; set; }

    public bool? AllowSerial { get; set; }

    public bool? AllowToChangePrice { get; set; }

    [Column("ProcurementTypeID")]
    public int? ProcurementTypeId { get; set; }

    [Column("NatureTypeID")]
    public int? NatureTypeId { get; set; }

    public bool? AllowToPublish { get; set; }

    [Column("ExternalID")]
    [StringLength(50)]
    public string? ExternalId { get; set; }

    [StringLength(20)]
    public string? GenericCode { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(50)]
    public string? ItemType { get; set; }

    [StringLength(50)]
    public string? UnitOfMeasure { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(50)]
    public string? Brand { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Weight { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Length { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Width { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Height { get; set; }

    [StringLength(100)]
    public string DepartmentName { get; set; } = null!;

    [StringLength(50)]
    public string? DepartmentCode { get; set; }

    [StringLength(100)]
    public string ReportGroupName { get; set; } = null!;

    [StringLength(100)]
    public string TaxGroupName { get; set; } = null!;

    [StringLength(100)]
    public string DiscountGroupName { get; set; } = null!;

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    public bool? IsQuick { get; set; }

    public string? AllBarcode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CurrentDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LastPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CurrentPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal BulkPriceAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CommissionPercent { get; set; }

    public bool Taxable { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TaxPercent { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [StringLength(101)]
    public string? SupplierName { get; set; }

    [Column("ContractTypeID")]
    public int? ContractTypeId { get; set; }

    [StringLength(50)]
    public string? ContractType { get; set; }

    [Column("ContractID")]
    public Guid? ContractId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentCost { get; set; }

    public bool? CalcServiceTime { get; set; }

    public int? TimePeriod { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PriceOfTimePeriod { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TollPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PackUnitCount { get; set; }

    public bool? ShowInVitrin { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MinPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxPrice { get; set; }

    [Column("TemplateID")]
    public int? TemplateId { get; set; }

    [StringLength(119)]
    public string? ImageUrl { get; set; }

    public int ImageCount { get; set; }
}
