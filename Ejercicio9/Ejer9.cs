// 9. Dada una lista de números enteros, crea un programa en C# que calcule la suma de todos los números pares de la lista.

using static System.Console;

namespace Ej9{
    class Program
    {
        static void Main()
        {
            Ejercicio9Solo ejer9 = new Ejercicio9Solo();
            ejer9.SumaNumerosPares();
        }
    }

    class Ejercicio9Solo
    {
        public void SumaNumerosPares()
        {
            List<int> numeros = new List<int>();

            while(true) {
                Write("Entre el numero, si desea finalizar escriba FIN: ");
                string? elemento = ReadLine();
                int numero;
                if (elemento == "FIN")
                break;
                else if (!int.TryParse(elemento, out numero)){
                    WriteLine("Elemento no válido, vuelva a introducir el número");
                    continue;
                }
                else {
                    numeros.Add(numero);
                }
            }
            int suma = 0;

            foreach (int num in numeros)
            {
                if (num % 2 == 0)
                    suma += num;
            }
            WriteLine("La suma de los números pares es {0}", suma);
            ReadKey();
        }
    }
}