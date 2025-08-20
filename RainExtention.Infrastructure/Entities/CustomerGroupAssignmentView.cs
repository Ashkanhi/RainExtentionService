using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CustomerGroupAssignmentView
{
    [Column("CustomerGroupID")]
    public Guid CustomerGroupId { get; set; }

    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [StringLength(50)]
    public string? GroupName { get; set; }

    [StringLength(152)]
    public string? CustomerName { get; set; }

    public bool? AllowChangePoint { get; set; }

    public bool? AllowChangeCredit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxCreditUsage { get; set; }

    public bool? AllowToChangeGroup { get; set; }

    [Column("TypeID")]
    public int TypeId { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
