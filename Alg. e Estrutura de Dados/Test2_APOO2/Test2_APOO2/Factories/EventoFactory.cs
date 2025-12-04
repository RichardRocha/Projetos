using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2_APOO2.Models;

namespace Test2_APOO2.Factories
{
    public abstract class EventoFactory
    {
        private static int _proximoId = 1;
        public abstract Evento CriarEvento(string titulo, DateTime data, string palestrante);

        protected int GerarId()
        {
            return _proximoId++;
        }
    }
}
