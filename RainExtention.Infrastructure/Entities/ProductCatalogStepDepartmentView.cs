using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ProductCatalogStepDepartmentView
{
    [Column("StepID")]
    public int StepId { get; set; }

    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }

    [StringLength(50)]
    public string? DepartmentCode { get; set; }
}
