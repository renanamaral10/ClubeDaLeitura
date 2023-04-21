using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.Compartilhamento;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class TelaAmigos : RepositorioMae
    {
        public RepositorioAmigos repositorio = null;
        public void MenuAmigos(RepositorioAmigos amigos)
        {
            bool menuamigos = true;

            while (menuamigos)
            {
                Console.WriteLine("                            Menu Amigos");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("(1) Cadastro - (2) Editar - (3) Excluir - (4) Verificar - (S) Sair");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    amigos.CadastrarAmigos();
                }
                else if (escolha == "2")
                {
                    amigos.EditarAmigos();
                }
                else if (escolha == "3")
                {
                    amigos.ExcluirAmigos();
                }
                else if (escolha == "4")
                {
                    VerificarAmigos();
                }
                else if (escolha == "S")
                {
                    menuamigos = false;
                }
                else
                {
                    Console.WriteLine("Resposta inválida, tente novamente");
                }
            }
        }
        public void VerificarAmigos()
        {
            Console.WriteLine("ID - Nome - Nome do Responsável - Numero de Telefone - Endereço");
            foreach (Amigos item in repositorio.listaRegistros)
            {
                Console.Write($"{item.IDamigos}  {item.nome}  {item.nomeresponsavel}  {item.numerotelefone}  {item.endereco}\n");
            }
            Console.WriteLine();
        }       
    }
}
