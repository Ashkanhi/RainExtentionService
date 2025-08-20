using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ContractId", "StoreId")]
[Table("VisitorContractStore")]
public partial class VisitorContractStore
{
    [Key]
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("VisitorContractStores")]
    public virtual VisitorContract Contract { get; set; } = null!;
}
