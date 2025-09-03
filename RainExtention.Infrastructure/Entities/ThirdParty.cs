using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ThirdParty")]
public partial class ThirdParty
{
    [Key]
    [Column("ThirdPartyID")]
    public Guid ThirdPartyId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxCredit { get; set; }

    [InverseProperty("ThirdParty")]
    public virtual Company? Company { get; set; }

    [InverseProperty("ThirdParty")]
    public virtual Person? Person { get; set; }

    [InverseProperty("ThirdParty")]
    public virtual ICollection<ProductionDocument> ProductionDocuments { get; set; } = new List<ProductionDocument>();

    [ForeignKey("StatusId")]
    [InverseProperty("ThirdParties")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("ThirdParty")]
    public virtual ICollection<TreasuryDocument> TreasuryDocuments { get; set; } = new List<TreasuryDocument>();
}
