using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("AgreementId", "DepartmentId")]
[Table("SupplierAgreementDepartment")]
public partial class SupplierAgreementDepartment
{
    [Key]
    [Column("AgreementID")]
    public Guid AgreementId { get; set; }

    [Key]
    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MarginPercent { get; set; }

    [ForeignKey("AgreementId")]
    [InverseProperty("SupplierAgreementDepartments")]
    public virtual SupplierAgreement Agreement { get; set; } = null!;

    [ForeignKey("DepartmentId")]
    [InverseProperty("SupplierAgreementDepartments")]
    public virtual Department Department { get; set; } = null!;
}
