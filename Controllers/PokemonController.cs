using ExercicePokemon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExercicePokemon.Controllers
{
    public class PokemonController : Controller
    {
        private BaseDeDonnees BD { get; set; }

        public PokemonController(BaseDeDonnees Pbase)
        {
            BD = Pbase;
            
        }

        
        public IActionResult Lister()
        {
            return View(BD.Pokemons.ToList());
        }

        public IActionResult Consulter(int id)
        {
            var pokemonRecherché = BD.Pokemons.Where(p => p.Id == id).SingleOrDefault();
            if(pokemonRecherché == null)
            {
                return View("../Shared/NonTrouvé");
            }
            return View(pokemonRecherché);
        }
        
    }
}