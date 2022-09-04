using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322085
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // intanciação do objeto
            Entrada en = new Entrada();
            Filme fil = new Filme();

            Console.Write("Filme: ");
            string titulo = Console.ReadLine();
            Console.Write("Sinopse: ");
            string sinopse = Console.ReadLine();
            Console.Write("Genero: ");
            string genero = Console.ReadLine();
            Console.Write("Classificação: ");
            string classi = Console.ReadLine();
            fil.receber(titulo, sinopse, genero, classi);

            Console.Write("Poltrona: ");
            en.setpoltrona(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Valor da Entrada: ");
            en.setvalor(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Dia e Hora: ");
            en.sethoras(Console.ReadLine());
            

            Console.WriteLine("\nPoltrona: " + en.getpoltrona() + "\nValor da Entrada: "
                + en.getvalor().ToString("C") + "\nDia: " + en.gethoras());

            Console.WriteLine(fil.mostrar());
            



            Console.ReadKey();
        }
    }
}
