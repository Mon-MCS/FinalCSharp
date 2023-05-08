using static System.Console;
using FinalCSharp.Ejercicio1;
using FinalCSharp.Ejercicio2;
using FinalCSharp.Ejercicio3;
using FinalCSharp.Ejercicio4;
using FinalCSharp.Ejercicio5;
using FinalCSharp.Ejercicio6;
using FinalCSharp.Ejercicio7;
using FinalCSharp.Ejercicio8;
using FinalCSharp.Ejercicio9;
using FinalCSharp.Ejercicio10;
using FinalCSharp.Ejercicio11;
using FinalCSharp.Ejercicio12;
using FinalCSharp.Ejercicio13;
using FinalCSharp.Ejercicio14;
using FinalCSharp.Ejercicio15;
namespace ProgramaPrincipal
{
    public class Program
    {
        public static void Main()
        {
            while(true)
            {
                int opcion;
                Clear();
                WriteLine("Seleccione una de las opciones siguientes: ");
                WriteLine(" 0. Salir");
                WriteLine(" 1. Dada una lista de números enteros, determinar cuál es el mayor y cuál es el menor.");
                WriteLine(" 2. Dado un número entero, determinar si es par o impar.");
                WriteLine(" 3. Determinar si un año es bisiesto o no.");
                WriteLine(" 4. Determinar si una cadena de texto es un palíndromo o no.");
                WriteLine(" 5. Dada una lista de nombres, ordenar la lista alfabéticamente.");
                WriteLine(" 6. Dado un número entero, calcular su factorial.");
                WriteLine(" 7. Dado un número entero, determinar si es primo o no.");
                WriteLine(" 8. Dado el lado de un cubo, calcular su área y su volumen.");
                WriteLine(" 9. Dada una lista de números enteros, calcular la suma de todos los números pares de la lista.");
                WriteLine(" 10. Dado un número, determinar si es positivo, negativo o cero.");
                WriteLine(" 11. Dada una lista de números, calcular su media.");
                WriteLine(" 12. Dado un número aleatorio entre 1 y 100, el usuario debe adivinarlo. Indicándose si el número introducido es mayor o menor que el número aleatorio, hasta que el usuario adivine el número correcto");
                WriteLine(" 13. Determinar si una cadena de texto es un anagrama de otra cadena de texto.");
                WriteLine(" 14. Dada una lista de números enteros, eliminar los números duplicados de la lista.");
                Write("Introduzca su opción: ");

                string? opcionString = ReadLine();
                    if (!int.TryParse(opcionString, out opcion))
                        WriteLine("Ha introducido un elemento que no es un número, vuelva a introducir su opción");
                    else if (opcion == 1)
                    {
                        Ejercicio1 ejer1 = new Ejercicio1();
                        ejer1.MenorMayor();
                    }
                    else if (opcion == 2)
                    {
                        Ejercicio2 ejer2 = new Ejercicio2();
                        ejer2.ParImpar();
                    }
                    else if (opcion == 3){
                        Ejercicio3 ejer3 = new Ejercicio3();
                        ejer3.AnyoBisiesto();
                    }
                    else if (opcion == 4){
                        Ejercicio4 ejer4 = new Ejercicio4();
                        ejer4.palindromo();
                    }
                    else if (opcion == 5){
                        Ejercicio5 ejer5 = new Ejercicio5();
                        ejer5.ordenarLista();
                    }
                    else if (opcion == 6){
                        Ejercicio6 ejer6 = new Ejercicio6();
                        ejer6.factorial();
                    }
                    else if (opcion == 7){
                        Ejercicio7 ejer7 = new Ejercicio7();
                        ejer7.NumeroPrimo();
                    }
                    else if (opcion == 8){
                        Ejercicio8 ejer8 = new Ejercicio8();
                        ejer8.AreaVolumenCubo();
                    }
                    else if (opcion == 9){
                        Ejercicio9 ejer9 = new Ejercicio9();
                        ejer9.SumaNumerosPares();
                    }
                    else if (opcion == 10){
                        Ejercicio10 ejer10 = new Ejercicio10();
                        ejer10.NumeroPositivoNegativoCero();
                    }
                    else if (opcion == 11){
                        Ejercicio11 ejer11 = new Ejercicio11();
                        ejer11.MediaLista();
                    }
                    else if (opcion == 12){
                        Ejercicio12 ejer12 = new Ejercicio12();
                        ejer12.AdivinarNumero();
                    }
                    else if (opcion == 13){
                        Ejercicio13 ejer13 = new Ejercicio13();
                        ejer13.Anagrama();
                    }
                    else if (opcion == 14){
                        Ejercicio14 ejer14 = new Ejercicio14();
                        ejer14.EliminarDuplicados();
                    }
                    else if (opcion == 15){
                        Ejercicio15 ejer15 = new Ejercicio15();
                        ejer15.Capicua();
                    }
                    else if (opcion == 0)
                        break;
                    else 
                    {
                        WriteLine("Ha introducido un número fuera de las opciones disponibles");
                        ReadKey();
                    }
            }
        }
    }
}