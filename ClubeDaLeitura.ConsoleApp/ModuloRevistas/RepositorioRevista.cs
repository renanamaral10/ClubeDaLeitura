using ClubeDaLeitura.ConsoleApp.Compartilhamento;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevistas
{
    public class RepositorioRevistas : RepositorioMae
    {
        public RepositorioCaixas repositoriocaixas = null;
        public TelaCaixas telacaixa = null;
        public void CadastrarRevistas()
        {
            Revistas revistas = new Revistas();

            Caixa caixas = null;

            Console.Write("Digite a Coleção da Revista: ");
            revistas.colecao = Console.ReadLine();

            Console.Write("Digite a Edição da Revista: ");
            revistas.edicao = Console.ReadLine();

            Console.Write("Digite o Ano da Revista: ");
            revistas.ano = Console.ReadLine();

            telacaixa.VerificarCaixas();

            Console.WriteLine();

            Console.Write("Digite o ID da Caixa em que a Revista esta: ");
            int Idcaixa = Convert.ToInt32(Console.ReadLine());

            foreach (Caixa item in repositoriocaixas.listaRegistros)
            {
                if (item.IDcaixa == Idcaixa)
                {
                    caixas = item;
                    revistas.achou = true;
                }
                else
                {
                    revistas.achou = false;
                }
            }

            if (revistas.achou == true)
            {
                revistas.IDrevistas = listaRegistros.Count;
                revistas.caixaescolhida = caixas;
                revistas.IDrevistas++;
                listaRegistros.Add(revistas);
                Console.WriteLine("Cadastro feito com sucesso.");
            }
            else
            {
                Console.WriteLine("Caixa não existe, tente Cadastra-la");
            }
        }
        public void EditarRevistas()
        {
            Revistas revistas = new Revistas();

            Caixa caixas = null;

            Console.Write("Qual o ID gostaria de Editar: ");
            revistas.remove = Convert.ToInt32(Console.ReadLine());

            SelecionarPorID(revistas.remove);

            listaRegistros.RemoveAt(revistas.remove);

            Console.Write("Digite a Coleção da Revista: ");
            revistas.colecao = Console.ReadLine();

            Console.Write("Digite a Edição da Revista: ");
            revistas.edicao = Console.ReadLine();

            Console.Write("Digite o Ano da Revista: ");
            revistas.ano = Console.ReadLine();

            Console.Write("Digite a Caixa que a Revista esta: ");
            int Idcaixa = Convert.ToInt32(Console.ReadLine());


            foreach (Caixa item in repositoriocaixas.listaRegistros)
            {
                if (item.IDcaixa == Idcaixa)
                {
                    caixas = item;
                    revistas.achou = true;
                }
                else
                {
                    revistas.achou = false;
                }
            }

            if (revistas.achou == true)
            {
                revistas.IDrevistas = listaRegistros.Count;
                revistas.caixaescolhida = caixas;
                revistas.IDrevistas++;
                listaRegistros.Add(revistas);
                Console.WriteLine("Edição feita com sucesso.");
            }
            else
            {
                Console.WriteLine("Caixa não existe, tente Cadastra-la");
            }
        }
        public void ExcluirRevistas()
        {
            Revistas revistas = new Revistas();
            Console.Write("Qual o ID gostaria de Editar: ");
            revistas.remove = Convert.ToInt32(Console.ReadLine());

            SelecionarPorID(revistas.remove);
            listaRegistros.RemoveAt(revistas.remove);

            Console.WriteLine("Exclusão feita com sucesso.");
        }
        public Revistas SelecionarPorID(int id)
        {
            foreach (Revistas r in listaRegistros)
            {
                if (r.IDrevistas == id)
                {
                    return r;
                }
            }
            return null;
        }       
    }
}
