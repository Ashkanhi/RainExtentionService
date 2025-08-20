using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "LineItemId")]
[Table("QualityControlTaskItem")]
public partial class QualityControlTaskItem
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AcceptResult { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("QualityControlTaskItems")]
    public virtual QualityControlTask IdNavigation { get; set; } = null!;

    [InverseProperty("QualityControlTaskItem")]
    public virtual ICollection<QualityControlResult> QualityControlResults { get; set; } = new List<QualityControlResult>();
}
