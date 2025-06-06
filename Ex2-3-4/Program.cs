using System;

namespace VendaIngressos
{
    class TesteIngresso
    {
        static void Main(string[] args)
        {

            Ingresso show1 = new Ingresso();

            Console.WriteLine("=== USANDO MÉTODOS SETTERS ===");
            show1.SetNomeDoShow("Rock in Rio");
            show1.SetPreco(250.00);
            show1.SetQuantidadeDisponivel(1500);

            Console.WriteLine("Valores definidos usando setters:");
            show1.ExibirInformacoes();

            Console.WriteLine("\n=== USANDO MÉTODOS GETTERS ===");
            Console.WriteLine($"Nome do show (getter): {show1.GetNomeDoShow()}");
            Console.WriteLine($"Preço (getter): R$ {show1.GetPreco():F2}");
            Console.WriteLine($"Quantidade (getter): {show1.GetQuantidadeDisponivel()}");

            Console.WriteLine("\n=== TESTANDO SETTERS - ALTERANDO PREÇO ===");
            show1.SetPreco(280.00);
            Console.WriteLine($"Novo preço (getter): R$ {show1.GetPreco():F2}");
            show1.ExibirInformacoes();

            Console.WriteLine("\n=== TESTANDO SETTERS - ALTERANDO QUANTIDADE ===");
            show1.SetQuantidadeDisponivel(1200);
            Console.WriteLine($"Nova quantidade (getter): {show1.GetQuantidadeDisponivel()}");
            show1.ExibirInformacoes();

            Console.WriteLine("\n=== SEGUNDO SHOW - USANDO SETTERS ===");
            Ingresso show2 = new Ingresso();
            show2.SetNomeDoShow("Festival de Jazz");
            show2.SetPreco(180.50);
            show2.SetQuantidadeDisponivel(800);

            Console.WriteLine("Informações do segundo show:");
            show2.ExibirInformacoes();

            Console.WriteLine($"\nConfirmando com getters:");
            Console.WriteLine($"Show: {show2.GetNomeDoShow()}");
            Console.WriteLine($"Preço: R$ {show2.GetPreco():F2}");
            Console.WriteLine($"Disponível: {show2.GetQuantidadeDisponivel()}");

            Console.ReadKey();
        }
    }
}