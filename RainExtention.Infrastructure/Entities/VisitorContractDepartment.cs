using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ContractId", "DepartmentId")]
[Table("VisitorContractDepartment")]
public partial class VisitorContractDepartment
{
    [Key]
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Key]
    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedDailySale { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ComissionPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountComissionPercent { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("VisitorContractDepartments")]
    public virtual VisitorContract Contract { get; set; } = null!;
}
