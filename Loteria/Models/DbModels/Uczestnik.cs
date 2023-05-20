using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loteria.Models.DbModels
{
    public class Uczestnik
    {
        public string Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pseudonim { get; set; }

        public Uczestnik() { }

        public Uczestnik(string imie, string nazwisko, string pseudonim)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pseudonim = pseudonim;
        }
    }
}