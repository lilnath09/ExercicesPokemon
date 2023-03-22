using System.Collections.Generic;

namespace ExercicePokemon.Models
{
    public class Dresseur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Image { get; set; }
        public string Arena { get; set; }
        public string TypeSpecialisé { get; set; }
        public List<PokemonDresseur> PokemonsDresseur { get; set; }

        public Dresseur()
        {
            PokemonsDresseur = new List<PokemonDresseur>();
        }
    }
}
