using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class PartialPaymentRuleStoreGroupAssignmentView
{
    [Column("RuleID")]
    public Guid RuleId { get; set; }

    [Column("StoreGroupID")]
    public Guid StoreGroupId { get; set; }

    [StringLength(50)]
    public string? GroupName { get; set; }
}
