using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Person")]
[Index("Birthday", Name = "IX_Birthday")]
[Index("DetailAccountId", Name = "IX_DetailAccountID", IsUnique = true)]
[Index("EducationId", Name = "IX_EducationID")]
[Index("NationalId", Name = "IX_NationalID")]
[Index("PartyId", Name = "IX_PartyID", IsUnique = true)]
[Index("SalutionId", Name = "IX_SalutionID")]
[Index("SexId", Name = "IX_SexID")]
[Index("ThirdPartyId", Name = "IX_ThirdPartyID", IsUnique = true)]
public partial class Person
{
    [Key]
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

    [InverseProperty("OperationalManager")]
    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    [ForeignKey("DetailAccountId")]
    [InverseProperty("Person1")]
    public virtual DetailAccount? DetailAccount { get; set; }

    [ForeignKey("PartyId")]
    [InverseProperty("Person1")]
    public virtual Party? Party { get; set; }

    [InverseProperty("Person")]
    public virtual PersonCustomField? PersonCustomField { get; set; }

    [InverseProperty("Person")]
    public virtual ICollection<PersonNameTranslation> PersonNameTranslations { get; set; } = new List<PersonNameTranslation>();

    [ForeignKey("SalutionId")]
    [InverseProperty("Person1s")]
    public virtual Dictionary? Salution { get; set; }

    [InverseProperty("Agent")]
    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();

    [ForeignKey("ThirdPartyId")]
    [InverseProperty("Person1")]
    public virtual ThirdParty? ThirdParty { get; set; }
}
