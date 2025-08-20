using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("FinancialMapping")]
public partial class FinancialMapping
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("OperationID")]
    public Guid? OperationId { get; set; }

    public int? Kind { get; set; }

    [StringLength(50)]
    public string? FieldValue { get; set; }

    [Column("CreditSubAccountID")]
    [StringLength(50)]
    public string? CreditSubAccountId { get; set; }

    [StringLength(50)]
    public string? CreditSubAccount { get; set; }

    public bool? CreditCostCenter { get; set; }

    public bool? CreditAccountNumber { get; set; }

    [StringLength(50)]
    public string? CreditDetailAccount { get; set; }

    [StringLength(50)]
    public string? CreditDetailAccount2 { get; set; }

    [StringLength(50)]
    public string? CreditDetailAccount3 { get; set; }

    [Column("DebitSubAccountID")]
    [StringLength(50)]
    public string? DebitSubAccountId { get; set; }

    [StringLength(50)]
    public string? DebitSubAccount { get; set; }

    public bool? DebitCostCenter { get; set; }

    public bool? DebitAccountNumber { get; set; }

    [StringLength(50)]
    public string? DebitDetailAccount { get; set; }

    [StringLength(50)]
    public string? DebitDetailAccount2 { get; set; }

    [StringLength(50)]
    public string? DebitDetailAccount3 { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? OrderNo { get; set; }

    [ForeignKey("OperationId")]
    [InverseProperty("FinancialMappings")]
    public virtual ExportDataConfig? Operation { get; set; }
}
