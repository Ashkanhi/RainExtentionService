using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class MessageUserAssignmentView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("UserID")]
    public Guid UserId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(50)]
    public string? UserName { get; set; }
}
