using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class LotteryDepartmentAssignmentView
{
    [Column("LotteryID")]
    public Guid LotteryId { get; set; }

    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }
}
