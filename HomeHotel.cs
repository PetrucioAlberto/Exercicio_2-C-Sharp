using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
    class HomeHotel
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        private List<Suite> suites = new List<Suite>();
        private List<Reserva> reservas = new List<Reserva>();

        public void Executar()
        {
            bool sair = false;
            do
            {
                MostrarMenu();
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastroMenu();
                        break;
                    case 2:
                        ConsultaMenu();
                        break;
                    case 3:
                        ListarMenu();
                        break;
                    case 4:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (!sair);
        }

        private void MostrarMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1. Cadastro");
            Console.WriteLine("2. Consultar");
            Console.WriteLine("3. Listar");
            Console.WriteLine("4. SAIR");
        }

        private void CadastroMenu()
        {
            Console.WriteLine("CADASTRO:");
            Console.WriteLine("1. Hospede");
            Console.WriteLine("2. Suite");
            Console.WriteLine("3. Reserva");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarHospede();
                    break;
                case 2:
                    CadastrarSuite();
                    break;
                case 3:
                    RealizarReserva();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
              
        }

        private void ConsultaMenu()
        {
            Console.WriteLine("CONSULTA:");
            Console.WriteLine("1. Hospede");
            Console.WriteLine("2. Suite");
            Console.WriteLine("3. Reserva");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ConsultarHospede();
                    break;
                case 2:
                    ConsultarSuite();
                    break;
                case 3:
                    ConsultarReserva();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            
        }

        private void ListarMenu()
        {
            Console.WriteLine("LISTAR:");
            Console.WriteLine("1. Hospedes");
            Console.WriteLine("2. Suites");
            Console.WriteLine("3. Reservas");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ListarHospedes();
                    break;
                case 2:
                    ListarSuites();
                    break;
                case 3:
                    ListarReservas();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            
        }

        private void CadastrarHospede()
        {
            Console.WriteLine("CADASTRO DE HOSPEDE:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Gênero: ");
            string genero = Console.ReadLine();
            Console.Write("Profissão: ");
            string profissao = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, idade, genero, profissao);
            pessoas.Add(pessoa);
            Console.WriteLine("Hospede cadastrado com sucesso!");
        }

        private void CadastrarSuite()
        {
            Console.WriteLine("CADASTRO DE SUITE:");
            Console.Write("Capacidade: ");
            int capacidade = int.Parse(Console.ReadLine());
            Console.Write("Valor da Diária: ");
            double valorDiaria = double.Parse(Console.ReadLine());

            Suite suite = new Suite(capacidade, valorDiaria);
            suites.Add(suite);
            Console.WriteLine("Suite cadastrada com sucesso!");
        }

        private void RealizarReserva()
        {
            Console.WriteLine("REALIZAR RESERVA:");
            Console.WriteLine("Selecione o hóspede:");

            for (int i = 0; i < pessoas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pessoas[i].Nome}");
            }

            int indiceHospede = int.Parse(Console.ReadLine()) - 1;
            Pessoa hospedeSelecionado = pessoas[indiceHospede];

            Console.WriteLine("Selecione a suíte:");

            for (int i = 0; i < suites.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Suite com capacidade para {suites[i].Capacidade} pessoas");
            }

            int indiceSuite = int.Parse(Console.ReadLine()) - 1;
            Suite suiteSelecionada = suites[indiceSuite];

            Console.Write("Data Inicio da Reserva (dd/mm/aaaa): ");
            DateTime dataInicio = DateTime.Parse(Console.ReadLine());
            Console.Write("Data Fim da Reserva (dd/mm/aaaa): ");
            DateTime dataFim = DateTime.Parse(Console.ReadLine());

            Reserva reserva = new Reserva(hospedeSelecionado, suiteSelecionada, dataInicio, dataFim);
            reservas.Add(reserva);
            Console.WriteLine("Reserva realizada com sucesso!");
        }

        private void ConsultarHospede()
        {
            Console.WriteLine("CONSULTA DE HOSPEDE:");
            
        }

        private void ConsultarSuite()
        {
            Console.WriteLine("CONSULTA DE SUITE:");
          
        }

        private void ConsultarReserva()
        {
            Console.WriteLine("CONSULTA DE RESERVA:");
            
        }

        private void ListarHospedes()
        {
            Console.WriteLine("LISTA DE HOSPEDES:");
            foreach (var hospede in pessoas)
            {
                Console.WriteLine($"Nome: {hospede.Nome}, Idade: {hospede.Idade}, Gênero: {hospede.Genero}, Profissão: {hospede.Profissao}");
            }
        }

        private void ListarSuites()
        {
            Console.WriteLine("LISTA DE SUITES:");
            foreach (var suite in suites)
            {
                Console.WriteLine($"Capacidade: {suite.Capacidade}, Valor Diária: {suite.ValorDiaria}");
            }
        }

        private void ListarReservas()
        {
            Console.WriteLine("LISTA DE RESERVAS:");
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"Hóspede: {reserva.Pessoa.Nome}, Suíte: {reserva.Suite.Capacidade}, Data Início: {reserva.DataInicio}, Data Fim: {reserva.DataFim}");
            }
        }
    }
}