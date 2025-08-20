using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("StoreId", "WorkstationId")]
[Table("Workstation")]
public partial class Workstation
{
    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [Key]
    [Column("WorkstationID")]
    public int WorkstationId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Hostname { get; set; }

    [StringLength(50)]
    public string? DatabaseServer { get; set; }

    [Column("UserID")]
    [StringLength(50)]
    public string? UserId { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    public string? ExtraInfo { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column("HardwareID")]
    [StringLength(100)]
    public string? HardwareId { get; set; }

    [Column("IPAddress")]
    [StringLength(20)]
    public string? Ipaddress { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [InverseProperty("Workstation")]
    public virtual ICollection<CashLoan> CashLoans { get; set; } = new List<CashLoan>();

    [InverseProperty("Workstation")]
    public virtual ICollection<CashSettelment> CashSettelments { get; set; } = new List<CashSettelment>();

    [InverseProperty("Workstation")]
    public virtual ICollection<OrderDocument> OrderDocuments { get; set; } = new List<OrderDocument>();

    [InverseProperty("Workstation")]
    public virtual ICollection<SaleInvoice> SaleInvoices { get; set; } = new List<SaleInvoice>();

    [InverseProperty("Workstation")]
    public virtual ICollection<StockDocument> StockDocuments { get; set; } = new List<StockDocument>();

    [ForeignKey("StoreId")]
    [InverseProperty("Workstations")]
    public virtual Store Store { get; set; } = null!;

    [InverseProperty("Workstation")]
    public virtual ICollection<TenderConfiguration> TenderConfigurations { get; set; } = new List<TenderConfiguration>();

    [InverseProperty("Workstation")]
    public virtual ICollection<TreasuryDocument> TreasuryDocuments { get; set; } = new List<TreasuryDocument>();

    [ForeignKey("TypeId")]
    [InverseProperty("Workstations")]
    public virtual Dictionary? Type { get; set; }

    [ForeignKey("StoreId, WorkstationId")]
    [InverseProperty("Workstations")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
