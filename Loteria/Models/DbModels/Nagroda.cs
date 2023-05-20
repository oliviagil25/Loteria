﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loteria.Models.DbModels
{
    public class Nagroda
    {
        [Key]
        public int NagrodaId { get; set; }
        public string nagroda { get; set; }

        public Nagroda() { }
        public Nagroda(string nagroda) {  this.nagroda = nagroda; }
    }
}