using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

public partial class ProductionSeries
{
    [Key]
    [Column("BatchID")]
    public Guid BatchId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [StringLength(50)]
    public string? BatchNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [InverseProperty("Batch")]
    public virtual ICollection<ProductionDocument> ProductionDocuments { get; set; } = new List<ProductionDocument>();
}
