using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Tender")]
public partial class Tender
{
    [Key]
    [Column("TenderID")]
    public int TenderId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column("TenderTypeID")]
    public int? TenderTypeId { get; set; }

    [Column("ActionTypeID")]
    public int? ActionTypeId { get; set; }

    [Column("RepositoryID")]
    public int? RepositoryId { get; set; }

    public bool? IsPrintable { get; set; }

    [StringLength(50)]
    public string? LayoutFile { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    public bool? IsOnline { get; set; }

    public string? ConnectionInfo { get; set; }

    public byte[]? TenderImage { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("CurrencyID")]
    public int? CurrencyId { get; set; }

    [ForeignKey("ActionTypeId")]
    [InverseProperty("TenderActionTypes")]
    public virtual Dictionary? ActionType { get; set; }

    [InverseProperty("Tender")]
    public virtual ICollection<CashLoan> CashLoans { get; set; } = new List<CashLoan>();

    [InverseProperty("Tender")]
    public virtual ICollection<CashSettelmentLineItem> CashSettelmentLineItems { get; set; } = new List<CashSettelmentLineItem>();

    [ForeignKey("CurrencyId")]
    [InverseProperty("Tenders")]
    public virtual Currency? Currency { get; set; }

    [ForeignKey("DetailAccountId")]
    [InverseProperty("Tenders")]
    public virtual DetailAccount? DetailAccount { get; set; }

    [ForeignKey("RepositoryId")]
    [InverseProperty("Tenders")]
    public virtual Repository? Repository { get; set; }

    [InverseProperty("Tender")]
    public virtual ICollection<SaleInvoiceTender> SaleInvoiceTenders { get; set; } = new List<SaleInvoiceTender>();

    [InverseProperty("Tender")]
    public virtual ICollection<StockDocumentPayment> StockDocumentPayments { get; set; } = new List<StockDocumentPayment>();

    [InverseProperty("Tender")]
    public virtual ICollection<TenderConfiguration> TenderConfigurations { get; set; } = new List<TenderConfiguration>();

    [ForeignKey("TenderTypeId")]
    [InverseProperty("TenderTenderTypes")]
    public virtual Dictionary? TenderType { get; set; }

    [InverseProperty("Tender")]
    public virtual ICollection<TreasuryDocumentLineItem> TreasuryDocumentLineItems { get; set; } = new List<TreasuryDocumentLineItem>();

    [ForeignKey("TenderId")]
    [InverseProperty("Tenders")]
    public virtual ICollection<UserGroup> Groups { get; set; } = new List<UserGroup>();

    [ForeignKey("TenderId")]
    [InverseProperty("Tenders")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
