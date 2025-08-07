using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class UvTissInfo
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("cap", TypeName = "decimal(38, 0)")]
    public decimal? Cap { get; set; }

    [Column("bid")]
    public int? Bid { get; set; }

    [Column("bpc")]
    public int? Bpc { get; set; }

    [Column("bbc")]
    public int? Bbc { get; set; }

    [Column("bpn")]
    public int? Bpn { get; set; }

    [Column("ft")]
    public int? Ft { get; set; }

    [Column("scln")]
    public int? Scln { get; set; }

    [Column("scc")]
    public int? Scc { get; set; }

    [Column("crn")]
    public int? Crn { get; set; }

    [Column("cdcn")]
    public int? Cdcn { get; set; }

    [Column("cdcd")]
    public int? Cdcd { get; set; }

    [Column("billid")]
    public int? Billid { get; set; }

    [Column("tprdis", TypeName = "decimal(38, 6)")]
    public decimal? Tprdis { get; set; }

    [Column("tdis", TypeName = "decimal(38, 0)")]
    public decimal? Tdis { get; set; }

    [Column("tadis", TypeName = "decimal(38, 0)")]
    public decimal? Tadis { get; set; }

    [Column("tvam", TypeName = "decimal(38, 0)")]
    public decimal? Tvam { get; set; }

    [Column("todam")]
    public int? Todam { get; set; }

    [Column("tbill", TypeName = "decimal(38, 0)")]
    public decimal? Tbill { get; set; }

    [Column("tonw")]
    public int? Tonw { get; set; }

    [Column("torv")]
    public int? Torv { get; set; }

    [Column("tocv")]
    public int? Tocv { get; set; }

    [Column("setm")]
    public int Setm { get; set; }

    [Column("insp")]
    public int? Insp { get; set; }

    [Column("tvop")]
    public int? Tvop { get; set; }

    [Column("taxid")]
    [StringLength(1)]
    [Unicode(false)]
    public string Taxid { get; set; } = null!;

    [Column("indatim")]
    [StringLength(4000)]
    public string Indatim { get; set; } = null!;

    [Column("inty")]
    public int Inty { get; set; }

    [Column("inno")]
    public long? Inno { get; set; }

    [Column("irtaxid")]
    [StringLength(100)]
    public string? Irtaxid { get; set; }

    [Column("inp")]
    public int Inp { get; set; }

    [Column("ins")]
    public int? Ins { get; set; }

    [Column("tins")]
    [StringLength(14)]
    [Unicode(false)]
    public string Tins { get; set; } = null!;

    [Column("tinb")]
    public int? Tinb { get; set; }

    [Column("tob")]
    public int? Tob { get; set; }

    public int? Tax17 { get; set; }

    public int? Indati2m { get; set; }

    [Column("sstid")]
    [StringLength(100)]
    public string? Sstid { get; set; }

    [Column("sstt")]
    [StringLength(255)]
    public string? Sstt { get; set; }

    [Column("mu")]
    public int? Mu { get; set; }

    [Column("am", TypeName = "decimal(38, 6)")]
    public decimal? Am { get; set; }

    [Column("nw")]
    public int? Nw { get; set; }

    [Column("fee", TypeName = "decimal(38, 9)")]
    public decimal? Fee { get; set; }

    [Column("cfee")]
    public int? Cfee { get; set; }

    [Column("cut")]
    public int? Cut { get; set; }

    [Column("exr")]
    public int? Exr { get; set; }

    [Column("ssrv")]
    public int? Ssrv { get; set; }

    [Column("sscv")]
    public int? Sscv { get; set; }

    [Column("prdis", TypeName = "decimal(38, 6)")]
    public decimal? Prdis { get; set; }

    [Column("dis", TypeName = "decimal(38, 0)")]
    public decimal? Dis { get; set; }

    [Column("adis", TypeName = "decimal(38, 0)")]
    public decimal? Adis { get; set; }

    [Column("vra", TypeName = "decimal(19, 3)")]
    public decimal? Vra { get; set; }

    [Column("vam", TypeName = "decimal(38, 0)")]
    public decimal? Vam { get; set; }

    [Column("odt")]
    public int? Odt { get; set; }

    [Column("odr")]
    public int? Odr { get; set; }

    [Column("odam")]
    public int? Odam { get; set; }

    [Column("olt")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Olt { get; set; }

    [Column("olr")]
    public int? Olr { get; set; }

    [Column("sbc")]
    public int? Sbc { get; set; }

    [Column("olam")]
    public int? Olam { get; set; }

    [Column("consfee")]
    public int? Consfee { get; set; }

    [Column("spro")]
    public int? Spro { get; set; }

    [Column("bros")]
    public int? Bros { get; set; }

    [Column("tcpbs")]
    public int? Tcpbs { get; set; }

    [Column("cop")]
    public int? Cop { get; set; }

    [Column("vop")]
    public int? Vop { get; set; }

    [Column("bsrn")]
    public int? Bsrn { get; set; }

    [Column("tsstam", TypeName = "decimal(38, 0)")]
    public decimal? Tsstam { get; set; }

    [Column("iinn")]
    public int? Iinn { get; set; }

    [Column("acn")]
    public int? Acn { get; set; }

    [Column("trmn")]
    public int? Trmn { get; set; }

    [Column("pmt")]
    public int? Pmt { get; set; }

    [Column("trn")]
    public int? Trn { get; set; }

    [Column("pcn")]
    public int? Pcn { get; set; }

    [Column("pid")]
    public int? Pid { get; set; }

    [Column("pdt")]
    public int? Pdt { get; set; }

    [Column("pv")]
    public int? Pv { get; set; }

    [Column("InvoiceTypeID")]
    public int? InvoiceTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    [StringLength(152)]
    public string? CustomerName { get; set; }

    public DateOnly? BusinessDate { get; set; }

    [StringLength(50)]
    public string? InvoiceNumber { get; set; }
}
