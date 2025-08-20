using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SupplierSaleLineItemView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [Column("ReferStoreID")]
    public int? ReferStoreId { get; set; }

    [Column("ReferWorkstationID")]
    public int? ReferWorkstationId { get; set; }

    [Column("ReferDocumentID")]
    public Guid? ReferDocumentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedDate { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    [StringLength(101)]
    public string? SupplierName { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
