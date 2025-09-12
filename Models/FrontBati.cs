using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace webgis.Models;

[Table("FrontBati")]
public partial class FrontBati
{
    [Key]
    public int id { get; set; }

    [Column(TypeName = "geometry(MultiLineString,4326)")]
    public MultiLineString? geom { get; set; }

    public int? OBJECTID { get; set; }

    [StringLength(50)]
    public string? INDICE { get; set; }

    [StringLength(100)]
    public string? NATURE { get; set; }

    public double? SHAPE_Leng { get; set; }
}
