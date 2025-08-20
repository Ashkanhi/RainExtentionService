using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class UserView
{
    [Column("UserID")]
    public Guid UserId { get; set; }

    [Column("EmployeeID")]
    public Guid? EmployeeId { get; set; }

    [StringLength(50)]
    public string? DisplayName { get; set; }

    [StringLength(50)]
    public string? LoginName { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column("IsNTUser")]
    public bool? IsNtuser { get; set; }

    [StringLength(101)]
    public string? EmployeeName { get; set; }

    public string? Language { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }
}
