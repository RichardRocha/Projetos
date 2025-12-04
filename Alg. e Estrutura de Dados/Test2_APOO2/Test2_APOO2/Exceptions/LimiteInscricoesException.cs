using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_APOO2.Exceptions
{
    public class LimiteInscricoesException : Exception
    {
        public LimiteInscricoesException(string nomeParticipante, int limite)
            : base($"O participante '{nomeParticipante}' atingiu o limite de {limite} inscrições")
        {
        }
    }
}
