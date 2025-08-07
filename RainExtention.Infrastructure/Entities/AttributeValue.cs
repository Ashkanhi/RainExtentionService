using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("AttributeId", "Id")]
[Table("AttributeValue")]
[Index("Id", "Value", Name = "IX_Value", IsUnique = true)]
public partial class AttributeValue
{
    [Key]
    [Column("AttributeID")]
    public Guid AttributeId { get; set; }

    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? DisplayText { get; set; }

    [StringLength(50)]
    public string? Value { get; set; }

    public bool? ExtendedValue { get; set; }

    [ForeignKey("AttributeId")]
    [InverseProperty("AttributeValues")]
    public virtual Attribute Attribute { get; set; } = null!;

    [InverseProperty("AttributeValue")]
    public virtual ICollection<ItemAssortment> ItemAssortments { get; set; } = new List<ItemAssortment>();

    [InverseProperty("AttributeValue")]
    public virtual ICollection<ItemAttributeItem> ItemAttributeItems { get; set; } = new List<ItemAttributeItem>();

    [InverseProperty("AttributeValue")]
    public virtual ICollection<ProductCatalogColor> ProductCatalogColors { get; set; } = new List<ProductCatalogColor>();

    [InverseProperty("AttributeValue")]
    public virtual ICollection<StockDocumentLineItemAttribute> StockDocumentLineItemAttributes { get; set; } = new List<StockDocumentLineItemAttribute>();

    [ForeignKey("AttributeId, ValueId")]
    [InverseProperty("AttributeValues")]
    public virtual ICollection<BillOfMaterialItem> BillOfMaterialItems { get; set; } = new List<BillOfMaterialItem>();
}
