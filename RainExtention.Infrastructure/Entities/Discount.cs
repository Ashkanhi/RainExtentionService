using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Discount")]
[Index("BonusItemId", Name = "IX_BonusItem")]
[Index("EffectiveDate", "ExpireDate", Name = "IX_Discount")]
[Index("DiscountTypeId", Name = "IX_DiscountType")]
[Index("StatusId", Name = "IX_Status")]
[Index("ThersholdTypeId", Name = "IX_ThersholdType")]
public partial class Discount
{
    [Key]
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

    [ForeignKey("BonusItemId")]
    [InverseProperty("Discounts")]
    public virtual Item? BonusItem { get; set; }

    [InverseProperty("Discount")]
    public virtual ICollection<DiscountActiveTime> DiscountActiveTimes { get; set; } = new List<DiscountActiveTime>();

    [ForeignKey("DiscountCategoryId")]
    [InverseProperty("Discounts")]
    public virtual DiscountCategory? DiscountCategory { get; set; }

    [InverseProperty("Discount")]
    public virtual ICollection<DiscountCondition> DiscountConditions { get; set; } = new List<DiscountCondition>();

    [InverseProperty("Discount")]
    public virtual ICollection<DiscountDepartmentAssignment> DiscountDepartmentAssignments { get; set; } = new List<DiscountDepartmentAssignment>();

    [InverseProperty("DiscountNavigation")]
    public virtual ICollection<DiscountItemAssignment> DiscountItemAssignments { get; set; } = new List<DiscountItemAssignment>();

    [InverseProperty("Discount")]
    public virtual ICollection<DiscountTender> DiscountTenders { get; set; } = new List<DiscountTender>();

    [ForeignKey("DiscountTypeId")]
    [InverseProperty("DiscountDiscountTypes")]
    public virtual Dictionary? DiscountType { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("DiscountStatuses")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("ThersholdTypeId")]
    [InverseProperty("DiscountThersholdTypes")]
    public virtual Dictionary? ThersholdType { get; set; }

    [ForeignKey("DiscountId")]
    [InverseProperty("Discounts")]
    public virtual ICollection<CustomerGroup> CustomerGroups { get; set; } = new List<CustomerGroup>();

    [ForeignKey("DiscountId")]
    [InverseProperty("Discounts")]
    public virtual ICollection<StoreGroup> Groups { get; set; } = new List<StoreGroup>();

    [ForeignKey("DiscountId")]
    [InverseProperty("Discounts")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
