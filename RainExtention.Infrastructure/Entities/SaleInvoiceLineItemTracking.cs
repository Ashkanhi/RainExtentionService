using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId")]
[Table("SaleInvoiceLineItemTracking")]
public partial class SaleInvoiceLineItemTracking
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

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [StringLength(50)]
    public string? Barcode { get; set; }

    [StringLength(50)]
    public string? SerialNumber { get; set; }

    [StringLength(50)]
    public string? BatchNumber { get; set; }

    [Column("StockID")]
    public Guid? StockId { get; set; }

    [StringLength(50)]
    public string? DrugForm { get; set; }

    [StringLength(200)]
    public string? DrugInstructions { get; set; }

    public bool? InsuranceStatus { get; set; }

    public bool? IsInDoctorSpeciality { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId, LineItemId")]
    [InverseProperty("SaleInvoiceLineItemTracking")]
    public virtual SaleInvoiceLineItem SaleInvoiceLineItem { get; set; } = null!;

    [ForeignKey("StockId")]
    [InverseProperty("SaleInvoiceLineItemTrackings")]
    public virtual Stock? Stock { get; set; }
}
