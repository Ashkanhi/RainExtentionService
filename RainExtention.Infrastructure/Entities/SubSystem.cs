using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SubSystem")]
public partial class SubSystem
{
    [Key]
    [Column("SubSytemID")]
    public int SubSytemId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column("PermissionID")]
    public int? PermissionId { get; set; }

    [InverseProperty("SubSystem")]
    public virtual ICollection<ApplicationMenu> ApplicationMenus { get; set; } = new List<ApplicationMenu>();

    [ForeignKey("PermissionId")]
    [InverseProperty("SubSystems")]
    public virtual Permission? Permission { get; set; }
}
