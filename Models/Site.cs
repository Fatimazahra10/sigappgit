using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace webgis.Models;

public partial class Site
{
    [Key]
    public int id { get; set; }

    [Column(TypeName = "geometry(MultiPolygon,4326)")]
    public MultiPolygon? geom { get; set; }

    public int? OBJECTID { get; set; }

    [StringLength(50)]
    public string? REFERENCE { get; set; }

    [StringLength(254)]
    public string? Commune_Ce { get; set; }

    [StringLength(50)]
    public string? ETAT { get; set; }

    [StringLength(200)]
    public string? PREFECTURE { get; set; }

    public double? SHAPE_Leng { get; set; }

    public double? SHAPE_Area { get; set; }

    [Column("Site")]
    [StringLength(50)]
    public string? Site1 { get; set; }

    public int? Site_ID { get; set; }

    [StringLength(200)]
    public string? Avancement { get; set; }
}
