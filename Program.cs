using System;
using System.Collections.Generic;
using System.Linq;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
           // A partir del siguiente string:
//ave, banco, comida, duda, ejercicio, fuente, girasol
          //Utilizar los métodos de un string para tranformarlo en el siguiente string e imprimirlo.
//FUENTE;EJERCICIO;DUDA;COMIDA;BANCO

        string words = "ave, banco, comida, duda, ejercicio, fuente, girasol";
        System.Console.WriteLine(words);

        string words2 = words.ToUpper().Replace("," , ";");

        string[] wordsArray = words2.Split(" ");



        for(int i = wordsArray.Length - 2; i > 0; i--)
            {
                System.Console.Write(wordsArray[i]);
            }

       /* foreach (string word in wordsArray)
            {
                System.Console.WriteLine($" Acomodo incial: \n {word}");
            }
        
        */



        }
    }
}
