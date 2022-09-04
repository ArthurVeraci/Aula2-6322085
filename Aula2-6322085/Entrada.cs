using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322085
{
    internal class Entrada
    {
        int valor;
        int poltrona;
        string horas;

        public void setvalor(int valor)
        {
            this.valor = valor;
        }
        public int getvalor()
        {
            return this.valor;
        }
        public void setpoltrona(int poltrona)
        {
            this.poltrona = poltrona;
        }
        public int getpoltrona()
        {
            return this.poltrona;
        }
        public void sethoras(string horas)
        {
            this.horas = horas;
        }
        public string gethoras()
        {
            return this.horas;
        }

      
    }
}
