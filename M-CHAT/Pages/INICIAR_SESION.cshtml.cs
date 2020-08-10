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
    public class INICIAR_SESIONModel : PageModel
    {
        private readonly IRepository<Tutor> ITutor;

        [BindProperty]
        public Tutor cuenta  { get; set; }

        public INICIAR_SESIONModel(IRepository<Tutor> ITutor)
        {
            this.ITutor = ITutor;    
            cuenta = new Tutor();
        }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost(){
            Tutor existe = ITutor.GetAll().FirstOrDefault(x => x.Correo == cuenta.Correo && x.Contra == cuenta.Contra) ?? new Tutor();
            if(existe.Id > 0){
                return RedirectToPage("Perfil","OnGet",existe);
            }
            return Page();
        }
    }
}