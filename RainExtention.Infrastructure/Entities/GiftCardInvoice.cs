using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("GiftCardInvoice")]
public partial class GiftCardInvoice
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ThirdPartyID")]
    public Guid? ThirdPartyId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    [StringLength(50)]
    public string? InvoiceNumber { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountAmount { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("GiftCardInvoice")]
    public virtual GiftCard IdNavigation { get; set; } = null!;
}
