using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "ItemId")]
[Table("StoreDailyTurnOverLineItem")]
public partial class StoreDailyTurnOverLineItem
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column("ContractID")]
    public Guid? ContractId { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("StoreDailyTurnOverLineItems")]
    public virtual SupplierContract? Contract { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("StoreDailyTurnOverLineItems")]
    public virtual StoreDailyTurnOver IdNavigation { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("StoreDailyTurnOverLineItems")]
    public virtual Item Item { get; set; } = null!;
}
