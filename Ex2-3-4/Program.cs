using System;

namespace VendaIngressos
{
    class Ingresso
    {
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {nomeDoShow}");
            Console.WriteLine($"Preço: R$ {preco:F2}");
            Console.WriteLine($"Ingressos disponíveis: {quantidadeDisponivel}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ingresso show1 = new Ingresso();
            show1.nomeDoShow = "Rock in Rio";
            show1.preco = 250.00;
            show1.quantidadeDisponivel = 1500;

            Console.WriteLine("=== INFORMAÇÕES INICIAIS ===");
            show1.ExibirInformacoes();

            Console.WriteLine("\n=== ALTERANDO PREÇO ===");
            show1.AlterarPreco(280.00);
            show1.ExibirInformacoes();

            Console.WriteLine("\n=== ALTERANDO QUANTIDADE ===");
            show1.AlterarQuantidade(1200);
            show1.ExibirInformacoes();

            Console.WriteLine("\n=== SEGUNDO SHOW ===");
            Ingresso show2 = new Ingresso();
            show2.nomeDoShow = "Festival de Jazz";
            show2.preco = 180.50;
            show2.quantidadeDisponivel = 800;
            show2.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}