using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "LineItemId")]
[Table("MessageUserAssignment")]
[Index("StatusId", Name = "IX_MessageUserStatus")]
public partial class MessageUserAssignment
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("UserID")]
    public Guid UserId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("MessageUserAssignments")]
    public virtual Message IdNavigation { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("MessageUserAssignments")]
    public virtual User User { get; set; } = null!;
}
