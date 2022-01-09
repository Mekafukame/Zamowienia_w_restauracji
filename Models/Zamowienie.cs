using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zamowienia_w_restauracji.Models
{
    public class Zamowienie
    {
        public int ID {get; set;}
        public string Nr_zamowienia { get; set; }
        public string User_ID { get; set; }
        public int Danie_ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Ulica { get; set; }
        public string Nr_domu { get; set; }
        public string Nr_lokalu { get; set; }
        public int Ilosc { get; set; }
        public decimal Cena { get; set; }
    }
}
