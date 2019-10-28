using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using FinanSoft.Models.Clientes;

namespace FinanSoft.Forms_Clientes
{
    public partial class Wf_Estados : Form
    {  ///Definicion de Varables
        //Variables Publicas
        public int IdPais;
 
        public string NombrePais;
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        //Variables Privadas
        bool _EstadoNuevo = false;
        
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private DB_Context _contexto = new DB_Context();
        public Wf_Estados()
        {
            InitializeComponent();
        }
        //Metodos y Funciones del Programador
        private void Wf_Estados_Load(object sender, EventArgs e)
        {
            lbl_Pais.Text = NombrePais;
            this.ClearAll("all");
            this.LoadListaEstados();
            this.DisableAll();
        }
        private void LoadListaEstados()
        {
            _contexto.Dispose();
            _contexto = new DB_Context();
            //   var ListaMarcas = _contexto.Marcas.Include(m => m.TipoArticulo).ToList().Where(m => m.TipoArticulo.Id_TipoArticulo == IdTipoArticulo);

            var  ListaEstados = _contexto.Estados.Include(y => y.Pais).ToList().Where(e=>e.Pais.Id_Pais==IdPais);
           



            if (ListaEstados != null)
            {
                string[] item = new string[2];
                foreach (var ListEstados in ListaEstados)
                {
                    item[0] = ListEstados.Id_Estado.ToString();
                    item[1] = ListEstados.Nombre;
                    dgv_ListadoEstados.Rows.Add(item);

                }
            }
        }
        private void ClearAll(string tipo)
        {
            if (tipo == "all")
            {
                txt_IdEstados.Text = "";
                txt_NombreEstado.Text = "";
                rtb_DesEstado.Text = "";
               ckb_EstaEstado.Checked = false;
                string[] ListadoEstados = new string[5];
               dgv_ListadoEstados.Rows.Clear();
                ListadoEstados[0] = "X";
                ListadoEstados[1] = "Agregar Nuevo";
                dgv_ListadoEstados.Rows.Add(ListadoEstados);

            }
            else
            {
                txt_IdEstados.Text = "";
                txt_NombreEstado.Text = "";
                rtb_DesEstado.Text = "";
                ckb_EstaEstado.Checked = false;

                
            }

        }

        //// funciones para habilitar y sehabilitar controles
        private void EnableAll()
        {
            //txt_Id.Enabled = true;
           txt_NombreEstado.Enabled = true;
        rtb_DesEstado.Enabled = true;
          ckb_EstaEstado.Enabled = true;
            //dgv_ListadoTipos.Rows.Clear();

        }
        private void DisableAll()
        {
            txt_IdEstados.Enabled = false;
            txt_NombreEstado.Enabled = false;
            rtb_DesEstado.Enabled = false;
            ckb_EstaEstado.Enabled = false;


        }
       // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private void btn_GrabarEstado_Click(object sender, EventArgs e)
        {

            if (_EstadoNuevo)
            {
                _contexto.Dispose();
                _contexto = new DB_Context();
                var EstadoPais = _contexto.Paises.Include(es => es.Estados).FirstOrDefault(es => es.Id_Pais == IdPais);
                var NuevoEstado = new Estado
                {
                    Nombre = txt_NombreEstado.Text,
                    Descripcion = rtb_DesEstado.Text,
                    EstaActivo = ckb_EstaEstado.Checked,
                    Pais = EstadoPais

                };
                _contexto.Estados.Add(NuevoEstado);

                _contexto.SaveChanges();
                MessageBox.Show(" Tipo de Marca ha sido creado exitosamente");
                this.ClearAll("all");
                this.LoadListaEstados();
            }

            else

            {
                _contexto.Dispose();
                _contexto = new DB_Context();

                int IdEstadoPaies = int.Parse(txt_IdEstados.Text);
                var ModificarEstado = _contexto.Estados.FirstOrDefault(es => es.Id_Estado == IdEstadoPaies);


                ModificarEstado.Nombre = txt_NombreEstado.Text;
                ModificarEstado.Descripcion = rtb_DesEstado.Text;
                ModificarEstado.EstaActivo = ckb_EstaEstado.Checked;

                _contexto.SaveChanges();
                MessageBox.Show("Marca a  sido Modificado exitosamente :");
                this.ClearAll("all");
                this.LoadListaEstados();

            }
        }

        private void btn_ListadoEstados_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_ListadoEstados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Selecciona un Tipo");

           }
            else
            {
          this.EnableAll();
              if (dgv_ListadoEstados.Rows[e.RowIndex].Cells[0].Value.ToString() == "X")
               {

                    MessageBox.Show("Creando Estado para : " + NombrePais);
                    txt_NombreEstado.Focus();
                  this.EnableAll();
                   this.ClearAll(" ");
                    
                    this._EstadoNuevo = true;




                }
               else
               {
                    this.DisableAll();
                    int IdEstado = int.Parse(dgv_ListadoEstados.Rows[e.RowIndex].Cells[0].Value.ToString());
                  var Estado = _contexto.Estados.FirstOrDefault(es=>es.Id_Estado==IdEstado);

                  if (Estado != null)
                  {
                      
                        txt_IdEstados.Text = Estado.Id_Estado.ToString();
                        txt_NombreEstado.Text = Estado.Nombre;
                        rtb_DesEstado.Text = Estado.Descripcion;
                        ckb_EstaEstado.Checked = Estado.EstaActivo;



                    }
                    this._EstadoNuevo = false;

                }


            }
        }

        private void btn_ActualizarEstado_Click(object sender, EventArgs e)
        {
            this.EnableAll();
        }
    }
}
