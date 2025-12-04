using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_APOO2.Exceptions
{
    public class ParticipanteJaInscritoException : Exception
    {
        public ParticipanteJaInscritoException(string nomeParticipante, string nomeEvento)
            : base($"O participante '{nomeParticipante}' já está inscrito no evento '{nomeEvento}'")
        {
        }
    }
}
