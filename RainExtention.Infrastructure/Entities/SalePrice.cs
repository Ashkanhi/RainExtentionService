using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SalePrice")]
[Index("EffectiveDate", "ExpireDate", Name = "IX_SalePriceDate")]
[Index("PriceTypeId", Name = "IX_SalePriceType")]
[Index("StatusId", Name = "IX_Status")]
public partial class SalePrice
{
    [Key]
    [Column("PriceID")]
    public Guid PriceId { get; set; }

    [Column("PriceTypeID")]
    public int? PriceTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? VoidUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? DocumentCode { get; set; }

    public bool? ForceToActivate { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [Column("CurrencyID")]
    public int? CurrencyId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExchangeAmount { get; set; }

    public bool? IsPriceWithTax { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("SalePriceCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("SalePrices")]
    public virtual Currency? Currency { get; set; }

    [ForeignKey("ModifyUser")]
    [InverseProperty("SalePriceModifyUserNavigations")]
    public virtual User? ModifyUserNavigation { get; set; }

    [ForeignKey("PriceTypeId")]
    [InverseProperty("SalePricePriceTypes")]
    public virtual Dictionary? PriceType { get; set; }

    [InverseProperty("Price")]
    public virtual ICollection<SalePriceActiveTime> SalePriceActiveTimes { get; set; } = new List<SalePriceActiveTime>();

    [InverseProperty("Price")]
    public virtual ICollection<SalePriceConditional> SalePriceConditionals { get; set; } = new List<SalePriceConditional>();

    [InverseProperty("Price")]
    public virtual ICollection<SalePriceLineItem> SalePriceLineItems { get; set; } = new List<SalePriceLineItem>();

    [ForeignKey("StatusId")]
    [InverseProperty("SalePriceStatuses")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("PriceId")]
    [InverseProperty("Prices")]
    public virtual ICollection<CustomerGroup> CustomerGroups { get; set; } = new List<CustomerGroup>();

    [ForeignKey("PriceId")]
    [InverseProperty("Prices")]
    public virtual ICollection<StoreGroup> Groups { get; set; } = new List<StoreGroup>();

    [ForeignKey("PriceId")]
    [InverseProperty("Prices")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
