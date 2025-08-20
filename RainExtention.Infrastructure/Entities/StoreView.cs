using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class StoreView
{
    [Column("StoreID")]
    public int StoreId { get; set; }

    [Column("ParentID")]
    public int? ParentId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column("PartyID")]
    public Guid? PartyId { get; set; }

    [StringLength(50)]
    public string? BusinessCode { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    [Column("DetailedAccountID")]
    public Guid? DetailedAccountId { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public byte[]? StoreImage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastSynchTime { get; set; }

    [Column("GroupID")]
    public Guid? GroupId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxUsageAmount { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Length { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Width { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Height { get; set; }

    [StringLength(10)]
    public string? CompanyCode { get; set; }

    public byte? Grade { get; set; }

    [Column("ManagerID")]
    public Guid? ManagerId { get; set; }

    [StringLength(50)]
    public string? Hostname { get; set; }

    [Column("CompanyID")]
    public Guid? CompanyId { get; set; }

    [StringLength(15)]
    public string? Telephone { get; set; }

    [StringLength(15)]
    public string? Fax { get; set; }

    [StringLength(255)]
    public string? EmailAddress { get; set; }

    [StringLength(1000)]
    public string? Address { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Latitude { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Longitude { get; set; }

    [StringLength(50)]
    public string? GroupName { get; set; }

    [StringLength(50)]
    public string? ParentName { get; set; }

    [StringLength(101)]
    public string? EmployeeName { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [StringLength(117)]
    public string? ImageUrl { get; set; }
}
