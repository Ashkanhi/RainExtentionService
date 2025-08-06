using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ItemAttributeTemplate")]
public partial class ItemAttributeTemplate
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public string? Attributes { get; set; }

    public string? NameTemplate { get; set; }

    public string? BarcodeTemplate { get; set; }
}
