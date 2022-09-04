using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322085
{
    internal class Filme
    {
        string titulo;
        string sinopse;
        string genero;
       string classi;

        public void receber(string ti, string si, string ge, string cl)
        {
            this.titulo = ti;
            this.sinopse = si;
            this.genero = ge;
            this.classi = cl;

        }
        public string mostrar()
        {
            return "Titulo: " + this.titulo + "\nsinopse: " + this.sinopse + "\nGenero: "
                + this.genero + "\nClassificação: " + this.classi;
        }
                
       

    }
}
