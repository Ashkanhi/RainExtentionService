using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("DictionaryValue_14020528")]
public partial class DictionaryValue14020528
{
    [Column("DictionaryID")]
    public int DictionaryId { get; set; }

    [Column("TypeID")]
    public short TypeId { get; set; }

    public string? Value { get; set; }
}
