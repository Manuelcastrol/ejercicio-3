using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3.negocio
{
    class NClsdato
    {


        public string por()
        {
            Clsdato datos = new Clsdato();
            int dato = 1;

            while (dato == 1)
            {
                Console.WriteLine("ingrese el dinero que quiere sacar");
                datos.Valor = int.Parse(Console.ReadLine());
                if (datos.Valor % 5 == 0)
                {
                    Console.WriteLine("se comienza a retirar la cantidad de: " + datos.Valor + " dolares");

                }
                if (datos.Valor % 5 != 0)
                {
                    Console.WriteLine("error en la cantidad de " + datos.Valor + " dolares, no se ha podido retirar intente con otra cifra ejemlo 5,10,15 etc");
                    Console.WriteLine("se procedio a cerrar el programa por que la cifra ingresada no puede ser retirada\n");
                    dato = 2;


                }

            }



            return "";




        }


    }
}
