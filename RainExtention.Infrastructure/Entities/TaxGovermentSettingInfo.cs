using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("TaxGovermentSettingInfo")]
public partial class TaxGovermentSettingInfo
{
    public int StoreId { get; set; }

    public string PrivateKey { get; set; } = null!;

    [StringLength(50)]
    public string? ClientId { get; set; }

    [StringLength(500)]
    public string? PrivateKeyPath { get; set; }

    public int? ResponseCheckerTimeInSec { get; set; }

    public string? Url { get; set; }

    [StringLength(50)]
    public string? Tins { get; set; }
}
