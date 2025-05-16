using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PokemonTCG.Modelos;

namespace PokemonTCG.Data {
    public class TcgContext : DbContext {
        public DbSet<Pokemon> Pokemons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("TcgConnection");
            options.UseSqlite(connectionString);
        }
    }
}