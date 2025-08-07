using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class QuestionView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(1000)]
    public string? Question { get; set; }

    [Column("CategoryID")]
    public Guid? CategoryId { get; set; }

    public int? ResultType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    public int? Status { get; set; }

    [StringLength(50)]
    public string? CategoryName { get; set; }

    [StringLength(50)]
    public string? StatusText { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
