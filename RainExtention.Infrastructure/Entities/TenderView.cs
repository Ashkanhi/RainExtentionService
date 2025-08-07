using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class TenderView
{
    [Column("TenderID")]
    public int TenderId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column("TenderTypeID")]
    public int? TenderTypeId { get; set; }

    [Column("ActionTypeID")]
    public int? ActionTypeId { get; set; }

    [Column("RepositoryID")]
    public int? RepositoryId { get; set; }

    public bool? IsPrintable { get; set; }

    [StringLength(50)]
    public string? LayoutFile { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    public bool? IsOnline { get; set; }

    public string? ConnectionInfo { get; set; }

    public byte[]? TenderImage { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("CurrencyID")]
    public int? CurrencyId { get; set; }

    [StringLength(50)]
    public string? TenderTypeName { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ExchangeAmount { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
