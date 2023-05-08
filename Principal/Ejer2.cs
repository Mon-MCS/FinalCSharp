// 2.Dado un número entero, crea un programa en C# que determine si es par o impar.

using static System.Console;
namespace FinalCSharp.Ejercicio2{
    class Ejercicio2
    {
        public void ParImpar()
        {
            int numero;
            while(true)
            {
                Write("Ingrese un número entero: ");
                string? elemento = ReadLine();
                if (!int.TryParse(elemento, out numero))
                    WriteLine("Ha introducido un elemento incorrecto, vuelva a introducir el número");
                else
                {
                    if (numero % 2 == 0)
                    {
                        WriteLine("El número es par");
                    }
                    else
                    {
                        WriteLine("El número es impar");
                    }
                    break;
                }
            }
        }
    }
}


