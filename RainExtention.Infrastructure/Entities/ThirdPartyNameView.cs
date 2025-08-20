using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ThirdPartyNameView
{
    [Column("ThirdPartyID")]
    public Guid ThirdPartyId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }
}
