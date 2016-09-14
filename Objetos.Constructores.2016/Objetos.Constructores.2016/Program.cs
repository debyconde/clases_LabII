using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Constructores._2016
{
    class Program
    {
        static void Main(string[] args)
        {


            //Auto.cantidadObj = 777;

            //for (int i = 0; i < 3; i++)
            //{

            //    Auto a = new Auto();
                
            //}

            


            Auto a1;
            a1 = new Auto(3, ConsoleColor.Magenta);

            //a1.cantRuedas = 4;
            Auto a2 = new Auto(5, ConsoleColor.Green);

            Console.WriteLine(a1.Mostrar());

            Console.WriteLine(Auto.Mostrar(a2));

            Auto.DiferenciaEntreInstancias();

            Console.ReadLine();
        }
    }
}
