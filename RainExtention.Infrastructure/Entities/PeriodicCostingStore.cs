using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "Id", "StoreId")]
public partial class PeriodicCostingStore
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [ForeignKey("BookerStoreId, Id")]
    [InverseProperty("PeriodicCostingStores")]
    public virtual PeriodicCosting PeriodicCosting { get; set; } = null!;
}
