using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SalePriceView
{
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

    [StringLength(50)]
    public string? PriceType { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(50)]
    public string? CreationUserName { get; set; }

    [StringLength(50)]
    public string? ApproveUserName { get; set; }

    [StringLength(50)]
    public string? VoidUserName { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
