using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class UserStockAssignmentView
{
    [Column("UserID")]
    public Guid UserId { get; set; }

    [Column("StockID")]
    public Guid StockId { get; set; }

    [StringLength(50)]
    public string? StockName { get; set; }
}
