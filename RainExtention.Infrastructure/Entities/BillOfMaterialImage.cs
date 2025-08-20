using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "ImageId")]
[Table("BillOfMaterialImage")]
public partial class BillOfMaterialImage
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("ImageID")]
    public int ImageId { get; set; }

    [StringLength(200)]
    public string? Caption { get; set; }

    public byte[]? Image { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("BillOfMaterialImages")]
    public virtual BillOfMaterial IdNavigation { get; set; } = null!;
}
