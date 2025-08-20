using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("StoreId", "WorkstationId")]
[Table("DimWorkstation")]
public partial class DimWorkstation
{
    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [Key]
    [Column("WorkstationID")]
    public int WorkstationId { get; set; }

    [StringLength(50)]
    public string? WorkstationName { get; set; }
}
