﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loteria.Models.DbModels
{
    public class Pytanie
    {
        [Key]
        public int PytanieId { get; set; }
        public string tresc { get; set; }

        public Pytanie() { }
        public Pytanie(int PytanieId, string tresc) { 
            this.PytanieId = PytanieId;
            this.tresc = tresc; 
        }

    }
    
}