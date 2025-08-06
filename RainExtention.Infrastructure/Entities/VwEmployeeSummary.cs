using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class VwEmployeeSummary
{
    [StringLength(50)]
    public string? Department { get; set; }

    public long? EmployeeCount { get; set; }
}
