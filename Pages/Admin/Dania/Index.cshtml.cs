using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Zamowienia_w_restauracji.Data;
using Zamowienia_w_restauracji.Models;
using Microsoft.AspNetCore.Authorization;

namespace Zamowienia_w_restauracji.Pages.Dania
{
    [Authorize(Policy = "RequireAdministratorRole")]
    public class IndexModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public IndexModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Danie> Danie { get;set; }
        public IEnumerable<string> Kategorie { get; set; }

        public async Task OnGetAsync()
        {
            Danie = await _context.Danie.ToListAsync();
            Kategorie = (from danie in _context.Danie select danie.Rodzaj).Distinct();
        }
    }
}
