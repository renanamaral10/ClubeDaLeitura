using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.Compartilhamento;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevistas
{
    public class TelaRevistas : RepositorioMae
    {
        public RepositorioRevistas repositorio = null;
        public void MenuRevistas(RepositorioRevistas revista)
        {
            bool menurevistas = true;

            while (menurevistas)
            {
                Console.WriteLine("                         QQ C quer");
                Console.WriteLine("(1) Cadastrar - (2) Editar - (3) Excluir - (4) Verificar - (S) Sair");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    revista.CadastrarRevistas();
                }
                else if (escolha == "2")
                {
                    revista.EditarRevistas();
                }
                else if (escolha == "3")
                {
                    revista.ExcluirRevistas();
                }
                else if (escolha == "4")
                {
                    VerificarRevistas();
                }
                else if (escolha == "S")
                {
                    menurevistas = false;
                }
                else
                {
                    Console.WriteLine("Resposta inválida, tente novamente");
                }
            }
        }
        public void VerificarRevistas()
        {
            Console.WriteLine("ID  Coleção  Edição  Ano  CaixaID");
            foreach (Revistas item in repositorio.listaRegistros)
            {
                Console.Write($"{item.IDrevistas}  {item.colecao}  {item.edicao}  {item.ano}  {item.caixaescolhida.IDcaixa}\n");
            }
        }       
    }
}
