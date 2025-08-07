using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("CustomerCard")]
[Index("CardNumber", Name = "IX_CardNumber", IsUnique = true)]
[Index("ExpireDate", Name = "IX_ExpireDate")]
[Index("IsActive", Name = "IX_IsActive")]
[Index("Password", Name = "IX_Password")]
public partial class CustomerCard
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [StringLength(50)]
    public string CardNumber { get; set; } = null!;

    [StringLength(50)]
    public string? Password { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    public bool? IsActive { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("CustomerCards")]
    public virtual Customer Customer { get; set; } = null!;
}
