using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_APOO2.Exceptions
{
    public class EventoNaoEncontradoException : Exception
    {
        public EventoNaoEncontradoException(int id)
            : base($"Evento com ID {id} Não foi encontrado.")
        { 
        }
    }
}
