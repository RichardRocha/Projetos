using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2_APOO2.Config;
using Test2_APOO2.Controllers;
using Test2_APOO2.Factories;
using Test2_APOO2.Repositories;

namespace Test2_APOO2.Views
{
    public class EventoView
    {
        private EventoController _controller;

        public EventoView(EventoController controller)
        {
            _controller = controller;
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                var config = ConfiguracaoSistema.Instancia;
                Console.WriteLine($"=== {config.NomeInstituicao} ===");
                Console.WriteLine($"Contato: {config.EmailContato}\n");

                Console.WriteLine("1 - Cadastrar Evento");
                Console.WriteLine("2 - Listar Eventos");
                Console.WriteLine("3 - Inscrever Participante");
                Console.WriteLine("4 - Consultas");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha: ");

                var opcao = Console.ReadLine();

                try
                {
                    switch (opcao)
                    {
                        case "1": CadastrarEvento(); break;
                        case "2": ListarEventos(); break;
                        case "3": InscreverParticipante(); break;
                        case "4": MenuConsultas(); break;
                        case "0": return;
                        default: Console.WriteLine("Opção inválida!"); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nErro: {ex.Message}");
                }

                Console.WriteLine("\nPressione qualquer tecla...");
                Console.ReadKey();
            }
        }

        private void CadastrarEvento()
        {
            Console.WriteLine("\n=== Cadastrar Evento ===");
            Console.WriteLine("1 - Palestra");
            Console.WriteLine("2 - Workshop");
            Console.WriteLine("3 - Minicurso");
            Console.Write("Tipo: ");
            var tipo = Console.ReadLine();

            Console.Write("Título: ");
            var titulo = Console.ReadLine();

            Console.Write("Data (dd/mm/aaaa): ");
            var data = DateTime.Parse(Console.ReadLine());

            Console.Write("Palestrante: ");
            var palestrante = Console.ReadLine();

            EventoFactory factory = tipo switch
            {
                "1" => new PalestraFactory(),
                "2" => new WorkshopFactory(),
                "3" => new MinicursoFactory(),
                _ => throw new Exception("Tipo inválido")
            };

            var evento = _controller.CriarEvento(factory, titulo, data, palestrante);
            Console.WriteLine($"\nEvento '{evento.Titulo}' cadastrado com sucesso! ID: {evento.Id}");
        }

        private void ListarEventos()
        {
            Console.WriteLine("\n=== Eventos Cadastrados ===");
            var eventos = _controller.ListarTodos();

            foreach (var e in eventos)
            {
                Console.WriteLine($"\nID: {e.Id} | {e.Tipo}");
                Console.WriteLine($"Título: {e.Titulo}");
                Console.WriteLine($"Data: {e.Data:dd/MM/yyyy}");
                Console.WriteLine($"Palestrante: {e.Palestrante}");
                Console.WriteLine($"Preço: R$ {e.Preco:F2}");
                Console.WriteLine($"Vagas: {e.VagasDisponiveis}/{e.Capacidade}");
                Console.WriteLine($"Inscritos: {e.Inscritos.Count}");
            }
        }
    }
}
