using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca_Reges.Models
{
    public class Livro
    {
        public long? LivroId { get; set; }
        public string nome { get; set; }
        public string autor { get; set; }
        public string nomeEditora { get; set; }
        public string genero { get; set; }        
        public string isbn { get; set; }
        public long? bibliotecarioid { get; set; }
        public long? leitorId { get; set; }        
        public Bibliotecario bibliotecario { get; set; }
        public Leitor leitor { get; set; }
    }
}