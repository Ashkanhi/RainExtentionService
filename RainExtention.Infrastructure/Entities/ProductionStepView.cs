using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ProductionStepView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [Column("StockID")]
    public Guid? StockId { get; set; }

    public bool? AllowThirdParty { get; set; }

    public bool? AllowWithoutParent { get; set; }

    public bool? AllowCosting { get; set; }

    public bool? AllowDecomposition { get; set; }

    [Column("AllowBOM")]
    public bool? AllowBom { get; set; }

    public int? StepOrder { get; set; }

    [Column("PermissionID")]
    public int? PermissionId { get; set; }

    [Column("ApprovePermissionID")]
    public int? ApprovePermissionId { get; set; }

    [Column("VoidPermissionID")]
    public int? VoidPermissionId { get; set; }

    public Guid? Attribute1 { get; set; }

    public Guid? Attribute2 { get; set; }

    public Guid? Attribute3 { get; set; }

    public Guid? Attribute4 { get; set; }

    public Guid? Attribute5 { get; set; }

    [Column("AllowPartialBOM")]
    public bool? AllowPartialBom { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    public bool? AllowDeliveryDate { get; set; }

    public int? PersonCount { get; set; }

    [StringLength(50)]
    public string? GroupName { get; set; }

    [Column("AllowQC")]
    public bool? AllowQc { get; set; }

    [Column("OperationID")]
    public Guid? OperationId { get; set; }

    public bool? IsFinalStep { get; set; }

    [Column("ProductionTyepID")]
    public int? ProductionTyepId { get; set; }

    [StringLength(50)]
    public string? StockName { get; set; }

    [StringLength(100)]
    public string? PreviousStep { get; set; }
}
