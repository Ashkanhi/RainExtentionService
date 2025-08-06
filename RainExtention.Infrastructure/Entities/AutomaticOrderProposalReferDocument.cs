using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "LineItemId")]
public partial class AutomaticOrderProposalReferDocument
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("BookerStoreID")]
    public int? BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int? BookerWorkstationId { get; set; }

    [Column("DocumentID")]
    public Guid? DocumentId { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("AutomaticOrderProposalReferDocuments")]
    public virtual AutomaticOrderProposal IdNavigation { get; set; } = null!;
}
