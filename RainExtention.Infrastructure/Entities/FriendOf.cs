using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("FriendOf")]
public partial class FriendOf
{
    [Column("graph_id_DA345843E9424A679017FF0D3F5CD8A0")]
    public long GraphIdDa345843e9424a679017ff0d3f5cd8a0 { get; set; }

    [Column("$edge_id_DEEF773619F94CC2A53DB469FA6C2205")]
    [StringLength(1000)]
    public string EdgeIdDeef773619f94cc2a53db469fa6c2205 { get; set; } = null!;

    [Column("from_obj_id_FCF1C1BC492E49C1BC7C3392E3F7C7C5")]
    public int FromObjIdFcf1c1bc492e49c1bc7c3392e3f7c7c5 { get; set; }

    [Column("from_id_B3B214A196C34197A27894DAE66BA6E3")]
    public long FromIdB3b214a196c34197a27894dae66ba6e3 { get; set; }

    [Column("$from_id_B8820A1B5F084D36AF8CE105F13739E4")]
    [StringLength(1000)]
    public string? FromIdB8820a1b5f084d36af8ce105f13739e4 { get; set; }

    [Column("to_obj_id_A1F8CC150F08441AA94E23588D55A483")]
    public int ToObjIdA1f8cc150f08441aa94e23588d55a483 { get; set; }

    [Column("to_id_E414B6F266AE4B6AABBFDA2CD0D4807A")]
    public long ToIdE414b6f266ae4b6aabbfda2cd0d4807a { get; set; }

    [Column("$to_id_D5814D97081C4334992DA2B32EEBB4F9")]
    [StringLength(1000)]
    public string? ToIdD5814d97081c4334992da2b32eebb4f9 { get; set; }
}
