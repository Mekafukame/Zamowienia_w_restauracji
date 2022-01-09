using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Zamowienia_w_restauracji.Data;
using Microsoft.EntityFrameworkCore;
using Zamowienia_w_restauracji.Models;

namespace Zamowienia_w_restauracji.Pages.Dania
{
    public class CreateModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public CreateModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<string> Kategorie { get; set; }       
        public IActionResult OnGet()
        {
            var kat = from k in _context.Kategorie select k.Nazwa;
            Kategorie = kat.ToList();
            return Page();
        }
       
        [BindProperty]
        public Danie Danie { get; set; }
        
        
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Danie.Add(Danie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
