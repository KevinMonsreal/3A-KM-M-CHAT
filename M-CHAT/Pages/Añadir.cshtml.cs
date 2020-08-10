using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_CHAT.Models;
using M_CHAT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace M_CHAT.Pages
{
    public class AñadirModel : PageModel
    {
        private readonly IRepository<Niño> repository;
        private readonly IRepository<Tutor> Tutores;
        private readonly IRepository<Centro> Centroeducativo;

         [BindProperty]
        public Niño hijo { get; set; }
        public Tutor tutor { get; set; }

        [BindProperty]
        public Centro centro{get; set;}

        public AñadirModel(IRepository<Niño> repository,IRepository<Tutor> Tutores,IRepository<Centro> Centroeducativo)
        {
            this.repository = repository;
            this.Tutores = Tutores;
            tutor = new Tutor();
            this.Centroeducativo = Centroeducativo;
        }

        public void OnGet(int id)
        {
            tutor = Tutores.Get(id);
        }

        public IActionResult OnPost(int Id){
            tutor = Tutores.Get(Id);

            if (!ModelState.IsValid)
                return Page();
            
            hijo.Estado = "No Encuestado";
            hijo.TutorID = Id;
            hijo.Centro = centro;
            var id = repository.Insert(hijo);

            return RedirectToPage("Perfil","OnGet",tutor);
        }

       



    }
}
