using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_CHAT.Models;
using M_CHAT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class AlertaModel : PageModel
    {
        private readonly IRepository<Tutor> Tutores;
        private readonly IRepository<Niño> hijos;
        


        public Tutor tutor;
        public Niño hijo;

        

        public AlertaModel(IRepository<Tutor> Tutores,IRepository<Niño> hijos)
        {
            this.Tutores = Tutores;
            this.hijos = hijos;  
            
        }

        public void OnGet(Niño hijo )
        {
            this.hijo = hijo;
            this.tutor = Tutores.GetAll().FirstOrDefault(x => x.Id == hijo.TutorID);
            hijos.Update(hijo);
        }

        public IActionResult OnPost(int id, int id_Niño)
        {
            Tutor tutor = Tutores.Get(id);
            Niño hijo = hijos.Get(id_Niño);

            return RedirectToPage("Perfil","OnGet", tutor);
        }



    }
}
