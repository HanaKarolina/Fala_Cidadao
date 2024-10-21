using Fala_Cidadao.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fala_Cidadao.Controllers
{
    public class ProblemasController : Controller
    {
        private readonly AppDbContext _context;
        public ProblemasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Problemas.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Problema problema)

        {
            if (ModelState.IsValid)
            {
                _context.Problemas.Add(problema);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(problema);
        }
    }
}

