using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ThirdPartyView
{
    [Column("ThirdPartyID")]
    public Guid ThirdPartyId { get; set; }

    [StringLength(101)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxCredit { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public DateOnly? Date { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    public bool? IsEmployee { get; set; }

    public bool? IsCustomer { get; set; }

    public bool? IsSupplier { get; set; }

    public bool? IsVisitor { get; set; }

    [Column("EmployeeID")]
    public Guid? EmployeeId { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [Column("VisitorID")]
    public Guid? VisitorId { get; set; }
}
