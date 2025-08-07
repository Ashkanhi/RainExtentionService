using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class UserGroupAssignmentView
{
    [Column("UserGroupID")]
    public int UserGroupId { get; set; }

    [Column("UserID")]
    public Guid UserId { get; set; }

    [StringLength(50)]
    public string? UserName { get; set; }

    [StringLength(50)]
    public string? GroupName { get; set; }
}
