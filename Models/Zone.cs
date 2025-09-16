using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webgis.Models
{
    public class Zone
{
    public int Id { get; set; }
    public string Nom { get; set; }          // ex : "Zone A"
    public string ReglementPdf { get; set; } // chemin du PDF (ex : "/pdfs/zoneA.pdf")
}

}