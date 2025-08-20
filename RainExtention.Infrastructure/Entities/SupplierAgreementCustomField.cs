using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SupplierAgreementCustomField")]
public partial class SupplierAgreementCustomField
{
    [Key]
    [Column("AgreementID")]
    public Guid AgreementId { get; set; }

    [ForeignKey("AgreementId")]
    [InverseProperty("SupplierAgreementCustomField")]
    public virtual SupplierAgreement Agreement { get; set; } = null!;
}
