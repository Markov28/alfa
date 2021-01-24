using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declaracion de variable
            double radio = 0, volumen = 0, altura = 0;

            //Explicacion del ejercicio
            Console.WriteLine("Encontrar el Volumen de un cono.");

            //Solicitando parametros (Radio)
            Console.Write("Ingrese el radio de la base (en centimetros) : ");

            //Convierte de texto a tipo entero (Radio)
            radio = Int32.Parse(Console.ReadLine());

            //Pidiendo datos (Altura)
            Console.Write("Ingrese la altura del cono (en centimetros) : ");

            //Convierte de texto a tipo entero (Altura)
            altura = Double.Parse(Console.ReadLine());

            //Realiza la operacion
            volumen = (radio * radio * 3.1415 * altura) / 3;

            //Imprimiendo el resultado
            Console.WriteLine("El volumen del Cono es: " + volumen + " centimetros cubicos");

            //Truco para detener al esclavo
            Console.ReadKey();
        }
    }
}