using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("CompanyCustomField")]
public partial class CompanyCustomField
{
    [Key]
    [Column("CompanyID")]
    public Guid CompanyId { get; set; }

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

    [ForeignKey("CompanyId")]
    [InverseProperty("CompanyCustomField")]
    public virtual Company Company { get; set; } = null!;
}
