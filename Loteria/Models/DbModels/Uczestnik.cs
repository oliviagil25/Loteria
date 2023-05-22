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
        public int UczestnikId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pseudonim { get; set; }

        public virtual List<Nagroda> Nagrody { get; set; } = new List<Nagroda>();

        public Uczestnik() { }

        public Uczestnik(int UczestnikId, string imie, string nazwisko, string pseudonim)
        {
            this.UczestnikId = UczestnikId;
            Imie = imie;
            Nazwisko = nazwisko;
            Pseudonim = pseudonim;
        }
    }
}