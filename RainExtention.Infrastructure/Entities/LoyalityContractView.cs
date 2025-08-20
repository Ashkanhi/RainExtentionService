using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class LoyalityContractView
{
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    public int? ActiveDay { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CreditAmount { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(152)]
    public string? CustomerName { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
