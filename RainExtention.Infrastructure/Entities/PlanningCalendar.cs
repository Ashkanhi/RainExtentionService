using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("PlanningCalendar")]
public partial class PlanningCalendar
{
    [Key]
    [Column("CalendarID")]
    public Guid CalendarId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [InverseProperty("Calendar")]
    public virtual ICollection<AutomaticOrderPlan> AutomaticOrderPlans { get; set; } = new List<AutomaticOrderPlan>();

    [InverseProperty("Calendar")]
    public virtual ICollection<PlanningCalendarItem> PlanningCalendarItems { get; set; } = new List<PlanningCalendarItem>();
}
