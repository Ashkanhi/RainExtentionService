using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId")]
[Table("SaleInvoiceInfo")]
[Index("OrderCode", Name = "IX_OrderCode")]
public partial class SaleInvoiceInfo
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [StringLength(20)]
    public string? DailyInvoiceNumber { get; set; }

    [Column("TableID")]
    public Guid? TableId { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [StringLength(255)]
    public string? Description { get; set; }

    [StringLength(20)]
    public string? OrderCode { get; set; }

    public short? OrderState { get; set; }

    [StringLength(20)]
    public string? DoctorCode { get; set; }

    [StringLength(100)]
    public string? DoctorName { get; set; }

    [StringLength(100)]
    public string? DoctorExpertise { get; set; }

    public bool? IsDoctorExpertise { get; set; }

    public DateOnly? VisitDate { get; set; }

    [ForeignKey("ReasonId")]
    [InverseProperty("SaleInvoiceInfos")]
    public virtual Reason? Reason { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId")]
    [InverseProperty("SaleInvoiceInfo")]
    public virtual SaleInvoice SaleInvoice { get; set; } = null!;

    [ForeignKey("TableId")]
    [InverseProperty("SaleInvoiceInfos")]
    public virtual TableManagement? Table { get; set; }
}
