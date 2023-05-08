﻿// 6. Crea un programa en C# que calcule el factorial de un número entero.
using static System.Console;

namespace Ej6{
    class Program
    {
        static void Main()
        {
            Ejercicio6Solo ejer6 = new Ejercicio6Solo();
            ejer6.factorial();
        }
    }

    class Ejercicio6Solo
    {
        public void factorial()
        {
            int num = 0, factorial = 1;
            while(true)
            {
                Write("Introduce un número entero positivo: ");
                if (int.TryParse(ReadLine(), out num))
                {

                    for (int i = 1; i <= num; i++)
                    {
                        factorial *= i;
                    }

                    WriteLine("El factorial de {0} es {1}", num, factorial);
                    break;
                }
                else
                    WriteLine("Número inválido. Vuelva a intentarlo.");
            }
            ReadKey();
        }
    }
}