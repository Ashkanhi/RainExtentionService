using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class OrderDocumentView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

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

    [StringLength(10)]
    public string? Date { get; set; }

    [StringLength(50)]
    public string? StoreName { get; set; }

    [StringLength(50)]
    public string? CreationUserName { get; set; }

    [StringLength(50)]
    public string? ApproveUserName { get; set; }

    [StringLength(50)]
    public string? VoidUserName { get; set; }

    [Column("LanguageID")]
    public int LanguageId { get; set; }
}
