using System.ComponentModel.DataAnnotations;

namespace TechStoreMVC.Models;

public class Produto
{
    public int Id {get; set;}
    [Required(ErrorMessage ="Informe um nome ")]
    [StringLength(100,
    MinimumLength = 3,
    ErrorMessage = "o nome deve possuir entre 3 e 100 caracteres")]
    public string Nome { get; set; } = string.Empty;

    [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "O preço deve ser maior ou igual a zero")]
    public decimal Preco {get; set;}

    [Range(0, int.MaxValue, ErrorMessage = "O estoque deve ser maior ou igual a zero")]
    public int Estoque {get; set;}

    public Produto()
    {
    }

    public Produto(
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

