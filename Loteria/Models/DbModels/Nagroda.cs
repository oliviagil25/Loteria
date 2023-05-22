using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loteria.Models.DbModels
{
    public class Nagroda
    {
        [Key]
        public static int NagrodaId;
        public string nagroda { get; set; }
        static Nagroda()
        {
            NagrodaId = 1;
        }

        public Nagroda() 
        {
            NagrodaId++;
        }
        public Nagroda(string nagroda) {  
            this.nagroda = nagroda; }
    }
}