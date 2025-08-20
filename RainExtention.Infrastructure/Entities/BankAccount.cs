using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("BankAccount")]
public partial class BankAccount
{
    [Key]
    [Column("AccountID")]
    public Guid AccountId { get; set; }

    [Column("BankID")]
    public Guid? BankId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(50)]
    public string? BranchName { get; set; }

    [StringLength(10)]
    public string? BranchCode { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModiyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [ForeignKey("BankId")]
    [InverseProperty("BankAccounts")]
    public virtual Bank? Bank { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("BankAccountCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("ModifyUser")]
    [InverseProperty("BankAccountModifyUserNavigations")]
    public virtual User? ModifyUserNavigation { get; set; }
}
