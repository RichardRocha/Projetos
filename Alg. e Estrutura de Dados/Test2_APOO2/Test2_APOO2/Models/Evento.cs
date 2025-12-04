using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2_APOO2.Exceptions;


namespace Test2_APOO2.Models
{
    public abstract class Evento
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public DateTime Data { get; set; }
        public string? Palestrante { get; set; }

        private List<Participante> _inscritos = new List<Participante>();
        public List<Participante> Inscritos
        {
            get { return _inscritos; }
        }
        public abstract int Capacidade { get; set; }
        public abstract decimal Preco {  get; set; }
        public abstract int DuracaoHoras { get; set; }
        public abstract string Tipo {  get; set; }

        public int VagasDisponiveis
        {
            get { return Capacidade - Inscritos.Count; }
        }
        public bool TemVagas
        {
            get { return VagasDisponiveis > 0; }
        }

        public void Inscrever (Participante participante)
        {
            if (!TemVagas)
                throw new EventoSemVagasException(Titulo);
            if (_inscritos.Any(p => p.Id == participante.Id))
                throw new ParticipanteJaInscritoException(participante.Nome, Titulo);

            _inscritos.Add(participante);
        }

        public void Remover (Participante participante)
        {
            var jaInscrito = _inscritos.FirstOrDefault(p => p.Id == participante.Id);

            if (jaInscrito == null)
                throw new Exception($"Participante {participante.Nome} não está inscrito!");

            _inscritos.Remove(jaInscrito);
        }
    }
}
