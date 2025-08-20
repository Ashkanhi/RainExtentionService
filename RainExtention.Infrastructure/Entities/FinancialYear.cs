using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("FinancialYear")]
[Index("CompanyCode", "StartDate", "EndDate", Name = "IX_FinancialYear", IsUnique = true)]
public partial class FinancialYear
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(10)]
    public string? CompanyCode { get; set; }

    public int? CodeLength { get; set; }

    [InverseProperty("FinancialYear")]
    public virtual ICollection<FinancialDocument> FinancialDocuments { get; set; } = new List<FinancialDocument>();

    [ForeignKey("StatusId")]
    [InverseProperty("FinancialYears")]
    public virtual Dictionary? Status { get; set; }
}
