using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class DetailAccountView
{
    [Column("DetailAccountID")]
    public Guid DetailAccountId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("AccountID")]
    public Guid? AccountId { get; set; }

    [StringLength(20)]
    public string? ExternalCode { get; set; }

    public bool? IsEmployee { get; set; }

    public bool? IsCustomer { get; set; }

    public bool? IsSupplier { get; set; }

    public bool? IsUser { get; set; }
}
