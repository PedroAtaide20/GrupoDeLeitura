using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Pessoa
    {
        public string nome;
        public string nomeDoResponsavel;
        public int numero;
        public string endereco;
        public bool jaTemUmaRevista;

        public void RegistrarPessoa()
        {

            Console.WriteLine("Informe o nome do amigo?");
            nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Informe o nome do responsavel?");
            nomeDoResponsavel = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Informe o numero do responsavel?");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe qual endereço?");
            endereco = Convert.ToString(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("pressoa registrada com sucesso");
            Console.ResetColor();
            Console.ReadLine();
        }
        public void Mostrar()
        {
            Console.WriteLine("Amigo: " + nome);

            Console.WriteLine("Nome do responsavel" + nomeDoResponsavel);

            Console.WriteLine("Endereço: " + endereco);

            Console.WriteLine("Numero do responsavel: " + numero);

            if (jaTemUmaRevista == true)
                Console.WriteLine("Esse amigo está com uma revista!");
            else
                Console.WriteLine("Esse amigo não está com nenhuma revista");

            Console.ReadLine();
        }
}
}
