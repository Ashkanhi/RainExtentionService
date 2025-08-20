using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("Tamin")]
public partial class Tamin
{
    public string? JobCode { get; set; }

    public string? JobName { get; set; }
}
