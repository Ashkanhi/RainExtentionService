using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SafeStoreTurnOverView
{
    [StringLength(50)]
    public string? DocumentType { get; set; }

    [Column("BookerStoreID")]
    public int? BookerStoreId { get; set; }

    [StringLength(50)]
    public string? StoreName { get; set; }

    [StringLength(50)]
    public string? DocumentNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocumentDate { get; set; }

    [StringLength(101)]
    public string? ThirdPartyName { get; set; }

    [StringLength(100)]
    public string? AccountName { get; set; }

    [Column("RepositoryID")]
    public int RepositoryId { get; set; }

    [StringLength(50)]
    public string? RepositoryName { get; set; }

    [Column("TenderID")]
    public int TenderId { get; set; }

    [StringLength(50)]
    public string? TenderName { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? Credit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Debit { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
