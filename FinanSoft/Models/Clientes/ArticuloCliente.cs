using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Clientes
{
    [Table("ArticulosCliente")]
    public class ArticuloCliente
    {
        [Key]
        public int Id_ArticuloCliente { get; set; }

        public string Placa { get; set; }
        public TipoArticulo TipoArticulo { get; set; }
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public string Color { get; set; }
        public int Año { get; set; }
        public string Motor {get; set;}
        public string NumCilindros { get; set; }

        public string SerialMotor {get; set;}
        public string SerialChasis {get; set;}
        public string Origen { get; set; }
       
        public string Transmision { get; set; }
        public string Combustible { get; set; }

        public bool EstaActivo { get; set; }
        public string Descripcion { get; set; }

        public Socios Cliente { get; set; }

        //public string Tapiceria { get; set; }
        //public bool TieneAC { get; set; }
        //public bool TieneAlarma { get; set; }
        //public bool TieneArosMagnecio { get; set; }
        //public bool TieneBolsasDeAire { get; set; }
        //public bool TieneCerraduraCentral { get; set; }
        //public bool TieneEspejosElectricos { get; set; }
        //public bool TienePolarizado { get; set; }
        //public bool TieneRadio { get; set; }
        //public bool TieneSunroof { get; set; }
        //public bool TieneVidriosElectricos { get; set; }

        
    }
}
