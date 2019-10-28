using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Clientes
{
    [Table("Paises")]
    public class Pais
    {
        [Key]
        public int Id_Pais { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstaActiva { get; set; }
      //  public Direccion Direcciones { get; set; }
        public IList<Estado> Estados { get; set; }
    }
}
