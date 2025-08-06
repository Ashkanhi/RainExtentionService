using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("GiftCard")]
[Index("EffectiveDate", "ExpireDate", Name = "IX_GiftCardDate")]
public partial class GiftCard
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Thershold { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationTime { get; set; }

    public Guid? CreationUser { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual GiftCardInvoice? GiftCardInvoice { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<GiftCardSerial> GiftCardSerials { get; set; } = new List<GiftCardSerial>();

    [ForeignKey("Id")]
    [InverseProperty("Ids")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
