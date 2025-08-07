using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "LineItemId", "ReferDocumentId", "ReferLineItemId")]
[Table("QualityControlResult")]
public partial class QualityControlResult
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Key]
    [Column("ReferDocumentID")]
    public Guid ReferDocumentId { get; set; }

    [Key]
    [Column("ReferLineItemID")]
    public Guid ReferLineItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Result { get; set; }

    public bool? Passed { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [Column("CatalogID")]
    public Guid? CatalogId { get; set; }

    [ForeignKey("ReferDocumentId, ReferLineItemId")]
    [InverseProperty("QualityControlResults")]
    public virtual ProductionDocumentLineItem ProductionDocumentLineItem { get; set; } = null!;

    [ForeignKey("Id, LineItemId")]
    [InverseProperty("QualityControlResults")]
    public virtual QualityControlTaskItem QualityControlTaskItem { get; set; } = null!;
}
