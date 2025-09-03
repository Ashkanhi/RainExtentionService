using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Supplier")]
[Index("PartyId", Name = "IX_Party")]
public partial class Supplier
{
    [Key]
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

    [ForeignKey("AgentId")]
    [InverseProperty("Suppliers")]
    public virtual Person? Agent { get; set; }

    [ForeignKey("PartyId")]
    [InverseProperty("Suppliers")]
    public virtual Party? Party { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<ProductionOrderLineItem> ProductionOrderLineItems { get; set; } = new List<ProductionOrderLineItem>();

    [ForeignKey("StatusId")]
    [InverseProperty("Suppliers")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<StockDocument> StockDocuments { get; set; } = new List<StockDocument>();

    [InverseProperty("Supplier")]
    public virtual ICollection<SupplierContract> SupplierContracts { get; set; } = new List<SupplierContract>();

    [InverseProperty("Supplier")]
    public virtual SupplierCustomField? SupplierCustomField { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<SupplierItem> SupplierItems { get; set; } = new List<SupplierItem>();

    [InverseProperty("Supplier")]
    public virtual ICollection<SupplierNewItemProclamation> SupplierNewItemProclamations { get; set; } = new List<SupplierNewItemProclamation>();

    [InverseProperty("Supplier")]
    public virtual ICollection<SupplierNewPriceProclamation> SupplierNewPriceProclamations { get; set; } = new List<SupplierNewPriceProclamation>();

    [ForeignKey("SupplierId")]
    [InverseProperty("Suppliers")]
    public virtual ICollection<SupplierSale> Ids { get; set; } = new List<SupplierSale>();

    [ForeignKey("SupplierId")]
    [InverseProperty("Suppliers")]
    public virtual ICollection<AutomaticOrderPlan> Plans { get; set; } = new List<AutomaticOrderPlan>();
}
