using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("checkapi")]
public partial class Checkapi
{
    [Column("id")]
    public string? Id { get; set; }

    [Column("status")]
    public string? Status { get; set; }

    [Column("responseText")]
    public string? ResponseText { get; set; }

    [Column("DATE", TypeName = "datetime")]
    public DateTime? Date { get; set; }
}
