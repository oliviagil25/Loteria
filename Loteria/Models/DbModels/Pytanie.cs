using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loteria.Models.DbModels
{
    public class Pytanie
    {
        [Key]
        public static int PytanieId;
        public string tresc { get; set; }
        static Pytanie()
        {
            PytanieId = 1;
        }

        public Pytanie() 
        {
            PytanieId++;
        }
        public Pytanie(string tresc) { 
            this.tresc = tresc; 
        }

    }
    
}