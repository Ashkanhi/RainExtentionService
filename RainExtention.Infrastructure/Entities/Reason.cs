using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Reason")]
public partial class Reason
{
    [Key]
    [Column("ReasonID")]
    public int ReasonId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("AccountID")]
    public Guid? AccountId { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    [Column("ActionTypeID")]
    public int? ActionTypeId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public short? Priority { get; set; }

    [InverseProperty("Reason")]
    public virtual ICollection<CashLoan> CashLoans { get; set; } = new List<CashLoan>();

    [InverseProperty("Reason")]
    public virtual ICollection<PeriodicCostingExtend> PeriodicCostingExtends { get; set; } = new List<PeriodicCostingExtend>();

    [InverseProperty("Reason")]
    public virtual ICollection<SaleInvoiceInfo> SaleInvoiceInfos { get; set; } = new List<SaleInvoiceInfo>();

    [InverseProperty("Reason")]
    public virtual ICollection<SaleInvoiceLineItem> SaleInvoiceLineItems { get; set; } = new List<SaleInvoiceLineItem>();

    [InverseProperty("Reason")]
    public virtual ICollection<StockDocumentCostModifier> StockDocumentCostModifiers { get; set; } = new List<StockDocumentCostModifier>();

    [InverseProperty("Reason")]
    public virtual ICollection<TreasuryDocument> TreasuryDocuments { get; set; } = new List<TreasuryDocument>();

    [ForeignKey("TypeId")]
    [InverseProperty("Reasons")]
    public virtual Dictionary? Type { get; set; }
}
