using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class RepositoryView
{
    [Column("RepositoryID")]
    public int RepositoryId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(50)]
    public string? BankName { get; set; }

    [StringLength(50)]
    public string? BranchName { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentAmount { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
