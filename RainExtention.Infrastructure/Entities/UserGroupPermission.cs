using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("GroupId", "PermissionId")]
[Table("UserGroupPermission")]
public partial class UserGroupPermission
{
    [Key]
    [Column("GroupID")]
    public int GroupId { get; set; }

    [Key]
    [Column("PermissionID")]
    public int PermissionId { get; set; }

    public bool? AccessFlag { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("UserGroupPermissions")]
    public virtual UserGroup Group { get; set; } = null!;

    [ForeignKey("PermissionId")]
    [InverseProperty("UserGroupPermissions")]
    public virtual Permission Permission { get; set; } = null!;
}
