using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "Id")]
[Table("StockDocumentPayment")]
[Index("TenderId", Name = "IX_Tender")]
[Index("TypeId", Name = "IX_Type")]
public partial class StockDocumentPayment
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
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("TenderID")]
    public int? TenderId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId")]
    [InverseProperty("StockDocumentPayments")]
    public virtual StockDocument StockDocument { get; set; } = null!;

    [ForeignKey("TenderId")]
    [InverseProperty("StockDocumentPayments")]
    public virtual Tender? Tender { get; set; }
}
