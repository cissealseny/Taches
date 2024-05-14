using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MesTaches.Data;

namespace MesTaches.Pages
{
    public class TachesModel : PageModel
    {
        private readonly TacheContext _context;

        public TachesModel(TacheContext context)
        {
            _context = context;
        }

        public List<Tache> Taches { get; set; }

        public void OnGet()
        {
            if (!_context.Taches.Any())
            {
                _context.Taches.AddRange(
                    new Tache { Titre = "Faire les courses", Terminer = false },
                    new Tache { Titre = "Nettoyer la maison", Terminer = true },
                    new Tache { Titre = "Appeler le médecin", Terminer = false }
                   
                );
                _context.SaveChanges();
            }

            Taches = _context.Taches.ToList();
        }

    }
}
