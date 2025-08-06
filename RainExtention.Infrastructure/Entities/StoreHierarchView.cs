using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class StoreHierarchView
{
    public int Level1 { get; set; }

    public int Level2 { get; set; }

    public int Level3 { get; set; }

    public int Level4 { get; set; }

    public int Level5 { get; set; }
}
