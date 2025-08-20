using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class TreasuryAccountView
{
    [Column("AccountID")]
    public Guid AccountId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
