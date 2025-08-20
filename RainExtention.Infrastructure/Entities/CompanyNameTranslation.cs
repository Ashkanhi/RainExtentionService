using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("CompanyId", "LanguageId")]
public partial class CompanyNameTranslation
{
    [Key]
    [Column("CompanyID")]
    public Guid CompanyId { get; set; }

    [Key]
    [Column("LanguageID")]
    public int LanguageId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("CompanyNameTranslations")]
    public virtual Company Company { get; set; } = null!;
}
