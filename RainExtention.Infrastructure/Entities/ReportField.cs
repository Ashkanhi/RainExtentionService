using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ReportId", "FieldId")]
[Table("ReportField")]
public partial class ReportField
{
    [Key]
    [Column("ReportID")]
    public int ReportId { get; set; }

    [Key]
    [Column("FieldID")]
    public int FieldId { get; set; }

    [StringLength(255)]
    public string? FieldName { get; set; }

    [StringLength(50)]
    public string? DisplayText { get; set; }

    public int? FiledOrder { get; set; }

    [Column("FieldTypeID")]
    public int? FieldTypeId { get; set; }

    [StringLength(50)]
    public string? DisplayFormat { get; set; }

    public bool? Visible { get; set; }

    [StringLength(500)]
    public string? Experssion { get; set; }

    public byte? DataType { get; set; }

    [StringLength(50)]
    public string? BandName { get; set; }

    [StringLength(50)]
    public string? FieldIcon { get; set; }

    [StringLength(50)]
    public string? BandIcon { get; set; }

    public bool? AllowFilter { get; set; }

    public int? FilterType { get; set; }

    [StringLength(50)]
    public string? FilterKeyword { get; set; }

    [ForeignKey("ReportId")]
    [InverseProperty("ReportFields")]
    public virtual Report Report { get; set; } = null!;
}
