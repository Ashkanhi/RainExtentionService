using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class RecentItemView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("UserID")]
    public Guid? UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecentDate { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column("EntityID")]
    [StringLength(50)]
    public string? EntityId { get; set; }

    [StringLength(100)]
    public string? EntityName { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
