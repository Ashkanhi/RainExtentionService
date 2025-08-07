using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("SmsHistory")]
public partial class SmsHistory
{
    [StringLength(20)]
    public string? Mobile { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SendTime { get; set; }

    [StringLength(1000)]
    public string? Text { get; set; }
}
