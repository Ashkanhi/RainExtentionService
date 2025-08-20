using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SupplierNameView
{
    [Column("SupplierID")]
    public Guid SupplierId { get; set; }

    [StringLength(101)]
    public string? Name { get; set; }

    [Column("LanguageID")]
    public int LanguageId { get; set; }
}
