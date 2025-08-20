using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PlanId", "DepartmentId", "EventId")]
[Table("AutomaticOrderPlanDepartmentEvent")]
public partial class AutomaticOrderPlanDepartmentEvent
{
    [Key]
    [Column("PlanID")]
    public Guid PlanId { get; set; }

    [Key]
    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [Key]
    [Column("EventID")]
    public Guid EventId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OrderFactor { get; set; }

    [ForeignKey("PlanId, DepartmentId")]
    [InverseProperty("AutomaticOrderPlanDepartmentEvents")]
    public virtual AutomaticOrderPlanDepartmentAssignment AutomaticOrderPlanDepartmentAssignment { get; set; } = null!;

    [ForeignKey("DepartmentId")]
    [InverseProperty("AutomaticOrderPlanDepartmentEvents")]
    public virtual Department Department { get; set; } = null!;
}
