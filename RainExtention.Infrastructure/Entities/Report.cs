using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Report")]
public partial class Report
{
    [Key]
    [Column("ReportID")]
    public int ReportId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column("SubsystemID")]
    public int? SubsystemId { get; set; }

    [StringLength(50)]
    public string? SubSystem { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column(TypeName = "ntext")]
    public string? DatabaseConnection { get; set; }

    public string? Query { get; set; }

    public string? ReportFileName { get; set; }

    [Column("PermissionID")]
    public int? PermissionId { get; set; }

    public byte[]? ConditionalFormat { get; set; }

    public byte[]? PrintLayout { get; set; }

    public bool? AllowDrillThrough { get; set; }

    public int? DataType { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public bool? AllowRunWithoutFilter { get; set; }

    [InverseProperty("Report")]
    public virtual ICollection<ReportField> ReportFields { get; set; } = new List<ReportField>();

    [InverseProperty("Report")]
    public virtual ICollection<ReportFilter> ReportFilters { get; set; } = new List<ReportFilter>();
}
