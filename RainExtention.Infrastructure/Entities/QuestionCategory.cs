using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("QuestionCategory")]
public partial class QuestionCategory
{
    [Key]
    [Column("CategoryID")]
    public Guid CategoryId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
