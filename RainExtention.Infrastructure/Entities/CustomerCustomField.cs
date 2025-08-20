using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("CustomerCustomField")]
public partial class CustomerCustomField
{
    [Key]
    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("CustomerCustomField")]
    public virtual Customer Customer { get; set; } = null!;
}
