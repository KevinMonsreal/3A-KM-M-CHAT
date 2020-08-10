using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_CHAT.Models;
using M_CHAT.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace M_CHAT.Pages
{
    public class RegisterTutorModel : PageModel
    {
        [BindProperty]
        public Tutor Tutor { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        private readonly IRepository<Tutor> repository;

        public RegisterTutorModel(IRepository<Tutor> repository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

                
            var id = repository.Insert(Tutor);

            return RedirectToPage("/INICIAR_SESION");
        }
        public void OnGet()
        {

        }
    }
}