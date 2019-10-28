using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanSoft.Models.Clientes
{
    [Table("Contactos")]
    public class Contacto
    {
        [Key]
        public int Id_Contacto { get; set; }

        public string Posicion { get; set; }
        public string Titulo { get; set; }
       
        public string Nombre { get; set; }        
        public string SegundoNombre { get; set; }
        public string Apellido { get; set; }
        public string SegundoApellido { get; set; }
        
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorreoElectronico { get; set; }
        public string FechaNacimiento { get; set; }
        public string Observaciones { get; set; }
        public bool EstaActivo { get; set; }
        public bool EsPrincipal {get; set; }




    }
}
