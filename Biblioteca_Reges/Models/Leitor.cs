using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca_Reges.Models
{
    public class Leitor
    {
        public long LeitorId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public virtual ICollection<Livro> livro { get; set; }
    }
}