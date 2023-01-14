using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloquesExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Proyecto nuevo
            bool valido = false;
            do
            {
                try
                {
                    Console.Write("Ingrese un valor:"); // Necesitamos un valor entero
                    string linea = Console.ReadLine(); // Lo pasamos a linea
                    var num = int.Parse(linea); // Pasamos a numero
                    var cuadrado = num * num; // Calculamos
                    Console.WriteLine($"El resultado es {num} es {cuadrado}"); // Mostrar el resultado
                    valido = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Debe ingresar un entero");
                }
                Console.ReadKey(); // Esperamos tecla para cerrar
            } while (valido == false);
        }
    }
}
