using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("FactSaleTemp")]
public partial class FactSaleTemp
{
    public DateOnly? SaleDate { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    [Column("IDV_Type_1_DepartmentID")]
    public Guid? IdvType1DepartmentId { get; set; }

    [Column("Sale_Quantity", TypeName = "decimal(19, 3)")]
    public decimal? SaleQuantity { get; set; }

    [Column("Sale_Amount", TypeName = "decimal(38, 6)")]
    public decimal? SaleAmount { get; set; }

    [Column("Sale_Discount", TypeName = "decimal(20, 3)")]
    public decimal? SaleDiscount { get; set; }

    [Column("Sale_Rounding", TypeName = "decimal(19, 3)")]
    public decimal? SaleRounding { get; set; }

    [Column("Sale_NetAmount", TypeName = "decimal(38, 6)")]
    public decimal? SaleNetAmount { get; set; }

    [Column("Sale_TaxToll", TypeName = "decimal(19, 3)")]
    public decimal? SaleTaxToll { get; set; }

    [Column("Sale_NetAmountAfterTax", TypeName = "decimal(38, 6)")]
    public decimal? SaleNetAmountAfterTax { get; set; }

    [Column("Return_Quantity", TypeName = "decimal(19, 3)")]
    public decimal? ReturnQuantity { get; set; }

    [Column("Return_Amount", TypeName = "decimal(38, 6)")]
    public decimal? ReturnAmount { get; set; }

    [Column(TypeName = "decimal(20, 3)")]
    public decimal? ReturnDiscount { get; set; }

    [Column("Return_Rounding", TypeName = "decimal(19, 3)")]
    public decimal? ReturnRounding { get; set; }

    [Column("Return_NetAmount", TypeName = "decimal(38, 6)")]
    public decimal? ReturnNetAmount { get; set; }

    [Column("Return_TaxToll", TypeName = "decimal(19, 3)")]
    public decimal? ReturnTaxToll { get; set; }

    [Column("Return_NetAmountAfterTax", TypeName = "decimal(38, 6)")]
    public decimal? ReturnNetAmountAfterTax { get; set; }

    [Column("ExpectedAmount_Net", TypeName = "decimal(38, 6)")]
    public decimal? ExpectedAmountNet { get; set; }

    [Column("ExpectedAmount_Final", TypeName = "decimal(38, 6)")]
    public decimal? ExpectedAmountFinal { get; set; }
}
