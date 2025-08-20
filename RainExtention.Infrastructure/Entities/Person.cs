using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

public partial class Person
{
    [Column("graph_id_C16C27BE1FEA4AEB87D905D933DBF6AF")]
    public long GraphIdC16c27be1fea4aeb87d905d933dbf6af { get; set; }

    [Column("$node_id_9A1CFCDE0C3C451895D12C61F1697F7E")]
    [StringLength(1000)]
    public string NodeId9a1cfcde0c3c451895d12c61f1697f7e { get; set; } = null!;

    [Key]
    [Column("PersonID")]
    public int PersonId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }
}
