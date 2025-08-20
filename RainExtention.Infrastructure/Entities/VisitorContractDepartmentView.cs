using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class VisitorContractDepartmentView
{
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedDailySale { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ComissionPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountComissionPercent { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }
}
