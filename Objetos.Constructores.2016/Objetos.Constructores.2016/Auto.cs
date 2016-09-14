using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Constructores._2016
{
    class Auto
    {
        #region Atributos

        #region De Instancia

        private int cantRuedas;
        private ConsoleColor color;
        
        #endregion

        #region De Clase

        private static DateTime fechaCreacion;
        public static int cantidadObj;
        public static DateTime fechaUltimaInstancia;

        #endregion

        #endregion

        #region Métodos

        #region De Instancia

        public string Mostrar()
        {
            return this.cantRuedas.ToString() + " - " + this.color.ToString() + " - " + Auto.cantidadObj.ToString() + " - " + Auto.fechaUltimaInstancia.ToLongTimeString() + "\n";
        }

        #endregion

        #region De Clase

        public static string Mostrar(Auto a)
        {
            return a.Mostrar();
        }

        //public static void DiferenciaEntreInstancias() 
        //{
        //   TimeSpan dif =  Auto.fechaUltimaInstancia - Auto.fechaCreacion;

        //   Console.WriteLine(dif.TotalMilliseconds);
        //}

        public static void DiferenciaEntreInstancias() 
        {
            TimeSpan dif = Auto.fechaUltimaInstancia - Auto.fechaCreacion;
            Console.WriteLine(dif.TotalMilliseconds);


        }


        #endregion

        #endregion


        #region Constructores

        public Auto(int cant, ConsoleColor color)
        {
            this.cantRuedas = cant;
            this.color = color;
            Auto.cantidadObj++;
            Auto.fechaUltimaInstancia = DateTime.Now;
        }

        //public Auto()
        //{
        //    this.cantRuedas = 4;
        //    this.color = ConsoleColor.Gray;
        //    Auto.cantidadObj++;
        //    Auto.fechaUltimaInstancia = DateTime.Now;
        //}


        static Auto() 
        {
            Auto.fechaCreacion = DateTime.Now;
            Auto.cantidadObj = 0;
        }

        #endregion


        //alt + 126
        ~Auto() 
        {
            System.Diagnostics.Trace.WriteLine("El objeto se destruyo " + DateTime.Now.ToLongTimeString());
            System.Diagnostics.Trace.WriteLine(this.Mostrar());
        }
    }
}
