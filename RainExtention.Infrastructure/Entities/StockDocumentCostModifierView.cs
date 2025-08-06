using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class StockDocumentCostModifierView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [Column("ChangeAmountTypeID")]
    public int? ChangeAmountTypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    public bool? IsEffective { get; set; }

    [Column("CostCenterID")]
    public Guid? CostCenterId { get; set; }

    [StringLength(50)]
    public string? CostCenter { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? NetAmount { get; set; }

    public bool? IsTaxable { get; set; }

    public bool? IsPayable { get; set; }

    [Column("CurrencyID")]
    public int? CurrencyId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExchangeAmount { get; set; }

    public short? Priority { get; set; }

    [StringLength(50)]
    public string? ReasonName { get; set; }

    [StringLength(50)]
    public string? ChangeAmountType { get; set; }

    [StringLength(50)]
    public string? Currency { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
