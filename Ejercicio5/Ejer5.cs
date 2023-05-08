// 5.Dada una lista de nombres, crea un programa en C# que ordene la lista alfabéticamente.
using static System.Console;

namespace Ej5{
    // class Program
    // {
    //     static void Main()
    //     {
    //         Ejercicio5Solo ejer5 = new Ejercicio5Solo();
    //         ejer5.ordenarLista();
    //     }
    // }

    class Ejercicio5Solo
    {
        public void ordenarLista()
        {
            List<string> nombres = new List<string>();

            while(true) {
                Write("Entre el nombre, si desea finalizar escriba FIN: ");
                string? elemento = ReadLine();
                if (elemento == "FIN")
                break;
                else {
                    if (elemento == null)
                    {
                        WriteLine("Nombre inválido");
                        continue;
                    }
                    nombres.Add(elemento);
                }
            }
            nombres.Sort();

            WriteLine("Lista ordenada alfabéticamente:");

            foreach (string nombre in nombres)
            {
                WriteLine(nombre);
            }
            ReadKey();
        }
    }
}