using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public int numero;
        public Garcom garcom;

        public Mesa(int numero, Garcom garcom)
        {
            this.numero = numero;
            this.garcom = garcom;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizada = (Mesa)registroAtualizado;

            this.numero = mesaAtualizada.numero;
            this.garcom = mesaAtualizada.garcom;
        }
    }
}
