using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Clientes
{
    [Table("Estados")]
    public class Estado
    {
        [Key]
        public int Id_Estado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstaActivo { get; set; }
        public Pais Pais { get; set; }
    }
}
