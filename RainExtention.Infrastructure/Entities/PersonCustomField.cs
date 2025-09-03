using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("PersonCustomField")]
public partial class PersonCustomField
{
    [Key]
    [Column("PersonID")]
    public Guid PersonId { get; set; }

    [StringLength(50)]
    public string? Reserve1 { get; set; }

    [StringLength(50)]
    public string? Reserve2 { get; set; }

    [StringLength(50)]
    public string? Reserve3 { get; set; }

    [StringLength(50)]
    public string? Reserve4 { get; set; }

    [StringLength(50)]
    public string? Reserve5 { get; set; }

    [ForeignKey("PersonId")]
    [InverseProperty("PersonCustomField")]
    public virtual Person Person { get; set; } = null!;
}
