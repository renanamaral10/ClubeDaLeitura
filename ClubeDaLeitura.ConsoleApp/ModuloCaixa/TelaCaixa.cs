using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.Compartilhamento;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class TelaCaixas : RepositorioMae
    {
        public RepositorioCaixas repositorio = null;
        public void MenuCaixas(RepositorioCaixas caixas)
        {
            bool menucaixas = true;

            while (menucaixas)
            {
                Console.WriteLine("                            Menu Caixas");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("(1) Cadastro - (2) Editar - (3) Excluir - (4) Verificar - (S) Sair");

                string escolha = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (escolha == "1")
                {
                    caixas.CadastrarCaixas();
                }
                else if (escolha == "2")
                {
                    caixas.EditarCaixas();
                }
                else if (escolha == "3")
                {
                    caixas.ExcluirCaixas();
                }
                else if (escolha == "4")
                {
                    VerificarCaixas();
                }
                else if (escolha == "S")
                {
                    menucaixas = false;
                }
                else
                {
                    Console.WriteLine("Resposta inválida, tente novamente");
                }
            }
        }
        public void VerificarCaixas()
        {
            Console.WriteLine();

            Console.WriteLine("ID - Cor da Caixa - Etiqueta");

            foreach (Caixa item in repositorio.listaRegistros)
            {
                Console.Write($"{item.IDcaixa} {item.corcaixa} {item.etiqueta}\n");
            }
        }       
    }
}
