using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2_APOO2.Factories;
using Test2_APOO2.Repositories;
using Test2_APOO2.Models;
using Test2_APOO2.Exceptions;
using Test2_APOO2.Config;

namespace Test2_APOO2.Controllers
{
    public class EventoController
    {
        //TODO: Propriedade para acessar o repositório
        private readonly IEventoRepository _repository;
        //TODO: Construtor com injeção de dependência (DIP)
        public EventoController (IEventoRepository repository)
        {
            _repository = repository;
        }
        public Evento CriarEvento(EventoFactory factory, string titulo, DateTime date, string palestrante)
        {
            var evento = factory.CriarEvento(titulo, date, palestrante);
            _repository.Adicionar(evento);
            return evento;
        }

        public void InscreverParticipante(int eventoId, Participante participante)
        {
            var evento = _repository.BuscarPorId(eventoId);
            if (evento == null)
                throw new EventoNaoEncontradoException(eventoId);
            var config = ConfiguracaoSistema.Instancia;
            if (participante.EventosInscritos.Count >= config.LimiteInscricoesPorParticipante)
                throw new LimiteInscricoesException(participante.Nome, config.LimiteInscricoesPorParticipante);
            
            evento.Inscrever(participante);
            participante.EventosInscritos.Add(evento);
        }
        public List<Evento> ListarGratuitos()
        {
            return _repository.ListarTodos()
                .Where(e => e.Preco == 0)
                .ToList();
        }

        public List<Evento> ListarComVagas()
        {
            return _repository.ListarTodos()
                .Where(e => e.TemVagas)
                .ToList();
        }

        public List<Evento> ListarPorTipo(string tipo)
        {
            return _repository.ListarTodos()
                .Where(e => e.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public decimal CalcularArrecadacaoTotal()
        {
            return _repository.ListarTodos()
                .Sum(e => e.Preco * e.Inscritos.Count);
        }
        public List<Evento> ListarTodos()
        {
            return _repository.ListarTodos();
        }

    }
}
