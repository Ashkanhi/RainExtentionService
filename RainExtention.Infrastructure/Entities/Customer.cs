using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Customer")]
[Index("CustomerCode", Name = "IX_CustomerCode")]
[Index("PartyId", Name = "IX_Party")]
[Index("StatusId", Name = "IX_Status")]
public partial class Customer
{
    [Key]
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

    [ForeignKey("AgentId")]
    [InverseProperty("Customers")]
    public virtual Employee? Agent { get; set; }

    [ForeignKey("CorporateId")]
    [InverseProperty("InverseCorporate")]
    public virtual Customer? Corporate { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<CustomerCard> CustomerCards { get; set; } = new List<CustomerCard>();

    [InverseProperty("Customer")]
    public virtual ICollection<CustomerCreditHistory> CustomerCreditHistories { get; set; } = new List<CustomerCreditHistory>();

    [InverseProperty("Customer")]
    public virtual CustomerCustomField? CustomerCustomField { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<CustomerGroupAssignment> CustomerGroupAssignments { get; set; } = new List<CustomerGroupAssignment>();

    [InverseProperty("Child")]
    public virtual ICollection<CustomerRelationship> CustomerRelationshipChildren { get; set; } = new List<CustomerRelationship>();

    [InverseProperty("Customer")]
    public virtual ICollection<CustomerRelationship> CustomerRelationshipCustomers { get; set; } = new List<CustomerRelationship>();

    [InverseProperty("Customer")]
    public virtual ICollection<CustomerResult> CustomerResults { get; set; } = new List<CustomerResult>();

    [InverseProperty("Corporate")]
    public virtual ICollection<Customer> InverseCorporate { get; set; } = new List<Customer>();

    [InverseProperty("Reagent")]
    public virtual ICollection<Customer> InverseReagent { get; set; } = new List<Customer>();

    [InverseProperty("Customer")]
    public virtual ICollection<OrderDocumentLineItem> OrderDocumentLineItems { get; set; } = new List<OrderDocumentLineItem>();

    [ForeignKey("PartyId")]
    [InverseProperty("Customers")]
    public virtual Party? Party { get; set; }

    [ForeignKey("ReagentId")]
    [InverseProperty("InverseReagent")]
    public virtual Customer? Reagent { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<SaleInvoice> SaleInvoices { get; set; } = new List<SaleInvoice>();

    [ForeignKey("SalePersonId")]
    [InverseProperty("Customers")]
    public virtual Visitor? SalePerson { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("Customers")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<SuspendInvoice> SuspendInvoices { get; set; } = new List<SuspendInvoice>();
}
