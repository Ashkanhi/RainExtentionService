using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class LoyalityContractCustomerAssignmentView
{
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PercentAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CreditAmount { get; set; }

    [StringLength(152)]
    public string? CustomerName { get; set; }

    [StringLength(50)]
    public string? CustomerCode { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
