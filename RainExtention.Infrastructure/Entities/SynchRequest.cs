using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SynchRequest")]
public partial class SynchRequest
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("EntityID")]
    [StringLength(50)]
    public string? EntityId { get; set; }

    public int? EntityType { get; set; }

    public int? Direction { get; set; }

    public bool? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GenerationTime { get; set; }
}
