using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Visitor")]
public partial class Visitor
{
    [Key]
    [Column("VisitorID")]
    public Guid VisitorId { get; set; }

    [Column("PartyID")]
    public Guid? PartyId { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [InverseProperty("SalePerson")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    [ForeignKey("PartyId")]
    [InverseProperty("Visitors")]
    public virtual Party? Party { get; set; }

    [InverseProperty("Visitor")]
    public virtual ICollection<StockDocument> StockDocuments { get; set; } = new List<StockDocument>();

    [InverseProperty("Parent")]
    public virtual ICollection<VisitorContract> VisitorContractParents { get; set; } = new List<VisitorContract>();

    [InverseProperty("Visitor")]
    public virtual ICollection<VisitorContract> VisitorContractVisitors { get; set; } = new List<VisitorContract>();
}
