using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class MessageView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [StringLength(255)]
    public string? Subject { get; set; }

    public string? Message { get; set; }

    public bool? HasAttachment { get; set; }

    public bool? IsPrivate { get; set; }

    [Column("PriorityID")]
    public int? PriorityId { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationTime { get; set; }

    [Column("NotificationID")]
    public Guid? NotificationId { get; set; }

    [StringLength(50)]
    public string? CreationUserName { get; set; }
}
