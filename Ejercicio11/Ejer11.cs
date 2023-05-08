﻿// 11. Dada una lista de números enteros, crea un programa en C# que calcule la media de la lista.

using static System.Console;
using static System.Math;

namespace Ej11{
    class Program
    {
        static void Main()
        {
            Ejercicio11Solo ejer11 = new Ejercicio11Solo();
            ejer11.MediaLista();
        }
    }

    class Ejercicio11Solo
    {
        public void MediaLista()
        {
            List<int> numeros = new List<int>();
            while(true) 
            {
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
            double media = numeros.Average();
            WriteLine("La media es: " + Round(media,2));
            ReadKey();
        }
    }
}