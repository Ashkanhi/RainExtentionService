using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("BillOfMaterial")]
public partial class BillOfMaterial
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? VoidUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    [ForeignKey("ApproveUser")]
    [InverseProperty("BillOfMaterialApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual BillOfMaterialCustomField? BillOfMaterialCustomField { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<BillOfMaterialImage> BillOfMaterialImages { get; set; } = new List<BillOfMaterialImage>();

    [InverseProperty("IdNavigation")]
    public virtual ICollection<BillOfMaterialItem> BillOfMaterialItems { get; set; } = new List<BillOfMaterialItem>();

    [ForeignKey("CreationUser")]
    [InverseProperty("BillOfMaterialCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("BillOfMaterials")]
    public virtual Item? Item { get; set; }

    [InverseProperty("Bom")]
    public virtual ICollection<ProductionDocumentLineItem> ProductionDocumentLineItems { get; set; } = new List<ProductionDocumentLineItem>();

    [ForeignKey("StatusId")]
    [InverseProperty("BillOfMaterials")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("VoidUser")]
    [InverseProperty("BillOfMaterialVoidUserNavigations")]
    public virtual User? VoidUserNavigation { get; set; }
}
