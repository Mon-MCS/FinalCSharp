// 14. Dada una lista de números enteros, crea un programa en C# que elimine los números duplicados de la lista.

using static System.Console;

namespace FinalCSharp.Ejercicio14{
    class Ejercicio14
    {
        public void EliminarDuplicados()
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

            List<int> numerosSinDuplicados = new List<int>();

            foreach (int numero in numeros)
            {
                if (!numerosSinDuplicados.Contains(numero))
                {
                    numerosSinDuplicados.Add(numero);
                }
            }

            WriteLine("Números originales: " + string.Join(", ", numeros));
            WriteLine("Números sin duplicados: " + string.Join(", ", numerosSinDuplicados));
            ReadKey();
        }
    }
}