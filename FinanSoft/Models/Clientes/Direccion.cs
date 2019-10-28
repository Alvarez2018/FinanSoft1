using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Clientes
{
    [Table("Direcciones")]
    public class Direccion
    {
        [Key]
        public int Id_Direccion { get; set; }
        public string Nombre { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }

       
        public string CodigoPostal { get; set; }
        public Pais Pais { get; set; }
        public Estado Estado { get; set; }

        public string Observaciones { get; set; }
        public bool EstaActiva {get; set;}
        public bool EsDefault { get; set; }
    }
}
