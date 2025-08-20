using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "LineItemId")]
[Table("TaskEntityAssignment")]
public partial class TaskEntityAssignment
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("EntityTypeID")]
    public int? EntityTypeId { get; set; }

    [Column("EntityID")]
    [StringLength(50)]
    public string? EntityId { get; set; }

    [StringLength(100)]
    public string? Caption { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("TaskEntityAssignments")]
    public virtual Task IdNavigation { get; set; } = null!;
}
