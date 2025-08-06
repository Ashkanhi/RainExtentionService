using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemCardexView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    [Column("SecondStockID")]
    public Guid? SecondStockId { get; set; }

    [Column("StockID")]
    public Guid? StockId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Price { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? UnitCost { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [Column("DocumentTypeID")]
    public int? DocumentTypeId { get; set; }

    [Column("ThirdPartyID")]
    public Guid? ThirdPartyId { get; set; }

    [StringLength(101)]
    public string? EntityName { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
