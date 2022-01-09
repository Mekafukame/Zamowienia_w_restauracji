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


namespace Zamowienia_w_restauracji.Pages
{
    [AllowAnonymous]
    public class CartModel : PageModel
    {
        public List<Item> cart { get; set; }
        public double Total { get; set; }
        [BindProperty]
        public Danie Produkt { get; set; }

        private readonly Zamowienia_w_restauracji.Data.ApplicationDbContext _context;
        public CartModel(Zamowienia_w_restauracji.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null && cart.Count() > 0) {            
            Total = (double)cart.Sum(i => i.Danie.Cena * i.Quantity);            
            }
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
