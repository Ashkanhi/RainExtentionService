using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ProductionPlan")]
public partial class ProductionPlan
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

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

    [Column("SeasonID")]
    public int? SeasonId { get; set; }

    [ForeignKey("ApproveUser")]
    [InverseProperty("ProductionPlanApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("ProductionPlanCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("Plan")]
    public virtual ICollection<ProductionOrderLineItem> ProductionOrderLineItems { get; set; } = new List<ProductionOrderLineItem>();

    [InverseProperty("IdNavigation")]
    public virtual ProductionPlanCustomField? ProductionPlanCustomField { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<ProductionPlanDepartment> ProductionPlanDepartments { get; set; } = new List<ProductionPlanDepartment>();

    [ForeignKey("SeasonId")]
    [InverseProperty("ProductionPlanSeasons")]
    public virtual Dictionary? Season { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("ProductionPlanStatuses")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("VoidUser")]
    [InverseProperty("ProductionPlanVoidUserNavigations")]
    public virtual User? VoidUserNavigation { get; set; }
}
