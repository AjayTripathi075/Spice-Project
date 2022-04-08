using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Spice_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;
        public MenuItemController(ApplicationDbContext db, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment= hostingEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
