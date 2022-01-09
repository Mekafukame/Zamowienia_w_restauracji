using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace Zamowienia_w_restauracji.Pages.Admin
{
    [Authorize(Policy = "RequireAdministratorRole")]
    public class ZarzadzanieModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
