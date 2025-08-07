using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class AutomaticOrderProposalLineItemView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [Column("SourceStockID")]
    public Guid? SourceStockId { get; set; }

    [Column("TargetStockID")]
    public Guid? TargetStockId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OrderQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BonusQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RequestQuantity { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [StringLength(50)]
    public string? TargetStockName { get; set; }

    [StringLength(50)]
    public string? SourceStockName { get; set; }

    [StringLength(101)]
    public string? SupplierName { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
