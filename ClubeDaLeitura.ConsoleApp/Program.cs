using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
using ClubeDaLeitura.ConsoleApp.ModuloRevistas;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaAmigos amigos = new TelaAmigos();

            TelaEmprestimos emprestimos = new TelaEmprestimos();

            TelaRevistas revistas = new TelaRevistas();

            TelaCaixas caixas = new TelaCaixas();

            RepositorioAmigos repositorioamigos = new RepositorioAmigos();

            RepositorioEmprestimos repositorioemprestimos = new RepositorioEmprestimos();

            RepositorioRevistas repositoriorevistas = new RepositorioRevistas();

            RepositorioCaixas repositoriocaixas = new RepositorioCaixas();

            repositoriorevistas.repositoriocaixas = repositoriocaixas;

            repositoriorevistas.telacaixa = caixas;

            caixas.repositorio = repositoriocaixas;

            revistas.repositorio = repositoriorevistas;

            amigos.repositorio = repositorioamigos;

            repositorioemprestimos.telarevistas = revistas;

            repositorioemprestimos.repositoriorevistas = repositoriorevistas;

            repositorioemprestimos.repositorioamigos = repositorioamigos;

            emprestimos.repositorio = repositorioemprestimos;

            bool menuservico = true;
            while (menuservico == true)
            {
                Console.WriteLine("                         Clube da Leitura");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("                   Digite o Serviço a ser utilizado:");
                Console.WriteLine("(1) Amigos - (2) Emprestimos - (3) Revistas - (4) Caixas - (S) Fechar Programa");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    amigos.MenuAmigos(repositorioamigos);
                }
                else if (escolha == "2")
                {
                    emprestimos.MenuEmprestimos(repositorioemprestimos);
                }
                else if (escolha == "3")
                {
                    revistas.MenuRevistas(repositoriorevistas);
                }
                else if (escolha == "4")
                {
                    caixas.MenuCaixas(repositoriocaixas);
                }
                else if (escolha == "S")
                {
                    Console.WriteLine("Obrigado por utilizar nosso Sistema!");
                    menuservico = false;
                }
                else
                {
                    Console.WriteLine("Escolheu errado, tenta de novo");
                }
                Console.ReadKey();
            }
        }
    }    }