using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ProductionOrderCustomField")]
public partial class ProductionOrderCustomField
{
    [Key]
    [Column("OrderID")]
    public Guid OrderId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("ProductionOrderCustomField")]
    public virtual ProductionOrder Order { get; set; } = null!;
}
