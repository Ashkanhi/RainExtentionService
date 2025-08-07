using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PartyId", "TypeId")]
[Table("Email")]
public partial class Email
{
    [Key]
    [Column("PartyID")]
    public Guid PartyId { get; set; }

    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [StringLength(255)]
    public string? EmailAddress { get; set; }

    [ForeignKey("PartyId")]
    [InverseProperty("Emails")]
    public virtual Party Party { get; set; } = null!;

    [ForeignKey("TypeId")]
    [InverseProperty("Emails")]
    public virtual Dictionary Type { get; set; } = null!;
}
