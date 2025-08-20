using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class TaskView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [Column("CategoryID")]
    public Guid? CategoryId { get; set; }

    [Column("UserID")]
    public Guid? UserId { get; set; }

    [StringLength(20)]
    public string? TaskNumber { get; set; }

    [StringLength(255)]
    public string? Subject { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompleteDate { get; set; }

    public short? Progress { get; set; }

    public int? TimeEstimate { get; set; }

    [Column("TimeTypeID")]
    public short? TimeTypeId { get; set; }

    [Column("PriorityID")]
    public int? PriorityId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public bool? IsPrivate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [StringLength(255)]
    public string? CategoryName { get; set; }

    [StringLength(50)]
    public string? UserName { get; set; }

    [StringLength(50)]
    public string? CreationUserName { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(50)]
    public string? Priority { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
