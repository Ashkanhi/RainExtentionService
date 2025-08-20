using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("TaxGovermentInoiceDetailLog")]
public partial class TaxGovermentInoiceDetailLog
{
    [StringLength(255)]
    public string? Sstid { get; set; }

    [StringLength(255)]
    public string? Sstt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Mu { get; set; }

    [Column(TypeName = "decimal(19, 3)")]
    public decimal? Am { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Fee { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Prdis { get; set; }

    [Column(TypeName = "decimal(20, 3)")]
    public decimal? Dis { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Adis { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Vra { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Vam { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Odt { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Odr { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Odam { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Olt { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Olr { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Olam { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Consfee { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Spro { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Bros { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tcpbs { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Cop { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Vop { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Bsrn { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Tsstam { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Nw { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Ssrv { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Sscv { get; set; }

    public Guid? InvoiceId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }
}
