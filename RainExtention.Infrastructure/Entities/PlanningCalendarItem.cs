using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("CalendarId", "LineItemId")]
[Table("PlanningCalendarItem")]
public partial class PlanningCalendarItem
{
    [Key]
    [Column("CalendarID")]
    public Guid CalendarId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("MonthID")]
    public int? MonthId { get; set; }

    public int? Day { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [ForeignKey("CalendarId")]
    [InverseProperty("PlanningCalendarItems")]
    public virtual PlanningCalendar Calendar { get; set; } = null!;
}
