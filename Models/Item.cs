using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zamowienia_w_restauracji.Models;

namespace Zamowienia_w_restauracji.Models
{
    public class Item
    {
        public Danie Danie { get; set; }

        public int Quantity { get; set; }
    }
}
