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
    public class DetailsModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public DetailsModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }


        public List<Danie> Dania = new List<Danie>();
        public IEnumerable<Zamowienie> Zamowienie { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            Zamowienie = (from z in _context.Zamowienie where z.Nr_zamowienia == id select z);

            if (Zamowienie == null)
            {
                return NotFound();
            }

            foreach(var item in Zamowienie)
            {
                Dania.Add(((from d in _context.Danie where d.ID == item.Danie_ID select d).Single())) ;
            }             
            return Page();
        }
    }
}
