using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.Compartilhamento;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class RepositorioCaixas : RepositorioMae
    {
        public void CadastrarCaixas()
        {
            Caixa caixa = new Caixa ();

            Console.WriteLine("Qual a cor da caixa: ");
            caixa.corcaixa = Console.ReadLine();

            Console.WriteLine("Qual a etiqueta da caixa: ");
            caixa.etiqueta = Console.ReadLine();

            caixa.IDcaixa = listaRegistros.Count;

            caixa.IDcaixa++;

            listaRegistros.Add(caixa);

            Console.WriteLine("Cadastro feito com sucesso.");
        }
        public void EditarCaixas()
        {
            Caixa caixa = new Caixa();

            Console.Write("Qual ID gostaria de Editar: ");
            caixa.remove = Convert.ToInt32(Console.ReadLine());

            caixa = SelecionarPorID(caixa.remove);

            listaRegistros.Remove(caixa);

            Console.Write("Qual a cor da caixa: ");
            caixa.corcaixa = Console.ReadLine();

            Console.Write("Qual a etiqueta da caixa: ");
            caixa.etiqueta = Console.ReadLine();

            caixa.IDcaixa = listaRegistros.Count;

            caixa.IDcaixa++;

            listaRegistros.Add(caixa);

            Console.WriteLine("Edição feita com sucesso.");
        }
        public void ExcluirCaixas()
        {
            Caixa caixa = new Caixa();

            Console.Write("Qual ID gostaria de Excluir: ");
            caixa.remove = Convert.ToInt32(Console.ReadLine());

            caixa = SelecionarPorID(caixa.remove);

            listaRegistros.Remove(caixa);

            Console.WriteLine("Exclusão feita com sucesso.");
        }
        public Caixa SelecionarPorID(int id)
        {
            foreach (Caixa c in listaRegistros)
            {
                if (c.IDcaixa == id)
                {
                    return c;
                }
            }
            return null;
        }       
    }
}
