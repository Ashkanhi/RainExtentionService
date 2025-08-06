using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("CustomerId", "ChildId", "TypeId")]
[Table("CustomerRelationship")]
public partial class CustomerRelationship
{
    [Key]
    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [Key]
    [Column("ChildID")]
    public Guid ChildId { get; set; }

    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [ForeignKey("ChildId")]
    [InverseProperty("CustomerRelationshipChildren")]
    public virtual Customer Child { get; set; } = null!;

    [ForeignKey("CustomerId")]
    [InverseProperty("CustomerRelationshipCustomers")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("TypeId")]
    [InverseProperty("CustomerRelationships")]
    public virtual Dictionary Type { get; set; } = null!;
}
