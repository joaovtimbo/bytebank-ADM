using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Desafio
{
    public class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; set; }
        public string Isbn { get; private set; }
        public string AnoDePublicacao { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumeroDePaginas { get; set; }
        public string PaisDePublicacao { get; set; }

        public Livro(string isbn, string titulo)
        {
            this.Isbn = isbn;
            this.Titulo = titulo;
        }
    }
}
