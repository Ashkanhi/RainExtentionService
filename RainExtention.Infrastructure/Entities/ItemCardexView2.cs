using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemCardexView2
{
    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    [Column("StockID")]
    public Guid? StockId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Quantity { get; set; }

    [Column("DocumentTypeID")]
    public int? DocumentTypeId { get; set; }
}
