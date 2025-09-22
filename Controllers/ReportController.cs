using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using BlContainerSystem.Data;
using System.Threading.Tasks;

namespace BlContainerSystem.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Report/Index
        public async Task<IActionResult> Index()
        {
            // Busca todos os BLs e INCLUI os containers de cada um na mesma consulta
            var blsWithContainers = await _context.BLs
                                                  .Include(b => b.Containers)
                                                  .ToListAsync();
            
            return View(blsWithContainers);
        }
    }
}