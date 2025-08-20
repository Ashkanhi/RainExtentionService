using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class GiftCardSerialView
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [StringLength(100)]
    public string SerialNumber { get; set; } = null!;

    [StringLength(50)]
    public string? Password { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Thershold { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
