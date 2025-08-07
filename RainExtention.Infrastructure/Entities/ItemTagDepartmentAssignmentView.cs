using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemTagDepartmentAssignmentView
{
    [Column("TagID")]
    public Guid TagId { get; set; }

    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }
}
