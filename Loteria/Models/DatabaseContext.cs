﻿using Loteria.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Loteria.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("LoteriaConnectionString") { }

        public DbSet<Uczestnik> Uczestnicy { get; set; }
        public DbSet<Nagroda> Nagrody { get; set;}
        public DbSet<Pytanie> Pytania { get; set; }
        public DbSet<Odpowiedz> Odpowiedzi { get; set; }
        

    }
}