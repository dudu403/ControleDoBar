

using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloFuncionario;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloGarcom
{
    public class RepositorioGarcom : RepositorioBase
    {
        public RepositorioGarcom(ArrayList listaFuncionario)
        {
            this.listaRegistros = listaFuncionario;

        }

        public override Garcom SelecionarPorId(int id)
        {
            return (Garcom)base.SelecionarPorId(id);
        }
    }
}
