using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemTagItemAssignmentView
{
    [Column("TagID")]
    public Guid TagId { get; set; }

    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }
}
