using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ActiveQuestion
{
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(1000)]
    public string? Question { get; set; }

    [Column("CategoryID")]
    public Guid? CategoryId { get; set; }

    public int? ResultType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    public int? Status { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }
}
