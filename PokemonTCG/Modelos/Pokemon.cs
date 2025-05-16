using System.ComponentModel.DataAnnotations;
using PokemonTCG.Modelos.Enums;

namespace PokemonTCG.Modelos; 
public class Pokemon {
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public TipoEnum Tipo { get; set; }
    public Pokemon() { }
    public Pokemon(string nome, TipoEnum tipo) {
        Nome = nome;
        Tipo = tipo;
    }
    public override string ToString() {
        return $"Informações de {Nome}" +
            $"\nNome: {Nome}\nTipo: {Tipo}";
    }
}
