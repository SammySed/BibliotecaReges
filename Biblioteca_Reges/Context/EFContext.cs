using Biblioteca_Reges.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteca_Reges.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("RegesBiblioteca")
        {
            Database.SetInitializer<EFContext>
                (new DropCreateDatabaseIfModelChanges<EFContext>());
        }
        public DbSet<Bibliotecario> bibliotecario { get; set; }
        public DbSet<Leitor> leitor { get; set; }
        public DbSet<Livro> livro { get; set; }
    }
}