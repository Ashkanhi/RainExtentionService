using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ContractId", "StoreId")]
public partial class SupplierContractStore
{
    [Key]
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("SupplierContractStores")]
    public virtual SupplierContract Contract { get; set; } = null!;
}
