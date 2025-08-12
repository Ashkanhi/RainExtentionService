using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId")]
[Table("SaleInvoice")]
[Index("BusinessDate", Name = "IX_BusinessDate")]
[Index("CreationUser", Name = "IX_CreationUser")]
[Index("CustomerId", Name = "IX_Customer")]
[Index("InvoiceDate", Name = "IX_InvoiceDate")]
[Index("InvoiceNumber", Name = "IX_InvoiceNumber")]
[Index("InvoiceTypeId", Name = "IX_InvoiceType")]
[Index("IsOnlineSale", Name = "IX_IsOnlineSale")]
[Index("SaleChannelId", Name = "IX_SaleChannel")]
public partial class SaleInvoice
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    public DateOnly? BusinessDate { get; set; }

    [StringLength(50)]
    public string? InvoiceNumber { get; set; }

    [Column("InvoiceTypeID")]
    public int? InvoiceTypeId { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedAmount { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? AuthorizeUser { get; set; }

    public bool? IsOnlineSale { get; set; }

    public int? ScanCount { get; set; }

    [Precision(3)]
    public TimeOnly? InvoiceTime { get; set; }

    [Column("SaleChannelID")]
    public int? SaleChannelId { get; set; }

    [Column("StockID")]
    public Guid? StockId { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("SaleInvoiceCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("SaleInvoices")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("InvoiceTypeId")]
    [InverseProperty("SaleInvoices")]
    public virtual Dictionary? InvoiceType { get; set; }

    [ForeignKey("ModifyUser")]
    [InverseProperty("SaleInvoiceModifyUserNavigations")]
    public virtual User? ModifyUserNavigation { get; set; }

    [InverseProperty("SaleInvoice")]
    public virtual SaleInvoiceCustomDiscount? SaleInvoiceCustomDiscount { get; set; }

    [InverseProperty("SaleInvoice")]
    public virtual SaleInvoiceCustomField? SaleInvoiceCustomField { get; set; }

    [InverseProperty("SaleInvoice")]
    public virtual SaleInvoiceInfo? SaleInvoiceInfo { get; set; }

    [InverseProperty("SaleInvoice")]
    public virtual ICollection<SaleInvoiceLineItem> SaleInvoiceLineItems { get; set; } = new List<SaleInvoiceLineItem>();

    [InverseProperty("SaleInvoice")]
    public virtual SaleInvoiceLoyality? SaleInvoiceLoyality { get; set; }

    [InverseProperty("SaleInvoice")]
    public virtual ICollection<SaleInvoicePartialPayment> SaleInvoicePartialPayments { get; set; } = new List<SaleInvoicePartialPayment>();

    [InverseProperty("SaleInvoice")]
    public virtual ICollection<SaleInvoiceService> SaleInvoiceServices { get; set; } = new List<SaleInvoiceService>();

    [InverseProperty("SaleInvoice")]
    public virtual ICollection<SaleInvoiceTaxReference> SaleInvoiceTaxReferences { get; set; } = new List<SaleInvoiceTaxReference>();

    [InverseProperty("SaleInvoice")]
    public virtual ICollection<SaleInvoiceTender> SaleInvoiceTenders { get; set; } = new List<SaleInvoiceTender>();

    [InverseProperty("SaleInvoice")]
    public virtual ICollection<SaleItemDelivery> SaleItemDeliveries { get; set; } = new List<SaleItemDelivery>();

    [ForeignKey("StockId")]
    [InverseProperty("SaleInvoices")]
    public virtual Stock? Stock { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId")]
    [InverseProperty("SaleInvoices")]
    public virtual Workstation Workstation { get; set; } = null!;

}
