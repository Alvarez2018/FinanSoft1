using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Clientes
{
    [Table("Fabricantes")]
    public class Fabricante
    {
        [Key]
        public int Id_Fabricante { get; set; }
        public string Nomgre { get; set; }
        public string  Descripcion { get; set; }

        public bool EstasActivo { get; set; }
    }
}
