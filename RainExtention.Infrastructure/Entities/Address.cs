using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PartyId", "TypeId")]
[Table("Address")]
public partial class Address
{
    [Key]
    [Column("PartyID")]
    public Guid PartyId { get; set; }

    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [StringLength(50)]
    public string? Country { get; set; }

    [StringLength(50)]
    public string? State { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(50)]
    public string? Area { get; set; }

    [StringLength(1000)]
    public string? Street { get; set; }

    [StringLength(50)]
    public string? TagNumber { get; set; }

    [StringLength(50)]
    public string? PostalCode { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Latitude { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Longitude { get; set; }

    [ForeignKey("PartyId")]
    [InverseProperty("Addresses")]
    public virtual Party Party { get; set; } = null!;

    [ForeignKey("TypeId")]
    [InverseProperty("Addresses")]
    public virtual Dictionary Type { get; set; } = null!;
}
