using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ItemImage")]
public partial class ItemImage
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    public byte[]? Image { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemImages")]
    public virtual Item? Item { get; set; }
}
