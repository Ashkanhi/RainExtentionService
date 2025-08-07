using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Department")]
[Index("LevelId", Name = "IX_LevelID")]
[Index("TypeId", Name = "IX_TypeID")]
public partial class Department
{
    [Key]
    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    public bool? Taxable { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TollAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CommissionPercent { get; set; }

    [Column("OwnerGroupID")]
    public Guid? OwnerGroupId { get; set; }

    public byte[]? Image { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(50)]
    public string? DepartmentCode { get; set; }

    [Column("LevelID")]
    public int? LevelId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxUsageAmount { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<AutomaticOrderPlanDepartmentAssignment> AutomaticOrderPlanDepartmentAssignments { get; set; } = new List<AutomaticOrderPlanDepartmentAssignment>();

    [InverseProperty("Department")]
    public virtual ICollection<AutomaticOrderPlanDepartmentEvent> AutomaticOrderPlanDepartmentEvents { get; set; } = new List<AutomaticOrderPlanDepartmentEvent>();

    [InverseProperty("Department")]
    public virtual ICollection<DiscountDepartmentAssignment> DiscountDepartmentAssignments { get; set; } = new List<DiscountDepartmentAssignment>();

    [InverseProperty("Department")]
    public virtual ICollection<FileRepository> FileRepositories { get; set; } = new List<FileRepository>();

    [InverseProperty("Parent")]
    public virtual ICollection<Department> InverseParent { get; set; } = new List<Department>();

    [InverseProperty("Department")]
    public virtual ICollection<ItemDepartmentAssignment> ItemDepartmentAssignments { get; set; } = new List<ItemDepartmentAssignment>();

    [InverseProperty("Department")]
    public virtual ICollection<ItemDepartmentLog> ItemDepartmentLogs { get; set; } = new List<ItemDepartmentLog>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual Department? Parent { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<PartialPaymentRuleDepartmentAssignment> PartialPaymentRuleDepartmentAssignments { get; set; } = new List<PartialPaymentRuleDepartmentAssignment>();

    [InverseProperty("Department")]
    public virtual ICollection<ProductSize> ProductSizes { get; set; } = new List<ProductSize>();

    [InverseProperty("Department")]
    public virtual ICollection<ProductionPlanDepartment> ProductionPlanDepartments { get; set; } = new List<ProductionPlanDepartment>();

    [InverseProperty("Department")]
    public virtual ICollection<SaleQoutaDepartmentAssignment> SaleQoutaDepartmentAssignments { get; set; } = new List<SaleQoutaDepartmentAssignment>();

    [InverseProperty("Department")]
    public virtual ICollection<ServiceItem> ServiceItems { get; set; } = new List<ServiceItem>();

    [InverseProperty("Department")]
    public virtual ICollection<StoreContractDepartment> StoreContractDepartments { get; set; } = new List<StoreContractDepartment>();

    [InverseProperty("Department")]
    public virtual ICollection<SupplierAgreementDepartment> SupplierAgreementDepartments { get; set; } = new List<SupplierAgreementDepartment>();

    [ForeignKey("TypeId")]
    [InverseProperty("Departments")]
    public virtual DepartmentType? Type { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Departments")]
    public virtual ICollection<Attribute> Attributes { get; set; } = new List<Attribute>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Departments")]
    public virtual ICollection<QualityControlTask> Ids { get; set; } = new List<QualityControlTask>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Departments")]
    public virtual ICollection<Lottery> Lotteries { get; set; } = new List<Lottery>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Departments")]
    public virtual ICollection<ProductCatalogStep> Steps { get; set; } = new List<ProductCatalogStep>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Departments")]
    public virtual ICollection<ItemTag> Tags { get; set; } = new List<ItemTag>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Departments")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Departments")]
    public virtual ICollection<Workstation> Workstations { get; set; } = new List<Workstation>();
}
