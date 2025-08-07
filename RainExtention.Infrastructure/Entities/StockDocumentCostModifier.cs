using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("StockDocumentCostModifier")]
public partial class StockDocumentCostModifier
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [Key]
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

    [ForeignKey("ChangeAmountTypeId")]
    [InverseProperty("StockDocumentCostModifiers")]
    public virtual Dictionary? ChangeAmountType { get; set; }

    [ForeignKey("ReasonId")]
    [InverseProperty("StockDocumentCostModifiers")]
    public virtual Reason? Reason { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId")]
    [InverseProperty("StockDocumentCostModifiers")]
    public virtual StockDocument StockDocument { get; set; } = null!;

    [InverseProperty("StockDocumentCostModifier")]
    public virtual StockDocumentCostModifierReference? StockDocumentCostModifierReference { get; set; }
}
