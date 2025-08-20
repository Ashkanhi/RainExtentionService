using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SupplierAgreementLineItemView
{
    [Column("AgreementID")]
    public Guid AgreementId { get; set; }

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

    [StringLength(50)]
    public string? ReasonName { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
