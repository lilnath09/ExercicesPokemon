
using System.Collections.Generic;

namespace ExercicePokemon.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string TypePrimaire { get; set; }
        public string TypeSecondaire { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Defense { get; set; }
        public int Attaque { get; set; }
        public int SpecialAttaque { get; set; }
        public int SpecialDefense { get; set; }
        public int Vitesse { get; set; }
        public int Generation { get; set; }
        public bool Legendaire { get; set; }
        public string Description { get; set; }
        public List<PokemonDresseur> PokemonDresseurs { get; set; }

        public Pokemon()
        {
            PokemonDresseurs = new List<PokemonDresseur>();
        }
    }
}
