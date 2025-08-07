using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemImageView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [StringLength(119)]
    public string? ImageUrl { get; set; }
}
