using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Users")]
[Index("Email", Name = "UQ__Users__A9D10534C4E5C55D", IsUnique = true)]
public partial class User1
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }
}
