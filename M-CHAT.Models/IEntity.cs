using System;
using System.Collections.Generic;
using System.Text;

namespace M_CHAT.Models
{
    public interface IEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
    }
}
