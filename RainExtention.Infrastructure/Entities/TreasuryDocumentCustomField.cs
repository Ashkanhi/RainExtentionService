using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId")]
[Table("TreasuryDocumentCustomField")]
public partial class TreasuryDocumentCustomField
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

    [StringLength(50)]
    public string? Reserve1 { get; set; }

    [StringLength(50)]
    public string? Reserve2 { get; set; }

    [StringLength(50)]
    public string? Reserve3 { get; set; }

    [StringLength(50)]
    public string? Reserve4 { get; set; }

    [StringLength(50)]
    public string? Reserve5 { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId")]
    [InverseProperty("TreasuryDocumentCustomField")]
    public virtual TreasuryDocument TreasuryDocument { get; set; } = null!;
}
