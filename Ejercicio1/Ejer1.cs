// 1. Crear un progrma en C#, que dada una lista de números enteros, 
// determina cuál es el mayor y cuál es el menor.
using System.Collections.Generic;
using static System.Console;
namespace Ej1{
     class Program
     {
         static void Main()
         {
             Ejercicio1Solo ejer1 = new Ejercicio1Solo();
             ejer1.MenorMayor();
         }
    }

    class Ejercicio1Solo
    {
        public void MenorMayor()
        {
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
                int mayor = numeros[0];
                int menor = numeros[0];

                foreach (int numero in numeros)
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }

                WriteLine("El mayor número es: " + mayor);
                WriteLine("El menor número es: " + menor);
                ReadKey();
            }
        }
    }
}