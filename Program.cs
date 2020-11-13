using System;

namespace calculando_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            int idade;
            Console.WriteLine("Em que ano você nasceu?");
            ano = int.Parse(Console.ReadLine());
            idade = 2020 - ano;
            Console.Write("Você tem "+idade+" anos");
        }
    }
}
