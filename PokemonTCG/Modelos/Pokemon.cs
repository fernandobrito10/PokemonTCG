using System.ComponentModel.DataAnnotations;
using PokemonTCG.Modelos.Enums;

namespace PokemonTCG.Modelos; 
internal class Pokemon {
    [Key]
    public int Id { get; set; }
    public int Numero { get; set; }
    public string Nome { get; set; }
    public TipoEnum Tipo { get; set; }
    public Pokemon(int numero, string nome, TipoEnum tipo) {
        Numero = numero;
        Nome = nome;
        Tipo = tipo;
    }
    public void PrintInfo() {
        Console.WriteLine($"Informações de {Nome}");
        Console.WriteLine($"Nº {Numero}\nNome: {Nome}\nTipo: {Tipo}");
    }
}
