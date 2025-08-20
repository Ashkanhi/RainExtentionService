using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class AutomaticOrderPlanStoreAssignmentView
{
    [Column("PlanID")]
    public Guid PlanId { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    [StringLength(50)]
    public string? StoreName { get; set; }
}
