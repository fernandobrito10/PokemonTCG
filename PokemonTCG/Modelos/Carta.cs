using PokemonTCG.Modelos.Enums;

namespace PokemonTCG.Modelos {
    public class Carta {
        public Pokemon Pokemon { get; set; }
        public List<Golpe> Golpes { get; set; }
        public int Vida { get; set; }
        public string Foto { get; set; }
        public Carta(Pokemon pokemon, List<Golpe> golpes, int vida) {
            Pokemon = pokemon;
            Golpes = golpes;
            Vida = vida;

        }
        public void PrintCarta() {
            Console.WriteLine($"{Pokemon.Nome}           PS{Vida}\nGolpes:");
            foreach(Golpe golpes in Golpes) {
                Console.WriteLine($"{golpes.Nome}\nTipo:{golpes.Tipo}\nDano:{golpes.Dano}");
            }
            
        }
    }
}
