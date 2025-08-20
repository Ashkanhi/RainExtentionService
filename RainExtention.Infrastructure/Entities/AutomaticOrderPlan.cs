using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("AutomaticOrderPlan")]
public partial class AutomaticOrderPlan
{
    [Key]
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

    [InverseProperty("Plan")]
    public virtual ICollection<AutomaticOrderPlanDepartmentAssignment> AutomaticOrderPlanDepartmentAssignments { get; set; } = new List<AutomaticOrderPlanDepartmentAssignment>();

    [InverseProperty("Plan")]
    public virtual ICollection<AutomaticOrderPlanHistory> AutomaticOrderPlanHistories { get; set; } = new List<AutomaticOrderPlanHistory>();

    [InverseProperty("Plan")]
    public virtual ICollection<AutomaticOrderPlanItemAssignment> AutomaticOrderPlanItemAssignments { get; set; } = new List<AutomaticOrderPlanItemAssignment>();

    [ForeignKey("CalendarId")]
    [InverseProperty("AutomaticOrderPlans")]
    public virtual PlanningCalendar? Calendar { get; set; }

    [ForeignKey("PeriodId")]
    [InverseProperty("AutomaticOrderPlanPeriods")]
    public virtual Dictionary? Period { get; set; }

    [ForeignKey("PlanTypeId")]
    [InverseProperty("AutomaticOrderPlanPlanTypes")]
    public virtual Dictionary? PlanType { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("AutomaticOrderPlanStatuses")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("PlanId")]
    [InverseProperty("Plans")]
    public virtual ICollection<StoreGroup> Groups { get; set; } = new List<StoreGroup>();

    [ForeignKey("PlanId")]
    [InverseProperty("Plans")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();

    [ForeignKey("PlanId")]
    [InverseProperty("Plans")]
    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
