using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class DiscountView
{
    [Column("DiscountID")]
    public Guid DiscountId { get; set; }

    [Column("DiscountTypeID")]
    public int? DiscountTypeId { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    [Column("ThersholdTypeID")]
    public int? ThersholdTypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Thershold { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxThershold { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Interval { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value { get; set; }

    [Column("BonusItemID")]
    public Guid? BonusItemId { get; set; }

    public bool? AllowMerge { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    public bool? AllowToPrint { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    [Column("MaxTypeID")]
    public int? MaxTypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxQuantity { get; set; }

    [Column("DiscountCategoryID")]
    public int? DiscountCategoryId { get; set; }

    [Column("SaleChannelID")]
    public int? SaleChannelId { get; set; }

    public bool? IncludeNewCustomers { get; set; }

    [StringLength(50)]
    public string? DiscountType { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    public int? ActiveDay { get; set; }

    public int? ActiveHour { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [Column("GroupID")]
    public Guid? GroupId { get; set; }

    [StringLength(101)]
    public string? SupplierName { get; set; }

    [Column("BonusTypeID")]
    public int? BonusTypeId { get; set; }
}
