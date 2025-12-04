using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2_APOO2.Models;

namespace Test2_APOO2.Repositories
{
    public interface IEventoRepository
    {
        public void Adicionar(Evento evento);
        Evento BuscarPorId(int id);
        Evento BuscarPorTitulo(string titulo);
        List<Evento> ListarTodos();
    }
}
