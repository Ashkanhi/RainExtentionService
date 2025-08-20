using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Company")]
[Index("BusinessCode", Name = "IX_BusinessCode")]
[Index("DetailedAccountId", Name = "IX_DetailAccountID", IsUnique = true)]
[Index("NationalId", Name = "IX_NationalID")]
[Index("PartyId", Name = "IX_PartyID", IsUnique = true)]
[Index("RegisterDate", Name = "IX_RegisterDate")]
[Index("ThirdPartyId", Name = "IX_ThirdPartyID", IsUnique = true)]
public partial class Company
{
    [Key]
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

    [InverseProperty("Company")]
    public virtual CompanyCustomField? CompanyCustomField { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<CompanyNameTranslation> CompanyNameTranslations { get; set; } = new List<CompanyNameTranslation>();

    [ForeignKey("DetailedAccountId")]
    [InverseProperty("Company")]
    public virtual DetailAccount? DetailedAccount { get; set; }

    [ForeignKey("OperationalManagerId")]
    [InverseProperty("Companies")]
    public virtual Person1? OperationalManager { get; set; }

    [ForeignKey("PartyId")]
    [InverseProperty("Company")]
    public virtual Party? Party { get; set; }

    [ForeignKey("ThirdPartyId")]
    [InverseProperty("Company")]
    public virtual ThirdParty? ThirdParty { get; set; }
}
