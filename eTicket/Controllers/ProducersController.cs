using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDBContext _dbContext;
        public ProducersController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _dbContext.Producers.ToListAsync();
            return View("IndexNew",data);
        }
    }
}
