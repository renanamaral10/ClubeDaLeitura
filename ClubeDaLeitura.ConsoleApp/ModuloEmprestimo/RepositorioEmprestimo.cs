using ClubeDaLeitura.ConsoleApp.Compartilhamento;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class RepositorioEmprestimos : RepositorioMae
    {
        public RepositorioRevistas repositoriorevistas = null;
        public TelaRevistas telarevistas = null;
        public RepositorioAmigos repositorioamigos = null;
        public TelaAmigos telaamigos = null;
        public void CadastrarEmprestimos()
        {
            Emprestimos emprestimos = new Emprestimos();

            Revistas revistas = null;

            Amigos amigos = null;

            bool amigoachou = false;
            bool revistaachou = false;

            Console.Write("Qual a data do emprestimo: ");
            emprestimos.datasaida = Console.ReadLine();

            Console.Write("Qual Amigo esta fazendo o emprestimo: ");
            string amigoescolhido = Console.ReadLine().ToUpper();

            foreach (Amigos item in repositorioamigos.listaRegistros)
            {
                if (item.nome == amigoescolhido)
                {
                    amigos = item;
                    amigoachou = true;
                }
                else
                {
                    amigoachou = false;
                }
            }

            if (amigoachou == true)
            {
                emprestimos.IDemprestimos = listaRegistros.Count;
                emprestimos.amigo = amigos;
            }
            else
            {
                Console.WriteLine("Amigo não existe, tente Cadastra-lo");
                return;
            }

            telarevistas.VerificarRevistas();

            Console.Write("Qual ID da Revista esta fazendo o emprestimo: ");
            int revistaescolhida = Convert.ToInt32(Console.ReadLine());

            foreach (Revistas item in repositoriorevistas.listaRegistros)
            {
                if (item.IDrevistas == revistaescolhida)
                {
                    revistas = item;
                    revistaachou = true;
                }
                else
                {
                    revistaachou = false;
                }
            }

            if (revistaachou == true)
            {
                emprestimos.IDemprestimos = listaRegistros.Count;
                emprestimos.IDrevista = revistas;
                emprestimos.IDemprestimos++;
                listaRegistros.Add(emprestimos);
                Console.WriteLine("Cadastro feito com sucesso.");
            }
            else
            {
                Console.WriteLine("Revista não existe, tente Cadastra-la");
            }
        }
        public void EditarEmprestimos()
        {
            Emprestimos emprestimos = new Emprestimos();

            Revistas revistas = null;

            Amigos amigos = null;

            bool amigoachou = false;
            bool revistaachou = false;

            Console.Write("Qual ID gostaria de Editar: ");
            emprestimos.remove = Convert.ToInt32(Console.ReadLine());

            SelecionarPorID(emprestimos.remove);

            Console.Write("Qual a data do emprestimo: ");
            emprestimos.datasaida = Console.ReadLine();

            Console.Write("Qual Amigo esta fazendo o emprestimo: ");
            string amigoescolhido = Console.ReadLine().ToUpper();

            foreach (Amigos item in repositorioamigos.listaRegistros)
            {
                if (item.nome == amigoescolhido)
                {
                    amigos = item;
                    amigoachou = true;
                }
                else
                {
                    amigoachou = false;
                }
            }

            if (amigoachou == true)
            {
                emprestimos.IDemprestimos = listaRegistros.Count;
                emprestimos.amigo = amigos;
            }
            else
            {
                Console.WriteLine("Amigo não existe, tente Cadastra-lo");
                return;
            }

            telarevistas.VerificarRevistas();

            Console.Write("Qual ID da Revista esta fazendo o emprestimo: ");
            int revistaescolhida = Convert.ToInt32(Console.ReadLine());

            foreach (Revistas item in repositoriorevistas.listaRegistros)
            {
                if (item.IDrevistas == revistaescolhida)
                {
                    revistas = item;
                    revistaachou = true;
                }
                else
                {
                    revistaachou = false;
                }
            }

            if (revistaachou == true)
            {
                emprestimos.IDemprestimos = listaRegistros.Count;
                emprestimos.IDrevista = revistas;
                emprestimos.IDemprestimos++;
                listaRegistros.Add(emprestimos);
                Console.WriteLine("Cadastro feito com sucesso.");
            }
            else
            {
                Console.WriteLine("Revista não existe, tente Cadastra-la");
            }
        }
        public void DevolverRevista()
        {

        }
        public Emprestimos SelecionarPorID(int id)
        {
            foreach (Emprestimos e in listaRegistros)
            {
                if (e.IDemprestimos == id)
                {
                    return e;
                }
            }
            return null;
        }

    }
}
