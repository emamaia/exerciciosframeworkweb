using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EntityFramework_exercicio.Models
{
    public class DBContext : DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             if (!optionsBuilder.IsConfigured)
             {
                optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=avanade_aula;Data Source=LAPTOP-NA3QASJT");
                /* optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString); */             

             } 
         }
        public DbSet<Cliente> Clientes { get; set; }

    }
}