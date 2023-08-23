using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio10
{
    internal class TesteList
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public TesteList(int id, string nome, double valor, int quantidade)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public double ValorQuantidade()
        {
            return Valor * Quantidade;
        }

        public override string ToString()
        {
            return "Código: "
                + Id
                + ", Produto: "
                + Nome.ToUpper()
                + ", Valor: "
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade Armazenada: "
                + Quantidade
                + ", Valor total da Compra: $"
                + ValorQuantidade().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
