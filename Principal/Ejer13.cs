﻿// 13. Crea un programa en C# que determine si una cadena de texto es un anagrama de otra cadena de texto.

using static System.Console;

namespace FinalCSharp.Ejercicio13{
    class Ejercicio13
    {
        public void Anagrama()
        {   
            string? palabra1;
            string? palabra2;
            while(true)
            {
                Write("Introduzca una cadena: ");
                palabra1 = ReadLine();
                Write("Introduzca el anagrama de la cadena: ");
                palabra2 = ReadLine();
                if (((palabra1 != null) && (palabra2 != null)))
                    break;
                else 
                    WriteLine("Al menos una de las palabras introducidas es nula");
            }
            
            palabra1 = palabra1.ToLower().Replace(" ", "");
            palabra2 = palabra2.ToLower().Replace(" ", "");
            char[] letras1 = palabra1.ToCharArray();
            char[] letras2 = palabra2.ToCharArray();

            Array.Sort(letras1);
            Array.Sort(letras2);

            bool sonAnagramas = letras1.SequenceEqual(letras2);

            if (sonAnagramas)
            {
                WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
            }
            else
            {
                WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
            }
            ReadKey();
        }
    }
}