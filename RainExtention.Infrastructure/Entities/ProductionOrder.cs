using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ProductionOrder")]
public partial class ProductionOrder
{
    [Key]
    [Column("OrderID")]
    public Guid OrderId { get; set; }

    [StringLength(50)]
    public string? OrderCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    public Guid? VoidUser { get; set; }

    [Column("ProductionTyepID")]
    public int? ProductionTyepId { get; set; }

    [ForeignKey("ApproveUser")]
    [InverseProperty("ProductionOrderApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("ProductionOrderCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<ProductionDocument> ProductionDocuments { get; set; } = new List<ProductionDocument>();

    [InverseProperty("Order")]
    public virtual ProductionOrderCustomField? ProductionOrderCustomField { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<ProductionOrderLineItem> ProductionOrderLineItems { get; set; } = new List<ProductionOrderLineItem>();

    [ForeignKey("StatusId")]
    [InverseProperty("ProductionOrders")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("VoidUser")]
    [InverseProperty("ProductionOrderVoidUserNavigations")]
    public virtual User? VoidUserNavigation { get; set; }
}
