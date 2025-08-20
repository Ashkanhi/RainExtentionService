using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "SettelmentId", "TenderId")]
[Table("CashSettelmentLineItem")]
public partial class CashSettelmentLineItem
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("SettelmentID")]
    public Guid SettelmentId { get; set; }

    [Key]
    [Column("TenderID")]
    public int TenderId { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? ExpectedAmount { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? RegisterAmount { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? LastModifyAmount { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, SettelmentId")]
    [InverseProperty("CashSettelmentLineItems")]
    public virtual CashSettelment CashSettelment { get; set; } = null!;

    [ForeignKey("TenderId")]
    [InverseProperty("CashSettelmentLineItems")]
    public virtual Tender Tender { get; set; } = null!;
}
