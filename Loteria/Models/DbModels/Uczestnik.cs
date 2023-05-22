using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loteria.Models.DbModels
{
    public class Uczestnik
    {
        [Key]
        public static int UczestnikId;
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pseudonim { get; set; }

        public virtual List<Nagroda> Nagrody { get; set; } = new List<Nagroda>();
        static Uczestnik()
        {
            UczestnikId = 1;
        }

        public Uczestnik() 
        {
            UczestnikId++;
        }

        public Uczestnik(string imie, string nazwisko, string pseudonim)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pseudonim = pseudonim;
        }
    }
}