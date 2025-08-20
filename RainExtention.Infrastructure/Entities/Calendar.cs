using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BusinessDate", "LanguageId")]
[Table("Calendar")]
public partial class Calendar
{
    [Key]
    public DateOnly BusinessDate { get; set; }

    [Key]
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
}
