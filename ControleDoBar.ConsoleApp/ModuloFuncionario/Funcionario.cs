using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloFuncionario
{
    public class Funcionario : EntidadeBase
    {
        public string nome;
        public string login;
        public string senha;

        public Funcionario(string nome, string login, string senha)
        {
            this.nome = nome;
            this.login = login;
            this.senha = senha;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Funcionario funcionarioAtualizado = (Funcionario) registroAtualizado;

            this.nome = funcionarioAtualizado.nome;
            this.login = funcionarioAtualizado.login;
            this.senha = funcionarioAtualizado.senha;
        }

        //public override ArrayList Validar()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
