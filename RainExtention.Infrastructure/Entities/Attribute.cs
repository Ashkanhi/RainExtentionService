using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Attribute")]
[Index("Code", Name = "IX_Code", IsUnique = true)]
public partial class Attribute
{
    [Key]
    [Column("AttributeID")]
    public Guid AttributeId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public int? CodeLength { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [InverseProperty("Attribute")]
    public virtual ICollection<AttributeValue> AttributeValues { get; set; } = new List<AttributeValue>();

    [ForeignKey("AttributeId")]
    [InverseProperty("Attributes")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
