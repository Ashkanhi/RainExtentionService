using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class VisitorContractView
{
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

    [StringLength(101)]
    public string VisitorName { get; set; } = null!;

    [StringLength(101)]
    public string? ParentName { get; set; }

    [StringLength(50)]
    public string? CreationUserName { get; set; }

    [StringLength(50)]
    public string? ApproveUserName { get; set; }

    [StringLength(50)]
    public string? VoidUserName { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
