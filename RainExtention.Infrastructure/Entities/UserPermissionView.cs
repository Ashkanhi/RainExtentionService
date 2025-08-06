using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class UserPermissionView
{
    [Column("UserID")]
    public Guid UserId { get; set; }

    [Column("PermissionID")]
    public int PermissionId { get; set; }

    [Column("ParentID")]
    public int? ParentId { get; set; }

    [StringLength(50)]
    public string? PermissionName { get; set; }

    public bool? AccessFlag { get; set; }

    [StringLength(50)]
    public string? DisplayText { get; set; }

    public int? Language { get; set; }
}
