using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("FileRepository")]
public partial class FileRepository
{
    [Key]
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

    [ForeignKey("DepartmentId")]
    [InverseProperty("FileRepositories")]
    public virtual Department? Department { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("FileRepositories")]
    public virtual Dictionary? Status { get; set; }
}
