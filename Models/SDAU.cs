using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace webgis.Models;

[Table("SDAU")]
public partial class SDAU
{
    [Key]
    public int id { get; set; }

    [Column(TypeName = "geometry(MultiPolygon,4326)")]
    public MultiPolygon? geom { get; set; }

    public long? OBJECTID { get; set; }

    public long? FID_decoup { get; set; }

    [StringLength(50)]
    public string? PREFECTURE { get; set; }

    [StringLength(50)]
    public string? COMMUNE_AR { get; set; }

    [StringLength(50)]
    public string? PREFECTU_1 { get; set; }

    [Column("SDAU")]
    public int? SDAU1 { get; set; }

    public int? resultat_c { get; set; }

    [StringLength(100)]
    public string? nom_classe { get; set; }

    public double? Shape_Leng { get; set; }

    public double? SHAPE_area { get; set; }

    public double? SHAPE_len { get; set; }
}
