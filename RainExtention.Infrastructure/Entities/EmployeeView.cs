using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class EmployeeView
{
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

    [StringLength(101)]
    public string EmployeeName { get; set; } = null!;

    public bool? IsCustomer { get; set; }

    public bool? IsSupplier { get; set; }

    public bool? IsVisitor { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [Column("VisitorID")]
    public Guid? VisitorId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string StoreName { get; set; } = null!;

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
