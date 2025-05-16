using PokemonTCG.Data;
using PokemonTCG.Modelos;
using PokemonTCG.Modelos.Enums;

using var context = new TcgContext();

var psyduck = new Pokemon("Psyduck", TipoEnum.Agua);
context.Pokemons.Add(psyduck);
context.SaveChanges();

var lista = context.Pokemons.ToList();
foreach (var pokemons in lista)
    Console.WriteLine(pokemons);
