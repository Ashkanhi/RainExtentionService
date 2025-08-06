using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "LineItemId")]
[Table("SupplierSaleLineItem")]
public partial class SupplierSaleLineItem
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [Column("ReferStoreID")]
    public int? ReferStoreId { get; set; }

    [Column("ReferWorkstationID")]
    public int? ReferWorkstationId { get; set; }

    [Column("ReferDocumentID")]
    public Guid? ReferDocumentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedDate { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("SupplierSaleLineItems")]
    public virtual SupplierSale IdNavigation { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("SupplierSaleLineItems")]
    public virtual Item? Item { get; set; }

    [ForeignKey("ReferStoreId, ReferWorkstationId, ReferDocumentId")]
    [InverseProperty("SupplierSaleLineItems")]
    public virtual StockDocument? StockDocument { get; set; }
}
