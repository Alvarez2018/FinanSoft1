using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Clientes
{
    [Table("Socios")]
    public class Socios
    {
        [Key]
        public int Id_Socio { get; set; }
        public string Nombre { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Fax { get; set; }        
        public string Email { get; set; }        
        public string Observaciones { get; set; }
        public string NumeroDeTributacion { get; set; }
        public string NumeroDocIdentifica { get; set; }
        public bool EstaActivo { get; set; }
        public IList<ArticuloCliente> ArticuloClientes { get; set; }
        public IList<Contacto> Contactos { get; set; }

        public IList<Direccion> Direcciones { get; set; }
        public TiposSocio TiposSocio { get; set; }
        public GrupoSocio GrupoClientes { get; set; }
       

    }
}
