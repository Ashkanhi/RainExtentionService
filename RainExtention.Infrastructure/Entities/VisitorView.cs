using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class VisitorView
{
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

    [StringLength(101)]
    public string VisitorName { get; set; } = null!;

    public bool? IsCustomer { get; set; }

    public bool? IsSupplier { get; set; }

    public bool? IsEmployee { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [Column("EmployeeID")]
    public Guid? EmployeeId { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
