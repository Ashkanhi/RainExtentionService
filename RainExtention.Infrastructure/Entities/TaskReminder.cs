using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("TaskReminder")]
[Index("Status", Name = "IX_ReminderStatus")]
[Index("Status", Name = "IX_TaskReminderStatus")]
public partial class TaskReminder
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReminderDate { get; set; }

    [Column("AllowSMS")]
    public bool? AllowSms { get; set; }

    public bool Status { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("TaskReminder")]
    public virtual Task IdNavigation { get; set; } = null!;
}
