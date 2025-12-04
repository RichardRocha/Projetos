using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_APOO2.Models
{
    public class Minicurso : Evento
    {
        public override int Capacidade
        {
            get { return 20; }
        }
        public override decimal Preco
        {
            get { return 50; }
        }
        public override int DuracaoHoras
        {
            get { return 8; }
        }
        public override string Tipo
        {
            get { return "Minicurso"; }
        }
    }
}
