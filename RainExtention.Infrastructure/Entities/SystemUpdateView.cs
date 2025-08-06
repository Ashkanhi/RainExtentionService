using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SystemUpdateView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? UpdateVersion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateTime { get; set; }

    public byte[]? PatchFile { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    [Column("WorkstationID")]
    public int WorkstationId { get; set; }

    public int? Status { get; set; }
}
