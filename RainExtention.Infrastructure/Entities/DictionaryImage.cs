using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DictionaryId", "TypeId")]
[Table("DictionaryImage")]
public partial class DictionaryImage
{
    [Key]
    [Column("DictionaryID")]
    public int DictionaryId { get; set; }

    [Key]
    [Column("TypeID")]
    public short TypeId { get; set; }

    public byte[]? Image { get; set; }

    [Column("URI")]
    [StringLength(200)]
    public string? Uri { get; set; }

    [ForeignKey("DictionaryId")]
    [InverseProperty("DictionaryImages")]
    public virtual Dictionary Dictionary { get; set; } = null!;
}
