using Test2_APOO2.Controllers;
using Test2_APOO2.Repositories;
using Test2_APOO2.Views;

namespace Test2_APOO2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEventoRepository repository = new EventoRepository();
            EventoController controller = new EventoController(repository);
            EventoView view = new EventoView(controller);

            view.ExibirMenu();
        }
    }
}
