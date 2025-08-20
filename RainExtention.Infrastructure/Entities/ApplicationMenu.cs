using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ApplicationMenu")]
public partial class ApplicationMenu
{
    [Key]
    [Column("MenuID")]
    public int MenuId { get; set; }

    [Column("ParentID")]
    public int? ParentId { get; set; }

    [Column("ApplicationID")]
    public int? ApplicationId { get; set; }

    [Column("SubSystemID")]
    public int? SubSystemId { get; set; }

    [Column("PermissionID")]
    public int? PermissionId { get; set; }

    [Column("ActionTypeID")]
    public int? ActionTypeId { get; set; }

    [StringLength(255)]
    public string? Action { get; set; }

    [ForeignKey("ActionTypeId")]
    [InverseProperty("ApplicationMenus")]
    public virtual Dictionary? ActionType { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("ApplicationMenus")]
    public virtual Application? Application { get; set; }

    [InverseProperty("Menu")]
    public virtual ICollection<ApplicationMenuCaption> ApplicationMenuCaptions { get; set; } = new List<ApplicationMenuCaption>();

    [InverseProperty("Parent")]
    public virtual ICollection<ApplicationMenu> InverseParent { get; set; } = new List<ApplicationMenu>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual ApplicationMenu? Parent { get; set; }

    [ForeignKey("PermissionId")]
    [InverseProperty("ApplicationMenus")]
    public virtual Permission? Permission { get; set; }

    [ForeignKey("SubSystemId")]
    [InverseProperty("ApplicationMenus")]
    public virtual SubSystem? SubSystem { get; set; }
}
