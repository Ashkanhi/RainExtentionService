using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DictionaryId", "TypeId")]
[Table("DictionaryValue")]
public partial class DictionaryValue
{
    [Key]
    [Column("DictionaryID")]
    public int DictionaryId { get; set; }

    [Key]
    [Column("TypeID")]
    public short TypeId { get; set; }

    public string? Value { get; set; }

    [ForeignKey("DictionaryId")]
    [InverseProperty("DictionaryValues")]
    public virtual Dictionary Dictionary { get; set; } = null!;
}
