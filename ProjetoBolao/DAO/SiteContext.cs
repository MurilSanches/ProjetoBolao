﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoBolao.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoBolao.DAO
{
    public class SiteContext : DbContext
    {
        public DbSet<Notificacao> Notificacao { get; set; }
        public DbSet<Resultado> Resultado { get; set; }
        public DbSet<Votacao> Votacao { get; set; }

        public DbSet<Usuario> Usuario2 { get; set; }

        public DbSet<Time> Times { get; set; }

        public DbSet<Jogo> Jogo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=regulus.cotuca.unicamp.br;Initial Catalog=PR118187; User ID =PR118187; Password =PR118187");
        }
    }
}