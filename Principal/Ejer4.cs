// 4.Crea un programa en C# que determine si una cadena de texto es un palíndromo o no.
using static System.Console;
using System.Text.RegularExpressions;

namespace FinalCSharp.Ejercicio4{
    class Ejercicio4
    {
        public void palindromo()
        {
            Write("Ingrese una palabra o frase: ");
            string? texto = ReadLine();
            if (texto == null)
            {
                Write("Texto invalido");
                return;
            }
            texto = System.Text.RegularExpressions.Regex.Replace(texto.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            texto = Regex.Replace(texto, "\\p{P}", string.Empty);
            texto = texto.ToLower().Replace(" ", "");
            bool palindromo = true;
            for (int i = 0; i < texto.Length / 2; i++)
            {
                if (texto[i] != texto[texto.Length - 1 - i])
                {
                    palindromo = false;
                    break;
                }
            }

            if (palindromo)
            {
                WriteLine("La cadena es un palíndromo");
            }
            else
            {
                WriteLine("La cadena no es un palíndromo");
            }
            ReadKey();
        }
    }
}