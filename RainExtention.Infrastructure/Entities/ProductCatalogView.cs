using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ProductCatalogView
{
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

    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [Column("ExternalID")]
    [StringLength(50)]
    public string? ExternalId { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [StringLength(100)]
    public string DepartmentName { get; set; } = null!;

    [StringLength(50)]
    public string? Type { get; set; }

    [StringLength(50)]
    public string? CreationUserName { get; set; }

    [StringLength(50)]
    public string? ModifyUserName { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
