using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Task")]
[Index("PriorityId", Name = "IX_Priority")]
[Index("StatusId", Name = "IX_Status")]
[Index("CategoryId", Name = "IX_TaskCategory")]
[Index("PriorityId", Name = "IX_TaskPriority")]
[Index("IsPrivate", Name = "IX_TaskPrivacy")]
[Index("StatusId", Name = "IX_TaskStatus")]
[Index("TimeTypeId", Name = "IX_TaskTimeType")]
[Index("UserId", Name = "IX_TaskUser")]
[Index("UserId", Name = "IX_User")]
public partial class Task
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [Column("CategoryID")]
    public Guid? CategoryId { get; set; }

    [Column("UserID")]
    public Guid? UserId { get; set; }

    [StringLength(20)]
    public string? TaskNumber { get; set; }

    [StringLength(255)]
    public string? Subject { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompleteDate { get; set; }

    public short? Progress { get; set; }

    public int? TimeEstimate { get; set; }

    [Column("TimeTypeID")]
    public short? TimeTypeId { get; set; }

    [Column("PriorityID")]
    public int? PriorityId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public bool? IsPrivate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Tasks")]
    public virtual TaskCategory? Category { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("TaskCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<Task> InverseParent { get; set; } = new List<Task>();

    [ForeignKey("ModifyUser")]
    [InverseProperty("TaskModifyUserNavigations")]
    public virtual User? ModifyUserNavigation { get; set; }

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual Task? Parent { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("Tasks")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<TaskEntityAssignment> TaskEntityAssignments { get; set; } = new List<TaskEntityAssignment>();

    [InverseProperty("IdNavigation")]
    public virtual ICollection<TaskFileAttachment> TaskFileAttachments { get; set; } = new List<TaskFileAttachment>();

    [InverseProperty("IdNavigation")]
    public virtual TaskReminder? TaskReminder { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("TaskUsers")]
    public virtual User? User { get; set; }
}
