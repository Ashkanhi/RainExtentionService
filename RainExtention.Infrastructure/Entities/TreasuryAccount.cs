using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("TreasuryAccount")]
public partial class TreasuryAccount
{
    [Key]
    [Column("AccountID")]
    public Guid AccountId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [ForeignKey("TypeId")]
    [InverseProperty("TreasuryAccounts")]
    public virtual Dictionary? Type { get; set; }
}
