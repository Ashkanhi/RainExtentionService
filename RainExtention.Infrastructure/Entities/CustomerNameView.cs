using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CustomerNameView
{
    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [StringLength(100)]
    public string? CustomerName { get; set; }
}
