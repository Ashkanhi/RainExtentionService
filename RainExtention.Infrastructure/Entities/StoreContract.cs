using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("StoreContract")]
public partial class StoreContract
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(100)]
    public string? Title { get; set; }

    [Column("ContractTypeID")]
    public int? ContractTypeId { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ComissionPercent { get; set; }

    public string? Description { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationTime { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveTime { get; set; }

    public Guid? VoidUser { get; set; }

    public DateOnly? VoidDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountComissionPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedDailySale { get; set; }

    [Column("ManagerID")]
    public Guid? ManagerId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? StockValueCredit { get; set; }

    [ForeignKey("ApproveUser")]
    [InverseProperty("StoreContractApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [ForeignKey("ContractTypeId")]
    [InverseProperty("StoreContractContractTypes")]
    public virtual Dictionary? ContractType { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("StoreContractCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("StoreContractStatuses")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("StoreContracts")]
    public virtual Store? Store { get; set; }

    [InverseProperty("Contract")]
    public virtual ICollection<StoreContractDepartment> StoreContractDepartments { get; set; } = new List<StoreContractDepartment>();

    [ForeignKey("VoidUser")]
    [InverseProperty("StoreContractVoidUserNavigations")]
    public virtual User? VoidUserNavigation { get; set; }
}
