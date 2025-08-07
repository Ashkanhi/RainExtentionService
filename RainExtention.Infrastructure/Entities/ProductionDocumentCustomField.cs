using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ProductionDocumentCustomField")]
public partial class ProductionDocumentCustomField
{
    [Key]
    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [ForeignKey("DocumentId")]
    [InverseProperty("ProductionDocumentCustomField")]
    public virtual ProductionDocument Document { get; set; } = null!;
}
