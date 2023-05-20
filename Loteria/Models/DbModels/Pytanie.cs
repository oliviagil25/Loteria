using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loteria.Models.DbModels
{
    public class Pytanie
    {
        public int Id { get; set; }
        public string tresc { get; set; }
        public Pytanie() { }
        public Pytanie(string tresc) { this.tresc = tresc; }

    }
    
}