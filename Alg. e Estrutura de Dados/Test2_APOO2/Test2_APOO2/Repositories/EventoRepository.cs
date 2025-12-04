using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2_APOO2.Models;

namespace Test2_APOO2.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private List<Evento> _eventos = new List<Evento>();

        public void Adicionar (Evento evento)
        {
            _eventos.Add(evento);
        }
        public Evento BuscarPorId(int id)
        {
            return _eventos.FirstOrDefault(e => e.Id == id);
        }
        public Evento BuscarPorTitulo(string titulo)
        {
            return _eventos.FirstOrDefault(e => e.Titulo.Contains(titulo));
        }
    }
}
