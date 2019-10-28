﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSoft.Models.Clientes
{
    [Table("Modelos")]
    public class Modelo
    {
        [Key]
        public int Id_Modelo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstasActivo { get; set; }
        
        public Marca Marca { get; set; }
    }
}
