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
    public class IndexModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public IndexModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<string> Zamowienie { get;set; }

        public void OnGet()
        {            
            Zamowienie = (from z in _context.Zamowienie orderby z.Nr_zamowienia select z.Nr_zamowienia).Distinct();                   
        }
    }
}
