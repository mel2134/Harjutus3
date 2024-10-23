using Harjutus3.Core.Domain;
using Harjutus3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Harjutus3.Controllers
{
    public class WorkersController : Controller
    {
        public readonly Harjutus3DbContext _context;
        public WorkersController(Harjutus3DbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<Workers> GetWorkers()
        {
            var result = _context.Workers.FromSqlRaw<Workers>("spGetAllWorkers").ToList();
            return result;
        }
    }
}
