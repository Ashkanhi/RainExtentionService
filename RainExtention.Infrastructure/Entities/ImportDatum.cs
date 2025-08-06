using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

public partial class ImportDatum
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("ImportData")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<ImportDataItem> ImportDataItems { get; set; } = new List<ImportDataItem>();
}
