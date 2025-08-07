using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Party")]
public partial class Party
{
    [Key]
    [Column("PartyID")]
    public Guid PartyId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(500)]
    public string? Comment { get; set; }

    [InverseProperty("Party")]
    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    [InverseProperty("Party")]
    public virtual Company? Company { get; set; }

    [InverseProperty("Party")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    [InverseProperty("Party")]
    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();

    [InverseProperty("Party")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    [InverseProperty("Party")]
    public virtual Person1? Person1 { get; set; }

    [InverseProperty("Party")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();

    [InverseProperty("Party")]
    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();

    [InverseProperty("Party")]
    public virtual ICollection<Telephone> Telephones { get; set; } = new List<Telephone>();

    [InverseProperty("Party")]
    public virtual ICollection<Visitor> Visitors { get; set; } = new List<Visitor>();

    [InverseProperty("Party")]
    public virtual ICollection<WebSite> WebSites { get; set; } = new List<WebSite>();
}
