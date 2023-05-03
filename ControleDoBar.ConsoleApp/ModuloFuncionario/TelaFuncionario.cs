using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;
using System.Diagnostics;

namespace ControleDeBar.ConsoleApp.ModuloFuncionario
{
    public class TelaFuncionario : TelaBase
    {
        public TelaFuncionario()
        {
            this.repositorioBase = new RepositorioFuncionario(new ArrayList());
            nomeEntidade = "Funcionário";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", "ID", "Nome", "Login", "Senha");

            Console.WriteLine("------------------------------------------------------------------------------");

            foreach (Funcionario funcionario in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -30}", funcionario.id, funcionario.nome, funcionario.login, funcionario.senha);
            }
            
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o login: ");
            string login = Console.ReadLine();

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            return new Funcionario(nome, login, senha);
        }
    }
}
