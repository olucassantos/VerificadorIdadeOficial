using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorIdadeOficial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sua idade é {idade}");

            if (idade >= 18) // se
                Console.WriteLine("Você é maior de idade");
            else // senão
                Console.WriteLine("Você é menor de idade");

            if (idade >= 18)
            {
                Console.WriteLine("Bem vindo ao sistema");
                Console.WriteLine("Você tem acesso liberado a todas as funções");
            }
            else
            {
                Console.WriteLine("Você não tem permissão para usar o sistema");
            }

            // 0 a 2 - Bebê
            // 3 a 11 - Criança
            // 12 a 13 - Pré Adolescente
            // 14 a 17 - Adolescente
            // 18 a 59 - Adulto
            // Acima de 60 - Idoso

            if (idade <= 2)
                Console.WriteLine("Você é um Bebê");
            else if (idade > 2 && idade <= 11)
                Console.WriteLine("Você é uma Criança");
            else if (idade >= 12 && idade <= 13)
                Console.WriteLine("Você é um Pré-adolescente");
            else if (idade >= 14 && idade <= 17)
                Console.WriteLine("Você é um Adolescente");
            else if (idade >= 18 && idade < 60)
                Console.WriteLine("Você é um Adulto");
            else
                Console.WriteLine("Você é um Idoso");

            Console.ReadKey();
        }
    }
}
