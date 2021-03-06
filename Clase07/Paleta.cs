﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class Paleta
    {
        #region ATRIBUTOS

        private Tempera[] _colores;
        private sbyte _cantidadMaximaColores;

        #endregion 

        #region CONSTRUCTORES

        private Paleta(): this(4)
        {
        }

        private Paleta(sbyte maxColor)
        {
            this._colores = new Tempera[maxColor];
            this._cantidadMaximaColores = maxColor;
        }

        #endregion

        #region SOBRECARGA DE OPERADORES

        public static implicit operator Paleta(sbyte cant)
        {
            return new Paleta(cant);
        }

        public static explicit operator string(Paleta p1)
        {
            return Mostrar(p1);
        }

        public static bool operator ==(Paleta p1, Tempera t1)
        {
            foreach (Tempera t in p1._colores)
            {
                if (t == t1)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Paleta p1, Tempera t1)
        {
            return !(p1==t1);
        }


        #endregion

        #region METODOS

        private static string Mostrar(Paleta p1)
        {
            string ret = "La cantidad de temperas es " + p1._cantidadMaximaColores + "\n";

            foreach (Tempera t in p1._colores)
            {
                ret += t;
            }
            return ret;
        }

        public static Paleta operator +(Paleta p1, Tempera t1)
        {
            if (p1 != t1)
            {
                int index = nullSearcher(p1);

                if (index >= 0)
                {
                    p1._colores[index] = t1;
                }
            }
            return p1;
        }

        private static int nullSearcher(Paleta p1)
        {
            int firstNull = -1;
            foreach (Tempera t in p1._colores)
            {
                if (t.Equals(null))
                {
                    firstNull++;
                }
            }
            return firstNull;
        }

        #endregion

      

        //public static Paleta operator +(Paleta Pal1, Paleta Pal2)
        //{
        //    Paleta aux= new Paleta();

        //    if(Pal1._cantidadMaximaColores < Pal2._cantidadMaximaColores)
        //       Pal1._cantidadMaximaColores=Pal2._cantidadMaximaColores; 

        //    for(int i=0;i<Pal2._cantidadMaximaColores;i++) //recorer los colores de una sola paleta..
        //      {
        //            if(Pal1._colores[] != Pal2._colores[i]) // esta o no esta; si no esta lo agrego directamente, si esta sumo las cantidades con sobrecarga de temperas
        //            {
        //                aux+= Pal1._colores[] + Pal2._colores [i];
        //                //sobrecarga de operador get indexm(retorna entero)
                       

        //               // Pal2._colores[]= Pal1._colores[] + Pal2._colores[];
        //            }
                

        

        }

    }

