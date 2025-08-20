using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Message")]
[Index("IsPrivate", Name = "IX_MessagePrivate")]
[Index("NotificationId", Name = "IX_Notification")]
public partial class Message
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [StringLength(255)]
    public string? Subject { get; set; }

    [Column("Message")]
    public string? Message1 { get; set; }

    public bool? HasAttachment { get; set; }

    public bool? IsPrivate { get; set; }

    [Column("PriorityID")]
    public int? PriorityId { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationTime { get; set; }

    [Column("NotificationID")]
    public Guid? NotificationId { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<Message> InverseParent { get; set; } = new List<Message>();

    [InverseProperty("IdNavigation")]
    public virtual ICollection<MessageEntityAssignment> MessageEntityAssignments { get; set; } = new List<MessageEntityAssignment>();

    [InverseProperty("IdNavigation")]
    public virtual ICollection<MessageFileAttachment> MessageFileAttachments { get; set; } = new List<MessageFileAttachment>();

    [InverseProperty("IdNavigation")]
    public virtual ICollection<MessageUserAssignment> MessageUserAssignments { get; set; } = new List<MessageUserAssignment>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual Message? Parent { get; set; }
}
