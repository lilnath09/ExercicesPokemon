
namespace ExercicePokemon.Models
{
    public class PokemonDresseur
    {
        public int PokemonId { get; set; }
        public int DresseurId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Dresseur Dresseur { get; set; }
        public int Niveau { get; set; }
    }
}
