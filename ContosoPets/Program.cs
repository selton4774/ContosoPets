using System;
using System.Linq;
using ContosoPets.Data;
using ContosoPets.Models;

namespace ContosoPets
{
    class Program
    {
        static void Main(string[] args)
        {
            using var con = new ContosoPetsContext();

            // Adiciona na tabela de produtos 
            Produto pelucia = new Produto()
            {
                Nome = "Osso de pelúcia",
                Preço = 1.55M
            };

            con.Produtos.Add(pelucia);
            con.SaveChanges();


            Produto bolaDeTenis = new Produto()
            {
                Nome = "Bola de tênis",
                Preço = 9.99M
            };

            con.Add(bolaDeTenis);
            con.SaveChanges();

            //// Altera o valor de um produto
            //var produtoAlteracao = con.Produtos.Where(x => x.Nome == "Osso de pelúcia").FirstOrDefault();

            //if (produtoAlteracao is Produto)
            //{
            //    produtoAlteracao.Preço = 7.99M;
            //}

            //con.SaveChanges();

            // Remover um produto
            var produtoExcluir = con.Produtos.Where(x => x.Nome == "Osso de pelúcia").FirstOrDefault();

            if (produtoExcluir is Produto)
            {
                con.Remove(produtoExcluir);
            }

            con.SaveChanges();



            // Faz a leitura da tabela de produtos
            var produtos = con.Produtos
                           .Where(p => p.Preço >= 5.00M)
                           .OrderBy(p => p.Nome);

            Console.WriteLine($"Id \t Nome \t\t Preço");

            foreach (Produto p in produtos)
            {
                Console.WriteLine($"{p.Id} \t {p.Nome} \t R$ {p.Preço}");
                Console.WriteLine();
            }


            
        }
    }
}
