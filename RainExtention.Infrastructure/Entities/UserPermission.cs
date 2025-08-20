using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("UserId", "PermissionId")]
[Table("UserPermission")]
public partial class UserPermission
{
    [Key]
    [Column("UserID")]
    public Guid UserId { get; set; }

    [Key]
    [Column("PermissionID")]
    public int PermissionId { get; set; }

    public bool? AccessFlag { get; set; }

    [ForeignKey("PermissionId")]
    [InverseProperty("UserPermissions")]
    public virtual Permission Permission { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserPermissions")]
    public virtual User User { get; set; } = null!;
}
