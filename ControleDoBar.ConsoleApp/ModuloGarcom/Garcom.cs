using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string nome;
        public string cpf;
        public string telefone;

        public Garcom(string nome, string cpf, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom GarcomAtualizado = (Garcom) registroAtualizado;

            this.nome = GarcomAtualizado.nome;
            this.cpf = GarcomAtualizado.cpf;
            this.telefone = GarcomAtualizado.telefone;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
