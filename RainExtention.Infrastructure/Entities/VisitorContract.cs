using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("VisitorContract")]
public partial class VisitorContract
{
    [Key]
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [StringLength(50)]
    public string? ContractNumber { get; set; }

    [Column("VisitorID")]
    public Guid? VisitorId { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedDailySale { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ComissionPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountComissionPercent { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    public Guid? VoidUser { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [ForeignKey("ParentId")]
    [InverseProperty("VisitorContractParents")]
    public virtual Visitor? Parent { get; set; }

    [ForeignKey("VisitorId")]
    [InverseProperty("VisitorContractVisitors")]
    public virtual Visitor? Visitor { get; set; }

    [InverseProperty("Contract")]
    public virtual ICollection<VisitorContractDepartment> VisitorContractDepartments { get; set; } = new List<VisitorContractDepartment>();

    [InverseProperty("Contract")]
    public virtual ICollection<VisitorContractStore> VisitorContractStores { get; set; } = new List<VisitorContractStore>();
}
