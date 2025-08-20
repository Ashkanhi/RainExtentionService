using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

public partial class Product
{
    [Key]
    [Column("ProductID")]
    public int ProductId { get; set; }

    [StringLength(100)]
    public string? ProductName { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Price { get; set; }
}
