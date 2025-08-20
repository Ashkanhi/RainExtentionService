using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ContractId", "CustomerId")]
[Table("LoyalityContractCustomerAssignment")]
public partial class LoyalityContractCustomerAssignment
{
    [Key]
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Key]
    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PercentAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CreditAmount { get; set; }
}
