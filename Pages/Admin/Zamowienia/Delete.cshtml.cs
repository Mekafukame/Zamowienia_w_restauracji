using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Zamowienia_w_restauracji.Data;
using Zamowienia_w_restauracji.Models;

namespace Zamowienia_w_restauracji.Pages.Zamowienia
{
    public class DeleteModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public DeleteModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<Zamowienie> Zamowienie { get; set; }
        public string nr_Zam { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Zamowienie = await((from z in _context.Zamowienie where z.Nr_zamowienia == id select z).ToListAsync());
            nr_Zam = id;
            if (Zamowienie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Zamowienie = await ((from z in _context.Zamowienie where z.Nr_zamowienia == id select z).ToListAsync());

            if (Zamowienie != null)
            {
                foreach(var item in Zamowienie) { 
                _context.Zamowienie.Remove(item);
                await _context.SaveChangesAsync();
                }
            }

            return RedirectToPage("./Index");
        }
    }
}
