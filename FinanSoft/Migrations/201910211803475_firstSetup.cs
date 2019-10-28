namespace FinanSoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticulosCliente",
                c => new
                    {
                        Id_ArticuloCliente = c.Int(nullable: false, identity: true),
                        Placa = c.String(unicode: false),
                        Color = c.String(unicode: false),
                        Año = c.Int(nullable: false),
                        Motor = c.String(unicode: false),
                        NumCilindros = c.String(unicode: false),
                        SerialMotor = c.String(unicode: false),
                        SerialChasis = c.String(unicode: false),
                        Origen = c.String(unicode: false),
                        Transmision = c.String(unicode: false),
                        Combustible = c.String(unicode: false),
                        EstaActivo = c.Boolean(nullable: false, storeType: "bit"),
                        Descripcion = c.String(unicode: false),
                        Cliente_Id_Socio = c.Int(),
                        Marca_Id_Marca = c.Int(),
                        Modelo_Id_Modelo = c.Int(),
                        TipoArticulo_Id_TipoArticulo = c.Int(),
                    })
                .PrimaryKey(t => t.Id_ArticuloCliente)
                .ForeignKey("dbo.Socios", t => t.Cliente_Id_Socio)
                .ForeignKey("dbo.Marcas", t => t.Marca_Id_Marca)
                .ForeignKey("dbo.Modelos", t => t.Modelo_Id_Modelo)
                .ForeignKey("dbo.TipoArticulos", t => t.TipoArticulo_Id_TipoArticulo)
                .Index(t => t.Cliente_Id_Socio)
                .Index(t => t.Marca_Id_Marca)
                .Index(t => t.Modelo_Id_Modelo)
                .Index(t => t.TipoArticulo_Id_TipoArticulo);
            
            CreateTable(
                "dbo.Socios",
                c => new
                    {
                        Id_Socio = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                        Telefono1 = c.String(unicode: false),
                        Telefono2 = c.String(unicode: false),
                        Fax = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Observaciones = c.String(unicode: false),
                        NumeroDeTributacion = c.String(unicode: false),
                        NumeroDocIdentifica = c.String(unicode: false),
                        EstaActivo = c.Boolean(nullable: false, storeType: "bit"),
                        GrupoClientes_Id = c.Int(),
                        TiposSocio_Id_TipoSocio = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Socio)
                .ForeignKey("dbo.GrupoSocios", t => t.GrupoClientes_Id)
                .ForeignKey("dbo.TiposSocios", t => t.TiposSocio_Id_TipoSocio)
                .Index(t => t.GrupoClientes_Id)
                .Index(t => t.TiposSocio_Id_TipoSocio);
            
            CreateTable(
                "dbo.Contactos",
                c => new
                    {
                        Id_Contacto = c.Int(nullable: false, identity: true),
                        Posicion = c.String(unicode: false),
                        Titulo = c.String(unicode: false),
                        Nombre = c.String(unicode: false),
                        SegundoNombre = c.String(unicode: false),
                        Apellido = c.String(unicode: false),
                        SegundoApellido = c.String(unicode: false),
                        Telefono1 = c.String(unicode: false),
                        Telefono2 = c.String(unicode: false),
                        TelefonoMovil = c.String(unicode: false),
                        CorreoElectronico = c.String(unicode: false),
                        FechaNacimiento = c.String(unicode: false),
                        Observaciones = c.String(unicode: false),
                        EstaActivo = c.Boolean(nullable: false, storeType: "bit"),
                        EsPrincipal = c.Boolean(nullable: false, storeType: "bit"),
                        Socios_Id_Socio = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Contacto)
                .ForeignKey("dbo.Socios", t => t.Socios_Id_Socio)
                .Index(t => t.Socios_Id_Socio);
            
            CreateTable(
                "dbo.Direcciones",
                c => new
                    {
                        Id_Direccion = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                        Direccion1 = c.String(unicode: false),
                        Direccion2 = c.String(unicode: false),
                        CodigoPostal = c.String(unicode: false),
                        Observaciones = c.String(unicode: false),
                        EstaActiva = c.Boolean(nullable: false, storeType: "bit"),
                        EsDefault = c.Boolean(nullable: false, storeType: "bit"),
                        Estado_Id_Estado = c.Int(),
                        Pais_Id_Pais = c.Int(),
                        Socios_Id_Socio = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Direccion)
                .ForeignKey("dbo.Estados", t => t.Estado_Id_Estado)
                .ForeignKey("dbo.Paises", t => t.Pais_Id_Pais)
                .ForeignKey("dbo.Socios", t => t.Socios_Id_Socio)
                .Index(t => t.Estado_Id_Estado)
                .Index(t => t.Pais_Id_Pais)
                .Index(t => t.Socios_Id_Socio);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        Id_Estado = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                        Descripcion = c.String(unicode: false),
                        EstaActivo = c.Boolean(nullable: false, storeType: "bit"),
                        Pais_Id_Pais = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Estado)
                .ForeignKey("dbo.Paises", t => t.Pais_Id_Pais)
                .Index(t => t.Pais_Id_Pais);
            
            CreateTable(
                "dbo.Paises",
                c => new
                    {
                        Id_Pais = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                        Descripcion = c.String(unicode: false),
                        EstaActiva = c.Boolean(nullable: false, storeType: "bit"),
                    })
                .PrimaryKey(t => t.Id_Pais);
            
            CreateTable(
                "dbo.GrupoSocios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                        Descripcion = c.String(unicode: false),
                        EstaActivo = c.Boolean(nullable: false, storeType: "bit"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TiposSocios",
                c => new
                    {
                        Id_TipoSocio = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                        Descripcion = c.String(unicode: false),
                        EstaActivo = c.Boolean(nullable: false, storeType: "bit"),
                    })
                .PrimaryKey(t => t.Id_TipoSocio);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id_Marca = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                        Descripcion = c.String(unicode: false),
                        EstasActivo = c.Boolean(nullable: false, storeType: "bit"),
                        TipoArticulo_Id_TipoArticulo = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Marca)
                .ForeignKey("dbo.TipoArticulos", t => t.TipoArticulo_Id_TipoArticulo)
                .Index(t => t.TipoArticulo_Id_TipoArticulo);
            
            CreateTable(
                "dbo.Modelos",
                c => new
                    {
                        Id_Modelo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                        Descripcion = c.String(unicode: false),
                        EstasActivo = c.Boolean(nullable: false, storeType: "bit"),
                        Marca_Id_Marca = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Modelo)
                .ForeignKey("dbo.Marcas", t => t.Marca_Id_Marca)
                .Index(t => t.Marca_Id_Marca);
            
            CreateTable(
                "dbo.TipoArticulos",
                c => new
                    {
                        Id_TipoArticulo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                        Descripcion = c.String(unicode: false),
                        EstasActivo = c.Boolean(nullable: false, storeType: "bit"),
                    })
                .PrimaryKey(t => t.Id_TipoArticulo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticulosCliente", "TipoArticulo_Id_TipoArticulo", "dbo.TipoArticulos");
            DropForeignKey("dbo.ArticulosCliente", "Modelo_Id_Modelo", "dbo.Modelos");
            DropForeignKey("dbo.ArticulosCliente", "Marca_Id_Marca", "dbo.Marcas");
            DropForeignKey("dbo.Marcas", "TipoArticulo_Id_TipoArticulo", "dbo.TipoArticulos");
            DropForeignKey("dbo.Modelos", "Marca_Id_Marca", "dbo.Marcas");
            DropForeignKey("dbo.Socios", "TiposSocio_Id_TipoSocio", "dbo.TiposSocios");
            DropForeignKey("dbo.Socios", "GrupoClientes_Id", "dbo.GrupoSocios");
            DropForeignKey("dbo.Direcciones", "Socios_Id_Socio", "dbo.Socios");
            DropForeignKey("dbo.Direcciones", "Pais_Id_Pais", "dbo.Paises");
            DropForeignKey("dbo.Estados", "Pais_Id_Pais", "dbo.Paises");
            DropForeignKey("dbo.Direcciones", "Estado_Id_Estado", "dbo.Estados");
            DropForeignKey("dbo.Contactos", "Socios_Id_Socio", "dbo.Socios");
            DropForeignKey("dbo.ArticulosCliente", "Cliente_Id_Socio", "dbo.Socios");
            DropIndex("dbo.Modelos", new[] { "Marca_Id_Marca" });
            DropIndex("dbo.Marcas", new[] { "TipoArticulo_Id_TipoArticulo" });
            DropIndex("dbo.Estados", new[] { "Pais_Id_Pais" });
            DropIndex("dbo.Direcciones", new[] { "Socios_Id_Socio" });
            DropIndex("dbo.Direcciones", new[] { "Pais_Id_Pais" });
            DropIndex("dbo.Direcciones", new[] { "Estado_Id_Estado" });
            DropIndex("dbo.Contactos", new[] { "Socios_Id_Socio" });
            DropIndex("dbo.Socios", new[] { "TiposSocio_Id_TipoSocio" });
            DropIndex("dbo.Socios", new[] { "GrupoClientes_Id" });
            DropIndex("dbo.ArticulosCliente", new[] { "TipoArticulo_Id_TipoArticulo" });
            DropIndex("dbo.ArticulosCliente", new[] { "Modelo_Id_Modelo" });
            DropIndex("dbo.ArticulosCliente", new[] { "Marca_Id_Marca" });
            DropIndex("dbo.ArticulosCliente", new[] { "Cliente_Id_Socio" });
            DropTable("dbo.TipoArticulos");
            DropTable("dbo.Modelos");
            DropTable("dbo.Marcas");
            DropTable("dbo.TiposSocios");
            DropTable("dbo.GrupoSocios");
            DropTable("dbo.Paises");
            DropTable("dbo.Estados");
            DropTable("dbo.Direcciones");
            DropTable("dbo.Contactos");
            DropTable("dbo.Socios");
            DropTable("dbo.ArticulosCliente");
        }
    }
}
