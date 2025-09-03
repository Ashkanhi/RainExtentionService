using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PersonId", "LanguageId")]
public partial class PersonNameTranslation
{
    [Key]
    [Column("PersonID")]
    public Guid PersonId { get; set; }

    [Key]
    [Column("LanguageID")]
    public int LanguageId { get; set; }

    [StringLength(50)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    public string? MiddleName { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    [ForeignKey("PersonId")]
    [InverseProperty("PersonNameTranslations")]
    public virtual Person Person { get; set; } = null!;
}
