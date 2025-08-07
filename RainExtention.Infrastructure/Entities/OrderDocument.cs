using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "OrderId")]
[Table("OrderDocument")]
public partial class OrderDocument
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("OrderID")]
    public Guid OrderId { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [StringLength(15)]
    public string? OrderCode { get; set; }

    public DateOnly? OrderDate { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

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
    [InverseProperty("OrderDocumentApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("OrderDocumentCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("OrderDocument")]
    public virtual ICollection<OrderDocumentLineItem> OrderDocumentLineItems { get; set; } = new List<OrderDocumentLineItem>();

    [ForeignKey("StoreId")]
    [InverseProperty("OrderDocuments")]
    public virtual Store? Store { get; set; }

    [ForeignKey("VoidUser")]
    [InverseProperty("OrderDocumentVoidUserNavigations")]
    public virtual User? VoidUserNavigation { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId")]
    [InverseProperty("OrderDocuments")]
    public virtual Workstation Workstation { get; set; } = null!;
}
