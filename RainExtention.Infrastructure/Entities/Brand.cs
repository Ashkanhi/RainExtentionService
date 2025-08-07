using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Brand")]
public partial class Brand
{
    [Key]
    [Column("BrandID")]
    public Guid BrandId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    public byte[]? BrandImage { get; set; }

    [InverseProperty("Brand")]
    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
