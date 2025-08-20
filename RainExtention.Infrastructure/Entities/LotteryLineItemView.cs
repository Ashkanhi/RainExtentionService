using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class LotteryLineItemView
{
    [Column("LotteryID")]
    public Guid LotteryId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [StringLength(50)]
    public string? TickectNumber { get; set; }

    [StringLength(152)]
    public string? CustomerName { get; set; }

    [StringLength(50)]
    public string? CustomerCode { get; set; }

    [StringLength(15)]
    public string? Mobile { get; set; }

    [StringLength(15)]
    public string? Telephone { get; set; }

    [StringLength(255)]
    public string? EmailAddress { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
