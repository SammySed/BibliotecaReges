using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca_Reges.Models
{
    public class Bibliotecario
    {
        public long BibliotecarioId { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string documento { get; set; }
        public string pis { get; set; }
        public double salario { get; set; }
        public string logradouro { get; set; }
        public string cidade { get; set; }

        public virtual ICollection<Livro> livro { get; set; }
    }
}