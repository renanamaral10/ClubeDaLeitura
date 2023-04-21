using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.Compartilhamento;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class TelaEmprestimos : RepositorioMae
    {
        public RepositorioEmprestimos repositorio = null;
        public void MenuEmprestimos(RepositorioEmprestimos emprestimos)
        {
            bool menuemprestimo = true;

            while (menuemprestimo)
            {
                Console.WriteLine("                                        QQ C quer");
                Console.WriteLine("(1) Cadastrar - (2) Editar - (3) Devolução - (4) Verificar - (5) Emprestimos em Aberto - (S) Sair");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    emprestimos.CadastrarEmprestimos();
                }
                else if (escolha == "2")
                {
                    emprestimos.EditarEmprestimos();
                }
                else if (escolha == "3")
                {
                    emprestimos.DevolverRevista();
                }
                else if (escolha == "4")
                {
                    VerificarEmprestimos();
                }
                else if (escolha == "5")
                {
                    VerificarEmprestimosEmAberto();
                }
                else if (escolha == "S")
                {
                    menuemprestimo = false;
                }
                else
                {
                    Console.WriteLine("Resposta inválida, tente novamente");
                }
            }
        }
        public void VerificarEmprestimos()
        {
            Console.WriteLine();

            Console.WriteLine("ID - Amigo - IDRevista - Data de empréstimo - Data de Devolução");

            foreach (Emprestimos item in repositorio.listaRegistros)
            {
                Console.Write($"{item.IDemprestimos} {item.amigo.nome} {item.IDrevista.IDrevistas} {item.datasaida} {item.datadevolucao}\n");
            }
        }
        public void VerificarEmprestimosEmAberto()
        {

        }      
    }
}
