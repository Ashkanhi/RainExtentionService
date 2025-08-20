using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CustomerView
{
    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [Column("PartyID")]
    public Guid? PartyId { get; set; }

    [StringLength(50)]
    public string? CustomerCode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalPoint { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentPoint { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalCredit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentCredit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RemainCredit { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(50)]
    public string? LoginName { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column("ReagentID")]
    public Guid? ReagentId { get; set; }

    [Column("CorporateID")]
    public Guid? CorporateId { get; set; }

    [Column("AgentID")]
    public Guid? AgentId { get; set; }

    [Column("SalePersonID")]
    public Guid? SalePersonId { get; set; }

    [StringLength(50)]
    public string? Token { get; set; }

    [StringLength(152)]
    public string? CustomerName { get; set; }

    public byte[]? CustomerImage { get; set; }

    [StringLength(50)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    public bool? IsIndividual { get; set; }

    public DateOnly? Birthday { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [Column("NationalID")]
    [StringLength(50)]
    public string? NationalId { get; set; }

    [StringLength(50)]
    public string? IdentifierNo { get; set; }

    [StringLength(50)]
    public string? FatherName { get; set; }

    [StringLength(50)]
    public string? IssuedCity { get; set; }

    public bool? IsTaxPayer { get; set; }

    [StringLength(50)]
    public string? BusinessCode { get; set; }

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
    public string? StoreName { get; set; }

    public bool? IsEmployee { get; set; }

    public bool? IsSupplier { get; set; }

    public bool? IsVisitor { get; set; }

    [Column("EmployeeID")]
    public Guid? EmployeeId { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [Column("VisitorID")]
    public Guid? VisitorId { get; set; }

    [Column("ThirdPartyID")]
    public Guid? ThirdPartyId { get; set; }

    [StringLength(101)]
    public string AgentName { get; set; } = null!;

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    [StringLength(120)]
    public string? ImageUrl { get; set; }
}
