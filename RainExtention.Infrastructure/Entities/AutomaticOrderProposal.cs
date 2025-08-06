using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("AutomaticOrderProposal")]
public partial class AutomaticOrderProposal
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<AutomaticOrderProposalLineItem> AutomaticOrderProposalLineItems { get; set; } = new List<AutomaticOrderProposalLineItem>();

    [InverseProperty("IdNavigation")]
    public virtual ICollection<AutomaticOrderProposalReferDocument> AutomaticOrderProposalReferDocuments { get; set; } = new List<AutomaticOrderProposalReferDocument>();
}
