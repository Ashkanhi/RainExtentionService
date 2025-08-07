using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SalePriceStoreGroupAssignmentView
{
    [Column("PriceID")]
    public Guid PriceId { get; set; }

    [Column("GroupID")]
    public Guid GroupId { get; set; }

    [StringLength(50)]
    public string? GroupName { get; set; }
}
