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
        public int OdpowiedzId { get; set; }
        public string tresc { get; set; }
        public bool poprawnoscOdpowiedzi { get; set; }
        public int PytanieId { get; set; }
        public virtual Pytanie Pytanie { get; set; }

        public Odpowiedz() { }
        public Odpowiedz(int OdpowiedzId, string tresc, bool poprawnoscOdpowiedzi)
        {
            this.OdpowiedzId = OdpowiedzId;
            this.tresc = tresc;
            this.poprawnoscOdpowiedzi = poprawnoscOdpowiedzi;
        }
    }
}