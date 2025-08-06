using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("TaxGovermentInoiceHeaderLog")]
public partial class TaxGovermentInoiceHeaderLog
{
    public Guid InvoiceId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SaveDate { get; set; }

    public int? Inty { get; set; }

    [StringLength(50)]
    public string? Taxid { get; set; }

    [StringLength(50)]
    public string? Inno { get; set; }

    public int? Inp { get; set; }

    public int? Ins { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tins { get; set; }

    public int? Tob { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Bid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tinb { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Sbc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Bpc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Bbc { get; set; }

    public int? Ft { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Scln { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Scc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Crn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Billid { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tprdis { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tdis { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tadis { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tvam { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Todam { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tbill { get; set; }

    public int? Setm { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Cap { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Insp { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tvop { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tax17 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Cdcn { get; set; }

    public int? Cdcd { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tonw { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Torv { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Tocv { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(500)]
    public string? Irtaxid { get; set; }
}
