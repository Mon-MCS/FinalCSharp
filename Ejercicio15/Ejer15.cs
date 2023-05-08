// 15. Crea un programa en C# que determine si un número es capicúa o no.

using static System.Console;

namespace Ej15{
    class Program
    {
        static void Main()
        {
            Ejercicio15Solo ejer15 = new Ejercicio15Solo();
            ejer15.Capicua();
        }
    }

    class Ejercicio15Solo
    {
        public void Capicua()
        {
            int num = 0;
            while(true)
            {
                Write("Ingresa un número: ");
                if (!int.TryParse(ReadLine(), out num))
                    WriteLine("Ha introducido un elemento incorrecto, vuelva a introducir el número");
                else
                    break;
            }
            int originalNum = num;
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = (reversedNum * 10) + digit;
                num /= 10;
            }

            if (originalNum == reversedNum)
            {
                WriteLine("El número es capicúa.");
            }
            else
            {
                WriteLine("El número no es capicúa.");
            }
            ReadKey();
        }
    }
}