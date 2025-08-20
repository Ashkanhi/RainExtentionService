using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ReasonView
{
    [Column("ReasonID")]
    public int ReasonId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("AccountID")]
    public Guid? AccountId { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    [Column("ActionTypeID")]
    public int? ActionTypeId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public short? Priority { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    public int? Language { get; set; }
}
