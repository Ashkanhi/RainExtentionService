using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ItemBarcode")]
[Index("ItemId", Name = "IX_Item")]
[Index("Barcode", "ItemId", Name = "IX_ItemAndBarcode")]
[Index("Barcode", Name = "IX_ItemBarcode", IsUnique = true)]
public partial class ItemBarcode
{
    [Key]
    [Column("BarcodeID")]
    public Guid BarcodeId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    public bool? IsDefault { get; set; }

    public int? OrderNo { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemBarcodes")]
    public virtual Item? Item { get; set; }
}
