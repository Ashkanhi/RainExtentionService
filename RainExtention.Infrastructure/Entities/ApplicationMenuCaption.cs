using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("MenuId", "LanguageId")]
[Table("ApplicationMenuCaption")]
public partial class ApplicationMenuCaption
{
    [Key]
    [Column("MenuID")]
    public int MenuId { get; set; }

    [Key]
    [Column("LanguageID")]
    public int LanguageId { get; set; }

    [StringLength(100)]
    public string? Caption { get; set; }

    [ForeignKey("LanguageId")]
    [InverseProperty("ApplicationMenuCaptions")]
    public virtual Dictionary Language { get; set; } = null!;

    [ForeignKey("MenuId")]
    [InverseProperty("ApplicationMenuCaptions")]
    public virtual ApplicationMenu Menu { get; set; } = null!;
}
