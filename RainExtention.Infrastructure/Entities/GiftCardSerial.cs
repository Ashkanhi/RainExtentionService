using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("GiftCardSerial")]
[Index("StatusId", Name = "IX_Status")]
public partial class GiftCardSerial
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Key]
    [StringLength(100)]
    public string SerialNumber { get; set; } = null!;

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalAmount { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [InverseProperty("SerialNumberNavigation")]
    public virtual ICollection<GiftCardSerialLog> GiftCardSerialLogs { get; set; } = new List<GiftCardSerialLog>();

    [ForeignKey("Id")]
    [InverseProperty("GiftCardSerials")]
    public virtual GiftCard? IdNavigation { get; set; }
}
