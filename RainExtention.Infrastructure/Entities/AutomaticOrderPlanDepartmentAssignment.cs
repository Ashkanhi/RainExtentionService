using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PlanId", "DepartmentId")]
[Table("AutomaticOrderPlanDepartmentAssignment")]
public partial class AutomaticOrderPlanDepartmentAssignment
{
    [Key]
    [Column("PlanID")]
    public Guid PlanId { get; set; }

    [Key]
    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [InverseProperty("AutomaticOrderPlanDepartmentAssignment")]
    public virtual ICollection<AutomaticOrderPlanDepartmentEvent> AutomaticOrderPlanDepartmentEvents { get; set; } = new List<AutomaticOrderPlanDepartmentEvent>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("AutomaticOrderPlanDepartmentAssignments")]
    public virtual Department Department { get; set; } = null!;

    [ForeignKey("PlanId")]
    [InverseProperty("AutomaticOrderPlanDepartmentAssignments")]
    public virtual AutomaticOrderPlan Plan { get; set; } = null!;
}
