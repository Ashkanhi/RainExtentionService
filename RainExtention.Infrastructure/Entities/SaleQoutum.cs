using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

public partial class SaleQoutum
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("QoutaTypeID")]
    public int? QoutaTypeId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    public Guid? VoidUser { get; set; }

    [ForeignKey("ApproveUser")]
    [InverseProperty("SaleQoutumApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("SaleQoutumCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("QoutaTypeId")]
    [InverseProperty("SaleQoutumQoutaTypes")]
    public virtual Dictionary? QoutaType { get; set; }

    [InverseProperty("Qouta")]
    public virtual ICollection<SaleQoutaDepartmentAssignment> SaleQoutaDepartmentAssignments { get; set; } = new List<SaleQoutaDepartmentAssignment>();

    [InverseProperty("Qouta")]
    public virtual ICollection<SaleQoutaItemAssignment> SaleQoutaItemAssignments { get; set; } = new List<SaleQoutaItemAssignment>();

    [ForeignKey("StatusId")]
    [InverseProperty("SaleQoutumStatuses")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("VoidUser")]
    [InverseProperty("SaleQoutumVoidUserNavigations")]
    public virtual User? VoidUserNavigation { get; set; }

    [ForeignKey("QouatId")]
    [InverseProperty("Qouats")]
    public virtual ICollection<CustomerGroup> CustomerGroups { get; set; } = new List<CustomerGroup>();

    [ForeignKey("QouatId")]
    [InverseProperty("Qouats")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
