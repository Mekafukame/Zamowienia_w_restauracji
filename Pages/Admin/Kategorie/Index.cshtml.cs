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
    public class IndexModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public IndexModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Kategorie> Kategorie { get;set; }

        public async Task OnGetAsync()
        {
            Kategorie = await _context.Kategorie.ToListAsync();
        }
    }
}
