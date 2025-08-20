using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("QuestionId", "ResultId")]
[Table("PredefineResult")]
public partial class PredefineResult
{
    [Key]
    [Column("QuestionID")]
    public Guid QuestionId { get; set; }

    [Key]
    [Column("ResultID")]
    public Guid ResultId { get; set; }

    [StringLength(100)]
    public string? Result { get; set; }

    public int? Value { get; set; }

    [InverseProperty("PredefineResult")]
    public virtual ICollection<CustomerResult> CustomerResults { get; set; } = new List<CustomerResult>();

    [ForeignKey("QuestionId")]
    [InverseProperty("PredefineResults")]
    public virtual Question Question { get; set; } = null!;
}
