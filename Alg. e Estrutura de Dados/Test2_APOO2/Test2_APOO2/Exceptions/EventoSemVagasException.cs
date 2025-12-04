using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_APOO2.Exceptions
{
    public class EventoSemVagasException : Exception
    {
        public EventoSemVagasException(string nomeEvento)
            : base($"O evento '{nomeEvento}' não possui vagas disponíveis")
        {
        }
    }
}
