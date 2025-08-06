using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PlanId", "ItemId")]
[Table("AutomaticOrderPlanItemAssignment")]
public partial class AutomaticOrderPlanItemAssignment
{
    [Key]
    [Column("PlanID")]
    public Guid PlanId { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [InverseProperty("AutomaticOrderPlanItemAssignment")]
    public virtual ICollection<AutomaticOrderPlanItemEvent> AutomaticOrderPlanItemEvents { get; set; } = new List<AutomaticOrderPlanItemEvent>();

    [ForeignKey("ItemId")]
    [InverseProperty("AutomaticOrderPlanItemAssignments")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("PlanId")]
    [InverseProperty("AutomaticOrderPlanItemAssignments")]
    public virtual AutomaticOrderPlan Plan { get; set; } = null!;
}
