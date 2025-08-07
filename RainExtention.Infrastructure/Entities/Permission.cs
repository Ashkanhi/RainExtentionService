using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Permission")]
public partial class Permission
{
    [Key]
    [Column("PermissionID")]
    public int PermissionId { get; set; }

    [Column("ParentID")]
    public int? ParentId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? KeyName { get; set; }

    [InverseProperty("Permission")]
    public virtual ICollection<ApplicationMenu> ApplicationMenus { get; set; } = new List<ApplicationMenu>();

    [InverseProperty("Parent")]
    public virtual ICollection<Permission> InverseParent { get; set; } = new List<Permission>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual Permission? Parent { get; set; }

    [InverseProperty("Permission")]
    public virtual ICollection<ProductCatalogStep> ProductCatalogSteps { get; set; } = new List<ProductCatalogStep>();

    [InverseProperty("ApprovePermission")]
    public virtual ICollection<ProductionStep> ProductionStepApprovePermissions { get; set; } = new List<ProductionStep>();

    [InverseProperty("Permission")]
    public virtual ICollection<ProductionStep> ProductionStepPermissions { get; set; } = new List<ProductionStep>();

    [InverseProperty("VoidPermission")]
    public virtual ICollection<ProductionStep> ProductionStepVoidPermissions { get; set; } = new List<ProductionStep>();

    [InverseProperty("Permission")]
    public virtual ICollection<SubSystem> SubSystems { get; set; } = new List<SubSystem>();

    [InverseProperty("Permission")]
    public virtual ICollection<UserGroupPermission> UserGroupPermissions { get; set; } = new List<UserGroupPermission>();

    [InverseProperty("Permission")]
    public virtual ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();
}
