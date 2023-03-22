using System.Linq;
using ExercicePokemon.Models;
using ExercicePokemon.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExercicePokemon.Controllers
{
    public class DiversController : Controller
    {
        private BaseDeDonnees BD { get; set; }

        public DiversController(BaseDeDonnees baseDeresultat)
        {
            BD = baseDeresultat;
        }

        public IActionResult Menu()
        {
            return View();
        }
         

        public IActionResult Info1()
        {
            ViewData["description"] = "Afficher tous les pokémons";

            // À COMPLÉTER


            return View("AfficherListePokemons", BD.Pokemons.ToList()); //PASSER LE MODÈLE
        }

        public IActionResult Info2()
        {
            ViewData["description"] = "Afficher les pokémons ayant comme type primaire l'eau";

            var type = BD.Pokemons.Where(t => t.TypePrimaire == "Water");
           

            return View("AfficherListePokemons" ,type.ToList()); //PASSER LE MODÈLE
        }

        public IActionResult Info3()
        {
            ViewData["description"] = "Afficher les 5 premiers pokémons ayant comme type primaire l'eau";

            var type = BD.Pokemons.Where(t => t.TypePrimaire == "Water").Take(5);

            return View("AfficherListePokemons",type.ToList()); //PASSER LE MODÈLE
        }

        public IActionResult Info4()
        {
            ViewData["description"] = "Afficher les pokémons ayant comme type primaire l'électricité trié par puissance d'attaque";

            var type = BD.Pokemons.Where(t => t.TypePrimaire == "Electric").OrderBy(p => p.Attaque); 

            return View("AfficherListePokemons", type.ToList()); //PASSER LE MODÈLE
        }

        public IActionResult Info5()
        {
            ViewData["description"] = "Afficher les pokémons ayant la syllable \"chu\" dans leur nom";

            var type = BD.Pokemons.Where(p => p.Nom.Contains("chu"));

            return View("AfficherListePokemons", type.ToList()); //PASSER LE MODÈLE
        }
        public IActionResult Info6()
        {
            ViewData["description"] = "Afficher les pokémons ayant comme type primaire le feu et qui ont une puissant d'attaque supérieur à 60";

            var type = BD.Pokemons.Where(t => t.TypePrimaire == "Fire" && t.Attaque > 60);

            return View("AfficherListePokemons", type.ToList()); //PASSER LE MODÈLE
        }
        public IActionResult Info7()
        {
            ViewData["description"] = "Afficher les pokémons ayant comme type primaire le feu, l'eau ou l'herbe";

            var type = BD.Pokemons.Where(t => t.TypePrimaire == "Fire" || t.TypePrimaire == "Water" || t.TypePrimaire == "Grass" );

            return View("AfficherListePokemons", type.ToList()); //PASSER LE MODÈLE
        }
        public IActionResult Info8()
        {
            ViewData["description"] = "Afficher les pokémons ayant comme type primaire le feu, l'eau ou l'herbe trié par type primaire";

            var type = BD.Pokemons.Where(t => t.TypePrimaire == "Fire" || t.TypePrimaire == "Water" || t.TypePrimaire == "Grass").OrderBy(p => p.TypePrimaire);

            return View("AfficherListePokemons", type.ToList()); //PASSER LE MODÈLE
        }
        public IActionResult Info9()
        {
            ViewData["description"] = "Afficher les pokémons ayant comme type primaire le feu, l'eau ou l'herbe trié par type primaire puis par leur nom";

            var type = BD.Pokemons.Where(t => t.TypePrimaire == "Fire" || t.TypePrimaire == "Water" || t.TypePrimaire == "Grass").OrderBy(p => p.TypePrimaire).ThenBy(p => p.Nom);

            return View("AfficherListePokemons", type.ToList()); //PASSER LE MODÈLE
        }
        public IActionResult Info10()
        {
            ViewData["description"] = "Afficher le pokémon ayant le numéro 55";

           
            var type = BD.Pokemons.Where(t=> t.Id == 55).Single();

            return View("AfficherUnPokemon",type); //PASSER LE MODÈLE
        }
        public IActionResult Info11()
        {
            ViewData["description"] = "Afficher le pokémon le plus lent";

            var type = BD.Pokemons.OrderBy(t=> t.Vitesse).First();
            return View("AfficherUnPokemon",type); //PASSER LE MODÈLE
        }
        public IActionResult Info12()
        {
            ViewData["description"] = "Afficher le pokémon le plus rapide";

            var type = BD.Pokemons.OrderBy(t => t.Vitesse).Last();

            return View("AfficherUnPokemon",type); //PASSER LE MODÈLE
        }
        public IActionResult Info13()
        {
            ViewData["description"] = "Afficher le 3ème pokémon le plus rapide";

            var type = BD.Pokemons.OrderByDescending(t => t.Vitesse).Skip(2).First();

            return View("AfficherUnPokemon", type); //PASSER LE MODÈLE
        }
        public IActionResult Info14()
        {
            ViewData["description"] = "Afficher le dernier pokémon de type eau";

            var type = BD.Pokemons.OrderBy(t => t.TypePrimaire == "Water").Last();

            return View("AfficherUnPokemon",type); //PASSER LE MODÈLE
        }
        public IActionResult Info15()
        {
            ViewData["description"] = "Combien de pokémons ont une attaque supérieur à 40?";
            var type = BD.Pokemons.Where(p=> p.Attaque > 40).Count();

            return View("AfficherUnEntier",type); //PASSER LE MODÈLE
        }
        public IActionResult Info16()
        {
            ViewData["description"] = "Quelle est la moyenne d'attaque des pokémons?";

            var type = BD.Pokemons.Average(p => p.Attaque);

            return View("AfficherUnDouble",type); //PASSER LE MODÈLE
        }
        public IActionResult Info17()
        {
            ViewData["description"] = "Quelle est la moyenne d'attaque des pokémons de type primaire feu?";

            var type = BD.Pokemons.Where(t=> t.TypePrimaire == "Fire").Average(p => p.Attaque);

            return View("AfficherUnDouble",type); //PASSER LE MODÈLE
        }
        public IActionResult Info18()
        {
            ViewData["description"] = "Afficher les informations sur la moyenne des attaques de pokémons de type feu, d'eau et d'herbe séparément";

            // À COMPLÉTER

            //Puisque la structure de données à afficher est particulière à cette vue (3 doubles) vous devez créer un ViewModel (nommé Info18ViewModel) comme modèle pour cette vue.
            //Indice : le contrôleur devra faire 3 requêtes LINQ différentes sur le modèle afin de pouvoir remplir les propriétés de ce ViewModel

            return View("AfficherInfo18");
        }
    }
}