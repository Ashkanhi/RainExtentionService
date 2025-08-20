using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class QualityControlTaskDepartmentView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }
}
