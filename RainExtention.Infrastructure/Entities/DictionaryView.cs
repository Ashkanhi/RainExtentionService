using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class DictionaryView
{
    [Column("DictionaryID")]
    public int DictionaryId { get; set; }

    public int? DictionaryType { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }
}
