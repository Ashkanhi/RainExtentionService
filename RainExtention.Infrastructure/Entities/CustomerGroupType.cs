using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("CustomerGroupType")]
public partial class CustomerGroupType
{
    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("Type")]
    public virtual ICollection<CustomerGroup> CustomerGroups { get; set; } = new List<CustomerGroup>();
}
