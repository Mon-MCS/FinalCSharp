// 12. Crea un programa en C# que genere un número aleatorio entre 1 y 100, y le 
// pida al usuario adivinarlo. El programa en C# deberá indicar si el número introducido 
// es mayor o menor que el número aleatorio, hasta que el usuario adivine el número correcto.

using static System.Console;

namespace FinalCSharp.Ejercicio12{
    class Ejercicio12
    {
        public void AdivinarNumero()
        {

            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intentos = 0;
            int numeroUsuario = 0;

            while (numeroUsuario != numeroAleatorio)
            {
                Write("Adivina el número (entre 1 y 100):");
                if (!int.TryParse(ReadLine(), out numeroUsuario))
                {
                    WriteLine("Número invalido");
                    continue;
                }
                intentos++;

                if (numeroUsuario < numeroAleatorio)
                {
                    WriteLine("El número introducido es menor que el número aleatorio.");
                }
                else if (numeroUsuario > numeroAleatorio)
                {
                    WriteLine("El número introducido es mayor que el número aleatorio.");
                }
            }

            WriteLine("¡Has acertado el número en " + intentos + " intentos!");
            ReadKey();
        }
    }
}