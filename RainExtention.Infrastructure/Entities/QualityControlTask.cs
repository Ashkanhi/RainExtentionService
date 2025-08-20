using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("QualityControlTask")]
public partial class QualityControlTask
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("QualityControlTasks")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<QualityControlTaskItem> QualityControlTaskItems { get; set; } = new List<QualityControlTaskItem>();

    [ForeignKey("Id")]
    [InverseProperty("Ids")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
