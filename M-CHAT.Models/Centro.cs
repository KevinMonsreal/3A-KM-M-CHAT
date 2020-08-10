using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace M_CHAT.Models
{
    public class Centro : BaseEntity
    {
        [Required(ErrorMessage = "Nombre is required.")]
        [Display(Prompt = "Nombre")]
        public string Nombre_Centro { get; set; }

        [Required(ErrorMessage = "Direccion is required.")]
        [Display(Prompt = "Direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Clave is required.")]
        [Display(Prompt = "Clave")]
        public string Clave { get; set;}

        public ICollection<Niño> Niños { get; set; }
    }
}
