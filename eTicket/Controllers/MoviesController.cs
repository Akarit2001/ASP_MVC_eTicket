using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDBContext _dbContext;
        public MoviesController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _dbContext.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return View(data);
        }
    }
}
