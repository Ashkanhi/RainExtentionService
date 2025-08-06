using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("EmployeeCustomField")]
public partial class EmployeeCustomField
{
    [Key]
    [Column("EmployeeID")]
    public Guid EmployeeId { get; set; }

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

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeCustomField")]
    public virtual Employee Employee { get; set; } = null!;
}
