using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemNameView
{
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
}
