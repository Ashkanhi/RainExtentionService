using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("FactSupplierAgreement")]
public partial class FactSupplierAgreement
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(100)]
    public string? Title { get; set; }

    [StringLength(50)]
    public string? DocumentNumber { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxOrder { get; set; }

    public int? LeadTime { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AdmissionAmount { get; set; }

    public int? EarlySettelment { get; set; }

    public int? SettelmentDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SupplierDiscount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    public string? Description { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? VoidUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    public int? SecondSettelmentDate { get; set; }

    public int? EarlySecondSettelment { get; set; }

    [StringLength(200)]
    public string? EarlySettelmentDescription { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxReturn { get; set; }

    public bool? DiscountAfterTax { get; set; }

    public int? DelayPenalty { get; set; }

    public int? LeadTimeTolerance { get; set; }

    [Column("SettelmentDateTypeID")]
    public int? SettelmentDateTypeId { get; set; }
}
