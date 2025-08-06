using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class TelephoneView
{
    [Column("PartyID")]
    public Guid PartyId { get; set; }

    [Column("TypeID")]
    public int TypeId { get; set; }

    [Column("CountryCodeID")]
    public int? CountryCodeId { get; set; }

    [StringLength(10)]
    public string? AreaCode { get; set; }

    [StringLength(15)]
    public string? CallNumber { get; set; }

    public int? TypeLanguage { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [StringLength(50)]
    public string? Country { get; set; }

    public int? CountryLanguage { get; set; }

    public string? CountryCode { get; set; }
}
