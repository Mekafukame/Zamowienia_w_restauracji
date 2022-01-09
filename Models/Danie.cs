using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zamowienia_w_restauracji.Models
{
    public class Danie
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Sklad { get; set; }
        public string Rodzaj { get; set; }
        public decimal Cena { get; set; }
        public string Zdjecie { get; set; }
    }
}
