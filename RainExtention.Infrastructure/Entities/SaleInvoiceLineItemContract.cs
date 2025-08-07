using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId", "ContractId")]
[Table("SaleInvoiceLineItemContract")]
public partial class SaleInvoiceLineItemContract
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

    [Key]
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("SaleInvoiceLineItemContracts")]
    public virtual SupplierContract Contract { get; set; } = null!;

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId, LineItemId")]
    [InverseProperty("SaleInvoiceLineItemContracts")]
    public virtual SaleInvoiceLineItem SaleInvoiceLineItem { get; set; } = null!;
}
