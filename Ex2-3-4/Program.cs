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
}