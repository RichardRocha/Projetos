using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_APOO2.Models
{
    public class Palestra : Evento
    {
        public override int Capacidade
        {
            get { return 100;  }
        }
        public override decimal Preco
        {
            get { return 0; }
        }
        public override int DuracaoHoras
        {
            get { return 1; }
        }
        public override string Tipo
        {
            get { return "Palestra"; }
        }
    }
}
