using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto() {
            repositorioBase = new RepositorioProduto(new ArrayList());
            nomeEntidade = "Produto";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "ID", "Nome", "Valor");

            Console.WriteLine("----------------------------------------------");

            foreach (Produto produto in registros) 
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} ",produto.id, produto.nome, produto.valor);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor: ");
            string valor = Console.ReadLine();

            return new Produto(nome, valor);


        }
    }
}
