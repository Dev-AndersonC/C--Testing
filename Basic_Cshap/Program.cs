// using == "import usado para importação de modulos, bibliotecas e classes."
using System;

// !console cria a estrutura basica do C#
namespace ConsoleApp
{
// Escopo do programa aonde se inicia
    public class Program
    {
        public static void Main(string[] args) // Função principal
        {
            // Tudo que esta dentro do main e executado!

            // Variaveis
            // Formas de Declarar - Os tipos definidos (int(-156 ate 32334), float(-156.0 como 232132.0 ==> "Double | Decimal"), Bool(True or False), String("Para caracteres"), Char ou 
            // Caracter = 'Um unico caracter'), Dynamic (Menos performatica porém dinamica);
            
            /*var name = "Anderson";
            -----------------------------------------
            int idade = 21;
            float altura = 1.61f;
            char letraFavorita = 'B';
            bool segundaGuerra = true;
            -------------------------------------------
            // Constante são criada uma unica vez, e seu valor e constante não deve ser alterado após ser atribuido.
            // E criada usando ( const tipo(Float) PI(Nome) = 3.14 )
            const float Pi = 3.14f;
            ------------------------------------------------------------------------------------------------------*/



            /*  Codigo basico para receber entrada de dados do Usuario:
            ----------------------------------------------------------
            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Seu nome é " + nome); 
            -----------------------------------------------------------*/

            int numbOne;
            int numbTwo;
            int resul = numbOne + numbTwo;

            Console.Write("Digite o primeiro numero: ");
            numbOne = Console.ReadLine();
            Console.Write("Digite o segundo numero: ");
            numbTwo = Console.ReadLine();

            Console.WriteLine("A soma dos numeros ", + numbOne,"+ " + numbOne, "= " + resul);
        }
    }
// Fim do escopo do prgograma aonde finaliza o mesmo
}