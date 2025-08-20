using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Employee")]
[Index("EmployeeCode", Name = "IX_EmployeeCode")]
[Index("PartyId", Name = "IX_Party")]
public partial class Employee
{
    [Key]
    [Column("EmployeeID")]
    public Guid EmployeeId { get; set; }

    [Column("PartyID")]
    public Guid? PartyId { get; set; }

    [StringLength(50)]
    public string? EmployeeCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HireDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CommissionPercent { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [InverseProperty("Agent")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    [InverseProperty("Employee")]
    public virtual EmployeeCustomField? EmployeeCustomField { get; set; }

    [ForeignKey("PartyId")]
    [InverseProperty("Employees")]
    public virtual Party? Party { get; set; }

    [InverseProperty("SalePerson")]
    public virtual ICollection<SaleInvoiceLineItemSalePerson> SaleInvoiceLineItemSalePeople { get; set; } = new List<SaleInvoiceLineItemSalePerson>();

    [InverseProperty("Operator")]
    public virtual ICollection<SaleInvoiceService> SaleInvoiceServices { get; set; } = new List<SaleInvoiceService>();

    [InverseProperty("DeliveryPerson")]
    public virtual ICollection<SaleItemDelivery> SaleItemDeliveryDeliveryPeople { get; set; } = new List<SaleItemDelivery>();

    [InverseProperty("InstallPerson")]
    public virtual ICollection<SaleItemDelivery> SaleItemDeliveryInstallPeople { get; set; } = new List<SaleItemDelivery>();

    [InverseProperty("Employee")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();

    [ForeignKey("EmployeeId")]
    [InverseProperty("Employees")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
