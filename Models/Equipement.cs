using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace webgis.Models;

public partial class Equipement
{
    [Key]
    public int id { get; set; }

    [Column(TypeName = "geometry(MultiPolygon,4326)")]
    public MultiPolygon? geom { get; set; }

    public int? OBJECTID { get; set; }

    [StringLength(50)]
    public string? nature { get; set; }

    [StringLength(50)]
    public string? etat { get; set; }

    [StringLength(50)]
    public string? indice { get; set; }

    public double? SHAPE_Leng { get; set; }

    public double? SHAPE_Area { get; set; }
}
