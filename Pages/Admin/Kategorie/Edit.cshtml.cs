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

namespace Zamowienia_w_restauracji
{
    public class EditModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public EditModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Kategorie Kategorie { get; set; }
        [BindProperty]
        IList<Danie> result { get; set; }

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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Kategorie).State = EntityState.Modified;
            string kat = (from k in _context.Kategorie where k.ID == Kategorie.ID select k.Nazwa).SingleOrDefault() ;
            result = await (from d in _context.Danie where d.Rodzaj == kat select d).ToListAsync();
            try
            {
                
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KategorieExists(Kategorie.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            try
            {
                foreach(Danie d in result)
                {
                    d.Rodzaj = Kategorie.Nazwa;
                }
                await _context.SaveChangesAsync();
            }
            catch
            {

            }
            return RedirectToPage("./Index");
        }

        private bool KategorieExists(int id)
        {
            return _context.Kategorie.Any(e => e.ID == id);
        }
    }
}
