using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Zamowienia_w_restauracji.Data;
using Zamowienia_w_restauracji.Models;

namespace Zamowienia_w_restauracji
{
    public class DeleteModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public DeleteModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Kategorie Kategorie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kategorie = await _context.Kategorie.FirstOrDefaultAsync(m => m.ID == id);

            if (Kategorie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kategorie = await _context.Kategorie.FindAsync(id);

            if (Kategorie != null)
            {
                _context.Kategorie.Remove(Kategorie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
