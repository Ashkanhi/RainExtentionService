using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("AccountId", "TypeId")]
[Table("FinancialAccount")]
public partial class FinancialAccount
{
    [Key]
    [Column("AccountID")]
    public Guid AccountId { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [StringLength(50)]
    public string? AccountCode { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [Column("NatureTypeID")]
    public int? NatureTypeId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }
}
