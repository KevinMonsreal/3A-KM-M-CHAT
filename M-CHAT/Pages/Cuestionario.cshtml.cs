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
    public class CuestionarioModel : PageModel
    {
        private readonly IRepository<Preguntas> RPreguntas;
         private readonly IRepository<Tutor> Tutores;
         private readonly IRepository<Niño> hijos;
        public List<Preguntas> preguntas {get; set;}
        
        [BindProperty]
        public Boolean [] Respuestas {get; set;} = new Boolean [23];
        
        public int id;
        public int id_niño;

        public CuestionarioModel(IRepository<Preguntas> RPreguntas,IRepository<Tutor> Tutores,IRepository<Niño> hijos)
        {
            this.RPreguntas = RPreguntas;
            preguntas = RPreguntas.GetAll().ToList();
            this.Tutores = Tutores;
            this.hijos = hijos;            
        }

        public void OnGet(int id, int id_Niño)
        {
            this.id = id;
            this.id_niño = id_Niño;
        }


        public IActionResult OnPost(int id, int id_Niño)
        {
            Tutor tutor = Tutores.Get(id);
            Niño hijo = hijos.Get(id_Niño);
            preguntas = RPreguntas.GetAll().OrderBy(x => x.Id).ToList();

            int cont = 0;
            int criticas = 0;
            int normales = 0;
            
            foreach(var item in preguntas){
               
                
                if(item.Respuesta != Respuestas[cont])
                {
                    if(item.Id == 2)
                        criticas++;
                    else if(item.Id == 7)
                        criticas++;
                    else if(item.Id == 9)
                        criticas++;
                    else if(item.Id == 13)
                        criticas++;
                    else if(item.Id == 14)
                        criticas++;
                    else if(item.Id == 15)
                        criticas++;
                    else
                        normales++;
                }
                cont++;
            }
            Console.WriteLine(criticas);
            Console.WriteLine(normales);
            
            if(criticas > 2 || normales > 3)
               hijo.Estado = "Consulte a su medico";
            else
                hijo.Estado = "Aprobado";
            
            return RedirectToPage("Alerta","OnGet",hijo);
        }


    }
}
