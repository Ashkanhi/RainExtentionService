using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("LogTable")]
public partial class LogTable
{
    [StringLength(10)]
    [Unicode(false)]
    public string? ActionType { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    [Column("EmployeeID")]
    public int? EmployeeId { get; set; }
}
