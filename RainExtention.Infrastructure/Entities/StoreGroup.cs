using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("StoreGroup")]
public partial class StoreGroup
{
    [Key]
    [Column("GroupID")]
    public Guid GroupId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("Groups")]
    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();

    [ForeignKey("GroupId")]
    [InverseProperty("Groups")]
    public virtual ICollection<AutomaticOrderPlan> Plans { get; set; } = new List<AutomaticOrderPlan>();

    [ForeignKey("GroupId")]
    [InverseProperty("Groups")]
    public virtual ICollection<SalePrice> Prices { get; set; } = new List<SalePrice>();

    [ForeignKey("StoreGroupId")]
    [InverseProperty("StoreGroups")]
    public virtual ICollection<PartialPaymentRule> Rules { get; set; } = new List<PartialPaymentRule>();
}
