using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ShelfPrice")]
public partial class ShelfPrice
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public Guid? CreationUser { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("ShelfPrices")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<ShelfPriceItem> ShelfPriceItems { get; set; } = new List<ShelfPriceItem>();
}
