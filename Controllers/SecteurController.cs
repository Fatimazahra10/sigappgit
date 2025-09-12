using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using webgis.Data; // Adjust namespace for your DataContext
using webgis.Models; // Adjust namespace for your commune model
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;

namespace webgis.Controllers
{
    [Route("[controller]")]
    public class SecteurController : Controller
    {
        private readonly AppDbContext _context;
    public SecteurController(AppDbContext context)
    {
    _context = context;
    }
    // GET: Commune
    public IActionResult Index()
    {
    return View( _context.Secteurs.ToList());
    }
       

       
    }
}