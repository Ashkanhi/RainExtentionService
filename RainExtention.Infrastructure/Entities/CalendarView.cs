using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CalendarView
{
    public DateOnly BusinessDate { get; set; }

    [Column("LanguageID")]
    public int LanguageId { get; set; }

    [StringLength(10)]
    public string? Date { get; set; }

    [StringLength(50)]
    public string? Year { get; set; }

    [Column("SeasonID")]
    public int? SeasonId { get; set; }

    [Column("MonthID")]
    public int? MonthId { get; set; }

    [Column("DayID")]
    public int? DayId { get; set; }

    [StringLength(50)]
    public string? Season { get; set; }

    [StringLength(50)]
    public string? Month { get; set; }

    [StringLength(50)]
    public string? DayOfWeek { get; set; }
}
