using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("job")]
public partial class Job
{
    [Column("Â JobCode")]
    [Unicode(false)]
    public string? ÂJobCode { get; set; }

    [Unicode(false)]
    public string? JobName { get; set; }
}
