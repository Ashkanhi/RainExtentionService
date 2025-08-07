using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("StoreId", "RepositoryId")]
[Table("StoreRepository")]
public partial class StoreRepository
{
    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [Key]
    [Column("RepositoryID")]
    public int RepositoryId { get; set; }

    [Column("DetailAccountID")]
    public Guid? DetailAccountId { get; set; }

    [ForeignKey("DetailAccountId")]
    [InverseProperty("StoreRepositories")]
    public virtual DetailAccount? DetailAccount { get; set; }

    [ForeignKey("RepositoryId")]
    [InverseProperty("StoreRepositories")]
    public virtual Repository Repository { get; set; } = null!;

    [ForeignKey("StoreId")]
    [InverseProperty("StoreRepositories")]
    public virtual Store Store { get; set; } = null!;
}
