using FinanSoft.Models.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace FinanSoft.Forms_Clientes
{
    public partial class WFClientes : Form
    {
        private DB_Context _contexto = new DB_Context();
        private bool EsClienteNuevo = false;
        private bool EsClienteMod = false;
        private bool DirDireccionNueva = false;
        private bool ConContactoNuevo = false;
        private bool ArtiArticuloNuevo = false;
        
        public static string RecepcionString = "";
        private Socios _SocioForma;
        
            
        public WFClientes()
        {
            var contexto = new DB_Context();
            InitializeComponent();
       
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.disable_all_controls();
            
          
          
        }

        //BOTON CREAR CLIENTE
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
           
            this.EsClienteNuevo = true;
            this.clear_all_controls();
            this.enable_all_controls();
            this.fill_TipoSocios();
            this.fill_GrupoSocios();
           
        }       
        //BOTON GRABAR CLIENTE
        private void btn_Grabar_Cliente_Click(object sender, EventArgs e)
        {
            _contexto.Dispose();
            _contexto = new DB_Context();
            var idGrupo = int.Parse(cbo_Grupo.SelectedValue.ToString());
            var idTipo = int.Parse(cbo_Tipo.SelectedValue.ToString());
            if (this.EsClienteNuevo)
            {
                var SocioEstaActivo = true;
                
                _SocioForma = new Socios
                {
                    Nombre = txt_Nombre.Text,
                    
                    GrupoClientes = _contexto.GrupoClientes.FirstOrDefault(gc => gc.Id == idGrupo ),
                    TiposSocio = _contexto.TipoSocios.FirstOrDefault(gc => gc.Id_TipoSocio == idTipo),
                    Telefono1= txt_Telefono1.Text,
                    Telefono2= txt_Telefono2.Text,
                    Fax = txt_Fax.Text,                    
                    Email = txt_Email.Text,
                    Observaciones = rtb_Observaciones.Text,
                    NumeroDeTributacion = txt_Nit.Text,
                    EstaActivo = SocioEstaActivo,
                };
                

                _contexto.Socios.Add(_SocioForma);
                _contexto.SaveChanges();
                var idSocioGrabado = _SocioForma.Id_Socio;
                MessageBox.Show("Cliente NUEVO grabado con exito. "+ _SocioForma.Id_Socio.ToString());
                this.EsClienteNuevo = false;
                _SocioForma = _contexto.Socios
                    .Include(i => i.ArticuloClientes)
                    .Include(c => c.Contactos)
                    .Include(d => d.Direcciones)
                    .Include(t => t.TiposSocio)
                    .Include(g => g.GrupoClientes)
                    .SingleOrDefault(c => c.Id_Socio == idSocioGrabado);
            }
            else
            {
                if (this.EsClienteMod)
                {
                    int idSocioforma = Int32.Parse(txt_IdSocio.Text);
                    _SocioForma = _contexto.Socios.FirstOrDefault(c => c.Id_Socio == idSocioforma );
                    _SocioForma.Nombre = txt_Nombre.Text;
                    _SocioForma.GrupoClientes = _contexto.GrupoClientes.FirstOrDefault(gc => gc.Id == idGrupo);
                    _SocioForma.TiposSocio = _contexto.TipoSocios.FirstOrDefault(gc => gc.Id_TipoSocio == idTipo );
                    _SocioForma.Telefono1 = txt_Telefono1.Text;
                    _SocioForma.Telefono2 = txt_Telefono2.Text;
                    _SocioForma.Email = txt_Email.Text;
                    _SocioForma.Observaciones = rtb_Observaciones.Text;
                    _SocioForma.NumeroDeTributacion = txt_Nit.Text;
                    _SocioForma.EstaActivo = chk_ConActivo.Checked;
                    _contexto.SaveChanges();
                    MessageBox.Show("Cliente Modificado grabado con exito.");
                    this.EsClienteMod = false;
                } else
                {
                    MessageBox.Show("Grabar no es una opcion disponible.");
                }
            }
            this.desplegarCliente(_SocioForma);
        }
        //BOTON BUSCAR
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            this.clear_all_controls();
            this.disable_all_controls();
            using (Wf_ClienteLista WFL = new Wf_ClienteLista())
            {
                if (WFL.ShowDialog() == DialogResult.OK)
                {
                    //textBox2.Text = WFL.ClienteEnviar.Nombres1;
                    //textBox3.Text = WFL.ClienteEnviar.Nombres2;
                    int IdClienteBuscar = WFL.idClienteEnviar;                    
                    _SocioForma = _contexto.Socios
                                                    .Include(i => i.ArticuloClientes)
                                                    .Include(c => c.Contactos)
                                                    .Include(d => d.Direcciones)
                                                    .Include(t => t.TiposSocio)
                                                    .Include(g => g.GrupoClientes)
                                                    .SingleOrDefault(c => c.Id_Socio == IdClienteBuscar);
                    this.fill_TipoSocios();
                    this.fill_GrupoSocios();
                    this.desplegarCliente(_SocioForma);
                   
                }
            }
        }
        //BOTON MODIFICAR
        private void btn_Modificar(object sender, EventArgs e)
        {
            //this.fill_TipoSocios();
            //this.fill_GrupoSocios();
            if (txt_IdSocio.Text !="")
            {
                this.enable_all_controls();

                this.EsClienteMod = true;
            }
            else
            {
                MessageBox.Show("Selleccione un cliente por favor");
            }            
        }
       //Funciones y Metodos creados por programacion
        private void disable_all_controls()
        { //<*--   TAB General-->
            txt_IdSocio.Enabled = false;
            txt_Nombre.Enabled = false;
            cbo_Grupo.Enabled = false;
            cbo_Tipo.Enabled = false;
            txt_Telefono1.Enabled = false;
            txt_Telefono2.Enabled = false;
            txt_Fax.Enabled = false;
            txt_Email.Enabled=false;
            txt_Nit.Enabled = false;
            rtb_Observaciones.Enabled = false;            
            chk_ConActivo.Enabled = false;
           
            this.disable_DirTab();
            this.disable_ConTab();
            this.disable_ArtiTab();
            
            //<-- fin-->

           
        }
        private void disable_ConTab()
        {
            //<--TAB Contactos-->
            txt_ConId.Enabled = false;
            txt_ConPosicion.Enabled = false;
            txt_ConTitulo.Enabled = false;
            txt_ConNombre1.Enabled = false;
            txt_ConNombre2.Enabled = false;
            txt_ConApellido1.Enabled = false;
            txt_ConApellido2.Enabled = false;
            txt_ContTel1.Enabled = false;
            txt_ContTel2.Enabled = false;
            txt_ContTelMovil.Enabled = false;
            txt_ConCorreoElectronico.Enabled = false;
            txt_ConFechaNac.Enabled = false;
            rtb_ConObservaciones.Enabled = false;
            chk_ConActivo.Enabled = false;
            chk_ConPrincipal.Enabled = false;
            
            //dgv_ConContactos.Enabled = false;
            //<--TAB Contactos-->
        }
        private void disable_ArtiTab()
        {
            //<---Tab Carros-> 
            txt_ArtiId.Enabled = false;
            cbo_Arti_TipoArticulo.Enabled = false;
            cbo_ArtiMarca.Enabled = false;
            cbo_ArtiModelo.Enabled = false;
            txt_ArtiColor.Enabled = false;
            txt_ArtiAno.Enabled = false;
            txt_ArtiMotor.Enabled = false;
            txt_ArtiCilindros.Enabled = false;
            txt_ArtiSerialMotor.Enabled = false;
            txt_ArtiSerialChasis.Enabled = false;
            txt_ArtiOrigen.Enabled = false;
            txt_ArtiTransmision.Enabled = false;
            txt_ArtiCombustible.Enabled = false;
            rtb_ArtiDescripcion.Enabled = false;
            txt_ArtiPlaca.Enabled = false;
            
            chk_ArtiEstaActivo.Enabled = false;
            txt_ArtiCilindros.Enabled = false;
            
            //<---Tab Carros->
        }
        private void disable_DirTab()
        {
            //<--TAB Direcciones-->
            txt_DirId.Enabled = false;
            txt_DirNombre.Enabled = false;
            txt_DirDireccion1.Enabled = false;
            txt_DirDireccion2.Enabled = false;
            txt_DirCodigoPostal.Enabled = false;
            cbo_DirPais.Enabled = false;
            cbo_DirEstado.Enabled = false;
            rtb_DirObservacion.Enabled = false;
            chk_DirEsActiva.Enabled = false;
            chk_DirEsDefault.Enabled = false;            
            //<--TAB Direcciones-->
        }
        private void enable_all_controls()
        {
            //<*--   TAB General-->
            //txt_IdSocio.Enabled = true;
            txt_Nombre.Enabled = true;
            cbo_Grupo.Enabled = true;
            cbo_Tipo.Enabled = true;
            txt_Telefono1.Enabled = true;
            txt_Telefono2.Enabled = true;
            txt_Fax.Enabled = true;
            txt_Email.Enabled = true;
            txt_Nit.Enabled = true;
            rtb_Observaciones.Enabled = true;
            chk_ConActivo.Enabled = true;
            //<-- fin-->
        }
        private void enable_ConTab()
        {
            //<--TAB Contactos-->
            //txt_ConId.Enabled = true;
            txt_ConPosicion.Enabled = true;
            txt_ConTitulo.Enabled = true;
            txt_ConNombre1.Enabled = true;
            txt_ConNombre2.Enabled = true;
            txt_ConApellido1.Enabled = true;
            txt_ConApellido2.Enabled = true;
            txt_ContTel1.Enabled = true;
            txt_ContTel2.Enabled = true;
            txt_ContTelMovil.Enabled = true;
            txt_ConCorreoElectronico.Enabled = true;
            txt_ConFechaNac.Enabled = true;
            rtb_ConObservaciones.Enabled = true;
            chk_ConActivo.Enabled = true;            
            chk_ConPrincipal.Enabled = true;
            //<--TAB Contactos-->
        }
        private void enable_ArtiTab()
        {
            //<---Tab Carros-> 
            //txt_ArtiId.Enabled = true;
            cbo_Arti_TipoArticulo.Enabled = true;
            cbo_ArtiMarca.Enabled = true;
            cbo_ArtiModelo.Enabled = true;
            txt_ArtiColor.Enabled = true;
            txt_ArtiAno.Enabled = true;
            txt_ArtiMotor.Enabled = true;
            txt_ArtiCilindros.Enabled = true;
            txt_ArtiSerialMotor.Enabled = true;
            txt_ArtiSerialChasis.Enabled = true;
            txt_ArtiOrigen.Enabled = true;
            txt_ArtiTransmision.Enabled = true;
            txt_ArtiCombustible.Enabled = true;
            rtb_ArtiDescripcion.Enabled = true;            
            chk_ArtiEstaActivo.Enabled = true;
            txt_ArtiCilindros.Enabled = true;
            txt_ArtiPlaca.Enabled = true;
            //<---Tab Carros->
        }
        private void enable_DirTab()
        {
            //<--TAB Direcciones-->
            ////txt_DirId.Enabled = true;
            txt_DirNombre.Enabled = true;
            txt_DirDireccion1.Enabled = true;
            txt_DirDireccion2.Enabled = true;
            txt_DirCodigoPostal.Enabled = true;
            cbo_DirPais.Enabled = true;
            cbo_DirEstado.Enabled = true;
            chk_DirEsActiva.Enabled = true;
            chk_DirEsDefault.Enabled = true;
            rtb_DirObservacion.Enabled = true;
           // this.fill_Estados(int.Parse(cbo_DirPais.SelectedValue.ToString()));
            //<--TAB Direcciones-->

        }
        private void clear_all_controls()
        {
            _SocioForma = null;  
            this.Clear_TabGeneral();
            this.Clear_TabContactos("all");
            this.Clear_TabArticulos("all");
            this.Clear_TabDirecciones("all");
        }
        public void Clear_TabGeneral()
        {
            //<*--   TAB General-->
            txt_IdSocio.Text = "";
            txt_Nombre.Text = "";
            cbo_Grupo.Text = "";
            cbo_Tipo.Text = "";
            txt_Telefono1.Text = "";
            txt_Telefono2.Text = "";
            txt_Fax.Text = "";
            txt_Email.Text = "";
            txt_Nit.Text = "";
            rtb_Observaciones.Text = "";
            chk_ClienteActivo.Checked = false;
            //<-- fin-->
        }
        public void Clear_TabContactos(string descripcion)
        {
            if (descripcion == "all")
            {
                //<--TAB Contactos-->
                txt_ConId.Text = "";
                txt_ConPosicion.Text = "";
                txt_ConTitulo.Text = "";
                txt_ConNombre1.Text = "";
                txt_ConNombre2.Text = "";
                txt_ConApellido1.Text = "";
                txt_ConApellido2.Text = "";
                txt_ContTel1.Text = "";
                txt_ContTel2.Text = "";
                txt_ContTelMovil.Text = "";
                txt_ConCorreoElectronico.Text = "";
                txt_ConFechaNac.Text = "";
                rtb_ConObservaciones.Text = "";
                chk_ConActivo.Checked = false;
                chk_ConPrincipal.Checked = false;                
                dgv_ConContactos.Rows.Clear();
                //<--TAB Contactos-->
                string[] ContactoDesplegar = new string[5];                
                ContactoDesplegar[0] = "X";
                ContactoDesplegar[1] = "Agregar Nuevo";
                dgv_ConContactos.Rows.Add(ContactoDesplegar);
            }
            else
            {
                //<--TAB Contactos-->
                txt_ConId.Text = "";
                txt_ConPosicion.Text = "";
                txt_ConTitulo.Text = "";
                txt_ConNombre1.Text = "";
                txt_ConNombre2.Text = "";
                txt_ConApellido1.Text = "";
                txt_ConApellido2.Text = "";
                txt_ContTel1.Text = "";
                txt_ContTel2.Text = "";
                txt_ContTelMovil.Text = "";
                txt_ConCorreoElectronico.Text = "";
                txt_ConFechaNac.Text = "";
                rtb_ConObservaciones.Text = "";
                chk_ConActivo.Checked = false;
                chk_ConPrincipal.Checked = false;
                //<--TAB Contactos-->
            }

        }        
        public void Clear_TabDirecciones(string descripcion)
        {
            if (descripcion == "all")
            {
                //<--TAB Direcciones-->
                txt_DirId.Text = "";
                txt_DirNombre.Text = "";
                txt_DirDireccion1.Text = "";
                txt_DirDireccion2.Text = "";
                txt_DirCodigoPostal.Text = "";
                cbo_DirPais.Text = "";
                cbo_DirEstado.Text = "";
                chk_DirEsActiva.Checked = false;
                chk_DirEsDefault.Checked = false;
                rtb_DirObservacion.Text = "";
                dgv_DirListaDirecciones.Rows.Clear();
               
                //<--TAB Direcciones-->

                string[] DireccionesDesplegar = new string[5];
                //dgv_DirListaDirecciones.Columns.Add("col_IdDireccion", "Id");
                //dgv_DirListaDirecciones.Columns[0].Visible = false;
                //dgv_DirListaDirecciones.Columns.Add("col_NombreDireccion", "Direccion");
                //dgv_DirListaDirecciones.Columns[1].ReadOnly = true;
                DireccionesDesplegar[0] = "X";
                DireccionesDesplegar[1] = "Agregar Nuevo";
                dgv_DirListaDirecciones.Rows.Add(DireccionesDesplegar);

            }
            else
            {
                //< --TAB Direcciones-- >
                 txt_DirId.Text = "";
                txt_DirNombre.Text = "";
                txt_DirDireccion1.Text = "";
                txt_DirDireccion2.Text = "";
                txt_DirCodigoPostal.Text = "";
                cbo_DirPais.Text = "";
                cbo_DirEstado.Text = "";
                rtb_DirObservacion.Text = "";
                chk_DirEsActiva.Checked = false;
                chk_DirEsDefault.Checked = false;                
                //<--TAB Direcciones-->
            }

        }
        public void Clear_TabArticulos(string descripcion)
        {
            if (descripcion == "all")
            {
                //<---Tab Carros-> 
                txt_ArtiId.Text = "";
                cbo_Arti_TipoArticulo.Text = "";
                cbo_ArtiMarca.Text = "";
                cbo_ArtiModelo.Text = "";
                txt_ArtiColor.Text = "";
                txt_ArtiAno.Text = "";
                txt_ArtiMotor.Text = "";
                txt_ArtiCilindros.Text = "";
                txt_ArtiSerialMotor.Text = "";
                txt_ArtiSerialChasis.Text = "";
                txt_ArtiOrigen.Text = "";
                txt_ArtiTransmision.Text = "";
                txt_ArtiCombustible.Text = "";
                rtb_ArtiDescripcion.Text = "";
                txt_ArtiCilindros.Text = "";
                txt_ArtiPlaca.Text = "";
                
                chk_ArtiEstaActivo.Checked = false;
                dgv_ArtiListaArticulos.Rows.Clear();
                //<---Tab Carros->
                string[] CarroDatagrid = new string[5];

                //dgv_ArtiListaArticulos.Columns.Add("col_IdArticulo", "IdArticulo");
                //dgv_ArtiListaArticulos.Columns[0].Visible = false;
                //dgv_ArtiListaArticulos.Columns.Add("col_ArtiNombre", "Carros");
                //dgv_ArtiListaArticulos.Columns[1].ReadOnly = true;
                CarroDatagrid[0] = "X";
                CarroDatagrid[1] = "Agregar Nuevo";
                dgv_ArtiListaArticulos.Rows.Add(CarroDatagrid);
            }
            else
            {
                //<---Tab Carros-> 
                txt_ArtiId.Text = "";
                cbo_Arti_TipoArticulo.Text = "";
                cbo_ArtiMarca.Text = "";
                cbo_ArtiModelo.Text = "";
                txt_ArtiColor.Text = "";
                txt_ArtiAno.Text = "";
                txt_ArtiMotor.Text = "";
                txt_ArtiCilindros.Text = "";
                txt_ArtiSerialMotor.Text = "";
                txt_ArtiSerialChasis.Text = "";
                txt_ArtiOrigen.Text = "";
                txt_ArtiTransmision.Text = "";
                txt_ArtiCombustible.Text = "";
                rtb_ArtiDescripcion.Text = "";
                txt_ArtiCilindros.Text = "";
                txt_ArtiPlaca.Text = "";
                chk_ArtiEstaActivo.Checked = false;

                //<---Tab Carros->
            }

        }

        //
        //public TipoArticulo ArticuloCliente()
        //{



        //    return ArticuloCliente.;
        //}
        //
        /// <param name="ClienteEnviado"></param>
        // Despliega la informacion en la forma
        public void desplegarCliente (Socios ClienteEnviado)
        {
            //<---Llenado de TAB de Generales->
            
            txt_IdSocio.Text = ClienteEnviado.Id_Socio.ToString();
            txt_Nombre.Text = ClienteEnviado.Nombre;
            cbo_Tipo.SelectedValue = ClienteEnviado.TiposSocio.Id_TipoSocio.ToString();
            cbo_Grupo.SelectedValue = ClienteEnviado.GrupoClientes.Id.ToString();
            
            txt_Telefono1.Text = ClienteEnviado.Telefono1;
            txt_Telefono2.Text = ClienteEnviado.Telefono2;
            txt_Fax.Text = ClienteEnviado.Fax;
            txt_Email.Text = ClienteEnviado.Email;            
            txt_Nit.Text = ClienteEnviado.NumeroDeTributacion ;
            rtb_Observaciones.Text = ClienteEnviado.Observaciones;
            chk_ClienteActivo.Checked = ClienteEnviado.EstaActivo;
            //<---Llenado de TAB de Generales->

            //<---INICIO Llenado de TAB de Direcciones->
            this.llenarTabDirecciones(ClienteEnviado);
            //<---FIN Llenado de TAB de Direcciones->

            //<---INICIO Llenado de TAB de Contactos->
            this.llenarTabContactos(ClienteEnviado);
            //<---FIN Llenado de TAB de Contactos->

            //<---Llenado de TAB de Articulos->     
            this.llenarTabCarros(ClienteEnviado);
            //<---Llenado de TAB de Articulos->

            this.disable_all_controls();
        }

       //DESPLIEGA INFORMACION DEN EL TAB DE DIRECCIONES 
        private void llenarTabDirecciones(Socios clienteRecibido)
        {
            string[] DireccionesDesplegar = new string[5];
            if (clienteRecibido.Direcciones != null)
            {
                foreach (Direccion direccion in clienteRecibido.Direcciones)
                {
                    DireccionesDesplegar[0] = direccion.Id_Direccion.ToString();
                    DireccionesDesplegar[1] = direccion.Nombre;

                    dgv_DirListaDirecciones.Rows.Add(DireccionesDesplegar);
                }
            }
        }

        //DESPLIEGA INFORMACION EN EL TAB DE CONTACTOS
        private void llenarTabContactos(Socios clienteRecibido)
        {
            string[] ContactosDesplegar = new string[5];
            if (clienteRecibido.Contactos != null)
            {
                foreach (Contacto contacto in clienteRecibido.Contactos)
                {
                    ContactosDesplegar[0] = contacto.Id_Contacto.ToString();
                    ContactosDesplegar[1] = contacto.Posicion + " "+contacto.Nombre + " "+ contacto.Apellido;
                    dgv_ConContactos.Rows.Add(ContactosDesplegar);                    
                }
            }
        }

        //DESPLIEGA INFORMACION EN EL TAB DE CARROS
        private void llenarTabCarros(Socios clienteRecibido)
        {
            string[] ArticuloDesplegar = new string[5];
            if (clienteRecibido.ArticuloClientes != null)
            {
                foreach (ArticuloCliente Articulo in clienteRecibido.ArticuloClientes)
                {
                    ArticuloDesplegar[0] = Articulo.Id_ArticuloCliente.ToString();
                    ArticuloDesplegar[1] = /*Articulo.Marca.Nombre + " " + Articulo.Modelo.Nombre + " " + */Articulo.Año+ " " + Articulo.Color;
                    dgv_ArtiListaArticulos.Rows.Add(ArticuloDesplegar);
                    
                }
            }
        }
        //
       
        private void dgv_DirListaDirecciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_SocioForma == null)
            {
                MessageBox.Show("Tienes que grabar primero el cliente para adicionar direcciones");
            }
            else
            {
                this.enable_DirTab();
                if (e.RowIndex<0)
                {
                    MessageBox.Show("Selecciona una direccion");
                } else
                {
                    if (dgv_DirListaDirecciones.Rows[e.RowIndex].Cells[0].Value.ToString() == "X")
                    {
                        this.Clear_TabDirecciones("");
                        this.fill_Paises();
                       // this.enable_DirTab();
                        this.DirDireccionNueva = true;
                    }
                    else
                    {
                        this.disable_DirTab();
                        var idDireccion = int.Parse(dgv_DirListaDirecciones.Rows[e.RowIndex].Cells[0].Value.ToString());
                       

                        //Direccion direccionObjetivo2 = _contexto.Direcciones.FirstOrDefault(c => c.Id_Direccion == idDireccion);
                        Direccion direccionObjetivo = _contexto.Direcciones
                            .Include(d => d.Estado)                            
                            .Include(d => d.Pais)
                            .FirstOrDefault(d => d.Id_Direccion == idDireccion);
                        this.fill_Estados(direccionObjetivo.Pais.Id_Pais);
                        if (direccionObjetivo != null)
                        {
                            this.fill_Paises();
                            this.fill_Estados(direccionObjetivo.Pais.Id_Pais);
                            txt_DirId.Text = direccionObjetivo.Id_Direccion.ToString();
                            txt_DirNombre.Text = direccionObjetivo.Nombre;
                            txt_DirDireccion1.Text = direccionObjetivo.Direccion1;
                            txt_DirDireccion2.Text = direccionObjetivo.Direccion2;
                            chk_DirEsActiva.Checked = direccionObjetivo.EstaActiva;
                            chk_DirEsDefault.Checked = direccionObjetivo.EsDefault;
                            rtb_DirObservacion.Text = direccionObjetivo.Observaciones;
                            txt_DirCodigoPostal.Text = direccionObjetivo.CodigoPostal;
                            cbo_DirPais.SelectedValue = direccionObjetivo.Pais.Id_Pais.ToString();
                            cbo_DirEstado.SelectedValue = direccionObjetivo.Estado.Id_Estado.ToString();
                           
                               


                        }
                        this.DirDireccionNueva = false;
                    }

                }
                            
            }            
        }
        private void dgv_ConContactos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_SocioForma == null)
            {
                MessageBox.Show("Tienes que grabar primero el cliente para adicionar Contactos");
            }
            else
            {
                this.enable_ConTab();
                
                if (e.RowIndex < 0)
                {
                    MessageBox.Show("Selecciona un Carro");
                }
                else

                {
                    this.enable_ConTab();
                    if (dgv_ConContactos.Rows[e.RowIndex].Cells[0].Value.ToString() == "X")
                    {
                        this.Clear_TabContactos("");
                      
                        this.ConContactoNuevo = true;


                    }
                    else
                    {
                        var idContacto = int.Parse(dgv_ConContactos.Rows[e.RowIndex].Cells[0].Value.ToString());
                        Contacto contactoObjetivo = _contexto.Contactos.FirstOrDefault(c => c.Id_Contacto == idContacto);
                        if (contactoObjetivo != null)
                        {

                            txt_ConId.Text = contactoObjetivo.Id_Contacto.ToString();
                            txt_ConPosicion.Text = contactoObjetivo.Posicion;
                            txt_ConTitulo.Text = contactoObjetivo.Titulo;
                            txt_ConNombre1.Text = contactoObjetivo.Nombre;
                            txt_ConNombre2.Text = contactoObjetivo.SegundoNombre;
                            txt_ConApellido1.Text = contactoObjetivo.Apellido;
                            txt_ConApellido2.Text = contactoObjetivo.SegundoApellido;
                            txt_ContTel1.Text = contactoObjetivo.Telefono1;
                            txt_ContTel2.Text = contactoObjetivo.Telefono2;
                            txt_ContTelMovil.Text = contactoObjetivo.TelefonoMovil;
                            txt_ConCorreoElectronico.Text = contactoObjetivo.CorreoElectronico;
                            txt_ConFechaNac.Text = contactoObjetivo.FechaNacimiento;
                            rtb_ConObservaciones.Text = contactoObjetivo.Observaciones;
                            chk_ConActivo.Checked = contactoObjetivo.EstaActivo;
                            chk_ConPrincipal.Checked = contactoObjetivo.EsPrincipal;
                        }
                        this.ConContactoNuevo = false;

                    }


                }


            }

        }
        private void dgv_ArtiListaArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_SocioForma == null)
            {
                MessageBox.Show("Tienes que grabar primero el cliente para adicionar Carros");
            }
            else
            {

                
                //this.enable_ArtiTab();
                if (e.RowIndex < 0)
                {
                    MessageBox.Show("Selecciona un contacto");
                }
                else
                {
                    this.enable_ArtiTab();
                    if (dgv_ArtiListaArticulos.Rows[e.RowIndex].Cells[0].Value.ToString() == "X")
                    {
                        this.Clear_TabArticulos("");
                        this.fill_TipoArticulos();
                        this.ArtiArticuloNuevo = true;
                        //cbo_ArtiMarca.Enabled = false;
                        this.fill_Marcas(cbo_Arti_TipoArticulo.SelectedIndex);
                        this.fill_Modelos(cbo_ArtiMarca.SelectedIndex);


                    }
                    else
                    {
                        var idCarro = int.Parse(dgv_ArtiListaArticulos.Rows[e.RowIndex].Cells[0].Value.ToString());
                      
                        ArticuloCliente articuloObjetivo = _contexto.ArticuloClientes
                            .Include(a=>a.TipoArticulo)
                            .Include(a => a.Marca)
                            .Include(a => a.Modelo)
                            .FirstOrDefault(a=>a.Id_ArticuloCliente==idCarro);
                        this.fill_TipoArticulos();
                        if (articuloObjetivo != null)
                        {

                            this.disable_ArtiTab();
                            txt_ArtiId.Text = idCarro.ToString() ;
                            txt_ArtiPlaca.Text = articuloObjetivo.Placa;
                            this.fill_TipoArticulos();
                            cbo_Arti_TipoArticulo.SelectedValue =articuloObjetivo.TipoArticulo.Id_TipoArticulo.ToString();
                 
                            //cbo_Arti_TipoArticulo.SelectedValue = "6";
                            this.fill_Marcas(int.Parse(articuloObjetivo.TipoArticulo.Id_TipoArticulo.ToString()));
                            cbo_ArtiMarca.SelectedValue = articuloObjetivo.Marca.Id_Marca.ToString();
                            this.fill_Modelos(int.Parse(articuloObjetivo.Marca.Id_Marca.ToString()));
                            cbo_ArtiModelo.SelectedValue = articuloObjetivo.Modelo.Id_Modelo.ToString();
                          //  cbo_ArtiMarca.SelectedValue = articuloObjetivo.TipoArticulo.Id_TipoArticulo;
                            //cbo_Arti_TipoArticulo.Text = "";
                            //cbo_ArtiMarca.Text = "";
                            //cbo_ArtiModelo.Text = "";
                            txt_ArtiColor.Text = articuloObjetivo.Color;
                            txt_ArtiAno.Text = articuloObjetivo.Año.ToString();
                            txt_ArtiMotor.Text = articuloObjetivo.Motor;
                            txt_ArtiCilindros.Text = articuloObjetivo.NumCilindros;
                            txt_ArtiSerialMotor.Text = articuloObjetivo.SerialMotor;
                            txt_ArtiSerialChasis.Text = articuloObjetivo.SerialChasis;
                            txt_ArtiOrigen.Text = articuloObjetivo.Origen;
                            txt_ArtiTransmision.Text = articuloObjetivo.Transmision ;
                            txt_ArtiCombustible.Text = articuloObjetivo.Combustible;
                            chk_ArtiEstaActivo.Checked = articuloObjetivo.EstaActivo;
                            rtb_ArtiDescripcion.Text = articuloObjetivo.Descripcion;
                            //this.enable_ArtiTab();

                        }
                        this.ArtiArticuloNuevo = false;

                    }


                }


            }

        }

        // BOTON EN TAB DIRECCIONES - GRABA DIRECCIONES  DE SOCIO
        private void btn_DirGrabarDir_Click(object sender, EventArgs e)
        {

            if (this.DirDireccionNueva)
            {
                int IdPaisCliente = int.Parse(cbo_DirPais.SelectedValue.ToString());
                var PaisEnviadoCliente = _contexto.Paises.FirstOrDefault(p=>p.Id_Pais==IdPaisCliente);

                int IdEstado = int.Parse(cbo_DirEstado.SelectedValue.ToString());
                var EstadoEnviadoCliente  = _contexto.Estados.FirstOrDefault(es=>es.Id_Estado==IdEstado);

           
                Direccion NewDireccion = new Direccion()
                {
                    Nombre = txt_DirNombre.Text,
                    Direccion1 = txt_DirDireccion1.Text,
                    Direccion2 = txt_DirDireccion2.Text,
                    CodigoPostal = txt_DirCodigoPostal.Text,
                    Pais = PaisEnviadoCliente,
                    Estado =EstadoEnviadoCliente,
                    EstaActiva = chk_DirEsActiva.Checked,
                    EsDefault = chk_DirEsDefault.Checked,
                    Observaciones = rtb_DirObservacion.Text
                };
                //_SocioForma.Direcciones.Add(NewDireccion);
                //_contexto.SaveChanges();
                //this.Clear_TabDirecciones("all");
                //llenarTabDirecciones(_SocioForma);
                //this.disable_DirTab();

                
                 var IdSocio = int.Parse(txt_IdSocio.Text);
                _SocioForma = _contexto.Socios.Include(s => s.Direcciones).FirstOrDefault(s => s.Id_Socio == IdSocio);
                _SocioForma.Direcciones.Add(NewDireccion);                
                _contexto.SaveChanges();
                this.Clear_TabArticulos("all");
                llenarTabDirecciones(_SocioForma);
                this.disable_DirTab();

            }
            else
            {
                var idDireccion = int.Parse(txt_DirId.Text);
                var DireccionModifica = _contexto.Direcciones.SingleOrDefault(d => d.Id_Direccion == idDireccion);
                DireccionModifica.Nombre = txt_DirNombre.Text;
                DireccionModifica.Direccion1 = txt_DirDireccion1.Text;
                DireccionModifica.Direccion2 = txt_DirDireccion2.Text;
                DireccionModifica.CodigoPostal = txt_DirCodigoPostal.Text;
                DireccionModifica.EstaActiva = chk_DirEsActiva.Checked;
                DireccionModifica.EsDefault = chk_DirEsDefault.Checked;
                DireccionModifica.Observaciones = rtb_DirObservacion.Text;

                _contexto.SaveChanges();
                this.Clear_TabDirecciones("all");
                llenarTabDirecciones(_SocioForma);
                this.disable_DirTab();
            }
        }

        // BOTON EN TAB CONTACTOS - GRABA CONTACTO DE SOCIO
        private void btn_ConGrabarCon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("el id del cliente es:" + _SocioForma.Id_Socio.ToString());

            if (this.ConContactoNuevo)
            {
                Contacto newContacto = new Contacto()
                {
                    
                    Posicion = txt_ConPosicion.Text,
                    Titulo = txt_ConTitulo.Text,
                    Nombre = txt_ConNombre1.Text,
                    SegundoNombre = txt_ConNombre2.Text,
                    Apellido = txt_ConApellido1.Text,
                    SegundoApellido = txt_ConApellido2.Text, 
                    Telefono1 = txt_ContTel1.Text,
                    Telefono2 = txt_ContTel2.Text,
                    TelefonoMovil = txt_ContTelMovil.Text,
                    CorreoElectronico = txt_ConCorreoElectronico.Text,
                    FechaNacimiento = txt_ConFechaNac.Text,
                    Observaciones = rtb_ConObservaciones.Text, 
                    EstaActivo = chk_ConActivo.Checked,
                    EsPrincipal = chk_ConPrincipal.Checked,
                    
                };

                var IdSocio = int.Parse(txt_IdSocio.Text);
                _SocioForma = _contexto.Socios.Include(d => d.Contactos).SingleOrDefault(d=>d.Id_Socio==IdSocio);
         
              
                _SocioForma.Contactos.Add(newContacto);
                _contexto.SaveChanges();
                this.Clear_TabContactos("all");
                llenarTabContactos(_SocioForma);
                this.disable_ConTab();
             

            }
            else
            {
                var idContacto = int.Parse(txt_ConId.Text);
                var ContactoModifica = _contexto.Contactos.SingleOrDefault(c => c.Id_Contacto == idContacto);
                ContactoModifica.Posicion = txt_ConPosicion.Text;
                ContactoModifica.Titulo = txt_ConTitulo.Text;
                ContactoModifica.Nombre = txt_ConNombre1.Text;
                ContactoModifica.SegundoNombre = txt_ConNombre2.Text;
                ContactoModifica.Apellido = txt_ConApellido1.Text;
                ContactoModifica.SegundoApellido = txt_ConApellido2.Text;
                ContactoModifica.Telefono1 = txt_ContTel1.Text;
                ContactoModifica.Telefono2 = txt_ContTel2.Text;
                ContactoModifica.TelefonoMovil = txt_ContTelMovil.Text;
                ContactoModifica.CorreoElectronico = txt_ConCorreoElectronico.Text;
                ContactoModifica.FechaNacimiento = txt_ConFechaNac.Text;
                ContactoModifica.Observaciones = rtb_ConObservaciones.Text;
                ContactoModifica.EstaActivo = chk_ConActivo.Checked;
                ContactoModifica.EsPrincipal = chk_ConPrincipal.Checked;
                _contexto.SaveChanges();
                this.Clear_TabContactos("all");
                llenarTabContactos(_SocioForma);
                this.disable_ConTab();
            }
        }

        //BOTON EN TAB CARRO - GRABAR CARRO DE SOCIO
        private void btn_ArtiGrabarArti_Click(object sender, EventArgs e)
        {
            _contexto.Dispose();
            _contexto = new DB_Context();

            if (this.ArtiArticuloNuevo)
            {
                int IdArticuloCliente = int.Parse(cbo_Arti_TipoArticulo.SelectedValue.ToString());
                var TipoArticuloEnviado = _contexto.TipoArticulos.FirstOrDefault(ar=>ar.Id_TipoArticulo==IdArticuloCliente);
                int IdArticoMarcaEnviadio = int.Parse(cbo_ArtiMarca.SelectedValue.ToString());
                var ArticoMarcaEnviadio = _contexto.Marcas.FirstOrDefault(m=>m.Id_Marca==IdArticoMarcaEnviadio);
                int IdArticoMarcaModeloEnviadio = int.Parse(cbo_ArtiModelo.SelectedValue.ToString());
                var ArticoMarcaModeloEnviadio = _contexto.Modelos.FirstOrDefault(mo => mo.Id_Modelo==IdArticoMarcaModeloEnviadio);
                var articuloCliente = new ArticuloCliente
                {


                   TipoArticulo=TipoArticuloEnviado,
                   Marca=ArticoMarcaEnviadio,
                   Modelo=ArticoMarcaModeloEnviadio,
                   Placa = txt_ArtiPlaca.Text,
                    Color = txt_ArtiColor.Text,
                    Año = int.Parse(txt_ArtiAno.Text),
                    Motor = txt_ArtiMotor.Text,
                    NumCilindros = txt_ArtiCilindros.Text,
                    SerialMotor = txt_ArtiSerialMotor.Text,
                    SerialChasis = txt_ArtiSerialChasis.Text,
                    Origen = txt_ArtiOrigen.Text,
                    Transmision = txt_ArtiTransmision.Text,
                    Combustible = txt_ArtiCombustible.Text,
                    EstaActivo = chk_ArtiEstaActivo.Checked,
                    Descripcion = rtb_ArtiDescripcion.Text,
                   





                };
                var IdSocio = int.Parse(txt_IdSocio.Text);
                _SocioForma = _contexto.Socios.Include(s => s.ArticuloClientes).FirstOrDefault(s => s.Id_Socio == IdSocio);
                _SocioForma.ArticuloClientes.Add(articuloCliente);                
                _contexto.SaveChanges();
                this.Clear_TabArticulos("all");
                llenarTabCarros(_SocioForma);
                this.disable_ArtiTab();


            }
            else
            {
                var idArticulo = int.Parse(txt_ArtiId.Text);
                var ArticuloModifica = _contexto.ArticuloClientes.SingleOrDefault(a => a.Id_ArticuloCliente == idArticulo);
                ArticuloModifica.Placa = txt_ArtiPlaca.Text;
               //cbo_Arti_TipoArticulo.Text = "";
                //cbo_ArtiMarca.Text = "";
                //cbo_ArtiModelo.Text = "";
                ArticuloModifica.Color = txt_ArtiColor.Text;
                ArticuloModifica.Año = int.Parse(txt_ArtiAno.Text);
                ArticuloModifica.Motor = txt_ArtiMotor.Text;
                ArticuloModifica.NumCilindros = txt_ArtiCilindros.Text;
                ArticuloModifica.SerialMotor = txt_ArtiSerialMotor.Text;
                ArticuloModifica.SerialChasis = txt_ArtiSerialChasis.Text;
                ArticuloModifica.Origen = txt_ArtiOrigen.Text;
                ArticuloModifica.Transmision = txt_ArtiTransmision.Text;
                ArticuloModifica.Combustible = txt_ArtiCombustible.Text;
                ArticuloModifica.EstaActivo = chk_ArtiEstaActivo.Checked;
                ArticuloModifica.Descripcion = rtb_ArtiDescripcion.Text;
                _contexto.SaveChanges();
                this.Clear_TabArticulos("all");
                llenarTabCarros(_SocioForma);
                this.disable_ArtiTab();
            }
        }

        //PROCEDIMIENTO PARA OBTENCION DE TIPOS DE SOCIOS

        private void fill_TipoSocios()
        {
            Dictionary<string, string> TipoSocio = new Dictionary<string, string>();
            TipoSocio.Add("X","Crear Nuevo");
            _contexto.Dispose();
            _contexto = new DB_Context();
            
            var Tipos = _contexto.TipoSocios.ToList().Where(ts => ts.EstaActivo == true);
            
            
            
            if (Tipos != null)
            {
                foreach (var Tipo in Tipos)
                {
                    TipoSocio.Add(Tipo.Id_TipoSocio.ToString(),Tipo.Nombre);
                    
                }
            }
            cbo_Tipo.DataSource = null;
            cbo_Tipo.DataSource = new BindingSource(TipoSocio, null);
            cbo_Tipo.DisplayMember = "Value";
            cbo_Tipo.ValueMember = "Key";
        }
        
        private void fill_GrupoSocios()
        {
            Dictionary<string, string> GrupoCliente = new Dictionary<string, string>();
            GrupoCliente.Add("X","Crear Nuevo");
            _contexto.Dispose();
            _contexto = new DB_Context();
            var  Grupos= _contexto.GrupoClientes.ToList().Where(gc => gc.EstaActivo == true);
            
            if (Grupos != null)
            {
                foreach (var Grupo in Grupos)
                {
                    GrupoCliente.Add(Grupo.Id.ToString(),Grupo.Nombre);
                }
            }
            cbo_Grupo.DataSource = null;
            cbo_Grupo.DataSource = new BindingSource(GrupoCliente, null);
            cbo_Grupo.DisplayMember = "Value";
            cbo_Grupo.ValueMember = "Key";
        }

        private void fill_TipoArticulos()
        {
            Dictionary<string, string> TipoArticulos = new Dictionary<string, string>();
            TipoArticulos.Add("X", "Crear nuevo");
            _contexto.Dispose();
            _contexto = new DB_Context();
            var ListadoTipoArticulosDB = _contexto.TipoArticulos.ToList().Where(ta => ta.EstasActivo == true);


            if (ListadoTipoArticulosDB != null)
            {
                foreach(var TipoArticulo in ListadoTipoArticulosDB)
                {
                    TipoArticulos.Add(TipoArticulo.Id_TipoArticulo.ToString(),TipoArticulo.Nombre);
                }
                cbo_Arti_TipoArticulo.DataSource = null;
                cbo_Arti_TipoArticulo.DataSource = new BindingSource(TipoArticulos,null);
                cbo_Arti_TipoArticulo.DisplayMember = "Value";
                cbo_Arti_TipoArticulo.ValueMember = "Key";
            }
            string[] ListadoArticulos = new string[5];
            foreach (var TipoArticulo in ListadoTipoArticulosDB)
            {
                ListadoArticulos[0] = TipoArticulo.Id_TipoArticulo.ToString();
                ListadoArticulos[1] = TipoArticulo.Nombre;

            }

        }
        // Metodo para llenar el combobox de marcas 
        private void fill_Marcas( int IdArticulo)
        {
            Dictionary<string, string> Marca = new Dictionary<string, string>();
            Marca.Add("X", "Crear nuevo");
           _contexto.Dispose();
            _contexto = new DB_Context();
          
            //  var ListadoMarcasDB = _contexto.Marcas.ToList().Where(marca => marca.EstasActivo == true );
              var ListadoMarcasDB = _contexto.Marcas.Include(t=>t.TipoArticulo).ToList().Where(m => m.TipoArticulo.Id_TipoArticulo==IdArticulo && m.EstasActivo==true);
           
            if (ListadoMarcasDB != null)
            {
                foreach (var marcas in ListadoMarcasDB)
                {
                    Marca.Add(marcas.Id_Marca.ToString(),marcas.Nombre);

                }
                cbo_ArtiMarca.DataSource = null;
                cbo_ArtiMarca.DataSource = new BindingSource(Marca, null);
                cbo_ArtiMarca.DisplayMember = "Value";
                cbo_ArtiMarca.ValueMember = "Key";


            }
            string[] ListadoMarcas = new string[5];
            foreach (var ListaMarcas in ListadoMarcasDB)
            {
                ListadoMarcas[0] = ListaMarcas.ToString();
                ListadoMarcas[1] = ListaMarcas.Nombre;

            }

        }
        //-----------------------------------------------
        // Metodo para llenar el combobox de modelos 
        private void fill_Modelos(int IdMarca)
        {
            Dictionary<string, string> Modelo = new Dictionary<string, string>();
            Modelo.Add("X", "Crear nuevo");
            _contexto.Dispose();
            _contexto = new DB_Context();

            //  var ListadoMarcasDB = _contexto.Marcas.ToList().Where(marca => marca.EstasActivo == true );
            var ListadoModelosDB = _contexto.Modelos.Include(m => m.Marca).ToList().Where(mo => mo.Marca.Id_Marca == IdMarca && mo.EstasActivo == true);
            if (ListadoModelosDB != null)
            {
                foreach (var modelos in ListadoModelosDB)
                {
                    Modelo.Add(modelos.Id_Modelo.ToString(),modelos.Nombre);

                }
             
                 cbo_ArtiModelo.DataSource = null;
                cbo_ArtiModelo.DataSource = new BindingSource(Modelo, null);
                cbo_ArtiModelo.DisplayMember = "Value";
                cbo_ArtiModelo.ValueMember = "Key";


            }
            string[] ListadoModelos = new string[5];
            foreach (var ListaModelos in ListadoModelosDB)
            {
                ListadoModelos[0] = ListaModelos.ToString();
                ListadoModelos[1] = ListaModelos.Nombre;

            }

        }
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //metodo para llenar combobox de Pais
        private void fill_Paises()
        {
            Dictionary<string, string> Pais = new Dictionary<string, string>();
            Pais.Add("X", "Crear nuevo");
            _contexto.Dispose();
            _contexto = new DB_Context();
            var ListadoPaisDB = _contexto.Paises.ToList().Where(p => p.EstaActiva == true);

            if (ListadoPaisDB != null)
            {
                foreach (var Paises in ListadoPaisDB)
                {
                    Pais.Add(Paises.Id_Pais.ToString(),Paises.Nombre);
                }
                cbo_DirPais.DataSource = null;
                cbo_DirPais.DataSource=new BindingSource(Pais, null);
                cbo_DirPais.DisplayMember = "Value";
                cbo_DirPais.ValueMember = "Key";
            }
             
            string[] ListadoPaises = new string[5];
            foreach (var pais in ListadoPaisDB)

            {
                ListadoPaises[0] = pais.Id_Pais.ToString();
                ListadoPaises[1] = pais.Nombre;
            }
            
        }
        
        
        private void fill_Estados(int IdPais)
        {
            Dictionary<string, string> Estado = new Dictionary<string, string>();
            Estado.Add("X", "Crear nuevo");
            _contexto.Dispose();
            _contexto = new DB_Context();

           
            var ListadoEstadosDB = _contexto.Estados.Include( e=> e.Pais).ToList().Where(e => e.Pais.Id_Pais == IdPais && e.EstaActivo == true);
         
            if (ListadoEstadosDB != null)
            {
                foreach (var estados in ListadoEstadosDB)
                {
                    Estado.Add(estados.Id_Estado.ToString(),estados.Nombre);

                }

                cbo_DirEstado.DataSource = null;
                cbo_DirEstado.DataSource = new BindingSource(Estado, null);
                cbo_DirEstado.DisplayMember = "Value";
                cbo_DirEstado.ValueMember = "Key";


            }
            string[] ListadoEstados = new string[5];
            foreach (var ListaModelos in ListadoEstadosDB)
            {
                ListadoEstados[0] = ListaModelos.ToString();
                ListadoEstados[1] = ListaModelos.Nombre;

            }
        }
            //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            private void cbo_Tipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            if (cbo_Tipo.SelectedValue.ToString() == "X")
            {
                using (Wf_TiposSocios WFTS = new Wf_TiposSocios())
                {

                    
                    if (WFTS.ShowDialog() == DialogResult.OK)
                    { 
                        this.fill_TipoSocios();
                   
                    }
                }
               
            }
        }

        private void cbo_Grupo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbo_Grupo.SelectedValue.ToString() == "X")
            {

                // hayq ue cambiar este forma
                using (Wf_GrupoSocio WFGS = new Wf_GrupoSocio())
                {

                    
                    if (WFGS.ShowDialog() == DialogResult.OK)
                    {
                        this.fill_GrupoSocios();
                        
                    }
                }
            }
        }

        private void cbo_Arti_TipoArticulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbo_Arti_TipoArticulo.SelectedValue.ToString() == "X")
            {


                // hayq ue cambiar este forma
                using (WF_TipoArticulos WFTA = new WF_TipoArticulos())
                {


                    if (WFTA.ShowDialog() == DialogResult.OK)
                    {
                        this.fill_TipoArticulos();

                    }
                }
            }
            else
            {
                this.fill_Marcas(Int32.Parse(cbo_Arti_TipoArticulo.SelectedValue.ToString()));
                cbo_ArtiMarca.Text = "";
                cbo_ArtiModelo.Text = "";
            }
        }

        private void cbo_ArtiMarca_SelectionChangeCommitted(object sender, EventArgs e)


        {

            if (cbo_ArtiMarca.SelectedValue.ToString() == "X")
            {
                using (WF_TipoArticulos WFTA = new WF_TipoArticulos())
                {


                    if (WFTA.ShowDialog() == DialogResult.OK)
                    {
                        this.fill_TipoArticulos();

                    }
                }
            }
            else
            {

                this.fill_Modelos(int.Parse(cbo_ArtiMarca.SelectedValue.ToString()));
             
                
            }
        }

        private void cbo_ArtiModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbo_ArtiModelo.SelectedValue.ToString() == "X")
            {
                using (WF_TipoArticulos WFTA = new WF_TipoArticulos())
                {


                    if (WFTA.ShowDialog() == DialogResult.OK)
                    {
                        this.fill_TipoArticulos();

                    }
                }
            }
            else
            {
         
            }
        }

        private void cbo_DirPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbo_DirPais.SelectedValue.ToString() == "X")
            {


                // hayq ue cambiar este forma
                using (Wf_Paises WFTA = new Wf_Paises())
                {


                    if (WFTA.ShowDialog() == DialogResult.OK)
                    {
                        this.fill_Paises();

                    }
                }
            }
            else
            {
                this.fill_Estados(Int32.Parse(cbo_DirPais.SelectedValue.ToString()));
                cbo_DirEstado.Text = "";
                
            }

          
            
        }

        private void cbo_DirEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbo_DirEstado.SelectedValue.ToString() == "X")
            {


                // hayq ue cambiar este forma
                using (Wf_Paises WFTA = new Wf_Paises())
                {


                    if (WFTA.ShowDialog() == DialogResult.OK)
                    {
                        this.fill_Paises();

                    }
                }
            }
            else
            {
                //this.fill_Estados(Int32.Parse(cbo_DirPais.SelectedValue.ToString()));
                //cbo_DirEstado.Text = "";

            }



        }

        private void btn_ActualizarDireccion_Click(object sender, EventArgs e)
        {
            this.enable_DirTab();
        }

        private void btn_ArtiActualizar_Click(object sender, EventArgs e)
        {
            this.enable_ArtiTab();
        }

        private void btn_ConActualizarCon_Click(object sender, EventArgs e)
        {
            this.enable_ConTab();
                
                }
    }
}
