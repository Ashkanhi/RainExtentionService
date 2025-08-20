using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("AgreementId", "LineItemId")]
[Table("SupplierAgreementLineItem")]
public partial class SupplierAgreementLineItem
{
    [Key]
    [Column("AgreementID")]
    public Guid AgreementId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [StringLength(100)]
    public string? Title { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [ForeignKey("AgreementId")]
    [InverseProperty("SupplierAgreementLineItems")]
    public virtual SupplierAgreement Agreement { get; set; } = null!;
}
