using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BusinessDate", "EventId")]
[Table("CalendarEvent")]
public partial class CalendarEvent
{
    [Key]
    public DateOnly BusinessDate { get; set; }

    [Key]
    [Column("EventID")]
    public Guid EventId { get; set; }

    [Column("FixEventID")]
    public Guid? FixEventId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public bool? IsHoliday { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OrderFact { get; set; }

    [ForeignKey("FixEventId")]
    [InverseProperty("CalendarEvents")]
    public virtual CalendarEventFix? FixEvent { get; set; }
}
