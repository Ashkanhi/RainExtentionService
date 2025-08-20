using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("CashLoan")]
public partial class CashLoan
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [Column("WorkstationID")]
    public int? WorkstationId { get; set; }

    [Column("UserID")]
    public Guid? UserId { get; set; }

    [Column("TenderID")]
    public int? TenderId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LoanDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExchangeAmount { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [ForeignKey("ReasonId")]
    [InverseProperty("CashLoans")]
    public virtual Reason? Reason { get; set; }

    [ForeignKey("TenderId")]
    [InverseProperty("CashLoans")]
    public virtual Tender? Tender { get; set; }

    [ForeignKey("TypeId")]
    [InverseProperty("CashLoans")]
    public virtual Dictionary? Type { get; set; }

    [ForeignKey("StoreId, WorkstationId")]
    [InverseProperty("CashLoans")]
    public virtual Workstation? Workstation { get; set; }
}
