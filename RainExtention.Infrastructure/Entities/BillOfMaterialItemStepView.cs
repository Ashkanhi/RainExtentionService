using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class BillOfMaterialItemStepView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ChildID")]
    public Guid ChildId { get; set; }

    [Column("StepID")]
    public Guid StepId { get; set; }

    public int? StepOrder { get; set; }

    [StringLength(100)]
    public string? StepName { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }
}
