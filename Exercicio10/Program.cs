using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.WebSockets;


namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         ----------  KLEBERTON TECH  ----------");
            Console.WriteLine();
            Console.WriteLine();

            List<TesteList> list = new List<TesteList>();

            Console.Write("Quantos tipos de produtos serão armazenados: ");
            int Tipos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite os códigos do produto:");
            Console.WriteLine();

            int id = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Tipos; i++)
            {
                Console.Write("Código: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Nome do Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Valor de custo de Compra do Produto: $");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine();
                list.Add(new TesteList(id, nome, valor, quantidade));
            }

            Console.WriteLine("Relatorio de item cadastrados:");
            foreach (TesteList item in list)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
