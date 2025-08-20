using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class StockView
{
    [Column("StockID")]
    public Guid StockId { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public bool? SaleReturnFlag { get; set; }

    public bool? RecieveFlag { get; set; }

    public bool? ReturnToVendorFlag { get; set; }

    public bool? NormalStock { get; set; }

    [Column("OwnerGroupID")]
    public int? OwnerGroupId { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(50)]
    public string? StockCode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Length { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Width { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Height { get; set; }

    public bool? AllowToReceiveWithoutContract { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    [StringLength(50)]
    public string? StoreName { get; set; }

    public int? StoreStatus { get; set; }
}
