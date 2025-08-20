using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "LineItemId")]
[Table("ImportDataItem")]
public partial class ImportDataItem
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [StringLength(50)]
    public string? Section { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("ImportDataItems")]
    public virtual ImportDatum IdNavigation { get; set; } = null!;
}
