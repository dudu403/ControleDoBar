using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string nome;
        public string valor;

        public Produto(string nome, string valor)
        {
            this.nome = nome;
            this.valor = valor;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto ProdutoAtualizado = (Produto)registroAtualizado;

            this.nome = ProdutoAtualizado.nome;
            this.valor = ProdutoAtualizado.valor;
        }
    }
}
