using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zamowienia_w_restauracji.Models
{
    public class Adres
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Ulica { get; set; }
        public string Nr_domu { get; set; }
        public string Nr_lokalu { get; set; }
    }
}
