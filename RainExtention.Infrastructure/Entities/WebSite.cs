using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PartyId", "Type")]
[Table("WebSite")]
public partial class WebSite
{
    [Key]
    [Column("PartyID")]
    public Guid PartyId { get; set; }

    [Key]
    public int Type { get; set; }

    [StringLength(255)]
    public string? WebsiteAddress { get; set; }

    [ForeignKey("PartyId")]
    [InverseProperty("WebSites")]
    public virtual Party Party { get; set; } = null!;

    [ForeignKey("Type")]
    [InverseProperty("WebSites")]
    public virtual Dictionary TypeNavigation { get; set; } = null!;
}
