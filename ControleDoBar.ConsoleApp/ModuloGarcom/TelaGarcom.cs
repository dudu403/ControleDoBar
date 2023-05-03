

using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloFuncionario;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloGarcom
{
    public class TelaGarcom : TelaBase
    {
        public TelaGarcom(RepositorioGarcom repositorioGarcom) 
        {
            repositorioBase = repositorioGarcom;
            nomeEntidade = "Garçom";
            sufixo = "ns";
        }
        
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", "ID", "Nome", "CPF", "Telefone");

            Console.WriteLine("------------------------------------------------------------------------------");

            foreach(Garcom garcom in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -30}",garcom.id, garcom.nome,garcom.cpf, garcom.telefone);
            }

        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o cpf: ");
            string cpf = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            string telefone = Console.ReadLine();

            return new Garcom(nome, cpf, telefone);
        }
    }
}
