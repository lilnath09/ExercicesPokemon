using ExercicePokemon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace ExercicesPokemon.Controllers
{
    public class DresseurController : Controller
    {
        private BaseDeDonnees Bd { get; set; }
       

        public DresseurController(BaseDeDonnees bd)
        {
            Bd = bd;
        }


        public IActionResult Lister(List<Dresseur> pDresseur)
        {
             pDresseur=Bd.Dresseurs ;
            return View(pDresseur.ToList());
        }
        public IActionResult Consulter(int id)
        {
            foreach (Dresseur d in Bd.Dresseurs)
            {
                if (id == d.Id)
                {
                    return View(d);
                }
            }   
            
           
                return View("../Shared/NonTrouvé");
           
        }
    }
}
