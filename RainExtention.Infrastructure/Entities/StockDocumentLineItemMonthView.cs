using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class StockDocumentLineItemMonthView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("MonthID")]
    public int MonthId { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Quantity { get; set; }

    [StringLength(50)]
    public string? Month { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
