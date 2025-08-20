using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "LineItemId")]
[Table("AutomaticOrderProposalLineItem")]
public partial class AutomaticOrderProposalLineItem
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [Column("SourceStockID")]
    public Guid? SourceStockId { get; set; }

    [Column("TargetStockID")]
    public Guid? TargetStockId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OrderQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BonusQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RequestQuantity { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("AutomaticOrderProposalLineItems")]
    public virtual AutomaticOrderProposal IdNavigation { get; set; } = null!;
}
