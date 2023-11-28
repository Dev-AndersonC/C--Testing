using System;

namespace ConsoleApp
{
    public class Program
    {
        enum Cor {
            Verde, Vermelho, Amarelho, Rosa, Preto
        }
        enum Opcoes {
            Criar = 1, Deletar, Atualizar, Editar, Listar
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("-- Selecione uma da Opções abaixo --");
            Console.Write("1-Criar | 2-Deletar | 3-Atualizar | 4-Editar | 5-Listar: ");
            int Index = int.Parse(Console.ReadLine());
            Opcoes opcaoSelecionadas = (Opcoes)Index;

            Console.WriteLine(opcaoSelecionadas);
        }
    }
}