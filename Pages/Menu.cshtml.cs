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



namespace Zamowienia_w_restauracji.Pages
{
    [AllowAnonymous]
    public class MenuModel : PageModel
    {
        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;

        public MenuModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<string> Kategorie { get; set; }
        public IList<Danie> Danie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string Kategoria;

        public async Task OnGetAsync()
        {
            var dania = from d in _context.Danie select d;
            if (!string.IsNullOrEmpty(SearchString)) //filtrowanie
            {
                dania = dania.Where(s => s.Rodzaj.Contains(SearchString));
                Kategoria = SearchString;
            }
            Danie = await dania.ToListAsync();            
            Kategorie = (from danie in _context.Danie orderby danie.Rodzaj select danie.Rodzaj).Distinct();
            
            
        }
    }
}