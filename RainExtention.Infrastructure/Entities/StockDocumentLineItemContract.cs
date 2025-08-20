using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("StockDocumentLineItemContract")]
public partial class StockDocumentLineItemContract
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

    [Column("ContractID")]
    public Guid? ContractId { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId, LineItemId")]
    [InverseProperty("StockDocumentLineItemContract")]
    public virtual StockDocumentLineItem StockDocumentLineItem { get; set; } = null!;
}
