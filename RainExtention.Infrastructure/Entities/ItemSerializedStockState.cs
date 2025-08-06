using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "SerialNumber")]
[Table("ItemSerializedStockState")]
public partial class ItemSerializedStockState
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [StringLength(50)]
    public string SerialNumber { get; set; } = null!;

    [Column("StockID")]
    public Guid? StockId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegisterDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GuarantyDate { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemSerializedStockStates")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("ItemSerializedStockStates")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("StockId")]
    [InverseProperty("ItemSerializedStockStates")]
    public virtual Stock? Stock { get; set; }
}
