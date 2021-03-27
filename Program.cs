using System;
using System.Text.RegularExpressions;

namespace A133590.Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 11");
            Console.WriteLine("Dada una frase, remueve las tildes de las vocales que las tengan.");
            Console.Write("Por favor, ingrese una frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine(Regex.Replace(frase.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", ""));
            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
