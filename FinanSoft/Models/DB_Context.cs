using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FinanSoft.Models.Core;
using FinanSoft.Models.Seguridad;
using MySql.Data.Entity;
using FinanSoft.Models.Clientes;

using System.ComponentModel.DataAnnotations.Schema;


namespace FinanSoft
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DB_Context : DbContext
    {

        public DB_Context()
            : base("name=MySqlConcection")
        {

        }
        //public DbSet<Persona> Personas { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Socios> Socios { get; set; }
        public DbSet<ArticuloCliente> ArticuloClientes { get; set; }
        public DbSet<GrupoSocio> GrupoClientes { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<TiposSocio> TipoSocios { get; set; }

        public DbSet<TipoArticulo> TipoArticulos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Pais> Paises{ get;  set; }
        public DbSet<Estado> Estados { get; set; }
        
       
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties()
                .Where(x => x.PropertyType == typeof(bool))
                .Configure(x => x.HasColumnType("bit"));
        }
    }
   
}
