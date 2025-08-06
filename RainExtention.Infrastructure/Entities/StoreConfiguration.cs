using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("StoreId", "ConfigId")]
[Table("StoreConfiguration")]
public partial class StoreConfiguration
{
    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [Key]
    [Column("ConfigID")]
    public int ConfigId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Caption { get; set; }

    public int? Type { get; set; }

    public string? Value { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("StoreConfigurations")]
    public virtual Store Store { get; set; } = null!;
}
