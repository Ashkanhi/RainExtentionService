using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "DeliveryId")]
[Table("SaleItemDelivery")]
public partial class SaleItemDelivery
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [Key]
    [Column("DeliveryID")]
    public int DeliveryId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    [StringLength(1000)]
    public string? Address { get; set; }

    [StringLength(20)]
    public string? Tell { get; set; }

    [StringLength(20)]
    public string? Mobile { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Longitude { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Latitude { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InstallDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ConfirmDeliveryDate { get; set; }

    public int? Floor { get; set; }

    public bool? Elevator { get; set; }

    [Column("DeliveryPersonID")]
    public Guid? DeliveryPersonId { get; set; }

    [Column("InstallPersonID")]
    public Guid? InstallPersonId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? DeliveryPrice { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? InstallPrice { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    [StringLength(1000)]
    public string? InstallDescription { get; set; }

    public int? DeliveryRate { get; set; }

    public int? InstallRate { get; set; }

    public bool? IsDeliver { get; set; }

    public bool? IsInstall { get; set; }

    [Column("DeliveryTypeID")]
    public int? DeliveryTypeId { get; set; }

    [StringLength(50)]
    public string? ShippingCompany { get; set; }

    [StringLength(100)]
    public string? DriverName { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? FareAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ShippingDate { get; set; }

    [StringLength(50)]
    public string? ShippingNumber { get; set; }

    [StringLength(50)]
    public string? CertificateNumber { get; set; }

    public int? CarType { get; set; }

    [StringLength(50)]
    public string? CarTag { get; set; }

    public bool? FinanceApprove { get; set; }

    public Guid? FinanceApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinanceApproveDate { get; set; }

    public bool? IsInstallRequire { get; set; }

    public Guid? DeliveryApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryApproveDate { get; set; }

    public Guid? InstallApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InstallApproveDate { get; set; }

    [StringLength(50)]
    public string? ExtrernalCode { get; set; }

    [ForeignKey("DeliveryPersonId")]
    [InverseProperty("SaleItemDeliveryDeliveryPeople")]
    public virtual Employee? DeliveryPerson { get; set; }

    [ForeignKey("InstallPersonId")]
    [InverseProperty("SaleItemDeliveryInstallPeople")]
    public virtual Employee? InstallPerson { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId")]
    [InverseProperty("SaleItemDeliveries")]
    public virtual SaleInvoice SaleInvoice { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("SaleItemDeliveries")]
    public virtual Dictionary? Status { get; set; }
}
