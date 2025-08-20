using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("LotteryId", "LineItemId")]
[Table("LotteryLineItem")]
public partial class LotteryLineItem
{
    [Key]
    [Column("LotteryID")]
    public Guid LotteryId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [StringLength(50)]
    public string? TickectNumber { get; set; }

    [ForeignKey("LotteryId")]
    [InverseProperty("LotteryLineItems")]
    public virtual Lottery Lottery { get; set; } = null!;
}
