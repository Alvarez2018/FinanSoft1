using FinanSoft.Models.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Seguridad
{
    public class Usuario
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }

        [Required]
        public virtual Persona Persona { get; set; }
    }
}
