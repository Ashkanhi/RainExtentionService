using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("CustomerCreditHistory")]
[Index("CustomerId", Name = "IX_CustomerID")]
[Index("DocumentId", Name = "IX_DocumentID")]
[Index("IsTemporary", Name = "IX_IsTemporary")]
[Index("EffectiveTime", "ExpireTime", Name = "IX_Time")]
public partial class CustomerCreditHistory
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveTime { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ModifyCredit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentCredit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ModifyRemain { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RemainCredit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? UsePoint { get; set; }

    [Column("CustomerGroupID")]
    public Guid? CustomerGroupId { get; set; }

    [Column("UserID")]
    public Guid? UserId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AcceptPoint { get; set; }

    [Column("DocumentID")]
    public Guid? DocumentId { get; set; }

    [StringLength(10)]
    public string? DocumentCode { get; set; }

    public bool? IsTemporary { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireTime { get; set; }

    [Column("ReferStoreID")]
    public int? ReferStoreId { get; set; }

    [Column("ReferWorkstationID")]
    public int? ReferWorkstationId { get; set; }

    [Column("ReferInvoiceID")]
    public Guid? ReferInvoiceId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("CustomerCreditHistories")]
    public virtual Customer? Customer { get; set; }
}
