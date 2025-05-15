using PokemonTCG.Modelos;
using PokemonTCG.Modelos.Enums;

Golpe golpe1 = new Golpe("Dor de Cabeça", TipoEnum.Incolor, 10);
List<Golpe> golpesPsyduck = new List<Golpe>();
golpesPsyduck.Add(golpe1);
Pokemon psyduck = new Pokemon(54, "Psyduck", TipoEnum.Agua);;
Carta cartaPsyduck = new Carta(psyduck, golpesPsyduck, 60);
cartaPsyduck.Foto = "https://assets.pokemon.com/static-assets/content-assets/cms2-pt-br/img/cards/web/SM9/SM9_PT-BR_26.png";
psyduck.PrintInfo();
Console.WriteLine("-----------");
cartaPsyduck.PrintCarta();