using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "SettelmentId")]
[Table("CashSettelment")]
[Index("StoreId", "UserId", "StartDate", "EndDate", Name = "IX_CashSettelment", IsUnique = true)]
[Index("CreationUser", "CreationDate", Name = "IX_Create")]
[Index("ModifyUser", "ModifyDate", Name = "IX_Modify")]
[Index("SettelDate", Name = "IX_SettelDate")]
[Index("StatusId", Name = "IX_Status")]
[Index("StoreId", Name = "IX_Store")]
[Index("UserId", Name = "IX_User")]
public partial class CashSettelment
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("SettelmentID")]
    public Guid SettelmentId { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [Column("UserID")]
    public Guid? UserId { get; set; }

    public DateOnly? BusinessDate { get; set; }

    public DateOnly? SettelDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(500)]
    public string? Comment { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public int? IsExported { get; set; }

    [InverseProperty("CashSettelment")]
    public virtual CashSettelmentCustomField? CashSettelmentCustomField { get; set; }

    [InverseProperty("CashSettelment")]
    public virtual ICollection<CashSettelmentLineItem> CashSettelmentLineItems { get; set; } = new List<CashSettelmentLineItem>();

    [ForeignKey("CreationUser")]
    [InverseProperty("CashSettelmentCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("ModifyUser")]
    [InverseProperty("CashSettelmentModifyUserNavigations")]
    public virtual User? ModifyUserNavigation { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("CashSettelments")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("CashSettelments")]
    public virtual Store? Store { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CashSettelmentUsers")]
    public virtual User? User { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId")]
    [InverseProperty("CashSettelments")]
    public virtual Workstation Workstation { get; set; } = null!;
}
