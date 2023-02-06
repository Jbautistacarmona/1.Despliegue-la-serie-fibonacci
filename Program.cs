using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despliegue_la_serie_fibonacci
{
    internal class Program //Las clases que se declaran directamente dentro de un espacio de nombres
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número inicial:");
            int start = int.Parse(Console.ReadLine());          //Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente

            Console.WriteLine("Ingrese el límite:");            //aqui se visualiza el mensaje de que entre los datos necesario
            int limit = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            Console.Write(a + " " + b + " ");

            for (int i = 0; i < limit - 2; i++)     //ejecuta su cuerpo mientras una expresión booleana especificada se evalúe como true
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }

            Console.ReadLine(); //para imprimir el resultado.

        }
    }
}
