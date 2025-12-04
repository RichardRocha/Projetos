using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_APOO2.Config
{
    public class ConfiguracaoSistema
    {
        private static ConfiguracaoSistema _instancia;
        private static readonly object _lock = new object();
        public string NomeInstituicao { get; set; }
        public string EmailContato { get; set; }
        public int LimiteInscricoesPorParticipante { get; set; }

        private ConfiguracaoSistema()
        {
            NomeInstituicao = "FHO | Fundação Herminio Ometto";
            EmailContato = "fho@fho.edu.br";
            LimiteInscricoesPorParticipante = 3;
        }
        public static ConfiguracaoSistema Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (_lock)
                    {
                        if (_instancia == null)
                            _instancia = new ConfiguracaoSistema();
                    }
                }
                return _instancia;
            }
        }
    }
}
