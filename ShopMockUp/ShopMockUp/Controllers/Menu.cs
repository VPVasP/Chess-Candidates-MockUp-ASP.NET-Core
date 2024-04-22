using Microsoft.AspNetCore.Mvc;
using ShopMockUp.Data;
using ShopMockUp.Models;
using Microsoft.EntityFrameworkCore;

namespace ShopMockUp.Controllers
{
    public class Menu : Controller
    {
        private readonly MenuContext _context;
        public Menu(MenuContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string searchString)
        {
            var player = from d in _context.Players
                         select d;
            if (!string.IsNullOrEmpty(searchString))
            {
                player = player.Where(d => d.Name.Contains(searchString));
                return View(await player.ToListAsync());

            }
            return View(await player.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            var player = await _context.Players
                .Include(di => di.items)
                .ThenInclude(i => i.item)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }
    }
}
