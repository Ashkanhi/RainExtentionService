using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("CustomerGroup")]
public partial class CustomerGroup
{
    [Key]
    [Column("CustomerGroupID")]
    public Guid CustomerGroupId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    public bool? AllowChangePoint { get; set; }

    public bool? AllowChangeCredit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxCreditUsage { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    public bool? AllowToChangeGroup { get; set; }

    [InverseProperty("CustomerGroup")]
    public virtual ICollection<CustomerGroupAssignment> CustomerGroupAssignments { get; set; } = new List<CustomerGroupAssignment>();

    [InverseProperty("CustomerGroup")]
    public virtual ICollection<LoyalityAwardRule> LoyalityAwardRules { get; set; } = new List<LoyalityAwardRule>();

    [ForeignKey("TypeId")]
    [InverseProperty("CustomerGroups")]
    public virtual CustomerGroupType? Type { get; set; }

    [ForeignKey("CustomerGroupId")]
    [InverseProperty("CustomerGroups")]
    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();

    [ForeignKey("CustomerGroupId")]
    [InverseProperty("CustomerGroups")]
    public virtual ICollection<Lottery> Lotteries { get; set; } = new List<Lottery>();

    [ForeignKey("CustomerGroupId")]
    [InverseProperty("CustomerGroups")]
    public virtual ICollection<SalePrice> Prices { get; set; } = new List<SalePrice>();

    [ForeignKey("CustomerGroupId")]
    [InverseProperty("CustomerGroups")]
    public virtual ICollection<SaleQoutum> Qouats { get; set; } = new List<SaleQoutum>();

    [ForeignKey("CustomerGroupId")]
    [InverseProperty("CustomerGroups")]
    public virtual ICollection<PartialPaymentRule> Rules { get; set; } = new List<PartialPaymentRule>();
}
