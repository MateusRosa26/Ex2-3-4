using System;

namespace VendaIngressos
{
    class TesteIngresso
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== USANDO CONSTRUTOR COM PARÂMETROS ===");

            Ingresso show1 = new Ingresso("Rock in Rio", 250.00, 1500);

            Console.WriteLine("Ingresso criado com construtor:");
            show1.ExibirInformacoes();

            Console.WriteLine($"\nConfirmando com getters:");
            Console.WriteLine($"Nome: {show1.GetNomeDoShow()}");
            Console.WriteLine($"Preço: R$ {show1.GetPreco():F2}");
            Console.WriteLine($"Quantidade: {show1.GetQuantidadeDisponivel()}");

            Console.WriteLine("\n=== COMPARANDO: CONSTRUTOR vs SETTERS ===");


            Ingresso show2 = new Ingresso("Festival de Jazz", 180.50, 800);
            Console.WriteLine("Show criado com CONSTRUTOR (1 linha):");
            show2.ExibirInformacoes();


            Console.WriteLine("\nShow criado com SETTERS (4 linhas):");
            Ingresso show3 = new Ingresso();
            show3.SetNomeDoShow("Show de Rock");
            show3.SetPreco(150.00);
            show3.SetQuantidadeDisponivel(1000);
            show3.ExibirInformacoes();

            Console.WriteLine("\n=== TESTANDO ALTERAÇÕES APÓS CONSTRUÇÃO ===");
            Console.WriteLine("Alterando o primeiro show usando setters:");
            show1.SetPreco(280.00);
            show1.SetQuantidadeDisponivel(1200);

            Console.WriteLine($"Novo preço: R$ {show1.GetPreco():F2}");
            Console.WriteLine($"Nova quantidade: {show1.GetQuantidadeDisponivel()}");
            show1.ExibirInformacoes();

            Console.WriteLine("\n=== VANTAGENS DO CONSTRUTOR ===");
            Console.WriteLine("1. Criação em UMA linha vs QUATRO linhas");
            Console.WriteLine("2. Garante que o objeto já nasce com dados válidos");
            Console.WriteLine("3. Mais legível e menos propenso a erros");
            Console.WriteLine("4. Inicialização obrigatória dos valores essenciais");

            Console.ReadKey();
        }
    }
}