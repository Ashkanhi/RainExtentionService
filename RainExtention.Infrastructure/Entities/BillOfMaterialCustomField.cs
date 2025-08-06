using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("BillOfMaterialCustomField")]
public partial class BillOfMaterialCustomField
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("BillOfMaterialCustomField")]
    public virtual BillOfMaterial IdNavigation { get; set; } = null!;
}
