using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class VisitorNameView
{
    [Column("VisitorID")]
    public Guid VisitorId { get; set; }

    [StringLength(100)]
    public string? VisitorName { get; set; }
}
