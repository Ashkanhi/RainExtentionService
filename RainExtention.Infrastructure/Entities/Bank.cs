using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Bank")]
public partial class Bank
{
    [Key]
    [Column("BankID")]
    public Guid BankId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [InverseProperty("Bank")]
    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
}
