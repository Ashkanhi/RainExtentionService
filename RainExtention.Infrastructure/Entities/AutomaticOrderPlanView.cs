using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class AutomaticOrderPlanView
{
    [Column("PlanID")]
    public Guid PlanId { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    [Column("PlanTypeID")]
    public int? PlanTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("CalendarID")]
    public Guid? CalendarId { get; set; }

    [Column("PeriodID")]
    public int? PeriodId { get; set; }

    public int? PeriodYear { get; set; }

    [Column("SupplierSelectionTypeID")]
    public int? SupplierSelectionTypeId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? VoidUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(50)]
    public string? CreationUserName { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}
