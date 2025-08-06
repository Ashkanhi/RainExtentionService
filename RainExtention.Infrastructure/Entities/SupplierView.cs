using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SupplierView
{
    [Column("SupplierID")]
    public Guid SupplierId { get; set; }

    [Column("PartyID")]
    public Guid? PartyId { get; set; }

    [Column("ExtrernalID")]
    [StringLength(50)]
    public string? ExtrernalId { get; set; }

    public int? LeadTime { get; set; }

    public int? DueDate { get; set; }

    [Column("AgentID")]
    public Guid? AgentId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(50)]
    public string? LoginName { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [StringLength(50)]
    public string? BankAccountNumber { get; set; }

    [StringLength(50)]
    public string? InternationalBankAccountNumber { get; set; }

    public string? Description { get; set; }

    public byte? Rate { get; set; }

    public bool? AllowToViewSale { get; set; }

    public bool? AllowToViewQuantity { get; set; }

    public bool? AllowToViewCheque { get; set; }

    public bool? AllowToEditOrder { get; set; }

    public bool? AllowToImportItem { get; set; }

    public bool? AllowToImportPrice { get; set; }

    public int? IsIndividual { get; set; }

    [Column("CompanyID")]
    public Guid? CompanyId { get; set; }

    [Column("PersonID")]
    public Guid? PersonId { get; set; }

    [StringLength(50)]
    public string? RegisterNo { get; set; }

    public DateOnly? RegisterDate { get; set; }

    public byte[]? CompanyLogo { get; set; }

    [Column("ThirdPartyID")]
    public Guid? ThirdPartyId { get; set; }

    [Column("DetailedAccountID")]
    public Guid? DetailedAccountId { get; set; }

    [StringLength(20)]
    public string? DetailAccountCode { get; set; }

    public bool? IsEmployee { get; set; }

    public bool? IsCustomer { get; set; }

    public bool? IsVisitor { get; set; }

    [Column("EmployeeID")]
    public Guid? EmployeeId { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column("VisitorID")]
    public Guid? VisitorId { get; set; }

    [Column("LanguageID")]
    public int LanguageId { get; set; }

    [StringLength(101)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    public bool? IsTaxPayer { get; set; }

    [StringLength(50)]
    public string? BusinessCode { get; set; }

    [Column("NationalID")]
    [StringLength(50)]
    public string? NationalId { get; set; }

    [StringLength(10)]
    public string? AreaCode { get; set; }

    [StringLength(15)]
    public string? Telephone { get; set; }

    [StringLength(15)]
    public string? Mobile { get; set; }

    [StringLength(1000)]
    public string? Address { get; set; }

    [StringLength(50)]
    public string? PostalCode { get; set; }

    [StringLength(255)]
    public string? EmailAddress { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }
}
