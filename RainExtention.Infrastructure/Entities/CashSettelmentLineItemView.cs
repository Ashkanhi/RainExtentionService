using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CashSettelmentLineItemView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("SettelmentID")]
    public Guid SettelmentId { get; set; }

    [Column("TenderID")]
    public int TenderId { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? ExpectedAmount { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? RegisterAmount { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? LastModifyAmount { get; set; }

    [StringLength(50)]
    public string? TenderName { get; set; }

    [Column("TenderTypeID")]
    public int? TenderTypeId { get; set; }
}
