using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class FinancialExport
{
    [Column("ID")]
    [StringLength(50)]
    public string Id { get; set; } = null!;

    [Column("OperationID")]
    public Guid OperationId { get; set; }

    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocumentDate { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Amount { get; set; }

    [Column("UserID")]
    public Guid? UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExportDate { get; set; }
}
