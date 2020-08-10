using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace M_CHAT.Models
{
    public class Tutor : BaseEntity
    {
        [Required(ErrorMessage = "Nombre del tutor is required.")]
        [Display(Prompt = "Nombre del candidato")]
        public string Nombre { get; set; }
        
        [Display(Prompt = "Direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Correo is required.")]
        [Display(Prompt = "Correo electronico")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Contraseña is required.")]
        [Display(Prompt = "Contraseña")]
        public string Contra { get; set; }

        IEnumerable<Niño> niño { get; set; }
    }
}
