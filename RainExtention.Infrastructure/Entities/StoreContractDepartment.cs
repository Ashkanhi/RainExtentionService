using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ContractId", "LineItemId")]
public partial class StoreContractDepartment
{
    [Key]
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ComissionPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountComissionPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedDailySale { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("StoreContractDepartments")]
    public virtual StoreContract Contract { get; set; } = null!;

    [ForeignKey("DepartmentId")]
    [InverseProperty("StoreContractDepartments")]
    public virtual Department? Department { get; set; }
}
