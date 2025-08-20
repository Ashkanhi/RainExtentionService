using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("TaskCategory")]
public partial class TaskCategory
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    public byte[]? Icon { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
