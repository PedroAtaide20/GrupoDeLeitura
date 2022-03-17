using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Emprestimo
    {
        public Pessoa pegouARevista;
        public Revista revistaEmprestada;
        public DateTime dataDeEmprestimo;
        public DateTime dataDeFecharEmprestimo;
        public bool emprestimoAberto;
        int numeroRevista;
        int numeroPessoa;


        public void RegistrarEmprestimo(Revista[] revista, Pessoa[] amigo)
        {
            emprestimoAberto = true;
            Console.WriteLine("Data do emprestimo");
            dataDeEmprestimo = DateTime.Parse(Console.ReadLine());

            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null)
                    continue;

                Console.WriteLine($"Revista: {revista[i].anoDaRevista}, {revista[i].numeroDeEdicao}, {revista[i].tipoDeColecao}. Revista numero: {i}");
            }

            do
            {
                Console.WriteLine("qual revista deseja emprestar");

            } while (!(int.TryParse(Console.ReadLine(), out numeroRevista)) || revista[numeroRevista] == null || revista[numeroRevista].estaDisponivel == false);
            revistaEmprestada = revista[numeroRevista];
            revista[numeroRevista].estaDisponivel = false;




            for (int i = 0; i < amigo.Length; i++)
            {
                if (amigo[i] == null)
                    continue;

                Console.WriteLine($"Nome do amigo: {amigo[i].nome}, Nome do responsavel: {amigo[i].nomeDoResponsavel}, Endereço: {amigo[i].endereco}. Amigo numero: {i}");
            }

            do
            {
                Console.WriteLine("qual amigo deseja pegar emprestado");

            } while (!(int.TryParse(Console.ReadLine(), out numeroPessoa)) || amigo[numeroPessoa] == null || amigo[numeroPessoa].jaTemUmaRevista == false);
            pegouARevista = amigo[numeroPessoa];

            amigo[numeroPessoa].jaTemUmaRevista = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista Emprestada com sucesso :-)");
            Console.ResetColor();
            Console.ReadLine();
        }

        public void FecharEmprestimo()
        {
            emprestimoAberto = false;
            Console.WriteLine("Quando o amigo devolveu a revista?");
            dataDeFecharEmprestimo = DateTime.Parse(Console.ReadLine());
        }


        public void Mostrar()
        {
            Console.WriteLine("Informe quem pegou a revista: " + pegouARevista.nome);

            Console.WriteLine("Informe o nome do responsavel" + pegouARevista.nomeDoResponsavel);

            Console.WriteLine("Informe o dia que pegou a revista" + dataDeEmprestimo);
            if (emprestimoAberto == true)
                Console.WriteLine("O emprestimo está aberto!");
            else
                Console.WriteLine("O emprestimo não está aberto!!");
            Console.ReadLine();
        }
}
}
