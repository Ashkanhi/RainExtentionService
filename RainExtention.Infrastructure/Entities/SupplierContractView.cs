using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SupplierContractView
{
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

    [StringLength(100)]
    public string? Title { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AgreementStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AgreementEndDate { get; set; }

    [StringLength(50)]
    public string? DocumentNumber { get; set; }

    [StringLength(101)]
    public string? SupplierName { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [StringLength(50)]
    public string? CreationUserName { get; set; }

    [StringLength(50)]
    public string? ModifyUsername { get; set; }

    [StringLength(50)]
    public string? ContractType { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }
}
