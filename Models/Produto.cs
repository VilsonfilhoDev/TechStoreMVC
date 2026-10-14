using System;
using System.Reflection.Metadata;

namespace TechStoreMVC.Models;

public class Produto
{
    public int Id {get; set;}
    public string Nome {get; set;}
    public decimal Preco {get; set;}
    public int Estoque {get; set;}

    public Produto (
        int id,
        string nome,
        decimal preco,
        int estoque
    )
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

}

