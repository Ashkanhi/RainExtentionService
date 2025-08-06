using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("UserId", "Name")]
[Table("UserCustomLayout")]
public partial class UserCustomLayout
{
    [Key]
    [Column("UserID")]
    public Guid UserId { get; set; }

    [Key]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserCustomLayouts")]
    public virtual User User { get; set; } = null!;
}
