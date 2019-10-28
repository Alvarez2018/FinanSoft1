using FinanSoft.Models.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Core


{
    public class Persona
    {
        [Key]
        public int Id_Persona { get; set; }
        public string Nombres1 { get; set; }
        public string Nombres2 { get; set; }
        public string Apellidos1 { get; set; }
        public string Apellidos2 { get; set; }
        public string Empresa { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }

        public string Observaciones { get; set; }
        public string NumeroDeTributacion { get; set; }
        public string NumeroDocIdentifica { get; set; }
        public virtual Usuario Usuario { get; set; }
        //public virtual Tipo_Persona TipoPersona { get; set; }
        public int Status_Usuario { get; set; }
    }
}
