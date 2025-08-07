using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class AutomaticOrderPlanDepartmentAssignmentView
{
    [Column("PlanID")]
    public Guid PlanId { get; set; }

    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }
}
