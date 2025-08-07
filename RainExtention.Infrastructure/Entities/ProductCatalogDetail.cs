using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("CatalogId", "StepId", "DetailId")]
[Table("ProductCatalogDetail")]
public partial class ProductCatalogDetail
{
    [Key]
    [Column("CatalogID")]
    public Guid CatalogId { get; set; }

    [Key]
    [Column("StepID")]
    public int StepId { get; set; }

    [Key]
    [Column("DetailID")]
    public int DetailId { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    public string? Description { get; set; }

    public byte[]? Image { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompleteDate { get; set; }

    public short? Progress { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [ForeignKey("CatalogId")]
    [InverseProperty("ProductCatalogDetails")]
    public virtual ProductCatalog Catalog { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("ProductCatalogDetails")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("StepId")]
    [InverseProperty("ProductCatalogDetails")]
    public virtual ProductCatalogStep Step { get; set; } = null!;
}
