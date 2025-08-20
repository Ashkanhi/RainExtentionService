using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CustomerFavorite
{
    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column("EntityID")]
    [StringLength(50)]
    public string? EntityId { get; set; }

    [ForeignKey("CustomerId")]
    public virtual Customer? Customer { get; set; }
}
