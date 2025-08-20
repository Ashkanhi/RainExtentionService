using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Store")]
public partial class Store
{
    [Key]
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

    [InverseProperty("Store")]
    public virtual ICollection<CashSettelment> CashSettelments { get; set; } = new List<CashSettelment>();

    [InverseProperty("Store")]
    public virtual ICollection<CustomerResult> CustomerResults { get; set; } = new List<CustomerResult>();

    [ForeignKey("DetailedAccountId")]
    [InverseProperty("Stores")]
    public virtual DetailAccount? DetailedAccount { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<Store> InverseParent { get; set; } = new List<Store>();

    [InverseProperty("Store")]
    public virtual ICollection<OrderDocument> OrderDocuments { get; set; } = new List<OrderDocument>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual Store? Parent { get; set; }

    [ForeignKey("PartyId")]
    [InverseProperty("Stores")]
    public virtual Party? Party { get; set; }

    [InverseProperty("BookerStore")]
    public virtual ICollection<PeriodicCosting> PeriodicCostings { get; set; } = new List<PeriodicCosting>();

    [InverseProperty("Store")]
    public virtual ICollection<ShelfPricePrintHistory> ShelfPricePrintHistories { get; set; } = new List<ShelfPricePrintHistory>();

    [InverseProperty("Store")]
    public virtual ICollection<ShelfPricePrint> ShelfPricePrints { get; set; } = new List<ShelfPricePrint>();

    [ForeignKey("StatusId")]
    [InverseProperty("Stores")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("Store")]
    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    [InverseProperty("Store")]
    public virtual ICollection<StoreConfiguration> StoreConfigurations { get; set; } = new List<StoreConfiguration>();

    [InverseProperty("Store")]
    public virtual ICollection<StoreContract> StoreContracts { get; set; } = new List<StoreContract>();

    [InverseProperty("Store")]
    public virtual ICollection<StoreDailyTurnOver> StoreDailyTurnOvers { get; set; } = new List<StoreDailyTurnOver>();

    [InverseProperty("Store")]
    public virtual ICollection<StoreRepository> StoreRepositories { get; set; } = new List<StoreRepository>();

    [InverseProperty("Store")]
    public virtual ICollection<TableManagement> TableManagements { get; set; } = new List<TableManagement>();

    [InverseProperty("Store")]
    public virtual ICollection<Workstation> Workstations { get; set; } = new List<Workstation>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<GiftCard> Ids { get; set; } = new List<GiftCard>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<PhysicalDocumentConfig> IdsNavigation { get; set; } = new List<PhysicalDocumentConfig>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<Lottery> Lotteries { get; set; } = new List<Lottery>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<AutomaticOrderPlan> Plans { get; set; } = new List<AutomaticOrderPlan>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<SalePrice> Prices { get; set; } = new List<SalePrice>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<SaleQoutum> Qouats { get; set; } = new List<SaleQoutum>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<LoyalityAwardRule> Rules { get; set; } = new List<LoyalityAwardRule>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<PartialPaymentRule> RulesNavigation { get; set; } = new List<PartialPaymentRule>();

    [ForeignKey("StoreId")]
    [InverseProperty("Stores")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
