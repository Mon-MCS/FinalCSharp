// 3.Crea un programa en C# que determine si un año es bisiesto o no.
using static System.Console;

namespace Ej3{
        class Program
    {
        static void Main()
        {
            Ejercicio3Solo ejer3 = new Ejercicio3Solo();
            ejer3.AnyoBisiesto();
        }
    }
    class Ejercicio3Solo
    {
        public void AnyoBisiesto()
        {
            while(true)
            {
                Write("Ingrese un año: ");
                int anio = 0;
                if (int.TryParse(ReadLine(), out anio))
                {
                    if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                    {
                        WriteLine(anio + " es un año bisiesto");
                    }
                    else
                    {
                        WriteLine(anio + " no es un año bisiesto");
                    }
                    ReadLine();
                    break;
                }
                else
                    WriteLine("Ha entrado un año incorrecto, vuelva a intentarlo");
            }
            ReadKey();
        }
    }
}
