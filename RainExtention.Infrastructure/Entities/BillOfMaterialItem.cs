using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "ChildId")]
[Table("BillOfMaterialItem")]
public partial class BillOfMaterialItem
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("ChildID")]
    public Guid ChildId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Weight { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [Column("StepID")]
    public Guid? StepId { get; set; }

    [Column("SecondStepID")]
    public Guid? SecondStepId { get; set; }

    [Column("ThirdStepID")]
    public Guid? ThirdStepId { get; set; }

    [InverseProperty("BillOfMaterialItem")]
    public virtual ICollection<BillOfMaterialItemRelatedItem> BillOfMaterialItemRelatedItems { get; set; } = new List<BillOfMaterialItemRelatedItem>();

    [InverseProperty("BillOfMaterialItem")]
    public virtual ICollection<BillOfMaterialItemStep> BillOfMaterialItemSteps { get; set; } = new List<BillOfMaterialItemStep>();

    [ForeignKey("ChildId")]
    [InverseProperty("BillOfMaterialItems")]
    public virtual Item Child { get; set; } = null!;

    [ForeignKey("Id")]
    [InverseProperty("BillOfMaterialItems")]
    public virtual BillOfMaterial IdNavigation { get; set; } = null!;

    [ForeignKey("Id, ChildId")]
    [InverseProperty("BillOfMaterialItems")]
    public virtual ICollection<AttributeValue> AttributeValues { get; set; } = new List<AttributeValue>();
}
