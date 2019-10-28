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
using FinanSoft.Models.Clientes;

namespace FinanSoft.Forms_Clientes
{
    public partial class Wf_Modelos : Form
    {
        public int IDMarca;
        public string NombreMarcaModelo;
        private bool _ModeloNuevo = false;

        private DB_Context _contexto = new DB_Context();
        public Wf_Modelos()
        {
            InitializeComponent();
        }

        private void Wf_Modelos_Load(object sender, EventArgs e)
        {
            //var ListaMarcas = _contexto.Marcas.ToList().Where(m => m.Id_Marca == IdTipoArticulo);
            lbl_Marca.Text = NombreMarcaModelo;
            this.ClearAll("all");
            this.LoadListaModelos();
            this.DisableAll();
            
        }
        private void LoadListaModelos()
        {
            _contexto.Dispose();
            _contexto = new DB_Context();
            var ListaModelos = _contexto.Modelos.Include(m => m.Marca).ToList().Where(m=>m.Marca.Id_Marca==IDMarca); ;
          
            if (ListaModelos != null)
            {
                string[] item = new string[2];
                foreach (var ListModelos in ListaModelos)
                {
                    item[0] = ListModelos.Id_Modelo.ToString();
                    item[1] = ListModelos.Nombre;
                    dgv_ListadoModelos.Rows.Add(item);
                }
            }
        }

        private void btn_ListadoModelos_Click(object sender, EventArgs e)
        {
            this.EnableAll();


        }

        private void btn_GrabarTipo_Click(object sender, EventArgs e)
        {
         
            if (_ModeloNuevo)
            {
            
                _contexto.Dispose();
                _contexto = new DB_Context();
                var MarcaMod = _contexto.Marcas.Include(m => m.Modelos).FirstOrDefault(m=>m.Id_Marca==IDMarca);
              
                var NuevoModelo = new Modelo
                {
                    Nombre = txt_NombreModelo.Text,
                    Descripcion = rtb_Descripcion.Text,
                    EstasActivo = ckb_EstaAciva.Checked,
                    Marca = MarcaMod

                };
                _contexto.Modelos.Add(NuevoModelo);

                _contexto.SaveChanges();
                MessageBox.Show(" Modelo ha sido creado exitosamente");
                this.ClearAll("all");
                this.LoadListaModelos();
               
            }
            else
            {
              
                _contexto.Dispose();
                _contexto = new DB_Context();
                int Idmodelo = int.Parse(txt_IdModelo.Text);
                var ModificarModelo = _contexto.Modelos.FirstOrDefault(t=> t.Id_Modelo==Idmodelo);
                ModificarModelo.Nombre = txt_NombreModelo.Text;
                ModificarModelo.Descripcion= rtb_Descripcion.Text;
                ModificarModelo.EstasActivo= ckb_EstaAciva.Checked;
                _contexto.SaveChanges();
                MessageBox.Show("Exito al actualizar  Modelo");
                this.ClearAll("all");
                this.LoadListaModelos();

              
            }

        }
        ////Funciones::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //funcion para limpiar controles
        private void ClearAll(string tipo)
        {
            if (tipo == "all")
            {
                txt_IdModelo.Text = "";
                txt_NombreModelo.Text = "";
                rtb_Descripcion.Text = "";
                ckb_EstaAciva.Checked = false;
                string[] ListadoModelos = new string[5];
                dgv_ListadoModelos.Rows.Clear();
                ListadoModelos[0] = "X";
                ListadoModelos[1] = "Agregar Nuevo";
                dgv_ListadoModelos.Rows.Add(ListadoModelos);
           
            }
            else
            {
                txt_IdModelo.Text = "";
                txt_NombreModelo.Text = "";
                rtb_Descripcion.Text = "";
                ckb_EstaAciva.Checked = false;

                string[] ListadoPaises = new string[5];
                dgv_ListadoModelos.Rows.Clear();
                ListadoPaises[0] = "X";
                ListadoPaises[1] = "Agregar Nuevo";


            }

        }
        //// funciones para habilitar y sehabilitar controles
        private void EnableAll()
        {
            //txt_Id.Enabled = true;
            txt_NombreModelo.Enabled = true;
            rtb_Descripcion.Enabled = true;
            ckb_EstaAciva.Enabled = true;
            //dgv_ListadoTipos.Rows.Clear();

        }
        private void DisableAll()
        {
           txt_IdModelo.Enabled = false;
           txt_NombreModelo.Enabled = false;
            rtb_Descripcion.Enabled = false;
            ckb_EstaAciva.Enabled = false;


        }

       

        private void dgv_ListadoModelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Selecciona un Tipo");
            }
            else
            {
                
                if (dgv_ListadoModelos.Rows[e.RowIndex].Cells[0].Value.ToString() == "X")
                {
                    MessageBox.Show("Creando el Nuevo Modelo Para la Articulo Marca :"+NombreMarcaModelo.ToString());
                    txt_NombreModelo.Focus();
                    this.EnableAll();
                    this.ClearAll("solo formulario");
                 
                    this.LoadListaModelos();
                    this._ModeloNuevo = true;
                   

                }
                else
                {
                   
                    this.DisableAll();
                    var idModelo = int.Parse(dgv_ListadoModelos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var ModeloMarca = _contexto.Modelos.FirstOrDefault(m => m.Id_Modelo == idModelo);
                    if (ModeloMarca != null)
                    {
                        txt_IdModelo.Text = ModeloMarca.Id_Modelo.ToString();
                        txt_NombreModelo.Text = ModeloMarca.Nombre;
                        rtb_Descripcion.Text = ModeloMarca.Descripcion;
                        ckb_EstaAciva.Checked = ModeloMarca.EstasActivo;

                    }
                    this._ModeloNuevo = false;

                }


            }
        }
    }

        ///::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    
}
