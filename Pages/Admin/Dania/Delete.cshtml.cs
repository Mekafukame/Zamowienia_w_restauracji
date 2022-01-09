using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Zamowienia_w_restauracji.Data;
using Zamowienia_w_restauracji.Models;

namespace Zamowienia_w_restauracji.Pages.Dania
{
    public class DeleteModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public DeleteModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Danie Danie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Danie = await _context.Danie.FirstOrDefaultAsync(m => m.ID == id);

            if (Danie == null)
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

            Danie = await _context.Danie.FindAsync(id);

            if (Danie != null)
            {
                _context.Danie.Remove(Danie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
