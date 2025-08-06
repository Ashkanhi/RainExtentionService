using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("AgreementId", "StoreId")]
public partial class SupplierAgreementStore
{
    [Key]
    [Column("AgreementID")]
    public Guid AgreementId { get; set; }

    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [ForeignKey("AgreementId")]
    [InverseProperty("SupplierAgreementStores")]
    public virtual SupplierAgreement Agreement { get; set; } = null!;
}
