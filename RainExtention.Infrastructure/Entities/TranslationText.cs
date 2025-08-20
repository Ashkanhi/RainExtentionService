using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("TranslationKey", "Language")]
[Table("TranslationText")]
public partial class TranslationText
{
    [Key]
    [StringLength(50)]
    public string TranslationKey { get; set; } = null!;

    [Key]
    public int Language { get; set; }

    [Column("TranslationText")]
    [StringLength(50)]
    public string? TranslationText1 { get; set; }
}
