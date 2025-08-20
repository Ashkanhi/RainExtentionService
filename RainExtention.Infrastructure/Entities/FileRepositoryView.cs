using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class FileRepositoryView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(100)]
    public string? Title { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [StringLength(255)]
    public string? FileName { get; set; }

    public byte[]? FileContent { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
