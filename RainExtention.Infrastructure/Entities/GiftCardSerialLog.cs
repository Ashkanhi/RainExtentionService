using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("GiftCardSerialLog")]
public partial class GiftCardSerialLog
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("GiftCardID")]
    public Guid? GiftCardId { get; set; }

    [StringLength(100)]
    public string? SerialNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [Column("UserID")]
    public Guid? UserId { get; set; }

    [ForeignKey("SerialNumber")]
    [InverseProperty("GiftCardSerialLogs")]
    public virtual GiftCardSerial? SerialNumberNavigation { get; set; }
}
