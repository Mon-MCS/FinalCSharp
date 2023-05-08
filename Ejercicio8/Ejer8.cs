// 8. Crea un programa en C# que calcule el área y volumen de un cubo dado su lado.
using static System.Console;
using static System.Math;

namespace Ej8{
    class Program
    {
        static void Main()
        {
            Ejercicio8Solo ejer8 = new Ejercicio8Solo();
            ejer8.AreaVolumenCubo();
        }
    }

    class Ejercicio8Solo
    {
        public void AreaVolumenCubo()
        {
            double lado = 0, area, volumen;
            while (true)
            {
                Write("Introduce el valor del lado del cubo: ");
                    if (!double.TryParse(ReadLine(), out lado))
                        WriteLine("Lado invalido, vuelva a introducir el número.");
                    else
                        break;
            }

            area = 6 * Pow(lado, 2);
            volumen = Pow(lado, 3);

            WriteLine("El área del cubo es {0}", Math.Round(area,3));
            WriteLine("El volumen del cubo es {0}", Math.Round(volumen,3));
            ReadKey();
        }

    }
}