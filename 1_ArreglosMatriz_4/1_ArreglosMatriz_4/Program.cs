using System;

namespace _1_ArreglosMatriz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] calificaciones = new string[4, 4];
            calificaciones[0, 0] = "Ricardo";
            calificaciones[0, 1] = "10";
            calificaciones[0, 2] = "10";
            calificaciones[0,3] = "10";
            calificaciones[1, 0] = "Cecilia";
            calificaciones[1, 1] = " 8";
            calificaciones[1, 2] = " 8";
            calificaciones[1, 3] = "10";
            calificaciones[2, 0] = "Martha ";
            calificaciones[2, 1] = " 9";
            calificaciones[2, 2] = "10";
            calificaciones[2, 3] = "10";
            calificaciones[3, 0] = "Luis   ";
            calificaciones[3, 1] = "10";
            calificaciones[3, 2] = "10";
            calificaciones[3, 3] = "10";

            Console.WriteLine(calificaciones[1,0]);
            Console.ReadLine();

   
            for (int filas = 0; filas < 4; filas++)
            {
                for (int columnas = 0; columnas < 4; columnas++)
                {
                    Console.Write(calificaciones[filas, columnas] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
