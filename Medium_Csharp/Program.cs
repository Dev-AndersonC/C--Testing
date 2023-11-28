using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            // && (Acontece quando ambos são verdadeiros ou ambos são falsos) - (E / And) ou || (Acontece quando um dos dois lados e verdadeiro.)-(Ou / Or).
            
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11) {
                Console.WriteLine("Você é uma criança!");

            } else if(idade >= 12 && idade < 18) {
                Console.WriteLine("Você é um adolescente!");
            } else {
                Console.WriteLine("Você é um adulto");
            }
        }
    }
}