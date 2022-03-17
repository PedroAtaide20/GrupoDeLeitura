using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Revista
    {
        public bool estaDisponivel = true;
        public int anoDaRevista;
        public string tipoDeColecao;
        int adicinarRevistaCaixa;
        public int numeroDeEdicao;


        public Caixa caixaDaRevista;

        public void RegistrarRevista(Caixa[] caixa)
        {

            Console.WriteLine("Informe o ano da revista?");
            anoDaRevista = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Informe o numero de Edição da revista?");
            numeroDeEdicao = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Informe a coleção da revista?");
            tipoDeColecao = Convert.ToString(Console.ReadLine());



            Console.WriteLine("Informe a caixa que deseja guardar?");
            for (int i = 0; i < caixa.Length; i++)
            {
                if (caixa[i] == null)
                    continue;

                Console.WriteLine($"Caixa: {caixa[i].corCaixa}, {caixa[i].entiquetaCaixa}, {caixa[i].numeroCaixa}. Caixa numero: {i}");
            }



            adicinarRevistaCaixa = Convert.ToInt32(Console.ReadLine());
            caixaDaRevista = caixa[adicinarRevistaCaixa];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista registrada com sucesso ");
            Console.ResetColor();
            Console.ReadLine();

        }


        public void Mostrar()
        {
            Console.WriteLine("Coleção da revista: " + tipoDeColecao);

            Console.WriteLine("Numero de edição: " + numeroDeEdicao);

            Console.WriteLine("Ano da revista: " + anoDaRevista);

            Console.ReadLine();
        }
}
}
