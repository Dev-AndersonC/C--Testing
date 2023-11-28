using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* int condicao = 0;
            while (condicao < 10)
            {
                condicao++;
                Console.WriteLine(condicao);
                
            } */
            string[] palavra = {"Limão", "Pera","Sapato","Doido"};
            foreach(string palavras in palavra){
                Console.WriteLine(palavras);
            }
        }
    }
}