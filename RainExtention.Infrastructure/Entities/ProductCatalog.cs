using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ProductCatalog")]
public partial class ProductCatalog
{
    [Key]
    [Column("CatalogID")]
    public Guid CatalogId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("ProductCatalogCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ProductCatalogs")]
    public virtual Item? Item { get; set; }

    [ForeignKey("ModifyUser")]
    [InverseProperty("ProductCatalogModifyUserNavigations")]
    public virtual User? ModifyUserNavigation { get; set; }

    [InverseProperty("Catalog")]
    public virtual ICollection<ProductCatalogColor> ProductCatalogColors { get; set; } = new List<ProductCatalogColor>();

    [InverseProperty("Catalog")]
    public virtual ICollection<ProductCatalogDetail> ProductCatalogDetails { get; set; } = new List<ProductCatalogDetail>();

    [InverseProperty("Catalog")]
    public virtual ICollection<ProductCatalogSize> ProductCatalogSizes { get; set; } = new List<ProductCatalogSize>();

    [ForeignKey("TypeId")]
    [InverseProperty("ProductCatalogs")]
    public virtual Dictionary? Type { get; set; }

    [ForeignKey("CatalogId")]
    [InverseProperty("Catalogs")]
    public virtual ICollection<ProductCatalogStep> Steps { get; set; } = new List<ProductCatalogStep>();
}
