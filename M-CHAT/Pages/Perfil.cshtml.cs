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
    public class PerfilModel : PageModel
    {
        private readonly IRepository<Niño> hijo;
        public PerfilModel(IRepository<Niño> hijo)
        {
            this.hijo = hijo;
        }
        public Tutor tutor;
        public List<Niño> hijos;

        public void OnGet(Tutor cuenta)
        {
            tutor = cuenta;
            hijos = hijo.GetAll().Where(x => x.TutorID == tutor.Id).ToList();
        }

        public IActionResult OnPostNuevo(int id){
            
            return RedirectToPage("Añadir","OnGet",new {id = id});
        }

       public IActionResult OnPostCuestionario(int id, int id_Niño){
           return RedirectToPage("Cuestionario","OnGet",new {id = id, id_Niño = id_Niño});
       }

    }
}
