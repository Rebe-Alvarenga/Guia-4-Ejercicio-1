using System;

namespace Ejercicio_1_Guia_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, contestadas, porcentaje;
            Console.WriteLine("Hola y bienvenido. Este programa mide el nivel de capacidad laboral");
            Console.WriteLine("\nPara empezar, inserte el total de preguntas propuestas...");
            total = int.Parse(Console.ReadLine());
            Console.WriteLine("Bien, ahora inserte el numero de preguntas contestadas...");
            contestadas = int.Parse(Console.ReadLine());
            porcentaje = (100 * contestadas) / total;
            Console.WriteLine("\nEL PORCENTAJE DE CAPACIDAD LABORAL ES DE " + porcentaje + "%.");
            if (porcentaje >= 90)
            {
                Console.WriteLine("\n¡Felicidades! usted posee un nivel MAXIMO de capacidad laboral");
            }
            else if (porcentaje >=75 && porcentaje < 90)
            {
                Console.WriteLine("\n¡Bien hecho! usted posee un nivel MEDIO de capacidad laboral");
            }
            else if (porcentaje >=50 && porcentaje < 75)
            {
                Console.WriteLine("\nUsted posee un nivel REGULAR de capacidad laboral");
            }
            else if (porcentaje < 50)
            {
                Console.WriteLine("\nLo sentimos, usted se encuentra FUERA DE NIVEL de capacidad laboral");
            }
            Console.WriteLine("\nPRESIONE CUALQUIER TECLA PARA TERMINAR EL PROGRAMA...");
            Console.ReadKey();
        }
    }
}
