using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("DetailAccount")]
[Index("StatusId", Name = "IX_Status")]
[Index("TypeId", Name = "IX_Type")]
public partial class DetailAccount
{
    [Key]
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

    [InverseProperty("DetailedAccount")]
    public virtual Company? Company { get; set; }

    [InverseProperty("DetailAccount")]
    public virtual Person? Person1 { get; set; }

    [InverseProperty("DetailAccount")]
    public virtual ICollection<Repository> Repositories { get; set; } = new List<Repository>();

    [ForeignKey("StatusId")]
    [InverseProperty("DetailAccountStatuses")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("DetailAccount")]
    public virtual ICollection<StoreRepository> StoreRepositories { get; set; } = new List<StoreRepository>();

    [InverseProperty("DetailedAccount")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();

    [InverseProperty("DetailAccount")]
    public virtual ICollection<Tender> Tenders { get; set; } = new List<Tender>();

    [ForeignKey("TypeId")]
    [InverseProperty("DetailAccountTypes")]
    public virtual Dictionary? Type { get; set; }

    [InverseProperty("DetailAccount")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
