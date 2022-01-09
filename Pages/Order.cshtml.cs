using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zamowienia_w_restauracji.Models;
using Zamowienia_w_restauracji.Helpers;
using Zamowienia_w_restauracji.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;


namespace Zamowienia_w_restauracji.Pages
{
    [AllowAnonymous]
    public class OrderModel : PageModel
    {
        public List<Item> cart { get; set; }
        public double Total { get; set; }
        [BindProperty]
        public Danie Produkt { get; set; }

        [BindProperty]
        public Adres Adres { get; set; }

        [BindProperty]
        public Zamowienie Zamowienie { get; set; }

        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;      
        

        public OrderModel(
            UserManager<IdentityUser> userManager,           
            Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _userManager = userManager;            
            _context = context; ;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null && cart.Count() > 0)
            {
                Total = (double)cart.Sum(i => i.Danie.Cena * i.Quantity);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                Adres = await _context.Adres.FirstOrDefaultAsync(m => m.UserID == _userManager.GetUserId(User));
            }

            

            return Page();
        }

        public async Task<IActionResult> OnPostMakeOrder()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string Nr_zam;           
           
            string lastOrderNr = "";
            try
            {                    
                lastOrderNr = (from Zamowienie in _context.Zamowienie where Zamowienie.ID == _context.Zamowienie.Max(p => p.ID) select Zamowienie.Nr_zamowienia).Single();
                int position = lastOrderNr.IndexOf("/");
                if(position > 0)
                {
                    lastOrderNr = lastOrderNr.Substring(position + 1);
                    lastOrderNr = (int.Parse(lastOrderNr) + 1).ToString();
                }
            }
            catch
            {

            }
                
            if (string.IsNullOrEmpty(lastOrderNr)){
                Nr_zam = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + "/0";
            }
            else {
                Nr_zam = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString()+ DateTime.Today.Day.ToString() + "/" + lastOrderNr;
            }                        
           
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            foreach (var item in cart)
            {
                Zamowienie.ID = 0;
                Zamowienie.Nr_zamowienia = Nr_zam;
                if (User.Identity.IsAuthenticated)
                    Zamowienie.User_ID = _userManager.GetUserId(User);
                Zamowienie.Danie_ID = item.Danie.ID;
                Zamowienie.Ilosc = item.Quantity;
                Zamowienie.Cena = item.Quantity * item.Danie.Cena;
                Zamowienie.Imie = Adres.Imie;
                Zamowienie.Nazwisko = Adres.Nazwisko;
                Zamowienie.Miasto = Adres.Miasto;
                Zamowienie.Kod_pocztowy = Adres.Kod_pocztowy;
                Zamowienie.Ulica = Adres.Ulica;
                Zamowienie.Nr_domu = Adres.Nr_domu;
                Zamowienie.Nr_lokalu = Adres.Nr_lokalu;
                _context.Zamowienie.Add(Zamowienie);
                try
                {                    
                    await _context.SaveChangesAsync();                   
                }
                catch
                {

                }
            }
            SessionHelper.RemoveFromSession(HttpContext.Session,"cart");

            return RedirectToPage("OrderConfirm");
        }

        public IActionResult OnGetBuyNow(int id)
        {
            Produkt =  _context.Danie.FirstOrDefault(m => m.ID == id);
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    Danie = Produkt,
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Danie = Produkt,
                        Quantity = 1
                    });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToPage("Cart");
        }

        public IActionResult OnGetDelete(int id)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (var i = 0; i < cart.Count; i++)
            {
                cart[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        private int Exists(List<Item> cart, int id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Danie.ID == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
