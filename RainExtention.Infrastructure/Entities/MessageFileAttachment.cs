using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "LineItemId")]
[Table("MessageFileAttachment")]
public partial class MessageFileAttachment
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [StringLength(255)]
    public string? FileName { get; set; }

    public byte[]? FileContent { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("MessageFileAttachments")]
    public virtual Message IdNavigation { get; set; } = null!;
}
