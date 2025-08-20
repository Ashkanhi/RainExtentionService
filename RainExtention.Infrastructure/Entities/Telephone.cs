using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PartyId", "TypeId")]
[Table("Telephone")]
public partial class Telephone
{
    [Key]
    [Column("PartyID")]
    public Guid PartyId { get; set; }

    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [Column("CountryCodeID")]
    public int? CountryCodeId { get; set; }

    [StringLength(10)]
    public string? AreaCode { get; set; }

    [StringLength(15)]
    public string? CallNumber { get; set; }

    [ForeignKey("CountryCodeId")]
    [InverseProperty("TelephoneCountryCodes")]
    public virtual Dictionary? CountryCode { get; set; }

    [ForeignKey("PartyId")]
    [InverseProperty("Telephones")]
    public virtual Party Party { get; set; } = null!;

    [ForeignKey("TypeId")]
    [InverseProperty("TelephoneTypes")]
    public virtual Dictionary Type { get; set; } = null!;
}
