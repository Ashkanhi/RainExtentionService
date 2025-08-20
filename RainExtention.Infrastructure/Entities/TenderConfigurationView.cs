using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class TenderConfigurationView
{
    [Column("TenderID")]
    public int TenderId { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    [Column("WorkstationID")]
    public int WorkstationId { get; set; }

    public string? Value { get; set; }

    [StringLength(50)]
    public string? StoreName { get; set; }

    [StringLength(50)]
    public string? WorkstationName { get; set; }
}
