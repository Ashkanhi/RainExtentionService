using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Question")]
public partial class Question
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("Question")]
    [StringLength(1000)]
    public string? Question1 { get; set; }

    [Column("CategoryID")]
    public Guid? CategoryId { get; set; }

    public int? ResultType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    public int? Status { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Questions")]
    public virtual QuestionCategory? Category { get; set; }

    [InverseProperty("Question")]
    public virtual ICollection<PredefineResult> PredefineResults { get; set; } = new List<PredefineResult>();

    [ForeignKey("QuestionId")]
    [InverseProperty("Questions")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
