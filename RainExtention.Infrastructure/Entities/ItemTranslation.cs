using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "LanguageId")]
public partial class ItemTranslation
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("LanguageID")]
    public int LanguageId { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemTranslations")]
    public virtual Item Item { get; set; } = null!;
}
