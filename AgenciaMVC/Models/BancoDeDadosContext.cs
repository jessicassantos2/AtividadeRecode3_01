using System;
using AgenciaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciaMVC.Models
{
   public class BancoDeDadosContext : DbContext
             {
            public BancoDeDadosContext (DbContextOptions<BancoDeDadosContext> options) : base (options) {
             }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Destino> Destinos { get; set; }
            public DbSet<Pacote> Pacotes { get; set; }
   }
}
   
