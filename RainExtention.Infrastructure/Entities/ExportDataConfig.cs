using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ExportDataConfig")]
public partial class ExportDataConfig
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public string? Data { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [InverseProperty("Operation")]
    public virtual ICollection<FinancialMapping> FinancialMappings { get; set; } = new List<FinancialMapping>();
}
