using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ReportId", "FilterId")]
[Table("ReportFilter")]
public partial class ReportFilter
{
    [Key]
    [Column("ReportID")]
    public int ReportId { get; set; }

    [Key]
    [Column("FilterID")]
    public int FilterId { get; set; }

    [Column("FilterTypeID")]
    public int? FilterTypeId { get; set; }

    [StringLength(50)]
    public string? FieldName { get; set; }

    [StringLength(50)]
    public string? Keyword { get; set; }

    [StringLength(100)]
    public string? DefaultValue { get; set; }

    [StringLength(50)]
    public string? Caption { get; set; }

    [StringLength(500)]
    public string? DataSource { get; set; }

    public bool? AllowMultipleValue { get; set; }

    public bool? IsDefault { get; set; }

    [ForeignKey("ReportId")]
    [InverseProperty("ReportFilters")]
    public virtual Report Report { get; set; } = null!;
}
