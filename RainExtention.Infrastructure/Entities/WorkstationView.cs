using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class WorkstationView
{
    [Column("StoreID")]
    public int StoreId { get; set; }

    [Column("WorkstationID")]
    public int WorkstationId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Hostname { get; set; }

    [StringLength(50)]
    public string? DatabaseServer { get; set; }

    [Column("UserID")]
    [StringLength(50)]
    public string? UserId { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [StringLength(50)]
    public string? Comment { get; set; }

    public string? ExtraInfo { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column("HardwareID")]
    [StringLength(100)]
    public string? HardwareId { get; set; }

    [Column("IPAddress")]
    [StringLength(20)]
    public string? Ipaddress { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [StringLength(50)]
    public string? StoreName { get; set; }
}
