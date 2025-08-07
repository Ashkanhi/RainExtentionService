using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("TaxIDImport")]
public partial class TaxIdimport
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [Column("TaxID")]
    [StringLength(255)]
    public string? TaxId { get; set; }
}
