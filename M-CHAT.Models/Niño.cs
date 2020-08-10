using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace M_CHAT.Models
{
    public class Niño : BaseEntity
    {
        [Required(ErrorMessage = "Nombre is required.")]
        [Display(Prompt = "Nombre")]
        public string Nombre_Completo { get; set; }

        [Required(ErrorMessage = "CURP is required.")]
        [Display(Prompt = "Correo electronico")]
        public string CURP { get; set; }

        [Display(Prompt = "Fecha de nacimiento")]
        public DateTime Fecha_Nacimiento { get; set; }

        [Required(ErrorMessage = "Edad is required.")]
        [Display(Prompt = "Edad")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Genero is required.")]
        [Display(Prompt = "Genero")]
        public string Genero { get; set; }
        public string Estado { get; set; }
        
        public int TutorID { get; set; }
        public Tutor Tutor { get; set; }

        public int CentroID { get; set; }
        public Centro Centro {get; set; }
    }
}
