using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "Id")]
[Table("PeriodicCosting")]
public partial class PeriodicCosting
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    [ForeignKey("BookerStoreId")]
    [InverseProperty("PeriodicCostings")]
    public virtual Store BookerStore { get; set; } = null!;

    [ForeignKey("CreationUser")]
    [InverseProperty("PeriodicCostings")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("PeriodicCosting")]
    public virtual ICollection<PeriodicCostingExtend> PeriodicCostingExtends { get; set; } = new List<PeriodicCostingExtend>();

    [InverseProperty("PeriodicCosting")]
    public virtual ICollection<PeriodicCostingItem> PeriodicCostingItems { get; set; } = new List<PeriodicCostingItem>();

    [InverseProperty("PeriodicCosting")]
    public virtual ICollection<PeriodicCostingStore> PeriodicCostingStores { get; set; } = new List<PeriodicCostingStore>();
}
