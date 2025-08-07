using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId", "AttributeId", "Id")]
[Table("StockDocumentLineItemAttribute")]
public partial class StockDocumentLineItemAttribute
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

    [Key]
    [Column("AttributeID")]
    public Guid AttributeId { get; set; }

    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Quantity { get; set; }

    [ForeignKey("AttributeId, Id")]
    [InverseProperty("StockDocumentLineItemAttributes")]
    public virtual AttributeValue AttributeValue { get; set; } = null!;
}
