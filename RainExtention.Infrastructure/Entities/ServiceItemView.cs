using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ServiceItemView
{
    public Guid ServiceId { get; set; }

    [StringLength(50)]
    public string? ServiceName { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? BasePrice { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }
}
