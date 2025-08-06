using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class PersonView
{
    [Column("PersonID")]
    public Guid PersonId { get; set; }

    [Column("PartyID")]
    public Guid? PartyId { get; set; }

    [Column("SalutionID")]
    public int? SalutionId { get; set; }

    public DateOnly? Birthday { get; set; }

    [Column("NationalID")]
    [StringLength(50)]
    public string? NationalId { get; set; }

    [StringLength(50)]
    public string? IdentifierNo { get; set; }

    [StringLength(50)]
    public string? FatherName { get; set; }

    [StringLength(50)]
    public string? IssuedCity { get; set; }

    public byte[]? PersonImage { get; set; }

    [Column("ThirdPartyID")]
    public Guid? ThirdPartyId { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    [Column("SexID")]
    public int? SexId { get; set; }

    [Column("EducationID")]
    public int? EducationId { get; set; }

    public bool? IsTaxPayer { get; set; }

    [StringLength(50)]
    public string? BusinessCode { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [StringLength(101)]
    public string PersonName { get; set; } = null!;
}
