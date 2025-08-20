using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("CurrencyHistory")]
public partial class CurrencyHistory
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("CurrencyID")]
    public int? CurrencyId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("CurrencyHistories")]
    public virtual Currency? Currency { get; set; }

    [ForeignKey("ModifyUser")]
    [InverseProperty("CurrencyHistories")]
    public virtual User? ModifyUserNavigation { get; set; }
}
