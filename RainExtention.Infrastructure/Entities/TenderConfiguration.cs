using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("TenderId", "StoreId", "WorkstationId")]
[Table("TenderConfiguration")]
public partial class TenderConfiguration
{
    [Key]
    [Column("TenderID")]
    public int TenderId { get; set; }

    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [Key]
    [Column("WorkstationID")]
    public int WorkstationId { get; set; }

    public string? Value { get; set; }

    [ForeignKey("TenderId")]
    [InverseProperty("TenderConfigurations")]
    public virtual Tender Tender { get; set; } = null!;

    [ForeignKey("StoreId, WorkstationId")]
    [InverseProperty("TenderConfigurations")]
    public virtual Workstation Workstation { get; set; } = null!;
}
