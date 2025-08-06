using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("CalendarEventFix")]
public partial class CalendarEventFix
{
    [Key]
    [Column("EventID")]
    public Guid EventId { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [Column("MonthID")]
    public int? MonthId { get; set; }

    public int? DayOfMonth { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public bool? IsHoliday { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OrderFact { get; set; }

    [InverseProperty("FixEvent")]
    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();
}
