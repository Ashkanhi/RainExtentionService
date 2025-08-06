using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Stock")]
[Index("StockId", Name = "IX_StockCode")]
public partial class Stock
{
    [Key]
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

    [InverseProperty("Stock")]
    public virtual ICollection<ItemSerializedStockState> ItemSerializedStockStates { get; set; } = new List<ItemSerializedStockState>();

    [InverseProperty("Stock")]
    public virtual ICollection<ItemStockQuantity> ItemStockQuantities { get; set; } = new List<ItemStockQuantity>();

    [InverseProperty("Stock")]
    public virtual ICollection<ItemStockState> ItemStockStates { get; set; } = new List<ItemStockState>();

    [ForeignKey("OwnerGroupId")]
    [InverseProperty("Stocks")]
    public virtual UserGroup? OwnerGroup { get; set; }

    [InverseProperty("Stock")]
    public virtual ICollection<ProductionDocument> ProductionDocuments { get; set; } = new List<ProductionDocument>();

    [InverseProperty("Stock")]
    public virtual ICollection<ProductionStep> ProductionSteps { get; set; } = new List<ProductionStep>();

    [InverseProperty("Stock")]
    public virtual ICollection<SaleInvoiceLineItemTracking> SaleInvoiceLineItemTrackings { get; set; } = new List<SaleInvoiceLineItemTracking>();

    [InverseProperty("Stock")]
    public virtual ICollection<SaleInvoice> SaleInvoices { get; set; } = new List<SaleInvoice>();

    [InverseProperty("SourceStock")]
    public virtual ICollection<StockDocument> StockDocumentSourceStocks { get; set; } = new List<StockDocument>();

    [InverseProperty("TargetStock")]
    public virtual ICollection<StockDocument> StockDocumentTargetStocks { get; set; } = new List<StockDocument>();

    [InverseProperty("Stock")]
    public virtual ICollection<StockSection> StockSections { get; set; } = new List<StockSection>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stocks")]
    public virtual Store Store { get; set; } = null!;

    [ForeignKey("StockId")]
    [InverseProperty("Stocks")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
