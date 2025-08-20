using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class UserGroupTenderAssignmentView
{
    [Column("GroupID")]
    public int GroupId { get; set; }

    [Column("TenderID")]
    public int TenderId { get; set; }

    [StringLength(50)]
    public string? GroupName { get; set; }

    [StringLength(50)]
    public string? TenderName { get; set; }
}
