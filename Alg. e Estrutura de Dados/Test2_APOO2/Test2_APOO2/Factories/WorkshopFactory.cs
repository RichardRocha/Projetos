using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2_APOO2.Models;

namespace Test2_APOO2.Factories
{
    public class WorkshopFactory : EventoFactory
    {
        public override Evento CriarEvento(string titulo, DateTime data, string palestrante)
        {
            return new Workshop
            {
                Id = GerarId(),
                Titulo = titulo,
                Data = data,
                Palestrante = palestrante
            };
        }
    }
}
