using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_CHAT.Models
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; } = true;
    }
}
