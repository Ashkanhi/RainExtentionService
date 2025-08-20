using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class UvTaxInvoiceOld
{
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedAmount { get; set; }

    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("vra", TypeName = "decimal(19, 3)")]
    public decimal? Vra { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManualDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PriceAmount { get; set; }

    [Column(TypeName = "decimal(19, 3)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(20, 3)")]
    public decimal? TotalDiscount { get; set; }

    [Column(TypeName = "decimal(38, 18)")]
    public decimal? TotalDiscountPerLine { get; set; }

    [Column(TypeName = "decimal(38, 11)")]
    public decimal? TotalDiscountPercent { get; set; }

    [Column("vop")]
    public int Vop { get; set; }

    [Column("fee", TypeName = "decimal(18, 8)")]
    public decimal? Fee { get; set; }

    [Column("dis", TypeName = "decimal(38, 0)")]
    public decimal? Dis { get; set; }

    [Column("adis", TypeName = "decimal(38, 0)")]
    public decimal? Adis { get; set; }

    [Column("vam", TypeName = "decimal(38, 0)")]
    public decimal? Vam { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? NewPayAmount { get; set; }
}
