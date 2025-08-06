using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class FinancialExportView
{
    [Column("OperationID")]
    public Guid? OperationId { get; set; }

    [Column("ID")]
    public Guid? Id { get; set; }

    public DateOnly? Date { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    [StringLength(50)]
    public string? SecondCode { get; set; }

    [Column("EntityID")]
    [StringLength(40)]
    public string? EntityId { get; set; }

    [StringLength(101)]
    public string? EntityName { get; set; }

    [StringLength(100)]
    public string? DocumentType { get; set; }

    [Column("TypeID")]
    public int TypeId { get; set; }
}
