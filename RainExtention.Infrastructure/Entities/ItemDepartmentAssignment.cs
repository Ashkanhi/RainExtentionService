using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "TypeId")]
[Table("ItemDepartmentAssignment")]
public partial class ItemDepartmentAssignment
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("ItemDepartmentAssignments")]
    public virtual Department? Department { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemDepartmentAssignments")]
    public virtual Item Item { get; set; } = null!;
}
