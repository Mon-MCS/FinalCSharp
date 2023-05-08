// 7. Dado un número entero, crea un programa en C# que determine si es primo o no.
using static System.Console;

namespace FinalCSharp.Ejercicio7{
    class Ejercicio7
    {
        public void NumeroPrimo()
        {
            int num = 0, i;
            bool esPrimo = true;
            while(true){
                Write("Introduzca un número entero positivo: ");
                if (!int.TryParse(ReadLine(), out num))
                    WriteLine("Ha introducido un elemento incorrecto, vuelva a introducir el número");
                else
                    break;
            }
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
                WriteLine("{0} es un número primo", num);
            else
                WriteLine("{0} no es un número primo", num);
            ReadKey();
        }
    }
}