using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

public partial class CustomerResult
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResultDate { get; set; }

    [Column("QuestionID")]
    public Guid? QuestionId { get; set; }

    [Column("ResultID")]
    public Guid? ResultId { get; set; }

    public string? Description { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("CustomerResults")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("QuestionId, ResultId")]
    [InverseProperty("CustomerResults")]
    public virtual PredefineResult? PredefineResult { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("CustomerResults")]
    public virtual Store? Store { get; set; }
}
