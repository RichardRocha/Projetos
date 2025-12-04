using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_APOO2.Models
{
    public class Workshop : Evento
    {
        public override int Capacidade
        {
            get { return 30; }
        }
        public override decimal Preco
        {
            get { return 25; }
        }
        public override int DuracaoHoras
        {
            get { return 3; }
        }
        public override string Tipo
        {
            get { return "Workshop"; }
        }
    }
}
