using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loteria.Models.DbModels
{
    public class Odpowiedz
    {
        [Key]
        public static int OdpowiedzId { get; set; }
        public string tresc { get; set; }
        public bool poprawnoscOdpowiedzi { get; set; }
        public int PytanieId { get; set; }
        public virtual Pytanie Pytanie { get; set; }
        static Odpowiedz()
        {
            OdpowiedzId = 1;
        }

        public Odpowiedz() 
        {
            OdpowiedzId++;
        }
        public Odpowiedz(string tresc, bool poprawnoscOdpowiedzi)
        {
            this.tresc = tresc;
            this.poprawnoscOdpowiedzi = poprawnoscOdpowiedzi;
        }
    }
}