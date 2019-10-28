using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Inventario
{
    [Table("Articulos")]
    public class Articulo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
