using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ProductSize")]
public partial class ProductSize
{
    [Key]
    [Column("SizeID")]
    public int SizeId { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("DefaultAttributeValueID")]
    public Guid? DefaultAttributeValueId { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("ProductSizes")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("ProductSizes")]
    public virtual Department? Department { get; set; }

    [InverseProperty("Size")]
    public virtual ICollection<ProductSizeItem> ProductSizeItems { get; set; } = new List<ProductSizeItem>();
}
