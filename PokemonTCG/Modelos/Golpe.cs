using System.ComponentModel.DataAnnotations;
using PokemonTCG.Modelos.Enums;

namespace PokemonTCG.Modelos; 
internal class Golpe {
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public TipoEnum Tipo { get; set; }
    public int Dano { get; set; }
    public Golpe(string nome, TipoEnum tipo, int dano) {
        Nome = nome;
        Tipo = tipo;
        Dano = dano;
    }
}
