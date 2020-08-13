using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace Divisores
{
    class Program
    {
        static void Main()
        {
            StreamReader lectura, lectura1;
            string linea, linea1;
            int CantEst = File.ReadAllLines("estudiantes.txt").Length;
            int CantTemas = File.ReadAllLines("temas.txt").Length;
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            string[] estudiantes = new string[CantEst];
            string[] temas = new string[CantTemas];
            try
            {
                lectura = File.OpenText("estudiantes.txt");
                linea = lectura.ReadLine();
                for (int i = 0; i < CantEst; i++)
                {
                    estudiantes[i] = linea;
                    linea = lectura.ReadLine();
                }

                for (int i = estudiantes.Length - 1; i > 0; i--)
                {
                    var j = rnd.Next(0, i);
                    var temp = estudiantes[i];
                    estudiantes[i] = estudiantes[j];
                    estudiantes[j] = temp;
                }

            }
            catch (FileLoadException ex)
            {
                Console.WriteLine(ex);
            }
             
            try
            {
                lectura1 = File.OpenText("temas.txt");
                linea1 = lectura1.ReadLine();
                for (int i = 0; i < CantTemas; i++)
                {
                    temas[i] = linea1;
                    linea1 = lectura1.ReadLine();
                }
                for (int i = CantTemas - 1; i > 0; i--)
                {
                    var j = rnd.Next(0, i);
                    var temp = temas[i];
                    temas[i] = temas[j];
                    temas[j] = temp;

                }
            }
            catch(FileNotFoundException fe)
            {
                Console.WriteLine(fe);
            }

            var mitad = estudiantes.Length / 2;
            string[] Equipo1 = new string[estudiantes.Length / 2];
            Equipo1 = estudiantes.Take(mitad).ToArray();
            string[] Equipo2 = new string[estudiantes.Length / 2];
            Equipo2 = estudiantes.Skip(mitad).ToArray();




            var mitad2 = temas.Length / 2;
            string[] temas1 = new string[temas.Length / 2];
            temas1 = temas.Take(mitad2).ToArray();
            string[] temas2 = new string[temas.Length / 2];
            temas2 = temas.Skip(mitad2).ToArray();

            Console.WriteLine("EQUIPO 1");
            Console.WriteLine("");

            for (int i = 0; i < Equipo1.Length; i++)
            {
                Console.WriteLine(" @" + Equipo1[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Temas");
            Console.WriteLine("");

            for (int i = 0; i < temas1.Length; i++)
            {
                Console.WriteLine(" - " + temas1[i]);

            }
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("");
            Console.WriteLine("");
                Console.WriteLine("Equipo 2");
            Console.WriteLine("");


            for (int i = 0; i < Equipo2.Length; i++)
                {
                Console.WriteLine("@" + Equipo2[i]);
                }
            Console.WriteLine("");
            Console.WriteLine("Temas");
            for (int i = 0; i < temas2.Length; i++)
            {
                Console.WriteLine(" - " + temas2[i]);
            }
            Console.ReadKey();

        }
            
        }
    }

