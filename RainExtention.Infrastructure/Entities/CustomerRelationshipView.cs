using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CustomerRelationshipView
{
    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [Column("ChildID")]
    public Guid ChildId { get; set; }

    [Column("TypeID")]
    public int TypeId { get; set; }

    [StringLength(152)]
    public string? CustomerName { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }
}
