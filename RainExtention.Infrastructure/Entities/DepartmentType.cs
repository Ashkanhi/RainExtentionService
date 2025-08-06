using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("DepartmentType")]
public partial class DepartmentType
{
    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("Type")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
