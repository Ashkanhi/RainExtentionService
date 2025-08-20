using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CompanyView
{
    [Column("CompanyID")]
    public Guid CompanyId { get; set; }

    [Column("PartyID")]
    public Guid? PartyId { get; set; }

    [StringLength(50)]
    public string? RegisterNo { get; set; }

    public DateOnly? RegisterDate { get; set; }

    [StringLength(50)]
    public string? BusinessCode { get; set; }

    public byte[]? CompanyLogo { get; set; }

    [Column("ThirdPartyID")]
    public Guid? ThirdPartyId { get; set; }

    [Column("DetailedAccountID")]
    public Guid? DetailedAccountId { get; set; }

    [Column("NationalID")]
    [StringLength(50)]
    public string? NationalId { get; set; }

    [StringLength(50)]
    public string? LicenseNo { get; set; }

    public bool? IsTaxPayer { get; set; }

    [Column("OperationalManagerID")]
    public Guid? OperationalManagerId { get; set; }

    [Column("LanguageID")]
    public int LanguageId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }
}
