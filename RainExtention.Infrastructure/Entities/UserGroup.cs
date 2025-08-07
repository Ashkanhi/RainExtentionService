using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("UserGroup")]
public partial class UserGroup
{
    [Key]
    [Column("GroupID")]
    public int GroupId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("UserGroups")]
    public virtual Department? Department { get; set; }

    [InverseProperty("OwnerGroup")]
    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    [InverseProperty("Group")]
    public virtual ICollection<UserGroupPermission> UserGroupPermissions { get; set; } = new List<UserGroupPermission>();

    [ForeignKey("GroupId")]
    [InverseProperty("Groups")]
    public virtual ICollection<Tender> Tenders { get; set; } = new List<Tender>();

    [ForeignKey("UserGroupId")]
    [InverseProperty("UserGroups")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
