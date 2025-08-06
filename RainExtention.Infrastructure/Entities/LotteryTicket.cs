using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("LotteryTicket")]
public partial class LotteryTicket
{
    [Key]
    [Column("TicketID")]
    public Guid TicketId { get; set; }

    [Column("BookerStoreID")]
    public int? BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int? BookerWorkstationId { get; set; }

    [Column("InvoiceID")]
    public Guid? InvoiceId { get; set; }

    [StringLength(50)]
    public string? TicketNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TicketDate { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [Column("LotteryID")]
    public Guid? LotteryId { get; set; }
}
