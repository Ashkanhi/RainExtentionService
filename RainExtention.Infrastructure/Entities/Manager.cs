using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

public partial class Manager
{
    [Key]
    [Column("ManagerID")]
    public int ManagerId { get; set; }

    [StringLength(100)]
    public string? ManagerName { get; set; }
}
