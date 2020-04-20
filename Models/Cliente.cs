using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFramework_exercicio.Models
{
    public class Cliente
    {
        private static DBContext _db = new DBContext();
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }

        public static DbSet<Cliente> Busca()
        {
            return _db.Clientes;
        }   

        public bool Salvar()
        {
            try
            {
                _db.Clientes.Add(this);
                _db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
    }


       
}