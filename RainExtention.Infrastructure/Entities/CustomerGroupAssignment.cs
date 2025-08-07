using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("CustomerId", "TypeId")]
[Table("CustomerGroupAssignment")]
public partial class CustomerGroupAssignment
{
    [Column("CustomerGroupID")]
    public Guid CustomerGroupId { get; set; }

    [Key]
    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("CustomerGroupAssignments")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("CustomerGroupId")]
    [InverseProperty("CustomerGroupAssignments")]
    public virtual CustomerGroup CustomerGroup { get; set; } = null!;
}
