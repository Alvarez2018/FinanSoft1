using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Clientes
{
    [Table("Marcas")]
    public class Marca
    {
        [Key]
        public int Id_Marca { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstasActivo { get; set; }
        public TipoArticulo TipoArticulo { get; set; }
        public IList<Modelo> Modelos { get; set; }
    }
}
