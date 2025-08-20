using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class DistributeDataView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("SystemID")]
    public int? SystemId { get; set; }

    public short? MessageType { get; set; }

    [Column("EntityID")]
    [StringLength(50)]
    public string? EntityId { get; set; }

    [StringLength(100)]
    public string? EntityName { get; set; }

    public string? EntityInfo { get; set; }

    public short? Direction { get; set; }

    public short? Priority { get; set; }

    public short? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GenerationTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SynchTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SendTime { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    [Column("WorkstationID")]
    public int WorkstationId { get; set; }
}
