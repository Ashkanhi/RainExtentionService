using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Application")]
public partial class Application
{
    [Key]
    [Column("AppicationID")]
    public int AppicationId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [InverseProperty("Application")]
    public virtual ICollection<ApplicationMenu> ApplicationMenus { get; set; } = new List<ApplicationMenu>();

    [ForeignKey("TypeId")]
    [InverseProperty("Applications")]
    public virtual Dictionary? Type { get; set; }
}
