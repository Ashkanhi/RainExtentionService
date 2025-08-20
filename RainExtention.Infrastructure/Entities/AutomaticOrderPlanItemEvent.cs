using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PlanId", "ItemId", "EventId")]
[Table("AutomaticOrderPlanItemEvent")]
public partial class AutomaticOrderPlanItemEvent
{
    [Key]
    [Column("PlanID")]
    public Guid PlanId { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("EventID")]
    public Guid EventId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OrderFactor { get; set; }

    [ForeignKey("PlanId, ItemId")]
    [InverseProperty("AutomaticOrderPlanItemEvents")]
    public virtual AutomaticOrderPlanItemAssignment AutomaticOrderPlanItemAssignment { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("AutomaticOrderPlanItemEvents")]
    public virtual Item Item { get; set; } = null!;
}
