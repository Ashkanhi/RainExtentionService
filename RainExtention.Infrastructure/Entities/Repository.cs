using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Repository")]
public partial class Repository
{
    [Key]
    [Column("RepositoryID")]
    public int RepositoryId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentAmount { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    [StringLength(50)]
    public string? BankName { get; set; }

    [StringLength(50)]
    public string? BranchName { get; set; }

    [ForeignKey("DetailAccountId")]
    [InverseProperty("Repositories")]
    public virtual DetailAccount? DetailAccount { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("RepositoryStatuses")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("Repository")]
    public virtual ICollection<StoreRepository> StoreRepositories { get; set; } = new List<StoreRepository>();

    [InverseProperty("Repository")]
    public virtual ICollection<Tender> Tenders { get; set; } = new List<Tender>();

    [ForeignKey("TypeId")]
    [InverseProperty("RepositoryTypes")]
    public virtual Dictionary? Type { get; set; }
}
