using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DocumentId", "StoreId", "StockId", "ItemId", "DocumentTypeId")]
[Table("ItemCardex")]
public partial class ItemCardex
{
    [Key]
    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [Key]
    [Column("StockID")]
    public Guid StockId { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Quantity { get; set; }

    [Key]
    [Column("DocumentTypeID")]
    public int DocumentTypeId { get; set; }
}
