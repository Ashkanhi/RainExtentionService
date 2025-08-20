using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ItemTag")]
public partial class ItemTag
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [ForeignKey("TagId")]
    [InverseProperty("Tags")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    [ForeignKey("TagId")]
    [InverseProperty("Tags")]
    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
