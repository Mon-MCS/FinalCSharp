// 10. Crea un programa en C# que determine si un número es positivo, negativo o cero.

using static System.Console;

namespace Ej10{
    class Program
    {
        static void Main()
        {
            Ejercicio10Solo ejer10 = new Ejercicio10Solo();
            ejer10.NumeroPositivoNegativoCero();
        }
    }
    class Ejercicio10Solo
    {
        public void NumeroPositivoNegativoCero()
        {
            int num;
            while(true)
            {
                Write("Introduzca un número entero: ");
                if (!int.TryParse(ReadLine(), out num))
                    WriteLine("Ha introducido un elemento incorrecto, vuelva a introducir el número");
                else
                    break;
            }

            if (num > 0)
                WriteLine("{0} es un número positivo", num);
            else if (num < 0)
                WriteLine("{0} es un número negativo", num);
            else
                WriteLine("{0} es cero", num);
            ReadKey();
        }
    }
}