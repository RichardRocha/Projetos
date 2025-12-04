using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2_APOO2.Models;

namespace Test2_APOO2.Factories
{
    public class PalestraFactory : EventoFactory
    {
        public override Evento CriarEvento(string titulo, DateTime data, string palestrante)
        {
            return new Palestra
            {
                Id = GerarId(),
                Titulo = titulo,
                Data = data,
                Palestrante = palestrante
            };
        }
    }
}
