using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {    //Array 
            String[] Produto = new String[5] {
                "Caneta", "Brinco", "Lapis","Peruca","Baton"
            };
            Console.WriteLine(Produto[4]);

            //Console.WriteLine(Somar(1,2,10));
            //GerarPreco("Caneta", 19f);
        }
        static void ExibirHello(){
                Console.WriteLine("Hello World!");
                Console.WriteLine("Usando Função!");
                Console.WriteLine("Uma grande Jornada Nos espera pequeno!");
    }
        static void GerarPreco(string nomeProduto,float preco)
        {
            // $ - (Funciona como F-String em C#);
         Console.WriteLine($"Produto:{nomeProduto} Preço: R${preco}");
        }

        static string Somar(int a, int b, int c) {
            int ResFinal = a + b + c;
            return $"A soma de {a} + {b} + {c} = {ResFinal}";
        }
    }
}