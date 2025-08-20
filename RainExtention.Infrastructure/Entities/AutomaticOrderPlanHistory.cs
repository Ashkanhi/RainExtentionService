using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("AutomaticOrderPlanHistory")]
public partial class AutomaticOrderPlanHistory
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("PlanID")]
    public Guid? PlanId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [ForeignKey("PlanId")]
    [InverseProperty("AutomaticOrderPlanHistories")]
    public virtual AutomaticOrderPlan? Plan { get; set; }
}
