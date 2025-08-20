using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SystemConfiguration")]
public partial class SystemConfiguration
{
    [Key]
    [Column("ConfigID")]
    public int ConfigId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public short? Type { get; set; }

    public string? Value { get; set; }

    [StringLength(50)]
    public string? Caption { get; set; }
}
