

using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        private TelaGarcom telaGarcom;
        private RepositorioGarcom repositorioGarcom;

        public TelaMesa(TelaGarcom telaGarcom, RepositorioGarcom repositorioGarcom, RepositorioMesa repositorioMesa)
        {
            this.repositorioBase = repositorioMesa;
            this.telaGarcom = telaGarcom;
            this.repositorioGarcom = repositorioGarcom;

            nomeEntidade = "Mesa";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "ID", "Número", "Garçom");

            Console.WriteLine("------------------------------------------------------------------------------");

            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", mesa.numero, mesa.id, mesa.garcom);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            telaGarcom.VisualizarRegistros(false);

            // Selecionar o garcom por id

            Console.Write("\nDigite o id do garçom: ");
            int idGarcom = Convert.ToInt32(Console.ReadLine());

            Garcom garcom = repositorioGarcom.SelecionarPorId(idGarcom);


            Console.Write("Digite o número da mesa: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            return new Mesa(numero, garcom);
        }
    }
}
