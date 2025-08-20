using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ItemDepartmentLog")]
public partial class ItemDepartmentLog
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column("UserID")]
    public Guid? UserId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("ItemDepartmentLogs")]
    public virtual Department? Department { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemDepartmentLogs")]
    public virtual Item? Item { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ItemDepartmentLogs")]
    public virtual User? User { get; set; }
}
