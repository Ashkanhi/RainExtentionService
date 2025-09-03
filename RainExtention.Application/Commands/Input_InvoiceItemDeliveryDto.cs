using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Application.Commands
{
  public  class Input_InvoiceItemDeliveryDto
    {
        public int BookerStoreId { get; set; }
        public int BookerWorkstationId { get; set; }
        public Guid InvoiceId { get; set; }
        public int DeliveryId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? Address { get; set; }
        public string? Tell { get; set; }
        public string? Mobile { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public DateTime? InstallDate { get; set; }
        public DateTime? ConfirmDeliveryDate { get; set; }
        public int? Floor { get; set; }
        public bool? Elevator { get; set; }
        public Guid? DeliveryPersonId { get; set; }
        public Guid? InstallPersonId { get; set; }
        public decimal? DeliveryPrice { get; set; }
        public decimal? InstallPrice { get; set; }
        public int? StatusId { get; set; }
        public string? Description { get; set; }
        public string? InstallDescription { get; set; }
        public int? DeliveryRate { get; set; }
        public int? InstallRate { get; set; }
        public bool? IsDeliver { get; set; }
        public bool? IsInstall { get; set; }
        public int? DeliveryTypeId { get; set; }
        public string? ShippingCompany { get; set; }
        public string? DriverName { get; set; }
        public decimal? FareAmount { get; set; }
        public DateTime? ShippingDate { get; set; }
        public string? ShippingNumber { get; set; }
        public string? CertificateNumber { get; set; }
        public int? CarType { get; set; }
        public string? CarTag { get; set; }
        public bool? FinanceApprove { get; set; }
        public Guid? FinanceApproveUser { get; set; }
        public DateTime? FinanceApproveDate { get; set; }
        public bool? IsInstallRequire { get; set; }
        public Guid? DeliveryApproveUser { get; set; }
        public DateTime? DeliveryApproveDate { get; set; }
        public Guid? InstallApproveUser { get; set; }
        public DateTime? InstallApproveDate { get; set; }
        public string? ExtrernalCode { get; set; }
    }
}
