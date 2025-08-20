using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Lottery")]
public partial class Lottery
{
    [Key]
    [Column("LotteryID")]
    public Guid LotteryId { get; set; }

    [StringLength(50)]
    public string? LotteryNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LotteryDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ThresholdAmount { get; set; }

    [Column("ThresholdTypeID")]
    public int? ThresholdTypeId { get; set; }

    [Column("CalculationTypeID")]
    public int? CalculationTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [ForeignKey("CalculationTypeId")]
    [InverseProperty("LotteryCalculationTypes")]
    public virtual Dictionary? CalculationType { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("Lotteries")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("Lottery")]
    public virtual ICollection<LotteryLineItem> LotteryLineItems { get; set; } = new List<LotteryLineItem>();

    [ForeignKey("ThresholdTypeId")]
    [InverseProperty("LotteryThresholdTypes")]
    public virtual Dictionary? ThresholdType { get; set; }

    [ForeignKey("LotteryId")]
    [InverseProperty("Lotteries")]
    public virtual ICollection<CustomerGroup> CustomerGroups { get; set; } = new List<CustomerGroup>();

    [ForeignKey("LotteryId")]
    [InverseProperty("Lotteries")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    [ForeignKey("LotteryId")]
    [InverseProperty("Lotteries")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
