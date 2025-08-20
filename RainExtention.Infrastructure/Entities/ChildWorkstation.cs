using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ChildWorkstation
{
    [Column("StoreID")]
    public int StoreId { get; set; }

    [Column("WorkstationID")]
    public int WorkstationId { get; set; }

    [Column("ParentID")]
    public int? ParentId { get; set; }
}
