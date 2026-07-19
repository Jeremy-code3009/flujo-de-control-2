using System;

namespace RegistroEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEstudiante\tNota1\tNota2\tNota3\tNota4\tPromedio\tEstatus");
            Console.WriteLine("--------------------------------------------------------------------------");

            for (int i = 1; i <= cantidadEstudiantes; i++)
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------------");

                Console.Write("Nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la nota 1: ");
                double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Ingrese la nota 2: ");
                double nota2 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Ingrese la nota 3: ");
                double nota3 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Ingrese la nota 4: ");
                double nota4 = double.Parse(Console.ReadLine());

                Console.WriteLine(); 

                double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

                string estatus;

                if (promedio >= 70)
                {
                    estatus = "Aprobado";
                }
                else
                {
                    estatus = "Reprobado";
                }

                Console.WriteLine($"{nombre}\t{nota1}\t{nota2}\t{nota3}\t{nota4}\t{promedio:F2}\t\t{estatus}");

                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}