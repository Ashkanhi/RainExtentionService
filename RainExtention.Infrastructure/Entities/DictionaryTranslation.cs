using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DictionaryId", "LanguageId")]
public partial class DictionaryTranslation
{
    [Key]
    [Column("DictionaryID")]
    public int DictionaryId { get; set; }

    [Key]
    [Column("LanguageID")]
    public int LanguageId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [ForeignKey("DictionaryId")]
    [InverseProperty("DictionaryTranslations")]
    public virtual Dictionary Dictionary { get; set; } = null!;
}
