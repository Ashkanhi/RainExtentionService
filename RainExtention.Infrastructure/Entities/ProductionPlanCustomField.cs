using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ProductionPlanCustomField")]
public partial class ProductionPlanCustomField
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("ProductionPlanCustomField")]
    public virtual ProductionPlan IdNavigation { get; set; } = null!;
}
