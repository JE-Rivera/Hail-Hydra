using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia10_Ejercicio32
{
    class Program
    {
        
        /*Dados los nombres y la carrera que estudian n personas en la FIA, imprima el nombre de la carrera y a continuación
        los nombres de las personas que estudian la carrera para cada una de ellas.*/
        static void Main(string[] args)
        {
            string[] names = new string[400];
            string[] names02 = new string[names.Length];
            int[] carreras = new int[names.Length];
            string[] Carrerasnames = new string[] { "Arquitectura", "Ingenieria Civil", "Ingeniera Industrial", "Ingeniera Mecanica", "Ingeniera Electrica", "Ingeniera Quimica", "Ingeniera Alimentos", "Ingeniera Sistemas" };
            int cont = 0;
            string b;
        Console.WriteLine(@"Gracias totales");
            do
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                names[cont] = Console.ReadLine();
                Console.WriteLine("\nIngrese La carrera del estudiante");
                carreras[cont] = ValidarCarreras();
                Console.WriteLine("\tHa terminado de registrar datos?\nPara continuar precione ENTER, Para terminar precione 0 y en seguida ENTER ");
                b = Console.ReadLine();
                cont++;
                Console.Clear();
            } while (b != "0");
            names = names02;
            Imprimir(carreras,names,cont,Carrerasnames);
            Console.ReadKey();

        }

        public static int ValidarCarreras()
        {
            int carrera;
            do
            {
                Console.WriteLine("Carreras:\n1-Arquitectura\n2-Ing.Civil\n3-Ing.Industrial");
                Console.WriteLine("4-Ing.Mecanica\n5-Ing.Electrica\n6-Ing.Quimica\n7-Ing. En Alimentos\n8-Ing En Sistemas");
                carrera = int.Parse(Console.ReadLine());
                if (!(carrera >= 1 && carrera <= 8))
                    Console.WriteLine("ERROR, Vuelva a ingresar el dato");
                Console.Clear();
            } while (!(carrera >= 1 && carrera <= 8));
            return carrera;
        }

        public static void Imprimir(int[] NumCarrera,string[]nombres,int cont,string[] Carreras)
        {
            int a;
            Console.WriteLine("=============== Listado de estudiantes por carreras. ===============");
            for(int i=0;i!=Carreras.Length;i++)
            {
                a = 0;
                for(int j=0;j!=cont;j++)
                {
                    if(NumCarrera[j]==i+1)
                    {
                        if (a == 0)
                        {
                            Console.WriteLine("\nCarrera: {0}", Carreras[i]);
                            a = 1;
                        }
                        Console.WriteLine("-"+nombres[j]);
                    }
                }
            }
        }
    }
}
