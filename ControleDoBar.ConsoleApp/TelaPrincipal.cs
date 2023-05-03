using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Controle do Bar da Galera \n");

            Console.WriteLine("Digite 1 para Cadastrar Funcionário");
            Console.WriteLine("Digite 2 para Cadastrar Garçom ");
            Console.WriteLine("Digite 3 para Cadastrar Mesa ");
            Console.WriteLine("Digite 4 para Cadastrar Produto ");
            // Console.WriteLine("Digite 1 para Cadastrar Funcionário: ");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
