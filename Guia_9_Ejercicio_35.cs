using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_9_Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dado el apellido por familia y el consumo total en $ (agua, electricidad y telecomunicaciones)
            de 10 familias imprima apellido de la familia que tiene el menor consumo total y el mayor consumo total*/

            double temp,agua,elec,com,menor,mayor;
            int m = 0, k = 0;
            string seudo;
            double[] comsumo = new double[10];
            string[] nombre = new string[10];

            for (int i = 0; i < comsumo.Length; i++)
            {
                Console.WriteLine("========Nombre de la familia {0}========",i+1);
                nombre[i] = Console.ReadLine();

                Console.WriteLine("Total recibo de Agua");
                agua = double.Parse(Console.ReadLine());
                Console.WriteLine("Total de recibo de Electricidad");
                elec = double.Parse(Console.ReadLine());
                Console.WriteLine("Total de gasto de cominicaciones");
                com = double.Parse(Console.ReadLine());
                comsumo[i] = agua+elec+com ;
                Console.Clear();
            }
            
            //METODO BURBUJA
            for (int i = 0; i < (comsumo.Length - 1); i++)
            {
                for (int j = 0; j < (comsumo.Length - 1); j++)
                {
                    if (comsumo[j] > comsumo[j + 1])
                    {
                        temp = comsumo[j];
                        seudo = nombre[j];
                        comsumo[j] = comsumo[j + 1];
                        nombre[j] = nombre[j + 1];
                        comsumo[j + 1] = temp;
                        nombre[j + 1] = seudo;
                    }
                }
            }
            menor = comsumo[0];
            
            Console.WriteLine("orden:");
            for (int p = 0; p != comsumo.Length; p++)
            {
                if(menor>comsumo[p])
                {
                    menor = comsumo[p];
                    m = p;
                }
            }
            mayor = comsumo[0];

            for (int p = 0; p != comsumo.Length; p++)
            {
                if (mayor < comsumo[p])
                {
                    mayor = comsumo[p];
                    k = p;
                }
            }
            Console.WriteLine("La familia {0} es la de menor comsumo con ${1}", nombre[m], menor);
            Console.WriteLine("La familia {0} es la de mayor comsumo con ${1}", nombre[k], mayor);
            Console.ReadLine();
        }

    }
}
