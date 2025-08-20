using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SupplierContract")]
public partial class SupplierContract
{
    [Key]
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [StringLength(50)]
    public string? ContractNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContractDate { get; set; }

    [Column("ContractTypeID")]
    public int? ContractTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [StringLength(500)]
    public string? Comment { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("AgreementID")]
    public Guid? AgreementId { get; set; }

    public bool? CalcByMargin { get; set; }

    public bool? IsPromotion { get; set; }

    [Column("CurrencyID")]
    public int? CurrencyId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExchangeAmount { get; set; }

    [ForeignKey("ContractTypeId")]
    [InverseProperty("SupplierContractContractTypes")]
    public virtual Dictionary? ContractType { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("SupplierContractCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("SupplierContracts")]
    public virtual Currency? Currency { get; set; }

    [ForeignKey("ModifyUser")]
    [InverseProperty("SupplierContractModifyUserNavigations")]
    public virtual User? ModifyUserNavigation { get; set; }

    [InverseProperty("Contract")]
    public virtual ICollection<SaleInvoiceLineItemContract> SaleInvoiceLineItemContracts { get; set; } = new List<SaleInvoiceLineItemContract>();

    [ForeignKey("StatusId")]
    [InverseProperty("SupplierContractStatuses")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("Contract")]
    public virtual ICollection<StoreDailyTurnOverLineItem> StoreDailyTurnOverLineItems { get; set; } = new List<StoreDailyTurnOverLineItem>();

    [ForeignKey("SupplierId")]
    [InverseProperty("SupplierContracts")]
    public virtual Supplier? Supplier { get; set; }

    [InverseProperty("Contract")]
    public virtual ICollection<SupplierContractLineItem> SupplierContractLineItems { get; set; } = new List<SupplierContractLineItem>();

    [InverseProperty("Contract")]
    public virtual ICollection<SupplierContractStore> SupplierContractStores { get; set; } = new List<SupplierContractStore>();
}
