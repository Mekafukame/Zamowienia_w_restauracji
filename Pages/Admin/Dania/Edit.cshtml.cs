using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Zamowienia_w_restauracji.Data;
using Zamowienia_w_restauracji.Models;

namespace Zamowienia_w_restauracji.Pages.Dania
{
    public class EditModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public EditModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Danie Danie { get; set; }
        public IList<string> Kategorie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            var kat = from k in _context.Kategorie select k.Nazwa;
            Kategorie = await kat.ToListAsync();

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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Danie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DanieExists(Danie.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DanieExists(int id)
        {
            return _context.Danie.Any(e => e.ID == id);
        }
    }
}
