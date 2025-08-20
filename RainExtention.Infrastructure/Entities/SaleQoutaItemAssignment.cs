using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("QoutaId", "ItemId")]
[Table("SaleQoutaItemAssignment")]
public partial class SaleQoutaItemAssignment
{
    [Key]
    [Column("QoutaID")]
    public Guid QoutaId { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxAmount { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("SaleQoutaItemAssignments")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("QoutaId")]
    [InverseProperty("SaleQoutaItemAssignments")]
    public virtual SaleQoutum Qouta { get; set; } = null!;
}
