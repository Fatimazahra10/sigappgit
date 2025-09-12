using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace webgis.Models;

[Table("DecoupageAdministratif")]
public partial class DecoupageAdministratif
{
    [Key]
    public int id { get; set; }

    [Column(TypeName = "geometry(MultiPolygon,4326)")]
    public MultiPolygon? geom { get; set; }

    public int? OBJECTID { get; set; }

    public double? Shape_Leng { get; set; }

    public double? Shape_Area { get; set; }

    [StringLength(50)]
    public string? PREFECTURE { get; set; }

    [StringLength(50)]
    public string? COMMUNE_AR { get; set; }

    [StringLength(50)]
    public string? PREFECTU_1 { get; set; }
}
